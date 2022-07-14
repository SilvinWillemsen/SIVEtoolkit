namespace Tilia.Input.UnityInputSystem.Transformation.Conversion
{
    using System;
    using UnityEngine.Events;
    using UnityEngine.InputSystem;

    /// <summary>
    /// Transforms a <see cref="InputAction.CallbackContext"/> to a <see cref="bool"/>.
    /// </summary>
    public class CallbackContextToBoolean : CallbackContextTransformer<bool, CallbackContextToBoolean.UnityEvent>
    {
        /// <summary>
        /// Defines the event with the transformed <see cref="bool"/> value.
        /// </summary>
        [Serializable]
        public class UnityEvent : UnityEvent<bool> { }

        /// <summary>
        /// Transforms the given input <see cref="InputAction.CallbackContext"/> to the equivalent <see cref="bool"/> value.
        /// </summary>
        /// <param name="input">The value to transform.</param>
        /// <returns>The transformed value.</returns>
        protected override bool Process(InputAction.CallbackContext input)
        {
            return input.ReadValueAsButton();
        }
    }
}