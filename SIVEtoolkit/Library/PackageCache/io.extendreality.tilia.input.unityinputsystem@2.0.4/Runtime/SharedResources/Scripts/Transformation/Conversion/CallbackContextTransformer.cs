namespace Tilia.Input.UnityInputSystem.Transformation.Conversion
{
    using System;
    using UnityEngine;
    using UnityEngine.Events;
    using UnityEngine.InputSystem;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Type.Transformation;

    /// <summary>
    /// Provides an abstract base to transform a given <see cref="InputAction.CallbackContext"/> to the <see cref="TOutput"/> data type.
    /// </summary>
    /// <typeparam name="TOutput">The variable type that will be output from the result of the transformation.</typeparam>
    /// <typeparam name="TEvent">The <see cref="UnityEvent"/> type the transformation will emit.</typeparam>
    public abstract class CallbackContextTransformer<TOutput, TEvent> : Transformer<InputAction.CallbackContext, TOutput, TEvent> where TEvent : UnityEvent<TOutput>, new()
    {
        /// <summary>
        /// The <see cref="InputAction.CallbackContext"/> event context.
        /// </summary>
        [Flags]
        public enum ContextType
        {
            /// <summary>
            /// Whether the event is the started state.
            /// </summary>
            Started = 1 << 0,
            /// <summary>
            /// Whether the event is the performed state.
            /// </summary>
            Performed = 1 << 1,
            /// <summary>
            /// Whether the event is the canceled state.
            /// </summary>
            Canceled = 1 << 2
        }

        [Tooltip("The ContextType event to process the transformation for.")]
        [SerializeField]
        [UnityFlags]
        private ContextType contextToProcess = ContextType.Performed;
        /// <summary>
        /// The <see cref="ContextType"/> event to process the transformation for.
        /// </summary>
        public ContextType ContextToProcess
        {
            get
            {
                return contextToProcess;
            }
            set
            {
                contextToProcess = value;
            }
        }

        /// <summary>
        /// Processes the given input into the output result as long as the context event is allowed to be processed based on the <see cref="ContextToProcess"/> value.
        /// </summary>
        /// <param name="input">The value to transform.</param>
        /// <returns>The transformed value.</returns>
        protected override TOutput ProcessResult(InputAction.CallbackContext input)
        {
            if ((input.started && (ContextToProcess & ContextType.Started) == 0) ||
                (input.performed && (ContextToProcess & ContextType.Performed) == 0) ||
                (input.canceled && (ContextToProcess & ContextType.Canceled) == 0))
            {
                return Result;
            }

            return base.ProcessResult(input);
        }
    }
}