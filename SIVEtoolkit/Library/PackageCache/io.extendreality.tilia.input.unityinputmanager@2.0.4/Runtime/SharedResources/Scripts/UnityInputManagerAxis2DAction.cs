namespace Tilia.Input.UnityInputManager
{
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Process;

    /// <summary>
    /// Listens for the specified axes and emits the appropriate action.
    /// </summary>
    public class UnityInputManagerAxis2DAction : Vector2Action, IProcessable
    {
        [Tooltip("The named x axis to listen for state changes on.")]
        [SerializeField]
        private string xAxisName;
        /// <summary>
        /// The named x axis to listen for state changes on.
        /// </summary>
        public string XAxisName
        {
            get
            {
                return xAxisName;
            }
            set
            {
                xAxisName = value;
            }
        }
        [Tooltip("The named y axis to listen for state changes on.")]
        [SerializeField]
        private string yAxisName;
        /// <summary>
        /// The named y axis to listen for state changes on.
        /// </summary>
        public string YAxisName
        {
            get
            {
                return yAxisName;
            }
            set
            {
                yAxisName = value;
            }
        }
        [Tooltip("Multiplies the x axis value.")]
        [SerializeField]
        private float xMultiplier = 1f;
        /// <summary>
        /// Multiplies the x axis value.
        /// </summary>
        public float XMultiplier
        {
            get
            {
                return xMultiplier;
            }
            set
            {
                xMultiplier = value;
            }
        }
        [Tooltip("Multiplies the y axis value.")]
        [SerializeField]
        private float yMultiplier = 1f;
        /// <summary>
        /// Multiplies the y axis value.
        /// </summary>
        public float YMultiplier
        {
            get
            {
                return yMultiplier;
            }
            set
            {
                yMultiplier = value;
            }
        }

        /// <inheritdoc />
        public void Process()
        {
            Receive(new Vector2(Input.GetAxis(XAxisName) * XMultiplier, Input.GetAxis(YAxisName) * YMultiplier));
        }
    }
}