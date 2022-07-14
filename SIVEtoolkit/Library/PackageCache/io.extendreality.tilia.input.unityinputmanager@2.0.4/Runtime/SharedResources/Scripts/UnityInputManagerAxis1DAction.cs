namespace Tilia.Input.UnityInputManager
{
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Process;

    /// <summary>
    /// Listens for the specified axis and emits the appropriate action.
    /// </summary>
    public class UnityInputManagerAxis1DAction : FloatAction, IProcessable
    {
        [Tooltip("The named axis to listen for state changes on.")]
        [SerializeField]
        private string axisName;
        /// <summary>
        /// The named axis to listen for state changes on.
        /// </summary>
        public string AxisName
        {
            get
            {
                return axisName;
            }
            set
            {
                axisName = value;
            }
        }
        [Tooltip("Multiplies the axis value.")]
        [SerializeField]
        private float multiplier = 1f;
        /// <summary>
        /// Multiplies the axis value.
        /// </summary>
        public float Multiplier
        {
            get
            {
                return multiplier;
            }
            set
            {
                multiplier = value;
            }
        }

        /// <inheritdoc />
        public void Process()
        {
            Receive(Input.GetAxis(AxisName) * Multiplier);
        }
    }
}