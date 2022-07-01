﻿using Zinnia.Data.Operation.Extraction;

namespace Test.Zinnia.Data.Operation.Extraction
{
    using NUnit.Framework;
    using System.Collections;
    using Test.Zinnia.Utility.Helper;
    using Test.Zinnia.Utility.Mock;
    using UnityEngine;
    using UnityEngine.TestTools;
    using Assert = UnityEngine.Assertions.Assert;

    public class RaycastHitTransformExtractorTest
    {
        private GameObject containingObject;
        private RaycastHitTransformExtractor subject;

        [SetUp]
        public void SetUp()
        {
            containingObject = new GameObject();
            subject = containingObject.AddComponent<RaycastHitTransformExtractor>();
        }

        [TearDown]
        public void TearDown()
        {
            Object.DestroyImmediate(containingObject);
        }

        [Test]
        public void Extract()
        {
            UnityEventListenerMock extractedMock = new UnityEventListenerMock();
            subject.Extracted.AddListener(extractedMock.Listen);
            GameObject blocker = RaycastHitHelper.CreateBlocker();
            RaycastHit hitData = RaycastHitHelper.GetRaycastHit(blocker);

            subject.Source = hitData;

            Assert.IsFalse(extractedMock.Received);
            Assert.IsNull(subject.Result);

            subject.Extract();

            Assert.IsTrue(extractedMock.Received);
            Assert.AreEqual(blocker, subject.Result);

            Object.DestroyImmediate(containingObject);
        }

        [Test]
        public void ExtractInvalidSource()
        {
            UnityEventListenerMock extractedMock = new UnityEventListenerMock();
            subject.Extracted.AddListener(extractedMock.Listen);

            Assert.IsFalse(extractedMock.Received);
            Assert.IsNull(subject.Result);

            subject.Extract();

            Assert.IsFalse(extractedMock.Received);
            Assert.IsNull(subject.Result);
        }

        [UnityTest]
        public IEnumerator ExtractNoCollisionData()
        {
            UnityEventListenerMock extractedMock = new UnityEventListenerMock();
            subject.Extracted.AddListener(extractedMock.Listen);

            yield return null;

            GameObject blocker = RaycastHitHelper.CreateBlocker();
            blocker.SetActive(false);
            RaycastHit hitData = RaycastHitHelper.GetRaycastHit(blocker);

            subject.Source = hitData;

            Assert.IsFalse(extractedMock.Received);
            Assert.IsNull(subject.Result);

            subject.Extract();

            Assert.IsFalse(extractedMock.Received);
            Assert.IsNull(subject.Result);

            Object.DestroyImmediate(containingObject);
        }

        [Test]
        public void ExtractInactiveGameObject()
        {
            UnityEventListenerMock extractedMock = new UnityEventListenerMock();
            subject.Extracted.AddListener(extractedMock.Listen);
            GameObject blocker = RaycastHitHelper.CreateBlocker();
            RaycastHit hitData = RaycastHitHelper.GetRaycastHit(blocker);

            subject.Source = hitData;
            subject.gameObject.SetActive(false);

            Assert.IsFalse(extractedMock.Received);
            Assert.IsNull(subject.Result);

            subject.Extract();

            Assert.IsFalse(extractedMock.Received);
            Assert.IsNull(subject.Result);

            Object.DestroyImmediate(containingObject);
        }

        [Test]
        public void ExtractInactiveComponent()
        {
            UnityEventListenerMock extractedMock = new UnityEventListenerMock();
            subject.Extracted.AddListener(extractedMock.Listen);
            GameObject blocker = RaycastHitHelper.CreateBlocker();
            RaycastHit hitData = RaycastHitHelper.GetRaycastHit(blocker);

            subject.Source = hitData;
            subject.enabled = false;

            Assert.IsFalse(extractedMock.Received);
            Assert.IsNull(subject.Result);

            subject.Extract();

            Assert.IsFalse(extractedMock.Received);
            Assert.IsNull(subject.Result);

            Object.DestroyImmediate(containingObject);
        }
    }
}
