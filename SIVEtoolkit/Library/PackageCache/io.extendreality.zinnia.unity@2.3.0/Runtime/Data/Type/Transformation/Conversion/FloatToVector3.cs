﻿namespace Zinnia.Data.Type.Transformation.Conversion
{
    using System;
    using UnityEngine;
    using UnityEngine.Events;

    /// <summary>
    /// Transforms a float array to a Vector3.
    /// </summary>
    /// <example>
    /// float[2f, 3f, 4f] = Vector3(2f, 3f, 4f)
    /// </example>
    public class FloatToVector3 : Transformer<float[], Vector3, FloatToVector3.UnityEvent>
    {
        /// <summary>
        /// Defines the event with the transformed <see cref="Vector3"/> value.
        /// </summary>
        [Serializable]
        public class UnityEvent : UnityEvent<Vector3> { }

        [Tooltip("A float to use as the current x value of the Vector3.")]
        [SerializeField]
        private float currentX;
        /// <summary>
        /// A <see cref="float"/> to use as the current x value of the <see cref="Vector3"/>.
        /// </summary>
        public float CurrentX
        {
            get
            {
                return currentX;
            }
            set
            {
                currentX = value;
            }
        }
        [Tooltip("A float to use as the current y value of the Vector3.")]
        [SerializeField]
        private float currentY;
        /// <summary>
        /// A <see cref="float"/> to use as the current y value of the <see cref="Vector3"/>.
        /// </summary>
        public float CurrentY
        {
            get
            {
                return currentY;
            }
            set
            {
                currentY = value;
            }
        }
        [Tooltip("A float to use as the current z value of the Vector3.")]
        [SerializeField]
        private float currentZ;
        /// <summary>
        /// A <see cref="float"/> to use as the current z value of the <see cref="Vector3"/>.
        /// </summary>
        public float CurrentZ
        {
            get
            {
                return currentZ;
            }
            set
            {
                currentZ = value;
            }
        }

        /// <summary>
        /// A reusable array of three <see cref="float"/>s.
        /// </summary>
        protected readonly float[] input = new float[3];

        /// <summary>
        /// Builds a <see cref="float"/> array from the current set x, y and z values and transforms it into a <see cref="Vector3"/>.
        /// </summary>
        public virtual Vector3 Transform()
        {
            input[0] = CurrentX;
            input[1] = CurrentY;
            input[2] = CurrentZ;
            return Transform(input);
        }

        /// <summary>
        /// Builds a <see cref="float"/> array from the current set x, y and z values and transforms it into a <see cref="Vector3"/>.
        /// </summary>
        public virtual void DoTransform()
        {
            Transform();
        }

        /// <summary>
        /// Transforms the given <see cref="float"/> array into a <see cref="Vector3"/>.
        /// </summary>
        /// <param name="input">The value to transform.</param>
        /// <returns>The transformed value or <see cref="Vector3.zero"/> if the input isn't three-dimensional.</returns>
        protected override Vector3 Process(float[] input)
        {
            return input.Length >= 3 ? new Vector3(input[0], input[1], input[2]) : Vector3.zero;
        }
    }
}