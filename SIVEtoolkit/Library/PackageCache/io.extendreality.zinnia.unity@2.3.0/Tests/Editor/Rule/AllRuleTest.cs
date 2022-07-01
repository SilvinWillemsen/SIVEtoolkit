﻿using Zinnia.Extension;
using Zinnia.Rule;
using Zinnia.Rule.Collection;
using BaseRule = Zinnia.Rule.Rule;

namespace Test.Zinnia.Rule
{
    using NUnit.Framework;
    using System.Collections;
    using Test.Zinnia.Utility.Stub;
    using UnityEngine;
    using UnityEngine.TestTools;
    using Assert = UnityEngine.Assertions.Assert;

    public class AllRuleTest
    {
        private GameObject containingObject;
        private RuleContainer container;
        private AllRule subject;

        [SetUp]
        public void SetUp()
        {
            containingObject = new GameObject();
            container = new RuleContainer();
            subject = containingObject.AddComponent<AllRule>();
            container.Interface = subject;
        }

        [TearDown]
        public void TearDown()
        {
            Object.DestroyImmediate(containingObject);
        }

        [UnityTest]
        public IEnumerator AcceptsMatch()
        {
            RuleContainerObservableList rules = containingObject.AddComponent<RuleContainerObservableList>();
            yield return null;
            subject.Rules = rules;

            rules.Add(
                new RuleContainer
                {
                    Interface = new TrueRuleStub()
                });
            rules.Add(
                new RuleContainer
                {
                    Interface = new TrueRuleStub()
                });

            Assert.IsTrue(container.Accepts(containingObject));
        }

        [UnityTest]
        public IEnumerator RefusesEmpty()
        {
            RuleContainerObservableList rules = containingObject.AddComponent<RuleContainerObservableList>();
            yield return null;
            subject.Rules = rules;

            Assert.IsFalse(container.Accepts(containingObject));
        }

        [Test]
        public void RefusesNullRules()
        {
            Assert.IsFalse(container.Accepts(containingObject));
        }

        [UnityTest]
        public IEnumerator RefusesDifferent()
        {
            RuleContainerObservableList rules = containingObject.AddComponent<RuleContainerObservableList>();
            yield return null;
            subject.Rules = rules;

            rules.Add(
                new RuleContainer
                {
                    Interface = new TrueRuleStub()
                });
            rules.Add(
                new RuleContainer
                {
                    Interface = new FalseRuleStub()
                });

            Assert.IsFalse(container.Accepts(containingObject));
        }

        [UnityTest]
        public IEnumerator RefusesInactiveGameObject()
        {
            RuleContainerObservableList rules = containingObject.AddComponent<RuleContainerObservableList>();
            yield return null;
            subject.Rules = rules;

            rules.Add(
                new RuleContainer
                {
                    Interface = new TrueRuleStub()
                });
            rules.Add(
                new RuleContainer
                {
                    Interface = new TrueRuleStub()
                });

            subject.gameObject.SetActive(false);

            Assert.IsFalse(container.Accepts(containingObject));
        }

        [UnityTest]
        public IEnumerator RefusesInactiveComponent()
        {
            RuleContainerObservableList rules = containingObject.AddComponent<RuleContainerObservableList>();
            yield return null;
            subject.Rules = rules;

            rules.Add(
                new RuleContainer
                {
                    Interface = new TrueRuleStub()
                });
            rules.Add(
                new RuleContainer
                {
                    Interface = new TrueRuleStub()
                });

            subject.enabled = false;

            Assert.IsFalse(container.Accepts(containingObject));
        }

        [UnityTest]
        public IEnumerator AcceptsInactiveGameObject()
        {
            RuleContainerObservableList rules = containingObject.AddComponent<RuleContainerObservableList>();
            yield return null;
            subject.Rules = rules;

            rules.Add(
                new RuleContainer
                {
                    Interface = new TrueRuleStub()
                });
            rules.Add(
                new RuleContainer
                {
                    Interface = new TrueRuleStub()
                });

            subject.AutoRejectStates = BaseRule.RejectRuleStates.RuleComponentIsDisabled;
            subject.gameObject.SetActive(false);

            Assert.IsTrue(container.Accepts(containingObject));

            subject.enabled = false;

            Assert.IsFalse(container.Accepts(containingObject));
        }

        [UnityTest]
        public IEnumerator AcceptsInactiveComponent()
        {
            RuleContainerObservableList rules = containingObject.AddComponent<RuleContainerObservableList>();
            yield return null;
            subject.Rules = rules;

            rules.Add(
                new RuleContainer
                {
                    Interface = new TrueRuleStub()
                });
            rules.Add(
                new RuleContainer
                {
                    Interface = new TrueRuleStub()
                });

            subject.AutoRejectStates = BaseRule.RejectRuleStates.RuleGameObjectIsNotActiveInHierarchy;
            subject.enabled = false;

            Assert.IsTrue(container.Accepts(containingObject));

            subject.gameObject.SetActive(false);

            Assert.IsFalse(container.Accepts(containingObject));
        }
    }
}