namespace Tilia.CameraRigs.XRPluginFramework
{
    using UnityEngine;
    using UnityEngine.XR;
    using Zinnia.Extension;
    using Zinnia.Tracking.CameraRig;

    /// <summary>
    /// Provides the description for a XR Plugin Framework CameraRig node element.
    /// </summary>
    public class XRFrameworkNodeRecord : BaseDeviceDetailsRecord
    {
        [Tooltip("The Node Type for the record.")]
        [SerializeField]
        private XRNode nodeType;
        /// <summary>
        /// The Node Type for the record.
        /// </summary>
        public XRNode NodeType
        {
            get
            {
                return nodeType;
            }
            set
            {
                nodeType = value;
            }
        }

        /// <inheritdoc/>
        public override XRNode XRNodeType { get { return NodeType; } protected set { NodeType = value; } }
        /// <inheritdoc/>
        public override int Priority { get => 0; protected set => throw new System.NotImplementedException(); }

        /// <summary>
        /// Sets the <see cref="NodeType"/>.
        /// </summary>
        /// <param name="index">The index of the <see cref="XRNode"/>.</param>
        public virtual void SetNodeType(int index)
        {
            NodeType = EnumExtensions.GetByIndex<XRNode>(index);
        }
    }
}