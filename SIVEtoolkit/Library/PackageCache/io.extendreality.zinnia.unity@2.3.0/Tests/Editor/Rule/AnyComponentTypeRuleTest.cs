﻿using Zinnia.Data.Collection.List;
using Zinnia.Extension;
using Zinnia.Rule;
using BaseRule = Zinnia.Rule.Rule;

namespace Test.Zinnia.Rule
{
    using NUnit.Framework;
    using System.Collections;
    using UnityEngine;
    using UnityEngine.TestTools;
    using Assert = UnityEngine.Assertions.Assert;

    public class AnyComponentTypeRuleTest
    {
        private GameObject containingObject;
        private RuleContainer container;
        private AnyComponentTypeRule subject;

        [SetUp]
        public void SetUp()
        {
            containingObject = new GameObject();
            container = new RuleContainer();
            subject = containingObject.AddComponent<AnyComponentTypeRule>();
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
            containingObject.AddComponent<TestScript>();
            SerializableTypeComponentObservableList componentTypes = containingObject.AddComponent<SerializableTypeComponentObservableList>();
            yield return null;
            subject.ComponentTypes = componentTypes;
            componentTypes.Add(typeof(TestScript));

            Assert.IsTrue(container.Accepts(containingObject));
        }

        [UnityTest]
        public IEnumerator RefusesEmpty()
        {
            SerializableTypeComponentObservableList componentTypes = containingObject.AddComponent<SerializableTypeComponentObservableList>();
            yield return null;
            subject.ComponentTypes = componentTypes;

            Assert.IsFalse(container.Accepts(containingObject));
        }

        [Test]
        public void RefusesNullComponentTypes()
        {
            Assert.IsFalse(container.Accepts(containingObject));
        }

        [UnityTest]
        public IEnumerator RefusesDifferent()
        {
            containingObject.AddComponent<Light>();
            SerializableTypeComponentObservableList componentTypes = containingObject.AddComponent<SerializableTypeComponentObservableList>();
            yield return null;
            subject.ComponentTypes = componentTypes;
            componentTypes.Add(typeof(TestScript));

            Assert.IsFalse(container.Accepts(containingObject));
        }

        [UnityTest]
        public IEnumerator RefusesInactiveGameObject()
        {
            containingObject.AddComponent<TestScript>();
            SerializableTypeComponentObservableList componentTypes = containingObject.AddComponent<SerializableTypeComponentObservableList>();
            yield return null;
            subject.ComponentTypes = componentTypes;
            componentTypes.Add(typeof(TestScript));

            subject.gameObject.SetActive(false);
            Assert.IsFalse(container.Accepts(containingObject));
        }

        [UnityTest]
        public IEnumerator RefusesInactiveComponent()
        {
            containingObject.AddComponent<TestScript>();
            SerializableTypeComponentObservableList componentTypes = containingObject.AddComponent<SerializableTypeComponentObservableList>();
            yield return null;
            subject.ComponentTypes = componentTypes;
            componentTypes.Add(typeof(TestScript));

            subject.enabled = false;
            Assert.IsFalse(container.Accepts(containingObject));
        }

        [UnityTest]
        public IEnumerator AcceptsInactiveGameObject()
        {
            containingObject.AddComponent<TestScript>();
            SerializableTypeComponentObservableList componentTypes = containingObject.AddComponent<SerializableTypeComponentObservableList>();
            yield return null;
            subject.ComponentTypes = componentTypes;
            componentTypes.Add(typeof(TestScript));

            subject.AutoRejectStates = BaseRule.RejectRuleStates.RuleComponentIsDisabled;
            subject.gameObject.SetActive(false);

            Assert.IsTrue(container.Accepts(containingObject));

            subject.enabled = false;
            Assert.IsFalse(container.Accepts(containingObject));
        }

        [UnityTest]
        public IEnumerator AcceptsInactiveComponent()
        {
            containingObject.AddComponent<TestScript>();
            SerializableTypeComponentObservableList componentTypes = containingObject.AddComponent<SerializableTypeComponentObservableList>();
            yield return null;
            subject.ComponentTypes = componentTypes;
            componentTypes.Add(typeof(TestScript));

            subject.AutoRejectStates = BaseRule.RejectRuleStates.RuleGameObjectIsNotActiveInHierarchy;
            subject.enabled = false;

            Assert.IsTrue(container.Accepts(containingObject));

            subject.gameObject.SetActive(false);

            Assert.IsFalse(container.Accepts(containingObject));
        }

        private class TestScript : MonoBehaviour { }
    }
}