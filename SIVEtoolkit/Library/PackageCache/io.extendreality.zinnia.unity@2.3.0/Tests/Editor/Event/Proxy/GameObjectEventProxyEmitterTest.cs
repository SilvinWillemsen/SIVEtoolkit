﻿using Zinnia.Data.Collection.List;
using Zinnia.Event.Proxy;
using Zinnia.Rule;

namespace Test.Zinnia.Event.Proxy
{
    using NUnit.Framework;
    using Test.Zinnia.Utility.Mock;
    using UnityEngine;
    using Assert = UnityEngine.Assertions.Assert;

    public class GameObjectEventProxyEmitterTest
    {
        private GameObject containingObject;
        private GameObjectEventProxyEmitter subject;

        [SetUp]
        public void SetUp()
        {
            containingObject = new GameObject();
            subject = containingObject.AddComponent<GameObjectEventProxyEmitter>();
        }

        [TearDown]
        public void TearDown()
        {
            Object.DestroyImmediate(subject);
            Object.DestroyImmediate(containingObject);
        }

        [Test]
        public void Receive()
        {
            UnityEventListenerMock emittedMock = new UnityEventListenerMock();
            subject.Emitted.AddListener(emittedMock.Listen);
            GameObject digest = new GameObject();

            Assert.IsFalse(emittedMock.Received);
            subject.Receive(digest);
            Assert.AreEqual(digest, subject.Payload);
            Assert.IsTrue(emittedMock.Received);

            Object.DestroyImmediate(digest);
        }

        [Test]
        public void ReceiveWithRuleRestrictions()
        {
            UnityEventListenerMock emittedMock = new UnityEventListenerMock();
            subject.Emitted.AddListener(emittedMock.Listen);
            GameObject digestValid = new GameObject();
            GameObject digestInvalid = new GameObject();

            ListContainsRule rule = subject.gameObject.AddComponent<ListContainsRule>();
            UnityObjectObservableList objects = containingObject.AddComponent<UnityObjectObservableList>();
            rule.Objects = objects;

            objects.Add(digestValid);
            subject.ReceiveValidity = new RuleContainer
            {
                Interface = rule
            };

            Assert.IsNull(subject.Payload);
            Assert.IsFalse(emittedMock.Received);

            subject.Receive(digestValid);

            Assert.AreEqual(digestValid, subject.Payload);
            Assert.IsTrue(emittedMock.Received);

            emittedMock.Reset();

            Assert.IsFalse(emittedMock.Received);

            subject.Receive(digestInvalid);

            Assert.AreEqual(digestValid, subject.Payload);
            Assert.IsFalse(emittedMock.Received);

            Object.DestroyImmediate(digestValid);
            Object.DestroyImmediate(digestInvalid);
        }

        [Test]
        public void ReceiveInactiveGameObject()
        {
            UnityEventListenerMock emittedMock = new UnityEventListenerMock();
            subject.Emitted.AddListener(emittedMock.Listen);
            GameObject digest = new GameObject();

            subject.gameObject.SetActive(false);

            Assert.IsNull(subject.Payload);
            Assert.IsFalse(emittedMock.Received);

            subject.Receive(digest);

            Assert.IsNull(subject.Payload);
            Assert.IsFalse(emittedMock.Received);

            Object.DestroyImmediate(digest);
        }

        [Test]
        public void ReceiveInactiveComponent()
        {
            UnityEventListenerMock emittedMock = new UnityEventListenerMock();
            subject.Emitted.AddListener(emittedMock.Listen);
            GameObject digest = new GameObject();

            subject.enabled = false;

            Assert.IsNull(subject.Payload);
            Assert.IsFalse(emittedMock.Received);

            subject.Receive(digest);

            Assert.IsNull(subject.Payload);
            Assert.IsFalse(emittedMock.Received);

            Object.DestroyImmediate(digest);
        }


        [Test]
        public void ClearReceiveValidity()
        {
            Assert.IsNull(subject.ReceiveValidity);
            RuleContainer rule = new RuleContainer();
            subject.ReceiveValidity = rule;
            Assert.AreEqual(rule, subject.ReceiveValidity);
            subject.ClearReceiveValidity();
            Assert.IsNull(subject.ReceiveValidity);
        }

        [Test]
        public void ClearReceiveValidityInactiveGameObject()
        {
            Assert.IsNull(subject.ReceiveValidity);
            RuleContainer rule = new RuleContainer();
            subject.ReceiveValidity = rule;
            Assert.AreEqual(rule, subject.ReceiveValidity);
            subject.gameObject.SetActive(false);
            subject.ClearReceiveValidity();
            Assert.AreEqual(rule, subject.ReceiveValidity);
        }

        [Test]
        public void ClearTargetValidityInactiveComponent()
        {
            Assert.IsNull(subject.ReceiveValidity);
            RuleContainer rule = new RuleContainer();
            subject.ReceiveValidity = rule;
            Assert.AreEqual(rule, subject.ReceiveValidity);
            subject.enabled = false;
            subject.ClearReceiveValidity();
            Assert.AreEqual(rule, subject.ReceiveValidity);
        }
    }
}