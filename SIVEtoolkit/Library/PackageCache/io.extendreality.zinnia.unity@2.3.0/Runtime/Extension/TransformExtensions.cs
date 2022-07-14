﻿namespace Zinnia.Extension
{
    using UnityEngine;

    /// <summary>
    /// Extended methods for the <see cref="Transform"/> Type.
    /// </summary>
    public static class TransformExtensions
    {
        /// <summary>
        /// The SetGlobalScale method is used to set a <see cref="Transform"/> scale based on a global scale instead of a local scale.
        /// </summary>
        /// <param name="transform">The reference to the <see cref="Transform"/> to scale.</param>
        /// <param name="globalScale">The global scale to apply to the given <see cref="Transform"/>.</param>
        public static void SetGlobalScale(this Transform transform, Vector3 globalScale)
        {
            if (transform == null)
            {
                return;
            }

            transform.localScale = Vector3.one;
            transform.localScale = globalScale.Divide(transform.lossyScale);
        }

        /// <summary>
        /// Gets the signed Euler angle of the <see cref="Transform"/>.
        /// </summary>
        /// <param name="transform">The reference to the <see cref="Transform"/> to get the rotation from.</param>
        /// <returns>The signed rotation Euler angles.</returns>
        public static Vector3 SignedEulerAngles(this Transform transform)
        {
            return transform.eulerAngles.UnsignedEulerToSignedEuler();
        }

        /// <summary>
        /// Gets the signed local Euler angle of the <see cref="Transform"/>.
        /// </summary>
        /// <param name="transform">The reference to the <see cref="Transform"/> to get the local rotation from.</param>
        /// <returns>The local signed rotation Euler angles.</returns>
        public static Vector3 SignedLocalEulerAngles(this Transform transform)
        {
            return transform.localEulerAngles.UnsignedEulerToSignedEuler();
        }
    }
}
