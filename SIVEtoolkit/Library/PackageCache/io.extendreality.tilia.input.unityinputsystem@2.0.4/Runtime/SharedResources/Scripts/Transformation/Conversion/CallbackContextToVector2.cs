namespace Tilia.Input.UnityInputSystem.Transformation.Conversion
{
    using System;
    using UnityEngine;
    using UnityEngine.Events;
    using UnityEngine.InputSystem;

    /// <summary>
    /// Transforms a <see cref="InputAction.CallbackContext"/> to a <see cref="Vector2"/>.
    /// </summary>
    public class CallbackContextToVector2 : CallbackContextTransformer<Vector2, CallbackContextToVector2.UnityEvent>
    {
        /// <summary>
        /// Defines the event with the transformed <see cref="Vector2"/> value.
        /// </summary>
        [Serializable]
        public class UnityEvent : UnityEvent<Vector2> { }

        /// <summary>
        /// Transforms the given input <see cref="InputAction.CallbackContext"/> to the equivalent <see cref="Vector2"/> value.
        /// </summary>
        /// <param name="input">The value to transform.</param>
        /// <returns>The transformed value.</returns>
        protected override Vector2 Process(InputAction.CallbackContext input)
        {
            return input.ReadValue<Vector2>();
        }
    }
}