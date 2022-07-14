﻿using Zinnia.Data.Type;
using Zinnia.Tracking.Follow.Modifier.Property.Rotation;

namespace Test.Zinnia.Tracking.Follow.Modifier.Property.Rotation
{
    using NUnit.Framework;
    using UnityEngine;
    using Assert = UnityEngine.Assertions.Assert;

    public class TransformPositionDifferenceRotationTest
    {
        private GameObject containingObject;
        private TransformPositionDifferenceRotation subject;

        [SetUp]
        public void SetUp()
        {
            containingObject = new GameObject();
            subject = containingObject.AddComponent<TransformPositionDifferenceRotation>();
        }

        [TearDown]
        public void TearDown()
        {
            Object.DestroyImmediate(subject);
            Object.DestroyImmediate(containingObject);
        }

        [Test]
        public void Modify()
        {
            GameObject source = new GameObject();
            GameObject target = new GameObject();

            target.transform.position = new Vector3(0f, 0f, 0f);
            target.transform.localRotation = Quaternion.identity;

            source.transform.position = new Vector3(0.5f, 0f, -0.5f);
            subject.Modify(source, target);
            source.transform.position = new Vector3(0.5f, 0.5f, -0.5f);
            subject.Modify(source, target);
            source.transform.position = new Vector3(0.5f, 1f, -0.5f);
            subject.Modify(source, target);

            Assert.AreEqual(new Quaternion(0.3f, -0.1f, 0.3f, 0.9f).ToString(), target.transform.localRotation.ToString());

            Object.DestroyImmediate(source);
            Object.DestroyImmediate(target);
        }

        [Test]
        public void ModifyWithAncestor()
        {
            GameObject ancestor = new GameObject();
            GameObject source = new GameObject();
            GameObject target = new GameObject();

            ancestor.transform.position = new Vector3(0f, 0f, 0f);
            source.transform.SetParent(ancestor.transform);
            target.transform.SetParent(ancestor.transform);
            subject.Ancestor = ancestor;

            target.transform.position = new Vector3(0f, 0f, 0f);
            target.transform.localRotation = Quaternion.identity;

            source.transform.position = new Vector3(0.5f, 0f, -0.5f);
            subject.Modify(source, target);
            ancestor.transform.position += Vector3.left;
            source.transform.position = new Vector3(0.5f, 0.5f, -0.5f);
            subject.Modify(source, target);
            ancestor.transform.position += Vector3.left;
            source.transform.position = new Vector3(0.5f, 1f, -0.5f);
            subject.Modify(source, target);

            Assert.AreEqual(new Quaternion(0.1f, -0.3f, 0.2f, 0.9f).ToString(), target.transform.localRotation.ToString());

            Object.DestroyImmediate(source);
            Object.DestroyImmediate(target);
            Object.DestroyImmediate(ancestor);
        }

        [Test]
        public void ModifyInactiveGameObject()
        {
            GameObject source = new GameObject();
            GameObject target = new GameObject();
            subject.gameObject.SetActive(false);

            target.transform.position = new Vector3(0f, 0f, 0f);
            target.transform.localRotation = Quaternion.identity;

            source.transform.position = new Vector3(0.5f, 0f, -0.5f);
            subject.Modify(source, target);
            source.transform.position = new Vector3(0.5f, 0.5f, -0.5f);
            subject.Modify(source, target);
            source.transform.position = new Vector3(0.5f, 1f, -0.5f);
            subject.Modify(source, target);

            Assert.AreEqual(Quaternion.identity, target.transform.localRotation);

            Object.DestroyImmediate(source);
            Object.DestroyImmediate(target);
        }


        [Test]
        public void ModifyInactiveComponent()
        {
            GameObject source = new GameObject();
            GameObject target = new GameObject();
            subject.enabled = false;

            target.transform.position = new Vector3(0f, 0f, 0f);
            target.transform.localRotation = Quaternion.identity;

            source.transform.position = new Vector3(0.5f, 0f, -0.5f);
            subject.Modify(source, target);
            source.transform.position = new Vector3(0.5f, 0.5f, -0.5f);
            subject.Modify(source, target);
            source.transform.position = new Vector3(0.5f, 1f, -0.5f);
            subject.Modify(source, target);

            Assert.AreEqual(Quaternion.identity, target.transform.localRotation);

            Object.DestroyImmediate(source);
            Object.DestroyImmediate(target);
        }

        [Test]
        public void ClearAncestor()
        {
            Assert.IsNull(subject.Ancestor);
            subject.Ancestor = containingObject;
            Assert.AreEqual(containingObject, subject.Ancestor);
            subject.ClearAncestor();
            Assert.IsNull(subject.Ancestor);
        }

        [Test]
        public void ClearAncestorInactiveGameObject()
        {
            Assert.IsNull(subject.Ancestor);
            subject.Ancestor = containingObject;
            Assert.AreEqual(containingObject, subject.Ancestor);
            subject.gameObject.SetActive(false);
            subject.ClearAncestor();
            Assert.AreEqual(containingObject, subject.Ancestor);
        }

        [Test]
        public void ClearAncestorInactiveComponent()
        {
            Assert.IsNull(subject.Ancestor);
            subject.Ancestor = containingObject;
            Assert.AreEqual(containingObject, subject.Ancestor);
            subject.enabled = false;
            subject.ClearAncestor();
            Assert.AreEqual(containingObject, subject.Ancestor);
        }

        [Test]
        public void SetFollowOnAxisX()
        {
            subject.FollowOnAxis = Vector3State.False;
            Assert.AreEqual(Vector3State.False, subject.FollowOnAxis);
            subject.SetFollowOnAxisX(true);
            Assert.AreEqual(Vector3State.XOnly, subject.FollowOnAxis);
        }

        [Test]
        public void SetFollowOnAxisY()
        {
            subject.FollowOnAxis = Vector3State.False;
            Assert.AreEqual(Vector3State.False, subject.FollowOnAxis);
            subject.SetFollowOnAxisY(true);
            Assert.AreEqual(Vector3State.YOnly, subject.FollowOnAxis);
        }

        [Test]
        public void SetFollowOnAxisZ()
        {
            subject.FollowOnAxis = Vector3State.False;
            Assert.AreEqual(Vector3State.False, subject.FollowOnAxis);
            subject.SetFollowOnAxisZ(true);
            Assert.AreEqual(Vector3State.ZOnly, subject.FollowOnAxis);
        }
    }
}