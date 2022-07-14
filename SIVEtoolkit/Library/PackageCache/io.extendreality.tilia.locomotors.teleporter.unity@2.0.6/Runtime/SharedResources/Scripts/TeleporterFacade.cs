namespace Tilia.Locomotors.Teleporter
{
    using UnityEngine;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Type;
    using Zinnia.Extension;
    using Zinnia.Rule;
    using Zinnia.Tracking.Modification;

    /// <summary>
    /// The public interface into the Teleporter Prefab.
    /// </summary>
    public class TeleporterFacade : MonoBehaviour
    {
        /// <summary>
        /// The type of offset to apply when teleporting.
        /// </summary>
        public enum OffsetType
        {
            /// <summary>
            /// Updates the teleported position with the <see cref="Offset"/> affecting the position but the destination rotation has no effect on the teleported rotation.
            /// </summary>
            OffsetAlwaysIgnoreDestinationRotation,
            /// <summary>
            /// Updates the teleported position with the <see cref="Offset"/> affecting the position and the destination rotation affecting the teleported rotation.
            /// </summary>
            OffsetAlwaysWithDestinationRotation,
            /// <summary>
            /// Updates the teleported position but only uses the <see cref="Offset"/> when affecting the floor snap position but the destination rotation has no effect on the teleported rotation.
            /// </summary>
            OffsetFloorSnapOnlyIgnoreDestinationRotation
        }

        #region Teleporter Settings
        [Header("Teleporter Settings")]
        [Tooltip("The target to move to the teleported position.")]
        [SerializeField]
        private GameObject target;
        /// <summary>
        /// The target to move to the teleported position.
        /// </summary>
        public GameObject Target
        {
            get
            {
                return target;
            }
            set
            {
                target = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterTargetChange();
                }
            }
        }
        [Tooltip("The offset to compensate the teleported target position by for both floor snapping and position movement.")]
        [SerializeField]
        private GameObject offset;
        /// <summary>
        /// The offset to compensate the teleported target position by for both floor snapping and position movement.
        /// </summary>
        public GameObject Offset
        {
            get
            {
                return offset;
            }
            set
            {
                offset = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterOffsetChange();
                }
            }
        }
        [Tooltip("Determines how to use the Offset when calculating the teleport location.")]
        [SerializeField]
        private OffsetType offsetUsage;
        /// <summary>
        /// Determines how to use the <see cref="Offset"/> when calculating the teleport location.
        /// </summary>
        public OffsetType OffsetUsage
        {
            get
            {
                return offsetUsage;
            }
            set
            {
                offsetUsage = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterOffsetUsageChange();
                }
            }
        }
        [Tooltip("Determines if the teleport destination Transform.rotation will be applied to the Target.")]
        [SerializeField]
        private bool applyDestinationRotation = true;
        /// <summary>
        /// Determines if the teleport destination <see cref="Transform.rotation"/> will be applied to the <see cref="Target"/>.
        /// </summary>
        public bool ApplyDestinationRotation
        {
            get
            {
                return applyDestinationRotation;
            }
            set
            {
                applyDestinationRotation = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterApplyDestinationRotationChange();
                }
            }
        }
        [Tooltip("The Rule of scene Cameras to apply a fade to.")]
        [SerializeField]
        private RuleContainer cameraValidity;
        /// <summary>
        /// The <see cref="Rule"/> of scene <see cref="Camera"/>s to apply a fade to.
        /// </summary>
        public RuleContainer CameraValidity
        {
            get
            {
                return cameraValidity;
            }
            set
            {
                cameraValidity = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterCameraValidityChange();
                }
            }
        }
        [Tooltip("Allows to optionally determine targets based on the set rules.")]
        [SerializeField]
        private RuleContainer targetValidity;
        /// <summary>
        /// Allows to optionally determine targets based on the set rules.
        /// </summary>
        public RuleContainer TargetValidity
        {
            get
            {
                return targetValidity;
            }
            set
            {
                targetValidity = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterTargetValidityChange();
                }
            }
        }
        #endregion

        #region Floor Snap Settings
        [Header("Floor Snap Settings")]
        [Tooltip("Whether to always attempt to teleport the Target to the nearest found floor every frame.")]
        [SerializeField]
        private bool snapToFloorEnabled = true;
        /// <summary>
        /// Whether to always attempt to teleport the <see cref="Target"/> to the nearest found floor every frame.
        /// </summary>
        public bool SnapToFloorEnabled
        {
            get
            {
                return snapToFloorEnabled;
            }
            set
            {
                snapToFloorEnabled = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterSnapToFloorEnabledChange();
                }
            }
        }
        [Tooltip("The distance between the previous floor and current floor to determine if a snap to the new floor is required.")]
        [SerializeField]
        private float snapToFloorThreshold = float.Epsilon;
        /// <summary>
        /// The distance between the previous floor and current floor to determine if a snap to the new floor is required.
        /// </summary>
        public float SnapToFloorThreshold
        {
            get
            {
                return snapToFloorThreshold;
            }
            set
            {
                snapToFloorThreshold = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterSnapToFloorThresholdChange();
                }
            }
        }
        [Tooltip("The distance between the previous floor and current floor to determine if the screen should blink when snapping to the new floor.")]
        [SerializeField]
        private float snapToFloorBlinkThreshold = 0.3f;
        /// <summary>
        /// The distance between the previous floor and current floor to determine if the screen should blink when snapping to the new floor.
        /// </summary>
        public float SnapToFloorBlinkThreshold
        {
            get
            {
                return snapToFloorBlinkThreshold;
            }
            set
            {
                snapToFloorBlinkThreshold = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterSnapToFloorBlinkThresholdChange();
                }
            }
        }
        [Tooltip("The distance between the previous floor and current floor to determine if the screen should blink when snapping to the new floor.")]
        [SerializeField]
        private Vector3 destinationOffset;
        /// <summary>
        /// The position amount to offset the destination teleport position.
        /// </summary>
        public Vector3 DestinationOffset
        {
            get
            {
                return destinationOffset;
            }
            set
            {
                destinationOffset = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterDestinationOffsetChange();
                }
            }
        }
        #endregion

        #region Teleporter Events
        /// <summary>
        /// Emitted when the teleporting is about to initiate.
        /// </summary>
        [Header("Teleporter Events")]
        public TransformPropertyApplier.UnityEvent Teleporting = new TransformPropertyApplier.UnityEvent();
        /// <summary>
        /// Emitted when the teleporting has completed.
        /// </summary>
        public TransformPropertyApplier.UnityEvent Teleported = new TransformPropertyApplier.UnityEvent();
        #endregion

        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The linked Internal Setup.")]
        [SerializeField]
        [Restricted]
        private TeleporterConfigurator configuration;
        /// <summary>
        /// The linked Internal Setup.
        /// </summary>
        public TeleporterConfigurator Configuration
        {
            get
            {
                return configuration;
            }
            protected set
            {
                configuration = value;
            }
        }
        #endregion

        /// <summary>
        /// Clears <see cref="Target"/>.
        /// </summary>
        public virtual void ClearTarget()
        {
            if (!this.IsValidState())
            {
                return;
            }

            Target = default;
        }

        /// <summary>
        /// Clears <see cref="Offset"/>.
        /// </summary>
        public virtual void ClearOffset()
        {
            if (!this.IsValidState())
            {
                return;
            }

            Offset = default;
        }

        /// <summary>
        /// Clears <see cref="CameraValidity"/>.
        /// </summary>
        public virtual void ClearCameraValidity()
        {
            if (!this.IsValidState())
            {
                return;
            }

            CameraValidity = default;
        }

        /// <summary>
        /// Clears <see cref="TargetValidity"/>.
        /// </summary>
        public virtual void ClearTargetValidity()
        {
            if (!this.IsValidState())
            {
                return;
            }

            TargetValidity = default;
        }

        /// <summary>
        /// Clears <see cref="Configuration"/>.
        /// </summary>
        public virtual void ClearConfiguration()
        {
            if (!this.IsValidState())
            {
                return;
            }

            Configuration = default;
        }

        /// <summary>
        /// Attempts to teleport the <see cref="Target"/>.
        /// </summary>
        /// <param name="destination">The location to attempt to teleport to.</param>
        public virtual void Teleport(Transform destination)
        {
            Teleport(new TransformData(destination));
        }

        /// <summary>
        /// Attempts to teleport the <see cref="Target"/>.
        /// </summary>
        /// <param name="destination">The location to attempt to teleport to.</param>
        public virtual void Teleport(GameObject destination)
        {
            Teleport(new TransformData(destination));
        }

        /// <summary>
        /// Attempts to teleport the <see cref="Target"/>.
        /// </summary>
        /// <param name="destination">The location to attempt to teleport to.</param>
        public virtual void Teleport(TransformData destination)
        {
            Configuration.Teleport(destination);
        }

        /// <summary>
        /// Attempts to teleport the <see cref="Target"/> to the given world position.
        /// </summary>
        /// <param name="destination">The world position to attempt to teleport to.</param>
        public virtual void Teleport(Vector3 destinationPosition)
        {
            GameObject transformLocation = new GameObject();
            TransformData destination = new TransformData(transformLocation.transform);
            destination.PositionOverride = destinationPosition;
            Teleport(destination);
            Destroy(transformLocation);
        }

        /// <summary>
        /// Sets <see cref="OffsetUsage"/>.
        /// </summary>
        /// <param name="offsetTypeIndex">The index of the <see cref="OffsetType"/>.</param>
        public virtual void SetOffsetUsage(int offsetTypeIndex)
        {
            OffsetUsage = EnumExtensions.GetByIndex<OffsetType>(offsetTypeIndex);
        }

        /// <summary>
        /// Called after <see cref="Target"/> has been changed.
        /// </summary>
        protected virtual void OnAfterTargetChange()
        {
            Configuration.ConfigureTransformPropertyAppliers();
        }

        /// <summary>
        /// Called after <see cref="Offset"/> has been changed.
        /// </summary>
        protected virtual void OnAfterOffsetChange()
        {
            Configuration.ConfigureSurfaceLocatorAliases();
            Configuration.ConfigureTransformPropertyAppliers();
        }

        /// <summary>
        /// Called after <see cref="OffsetUsage"/> has been changed.
        /// </summary>
        protected virtual void OnAfterOffsetUsageChange()
        {
            Configuration.ConfigureTransformPropertyAppliers();
        }

        /// <summary>
        /// Called after <see cref="ApplyDestinationRotation"/> has been changed.
        /// </summary>
        protected virtual void OnAfterApplyDestinationRotationChange()
        {
            Configuration.ConfigureRotationAbility(ApplyDestinationRotation);
        }

        /// <summary>
        /// Called after <see cref="CameraValidity"/> has been changed.
        /// </summary>
        protected virtual void OnAfterCameraValidityChange()
        {
            Configuration.ConfigureCameraColorOverlays();
        }

        /// <summary>
        /// Called after <see cref="TargetValidity"/> has been changed.
        /// </summary>
        protected virtual void OnAfterTargetValidityChange()
        {
            Configuration.ConfigureSurfaceLocatorRules();
        }

        /// <summary>
        /// Called after <see cref="SnapToFloorEnabled"/> has been changed.
        /// </summary>
        protected virtual void OnAfterSnapToFloorEnabledChange()
        {
            Configuration.ConfigureSnapToFloor();
        }

        /// <summary>
        /// Called after <see cref="SnapToFloorThreshold"/> has been changed.
        /// </summary>
        protected virtual void OnAfterSnapToFloorThresholdChange()
        {
            Configuration.ConfigureSurfaceChangeActions(SnapToFloorThreshold, SnapToFloorBlinkThreshold);
        }

        /// <summary>
        /// Called after <see cref="SnapToFloorBlinkThreshold"/> has been changed.
        /// </summary>
        protected virtual void OnAfterSnapToFloorBlinkThresholdChange()
        {
            Configuration.ConfigureSurfaceChangeActions(SnapToFloorThreshold, SnapToFloorBlinkThreshold);
        }

        /// <summary>
        /// Called after <see cref="DestinationOffset"/> has been changed.
        /// </summary>
        protected virtual void OnAfterDestinationOffsetChange()
        {
            Configuration.ConfigureSurfaceLocatorOffsets();
        }
    }
}