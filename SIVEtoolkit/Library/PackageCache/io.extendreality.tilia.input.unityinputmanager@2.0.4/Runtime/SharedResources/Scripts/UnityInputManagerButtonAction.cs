namespace Tilia.Input.UnityInputManager
{
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Process;

    /// <summary>
    /// Listens for the specified <see cref="KeyCode"/> state and emits the appropriate action.
    /// </summary>
    public class UnityInputManagerButtonAction : BooleanAction, IProcessable
    {
        [Tooltip("The KeyCode to listen for state changes on.")]
        [SerializeField]
        private KeyCode keyCode;
        /// <summary>
        /// The <see cref="UnityEngine.KeyCode"/> to listen for state changes on.
        /// </summary>
        public KeyCode KeyCode
        {
            get
            {
                return keyCode;
            }
            set
            {
                keyCode = value;
            }
        }

        /// <inheritdoc />
        public void Process()
        {
            Receive(Input.GetKey(KeyCode));
        }
    }
}