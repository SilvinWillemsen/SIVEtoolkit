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

    public class AnyBehaviourEnabledRuleTest
    {
        private GameObject containingObject;
        private RuleContainer container;
        private AnyBehaviourEnabledRule subject;

        [SetUp]
        public void SetUp()
        {
            containingObject = new GameObject();
            container = new RuleContainer();
            subject = containingObject.AddComponent<AnyBehaviourEnabledRule>();
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
            TestScript testScript = containingObject.AddComponent<TestScript>();
            SerializableTypeBehaviourObservableList behaviourTypes = containingObject.AddComponent<SerializableTypeBehaviourObservableList>();
            yield return null;
            subject.BehaviourTypes = behaviourTypes;
            behaviourTypes.Add(typeof(TestScript));
            testScript.enabled = true;

            Assert.IsTrue(container.Accepts(containingObject));
        }

        [UnityTest]
        public IEnumerator RefusesEmpty()
        {
            SerializableTypeBehaviourObservableList behaviourTypes = containingObject.AddComponent<SerializableTypeBehaviourObservableList>();
            yield return null;
            subject.BehaviourTypes = behaviourTypes;

            Assert.IsFalse(container.Accepts(containingObject));
        }

        [Test]
        public void RefusesNullComponentTypes()
        {
            Assert.IsFalse(container.Accepts(containingObject));
        }

        [UnityTest]
        public IEnumerator RefuseDisabledBehaviour()
        {
            TestScript testScript = containingObject.AddComponent<TestScript>();
            SerializableTypeBehaviourObservableList behaviourTypes = containingObject.AddComponent<SerializableTypeBehaviourObservableList>();
            yield return null;
            subject.BehaviourTypes = behaviourTypes;
            behaviourTypes.Add(typeof(TestScript));
            testScript.enabled = false;

            Assert.IsFalse(container.Accepts(containingObject));
        }

        [UnityTest]
        public IEnumerator RefusesDifferent()
        {
            containingObject.AddComponent<Light>();
            SerializableTypeBehaviourObservableList behaviourTypes = containingObject.AddComponent<SerializableTypeBehaviourObservableList>();
            yield return null;
            subject.BehaviourTypes = behaviourTypes;
            behaviourTypes.Add(typeof(TestScript));

            Assert.IsFalse(container.Accepts(containingObject));
        }

        [UnityTest]
        public IEnumerator RefusesInactiveGameObject()
        {
            TestScript testScript = containingObject.AddComponent<TestScript>();
            SerializableTypeBehaviourObservableList behaviourTypes = containingObject.AddComponent<SerializableTypeBehaviourObservableList>();
            yield return null;
            subject.BehaviourTypes = behaviourTypes;
            behaviourTypes.Add(typeof(TestScript));
            testScript.enabled = true;
            subject.gameObject.SetActive(false);

            Assert.IsFalse(container.Accepts(containingObject));
        }

        [UnityTest]
        public IEnumerator RefusesInactiveComponent()
        {
            TestScript testScript = containingObject.AddComponent<TestScript>();
            SerializableTypeBehaviourObservableList behaviourTypes = containingObject.AddComponent<SerializableTypeBehaviourObservableList>();
            yield return null;
            subject.BehaviourTypes = behaviourTypes;
            behaviourTypes.Add(typeof(TestScript));
            testScript.enabled = true;
            subject.enabled = false;

            Assert.IsFalse(container.Accepts(containingObject));
        }

        [UnityTest]
        public IEnumerator AcceptsInactiveGameObject()
        {
            TestScript testScript = containingObject.AddComponent<TestScript>();
            SerializableTypeBehaviourObservableList behaviourTypes = containingObject.AddComponent<SerializableTypeBehaviourObservableList>();
            yield return null;
            subject.BehaviourTypes = behaviourTypes;
            behaviourTypes.Add(typeof(TestScript));
            testScript.enabled = true;

            subject.AutoRejectStates = BaseRule.RejectRuleStates.RuleComponentIsDisabled;
            subject.gameObject.SetActive(false);

            Assert.IsTrue(container.Accepts(containingObject));

            subject.enabled = false;

            Assert.IsFalse(container.Accepts(containingObject));
        }

        [UnityTest]
        public IEnumerator AcceptsInactiveComponent()
        {
            TestScript testScript = containingObject.AddComponent<TestScript>();
            SerializableTypeBehaviourObservableList behaviourTypes = containingObject.AddComponent<SerializableTypeBehaviourObservableList>();
            yield return null;
            subject.BehaviourTypes = behaviourTypes;
            behaviourTypes.Add(typeof(TestScript));
            testScript.enabled = true;

            subject.AutoRejectStates = BaseRule.RejectRuleStates.RuleGameObjectIsNotActiveInHierarchy;
            subject.enabled = false;

            Assert.IsTrue(container.Accepts(containingObject));

            subject.gameObject.SetActive(false);

            Assert.IsFalse(container.Accepts(containingObject));
        }

        private class TestScript : MonoBehaviour { }
    }
}