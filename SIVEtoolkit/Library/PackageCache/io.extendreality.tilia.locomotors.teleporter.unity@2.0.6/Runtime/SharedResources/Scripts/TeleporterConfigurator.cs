namespace Tilia.Locomotors.Teleporter
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Data.Attribute;
    using Zinnia.Data.Enum;
    using Zinnia.Data.Type;
    using Zinnia.Tracking;
    using Zinnia.Tracking.Modification;
    using Zinnia.Visual;

    /// <summary>
    /// Sets up the Teleport Prefab based on the provided user settings.
    /// </summary>
    public class TeleporterConfigurator : MonoBehaviour
    {
        #region Facade Settings
        [Header("Facade Settings")]
        [Tooltip("The public interface facade.")]
        [SerializeField]
        [Restricted]
        private TeleporterFacade facade;
        /// <summary>
        /// The public interface facade.
        /// </summary>
        public TeleporterFacade Facade
        {
            get
            {
                return facade;
            }
            protected set
            {
                facade = value;
            }
        }
        #endregion

        #region Teleporter Settings
        [Header("Teleporter Settings")]
        [Tooltip("The SurfaceLocator to use for the teleporting event.")]
        [SerializeField]
        [Restricted]
        private SurfaceLocator surfaceTeleporter;
        /// <summary>
        /// The <see cref="SurfaceLocator"/> to use for the teleporting event.
        /// </summary>
        public SurfaceLocator SurfaceTeleporter
        {
            get
            {
                return surfaceTeleporter;
            }
            protected set
            {
                surfaceTeleporter = value;
            }
        }
        [Tooltip("The TransformPropertyApplier to use for the teleporting event.")]
        [SerializeField]
        [Restricted]
        private TransformPropertyApplier modifyTeleporter;
        /// <summary>
        /// The <see cref="TransformPropertyApplier"/> to use for the teleporting event.
        /// </summary>
        public TransformPropertyApplier ModifyTeleporter
        {
            get
            {
                return modifyTeleporter;
            }
            protected set
            {
                modifyTeleporter = value;
            }
        }
        [Tooltip("The TransformPropertyApplier to use for the teleporting event.")]
        [SerializeField]
        [Restricted]
        private GameObject snapToFloorContainer;
        /// <summary>
        /// The <see cref="GameObject"/> that contains the snap to floor controller logic.
        /// </summary>
        public GameObject SnapToFloorContainer
        {
            get
            {
                return snapToFloorContainer;
            }
            protected set
            {
                snapToFloorContainer = value;
            }
        }
        #endregion

        #region Alias Settings
        [Header("Alias Settings")]
        [Tooltip("The SurfaceLocator to set aliases on.")]
        [SerializeField]
        [Restricted]
        private List<SurfaceLocator> surfaceLocatorAliases = new List<SurfaceLocator>();
        /// <summary>
        /// The <see cref="SurfaceLocator"/> to set aliases on.
        /// </summary>
        public List<SurfaceLocator> SurfaceLocatorAliases
        {
            get
            {
                return surfaceLocatorAliases;
            }
            protected set
            {
                surfaceLocatorAliases = value;
            }
        }
        [Tooltip("The SurfaceLocator to set rules on.")]
        [SerializeField]
        [Restricted]
        private List<SurfaceLocator> surfaceLocatorRules = new List<SurfaceLocator>();
        /// <summary>
        /// The <see cref="SurfaceLocator"/> to set rules on.
        /// </summary>
        public List<SurfaceLocator> SurfaceLocatorRules
        {
            get
            {
                return surfaceLocatorRules;
            }
            protected set
            {
                surfaceLocatorRules = value;
            }
        }
        [Tooltip("The TransformPropertyApplier collection to set aliases on.")]
        [SerializeField]
        [Restricted]
        private List<TransformPropertyApplier> transformPropertyApplierAliases = new List<TransformPropertyApplier>();
        /// <summary>
        /// The <see cref="TransformPropertyApplier"/> collection to set aliases on.
        /// </summary>
        public List<TransformPropertyApplier> TransformPropertyApplierAliases
        {
            get
            {
                return transformPropertyApplierAliases;
            }
            protected set
            {
                transformPropertyApplierAliases = value;
            }
        }
        [Tooltip("The TransformPropertyApplier collection to ignore offsets on.")]
        [SerializeField]
        [Restricted]
        private List<TransformPropertyApplier> transformPropertyApplierIgnoreOffsetAliases = new List<TransformPropertyApplier>();
        /// <summary>
        /// The <see cref="TransformPropertyApplier"/> collection to ignore offsets on.
        /// </summary>
        public List<TransformPropertyApplier> TransformPropertyApplierIgnoreOffsetAliases
        {
            get
            {
                return transformPropertyApplierIgnoreOffsetAliases;
            }
            protected set
            {
                transformPropertyApplierIgnoreOffsetAliases = value;
            }
        }
        [Tooltip("The scene Cameras to set the CameraColorOverlays to affect.")]
        [SerializeField]
        [Restricted]
        private List<CameraColorOverlay> cameraColorOverlays = new List<CameraColorOverlay>();
        /// <summary>
        /// The scene <see cref="Camera"/>s to set the <see cref="CameraColorOverlay"/>s to affect.
        /// </summary>
        public List<CameraColorOverlay> CameraColorOverlays
        {
            get
            {
                return cameraColorOverlays;
            }
            protected set
            {
                cameraColorOverlays = value;
            }
        }
        [Tooltip("The SurfaceChangeAction that holds the threshold of whether a snap to floor should even occur.")]
        [SerializeField]
        [Restricted]
        private SurfaceChangeAction snapToFloorThresholdController;
        /// <summary>
        /// The <see cref="SurfaceChangeAction"/> that holds the threshold of whether a snap to floor should even occur.
        /// </summary>
        public SurfaceChangeAction SnapToFloorThresholdController
        {
            get
            {
                return snapToFloorThresholdController;
            }
            protected set
            {
                snapToFloorThresholdController = value;
            }
        }
        [Tooltip("The SurfaceChangeAction that holds the threshold of whether a blink should occur when snapping to floor.")]
        [SerializeField]
        [Restricted]
        private SurfaceChangeAction snapToFloorBlinkThresholdController;
        /// <summary>
        /// The <see cref="SurfaceChangeAction"/> that holds the threshold of whether a blink should occur when snapping to floor.
        /// </summary>
        public SurfaceChangeAction SnapToFloorBlinkThresholdController
        {
            get
            {
                return snapToFloorBlinkThresholdController;
            }
            protected set
            {
                snapToFloorBlinkThresholdController = value;
            }
        }
        #endregion

        /// <summary>
        /// A <see cref="SurfaceLocator"/> collection to store cached versions that get mutated but need changing back after process.
        /// </summary>
        protected List<SurfaceLocator> cachedLocators = new List<SurfaceLocator>();
        /// <summary>
        /// the <see cref="Facade.SnapToFloorBlinkThreshold"/> value before it is mutated.
        /// </summary>
        protected float cachedSnapToFloorBlinkThreshold;
        /// <summary>
        /// Whether the <see cref="Facade.SnapToFloorBlinkThreshold"/> can be changed and affects the configuration.
        /// </summary>
        protected bool allowSnapToFloorBlinkThresholdSet = true;
        /// <summary>
        /// The routine for resetting cached data.
        /// </summary>
        protected Coroutine resetCachedDataRoutine;

        /// <summary>
        /// Attempts to teleport the <see cref="TeleporterFacade.Target"/>.
        /// </summary>
        /// <param name="destination">The location to attempt to teleport to.</param>
        public virtual void Teleport(TransformData destination)
        {
            if (SurfaceTeleporter != null)
            {
                SurfaceTeleporter.Locate(destination);
            }

            if (ModifyTeleporter != null)
            {
                ModifyTeleporter.Source = destination;
                ModifyTeleporter.Apply();
            }
        }

        /// <summary>
        /// Notifies that the teleporter is about to initiate.
        /// </summary>
        /// <param name="data">The location data.</param>
        public virtual void NotifyTeleporting(TransformPropertyApplier.EventData data)
        {
            Facade.Teleporting?.Invoke(data);
        }

        /// <summary>
        /// Notifies that the teleporter has completed.
        /// </summary>
        /// <param name="data">The location data.</param>
        public virtual void NotifyTeleported(TransformPropertyApplier.EventData data)
        {
            Facade.Teleported?.Invoke(data);
        }

        /// <summary>
        /// Configures the surface locator aliases with the offset provided in the facade.
        /// </summary>
        public virtual void ConfigureSurfaceLocatorAliases()
        {
            foreach (SurfaceLocator currentLocator in SurfaceLocatorAliases)
            {
                currentLocator.SearchOrigin = Facade.Offset;
            }
        }

        /// <summary>
        /// Configures the surface locator rules with the valid targets provided in the facade.
        /// </summary>
        public virtual void ConfigureSurfaceLocatorRules()
        {
            foreach (SurfaceLocator currentLocator in SurfaceLocatorRules)
            {
                currentLocator.TargetValidity = Facade.TargetValidity;
            }
        }

        /// <summary>
        /// Configures the surface locator rules with the valid targets provided in the facade.
        /// </summary>
        public virtual void ConfigureSurfaceLocatorOffsets()
        {
            foreach (SurfaceLocator currentLocator in SurfaceLocatorRules)
            {
                Vector3 newOffset = Facade.DestinationOffset;
                if (Facade.DestinationOffset.Equals(Vector3.zero))
                {
                    cachedLocators.Add(currentLocator);
                    newOffset = Vector3.one * (currentLocator.PositionChangedEqualityThreshold + float.Epsilon);
                }
                currentLocator.DestinationOffset = newOffset;
            }

            allowSnapToFloorBlinkThresholdSet = false;
            cachedSnapToFloorBlinkThreshold = Facade.SnapToFloorBlinkThreshold;
            Facade.SnapToFloorBlinkThreshold = 0f;

            if (resetCachedDataRoutine == null)
            {
                resetCachedDataRoutine = StartCoroutine(ResetOffsetAtEndOfFrame());
            }
        }

        /// <summary>
        /// Configures the transform properties applies with the settings applied in the facade.
        /// </summary>
        public virtual void ConfigureTransformPropertyAppliers()
        {
            foreach (TransformPropertyApplier currentApplier in TransformPropertyApplierAliases)
            {
                currentApplier.Target = Facade.Target;
                currentApplier.Offset = null;

                if (!TransformPropertyApplierIgnoreOffsetAliases.Contains(currentApplier))
                {
                    currentApplier.Offset = Facade.Offset;
                    continue;
                }

                currentApplier.Offset = Facade.OffsetUsage == TeleporterFacade.OffsetType.OffsetAlwaysWithDestinationRotation || Facade.OffsetUsage == TeleporterFacade.OffsetType.OffsetAlwaysIgnoreDestinationRotation ? Facade.Offset : null;
                currentApplier.ApplyRotationOffsetOnAxis = Facade.OffsetUsage == TeleporterFacade.OffsetType.OffsetAlwaysWithDestinationRotation ? currentApplier.ApplyRotationOffsetOnAxis : Vector3State.False;
            }
        }

        /// <summary>
        /// Configures the camera color overlays with the scene cameras provided in the facade.
        /// </summary>
        public virtual void ConfigureCameraColorOverlays()
        {
            foreach (CameraColorOverlay currentOverlay in CameraColorOverlays)
            {
                currentOverlay.CameraValidity = Facade.CameraValidity;
            }
        }

        /// <summary>
        /// Configures whether the teleporter will apply the destination rotation to the target.
        /// </summary>
        public virtual void ConfigureRotationAbility(bool shouldRotate)
        {
            if (shouldRotate)
            {
                EnableRotations();
            }
            else
            {
                DisableRotations();
            }
        }

        /// <summary>
        /// Configures the surface change actions that determine the snap to floor functionality.
        /// </summary>
        /// <param name="snapToFloorThreshold">The threshold of whether the change distance should do a new snap to the found floor.</param>
        /// <param name="snapToFloorBlinkThreshold">The threshold of whether to blink the view.</param>
        public virtual void ConfigureSurfaceChangeActions(float snapToFloorThreshold, float snapToFloorBlinkThreshold)
        {
            if (!allowSnapToFloorBlinkThresholdSet)
            {
                return;
            }

            SnapToFloorThresholdController.ChangeDistance = snapToFloorThreshold;
            SnapToFloorBlinkThresholdController.ChangeDistance = snapToFloorBlinkThreshold;
        }

        /// <summary>
        /// Configures the snap to floor logic based on the <see cref="Facade.SnapToFloorEnabled"/> setting.
        /// </summary>
        public virtual void ConfigureSnapToFloor()
        {
            SnapToFloorContainer.SetActive(Facade.SnapToFloorEnabled);
        }

        protected virtual void OnEnable()
        {
            ConfigureSurfaceLocatorAliases();
            ConfigureSurfaceLocatorRules();
            ConfigureSurfaceLocatorOffsets();
            ConfigureTransformPropertyAppliers();
            ConfigureCameraColorOverlays();
            ConfigureRotationAbility(Facade.ApplyDestinationRotation);
            ConfigureSurfaceChangeActions(Facade.SnapToFloorThreshold, Facade.SnapToFloorBlinkThreshold);
            ConfigureSnapToFloor();
            allowSnapToFloorBlinkThresholdSet = true;
        }

        /// <summary>
        /// Disables the ability to rotate the target.
        /// </summary>
        protected virtual void DisableRotations()
        {
            foreach (TransformPropertyApplier alias in TransformPropertyApplierIgnoreOffsetAliases)
            {
                alias.ApplyTransformations &= ~TransformProperties.Rotation;
            }
        }

        /// <summary>
        /// Enables the ability to rotate the target.
        /// </summary>
        protected virtual void EnableRotations()
        {
            foreach (TransformPropertyApplier alias in TransformPropertyApplierIgnoreOffsetAliases)
            {
                alias.ApplyTransformations |= TransformProperties.Rotation;
            }
        }

        /// <summary>
        /// Resets the data mutated by the destination offset update to the original cached values.
        /// </summary>
        /// <returns>An Enumerator to manage the running of the Coroutine.</returns>
        protected virtual IEnumerator ResetOffsetAtEndOfFrame()
        {
            yield return new WaitForEndOfFrame();

            allowSnapToFloorBlinkThresholdSet = true;
            Facade.SnapToFloorBlinkThreshold = cachedSnapToFloorBlinkThreshold;
            foreach (SurfaceLocator currentLocator in cachedLocators)
            {
                currentLocator.DestinationOffset = Vector3.zero;
            }

            cachedLocators.Clear();
            resetCachedDataRoutine = null;
        }
    }
}
