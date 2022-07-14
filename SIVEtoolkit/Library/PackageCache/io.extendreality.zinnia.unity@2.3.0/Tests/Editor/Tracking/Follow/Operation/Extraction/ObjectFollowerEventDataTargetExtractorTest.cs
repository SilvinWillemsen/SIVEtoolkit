﻿using Zinnia.Tracking.Follow;
using Zinnia.Tracking.Follow.Operation.Extraction;

namespace Test.Zinnia.Tracking.Follow.Operation.Extraction
{
    using NUnit.Framework;
    using Test.Zinnia.Utility.Mock;
    using UnityEngine;
    using Assert = UnityEngine.Assertions.Assert;

    public class ObjectFollowerEventDataTargetExtractorTest
    {
        private GameObject containingObject;
        private ObjectFollowerEventDataTargetExtractor subject;

        [SetUp]
        public void SetUp()
        {
            containingObject = new GameObject();
            subject = containingObject.AddComponent<ObjectFollowerEventDataTargetExtractor>();
        }

        [TearDown]
        public void TearDown()
        {
            Object.DestroyImmediate(containingObject);
        }

        [Test]
        public void Extract()
        {
            GameObject source = new GameObject();

            UnityEventListenerMock extractedMock = new UnityEventListenerMock();
            subject.Extracted.AddListener(extractedMock.Listen);

            ObjectFollower.EventData eventData = new ObjectFollower.EventData
            {
                EventTarget = source
            };

            Assert.IsFalse(extractedMock.Received);
            Assert.IsNull(subject.Result);

            subject.Extract(eventData);

            Assert.IsTrue(extractedMock.Received);
            Assert.AreEqual(subject.Result, source);

            Object.DestroyImmediate(source);
        }
    }
}