﻿using Zinnia.Data.Type.Transformation.Conversion;

namespace Test.Zinnia.Data.Type.Transformation.Conversion
{
    using NUnit.Framework;
    using Test.Zinnia.Utility.Mock;
    using UnityEngine;
    using Assert = UnityEngine.Assertions.Assert;

    public class Vector2ToAngleTest
    {
        private GameObject containingObject;
        private Vector2ToAngle subject;

        [SetUp]
        public void SetUp()
        {
            containingObject = new GameObject();
            subject = containingObject.AddComponent<Vector2ToAngle>();
        }

        [TearDown]
        public void TearDown()
        {
            Object.DestroyImmediate(subject);
            Object.DestroyImmediate(containingObject);
        }

        [Test]
        public void TransformToDegrees()
        {
            UnityEventListenerMock transformedListenerMock = new UnityEventListenerMock();
            subject.Transformed.AddListener(transformedListenerMock.Listen);
            subject.Unit = Vector2ToAngle.AngleUnit.Degrees;
            subject.Origin = new Vector2(0f, 1f);

            Assert.AreEqual(0f, subject.Result);
            Assert.IsFalse(transformedListenerMock.Received);

            float result = subject.Transform(new Vector2(0f, 0f));

            Assert.AreEqual(0f, result);
            Assert.AreEqual(0f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);

            transformedListenerMock.Reset();

            result = subject.Transform(new Vector2(0f, 1f));
            Assert.AreEqual(0f, result);
            Assert.AreEqual(0f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);

            transformedListenerMock.Reset();

            result = subject.Transform(new Vector2(1f, 1f));
            Assert.AreEqual(45f, result);
            Assert.AreEqual(45f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);

            transformedListenerMock.Reset();

            result = subject.Transform(new Vector2(1f, 0f));
            Assert.AreEqual(90f, result);
            Assert.AreEqual(90f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);

            transformedListenerMock.Reset();

            result = subject.Transform(new Vector2(0f, -1f));
            Assert.AreEqual(180f, result);
            Assert.AreEqual(180f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);

            transformedListenerMock.Reset();

            result = subject.Transform(new Vector2(-1f, -1f));
            Assert.AreEqual(225f, result);
            Assert.AreEqual(225f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);

            transformedListenerMock.Reset();

            result = subject.Transform(new Vector2(-1f, 0f));
            Assert.AreEqual(270f, result);
            Assert.AreEqual(270f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);

            transformedListenerMock.Reset();

            subject.Origin = new Vector2(-1f, 0f);

            result = subject.Transform(new Vector2(0f, -1f));
            Assert.AreEqual(270f, result);
            Assert.AreEqual(270f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);
        }

        [Test]
        public void TransformToRadians()
        {
            UnityEventListenerMock transformedListenerMock = new UnityEventListenerMock();
            subject.Transformed.AddListener(transformedListenerMock.Listen);
            subject.Unit = Vector2ToAngle.AngleUnit.Radians;

            subject.Origin = new Vector2(0f, 1f);

            Assert.AreApproximatelyEqual(0f, subject.Result);
            Assert.IsFalse(transformedListenerMock.Received);

            float result = subject.Transform(new Vector2(0f, 0f));

            Assert.AreApproximatelyEqual(0f, result);
            Assert.AreApproximatelyEqual(0f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);

            transformedListenerMock.Reset();

            result = subject.Transform(new Vector2(0f, 1f));
            Assert.AreApproximatelyEqual(0f, result);
            Assert.AreApproximatelyEqual(0f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);

            transformedListenerMock.Reset();

            result = subject.Transform(new Vector2(1f, 1f));
            Assert.AreApproximatelyEqual(0.785398185f, result);
            Assert.AreApproximatelyEqual(0.785398185f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);

            transformedListenerMock.Reset();

            result = subject.Transform(new Vector2(1f, 0f));
            Assert.AreApproximatelyEqual(1.57079637f, result);
            Assert.AreApproximatelyEqual(1.57079637f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);

            transformedListenerMock.Reset();

            result = subject.Transform(new Vector2(0f, -1f));
            Assert.AreApproximatelyEqual(3.14159274f, result);
            Assert.AreApproximatelyEqual(3.14159274f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);

            transformedListenerMock.Reset();

            result = subject.Transform(new Vector2(-1f, -1f));
            Assert.AreApproximatelyEqual(3.92699075f, result);
            Assert.AreApproximatelyEqual(3.92699075f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);

            transformedListenerMock.Reset();

            result = subject.Transform(new Vector2(-1f, 0f));
            Assert.AreApproximatelyEqual(4.71238899f, result);
            Assert.AreApproximatelyEqual(4.71238899f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);

            transformedListenerMock.Reset();

            subject.Origin = new Vector2(-1f, 0f);

            result = subject.Transform(new Vector2(0f, -1f));
            Assert.AreApproximatelyEqual(4.71238899f, result);
            Assert.AreApproximatelyEqual(4.71238899f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);
        }

        [Test]
        public void TransformToSignedDegrees()
        {
            UnityEventListenerMock transformedListenerMock = new UnityEventListenerMock();
            subject.Transformed.AddListener(transformedListenerMock.Listen);
            subject.Unit = Vector2ToAngle.AngleUnit.SignedDegrees;
            subject.Origin = new Vector2(0f, 1f);

            Assert.AreEqual(0f, subject.Result);
            Assert.IsFalse(transformedListenerMock.Received);

            float result = subject.Transform(new Vector2(0f, 0f));

            Assert.AreEqual(0f, result);
            Assert.AreEqual(0f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);

            transformedListenerMock.Reset();

            result = subject.Transform(new Vector2(0f, 1f));
            Assert.AreEqual(0f, result);
            Assert.AreEqual(0f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);

            transformedListenerMock.Reset();

            result = subject.Transform(new Vector2(1f, 1f));
            Assert.AreEqual(45f, result);
            Assert.AreEqual(45f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);

            transformedListenerMock.Reset();

            result = subject.Transform(new Vector2(1f, 0f));
            Assert.AreEqual(90f, result);
            Assert.AreEqual(90f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);

            transformedListenerMock.Reset();

            result = subject.Transform(new Vector2(0f, -1f));
            Assert.AreEqual(180f, result);
            Assert.AreEqual(180f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);

            transformedListenerMock.Reset();

            result = subject.Transform(new Vector2(-1f, -1f));
            Assert.AreEqual(-135f, result);
            Assert.AreEqual(-135f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);

            transformedListenerMock.Reset();

            result = subject.Transform(new Vector2(-1f, 0f));
            Assert.AreEqual(-90f, result);
            Assert.AreEqual(-90f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);

            transformedListenerMock.Reset();

            subject.Origin = new Vector2(-1f, 0f);

            result = subject.Transform(new Vector2(0f, -1f));
            Assert.AreEqual(-90f, result);
            Assert.AreEqual(-90f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);
        }

        [Test]
        public void TransformToSignedRadians()
        {
            UnityEventListenerMock transformedListenerMock = new UnityEventListenerMock();
            subject.Transformed.AddListener(transformedListenerMock.Listen);
            subject.Unit = Vector2ToAngle.AngleUnit.SignedRadians;

            subject.Origin = new Vector2(0f, 1f);

            Assert.AreApproximatelyEqual(0f, subject.Result);
            Assert.IsFalse(transformedListenerMock.Received);

            float result = subject.Transform(new Vector2(0f, 0f));

            Assert.AreApproximatelyEqual(0f, result);
            Assert.AreApproximatelyEqual(0f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);

            transformedListenerMock.Reset();

            result = subject.Transform(new Vector2(0f, 1f));
            Assert.AreApproximatelyEqual(0f, result);
            Assert.AreApproximatelyEqual(0f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);

            transformedListenerMock.Reset();

            result = subject.Transform(new Vector2(1f, 1f));
            Assert.AreApproximatelyEqual(0.785398185f, result);
            Assert.AreApproximatelyEqual(0.785398185f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);

            transformedListenerMock.Reset();

            result = subject.Transform(new Vector2(1f, 0f));
            Assert.AreApproximatelyEqual(1.57079637f, result);
            Assert.AreApproximatelyEqual(1.57079637f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);

            transformedListenerMock.Reset();

            result = subject.Transform(new Vector2(0f, -1f));
            Assert.AreApproximatelyEqual(3.141593f, result);
            Assert.AreApproximatelyEqual(3.141593f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);

            transformedListenerMock.Reset();

            result = subject.Transform(new Vector2(-1f, -1f));
            Assert.AreApproximatelyEqual(-2.356194f, result);
            Assert.AreApproximatelyEqual(-2.356194f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);

            transformedListenerMock.Reset();

            result = subject.Transform(new Vector2(-1f, 0f));
            Assert.AreApproximatelyEqual(-1.570796f, result);
            Assert.AreApproximatelyEqual(-1.570796f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);

            transformedListenerMock.Reset();

            subject.Origin = new Vector2(-1f, 0f);

            result = subject.Transform(new Vector2(0f, -1f));
            Assert.AreApproximatelyEqual(-1.570796f, result);
            Assert.AreApproximatelyEqual(-1.570796f, subject.Result);
            Assert.IsTrue(transformedListenerMock.Received);
        }

        [Test]
        public void TransformInactiveGameObject()
        {
            UnityEventListenerMock transformedListenerMock = new UnityEventListenerMock();
            subject.Transformed.AddListener(transformedListenerMock.Listen);
            subject.gameObject.SetActive(false);

            Assert.AreEqual(0f, subject.Result);
            Assert.IsFalse(transformedListenerMock.Received);

            float result = subject.Transform(new Vector2(1f, 1f));

            Assert.AreEqual(0f, result);
            Assert.AreEqual(0f, subject.Result);
            Assert.IsFalse(transformedListenerMock.Received);
        }

        [Test]
        public void TransformInactiveComponent()
        {
            UnityEventListenerMock transformedListenerMock = new UnityEventListenerMock();
            subject.Transformed.AddListener(transformedListenerMock.Listen);
            subject.enabled = false;

            Assert.AreEqual(0f, subject.Result);
            Assert.IsFalse(transformedListenerMock.Received);

            float result = subject.Transform(new Vector2(1f, 1f));

            Assert.AreEqual(0f, result);
            Assert.AreEqual(0f, subject.Result);
            Assert.IsFalse(transformedListenerMock.Received);
        }
    }
}