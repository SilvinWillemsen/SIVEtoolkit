namespace Tilia.CameraRigs.TrackedAlias
{
    using System;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.Events;
    using UnityEngine.XR;
    using Zinnia.Data.Attribute;
    using Zinnia.Extension;
    using Zinnia.Haptics;
    using Zinnia.Haptics.Collection;
    using Zinnia.Tracking.CameraRig;
    using Zinnia.Tracking.CameraRig.Collection;
    using Zinnia.Tracking.Follow;
    using Zinnia.Tracking.Velocity;

    /// <summary>
    /// The public interface into the Tracked Alias Prefab.
    /// </summary>
    public class TrackedAliasFacade : MonoBehaviour
    {
        /// <summary>
        /// Defines the event with the <see cref="LinkedAliasAssociationCollection"/>.
        /// </summary>
        [Serializable]
        public class LinkedAliasAssociationCollectionUnityEvent : UnityEvent<LinkedAliasAssociationCollection> { }

        #region Tracked Alias Settings
        [Header("Tracked Alias Settings")]
        [Tooltip("The associated CameraRigs to track.")]
        [SerializeField]
        private LinkedAliasAssociationCollectionObservableList cameraRigs;
        /// <summary>
        /// The associated CameraRigs to track.
        /// </summary>
        public LinkedAliasAssociationCollectionObservableList CameraRigs
        {
            get
            {
                return cameraRigs;
            }
            set
            {
                if (this.IsMemberChangeAllowed())
                {
                    OnBeforeCameraRigsChange();
                }
                cameraRigs = value;
                if (this.IsMemberChangeAllowed())
                {
                    OnAfterCameraRigsChange();
                }
            }
        }
        #endregion

        #region Tracking Events
        /// <summary>
        /// Emitted when the tracked alias is about to change.
        /// </summary>
        [Header("Tracking Events")]
        public LinkedAliasAssociationCollectionUnityEvent TrackedAliasChanged = new LinkedAliasAssociationCollectionUnityEvent();
        /// <summary>
        /// Emitted when the dominant controller is changing.
        /// </summary>
        public DominantControllerObserver.UnityEvent DominantControllerIsChanging = new DominantControllerObserver.UnityEvent();
        #endregion

        #region Headset Events
        /// <summary>
        /// Emitted when the headset starts tracking for the first time.
        /// </summary>
        [Header("Headset Events")]
        public UnityEvent HeadsetTrackingBegun = new UnityEvent();
        /// <summary>
        /// Emitted when the headset becomes the dominant controller.
        /// </summary>
        public UnityEvent HeadsetBecameDominantController = new UnityEvent();
        /// <summary>
        /// Emitted when the headset connection status changes.
        /// </summary>
        public DeviceDetailsRecord.BoolUnityEvent HeadsetConnectionStatusChanged = new DeviceDetailsRecord.BoolUnityEvent();
        /// <summary>
        /// Emitted when the headset tracking type changes.
        /// </summary>
        public DeviceDetailsRecord.SpatialTrackingTypeUnityEvent HeadsetTrackingTypeChanged = new DeviceDetailsRecord.SpatialTrackingTypeUnityEvent();
        /// <summary>
        /// Emitted when the headset battery charge status changes.
        /// </summary>
        public DeviceDetailsRecord.BatteryStatusUnityEvent HeadsetBatteryChargeStatusChanged = new DeviceDetailsRecord.BatteryStatusUnityEvent();
        #endregion

        #region Left Controller Events
        /// <summary>
        /// Emitted when the left controller starts tracking for the first time.
        /// </summary>
        [Header("Left Controller Events")]
        public UnityEvent LeftControllerTrackingBegun = new UnityEvent();
        /// <summary>
        /// Emitted when the left controller becomes the dominant controller.
        /// </summary>
        public UnityEvent LeftControllerBecameDominantController = new UnityEvent();
        /// <summary>
        /// Emitted when the left controller connection status changes.
        /// </summary>
        public DeviceDetailsRecord.BoolUnityEvent LeftControllerConnectionStatusChanged = new DeviceDetailsRecord.BoolUnityEvent();
        /// <summary>
        /// Emitted when the left controller tracking type changes.
        /// </summary>
        public DeviceDetailsRecord.SpatialTrackingTypeUnityEvent LeftControllerTrackingTypeChanged = new DeviceDetailsRecord.SpatialTrackingTypeUnityEvent();
        /// <summary>
        /// Emitted when the left controller battery charge status changes.
        /// </summary>
        public DeviceDetailsRecord.BatteryStatusUnityEvent LeftControllerBatteryChargeStatusChanged = new DeviceDetailsRecord.BatteryStatusUnityEvent();
        #endregion

        #region Right Controller Events
        /// <summary>
        /// Emitted when the right controller starts tracking for the first time.
        /// </summary>
        [Header("Right Controller Events")]
        public UnityEvent RightControllerTrackingBegun = new UnityEvent();
        /// <summary>
        /// Emitted when the right controller becomes the dominant controller.
        /// </summary>
        public UnityEvent RightControllerBecameDominantController = new UnityEvent();
        /// <summary>
        /// Emitted when the right controller connection status changes.
        /// </summary>
        public DeviceDetailsRecord.BoolUnityEvent RightControllerConnectionStatusChanged = new DeviceDetailsRecord.BoolUnityEvent();
        /// <summary>
        /// Emitted when the right controller tracking type changes.
        /// </summary>
        public DeviceDetailsRecord.SpatialTrackingTypeUnityEvent RightControllerTrackingTypeChanged = new DeviceDetailsRecord.SpatialTrackingTypeUnityEvent();
        /// <summary>
        /// Emitted when the right controller battery charge status changes.
        /// </summary>
        public DeviceDetailsRecord.BatteryStatusUnityEvent RightControllerBatteryChargeStatusChanged = new DeviceDetailsRecord.BatteryStatusUnityEvent();
        #endregion

        #region Reference Settings
        [Header("Reference Settings")]
        [Tooltip("The linked Internal Setup.")]
        [SerializeField]
        [Restricted]
        private TrackedAliasConfigurator configuration;
        /// <summary>
        /// The linked Internal Setup.
        /// </summary>
        public TrackedAliasConfigurator Configuration
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

        public virtual LinkedAliasAssociationCollection ActiveLinkedAliasAssociation => GetFirstActiveLinkedAliasAssociationCollection(CameraRigs.NonSubscribableElements);
        /// <summary>
        /// Retrieves the active PlayArea that the TrackedAlias is using.
        /// </summary>
        public virtual GameObject ActivePlayArea => GetFirstActiveGameObject(PlayAreas);
        /// <summary>
        /// Retrieves the active Headset that the TrackedAlias is using.
        /// </summary>

        #region Headset Properties
        public virtual GameObject ActiveHeadset => GetFirstActiveGameObject(Headsets);
        /// <summary>
        /// Retrieves the active Headset Camera that the TrackedAlias is using.
        /// </summary>
        public virtual Camera ActiveHeadsetCamera => GetFirstActiveCamera(HeadsetCameras);
        /// <summary>
        /// Retrieves the active Headset Velocity Tracker that the TrackedAlias is using.
        /// </summary>
        public virtual VelocityTracker ActiveHeadsetVelocity => GetFirstActiveVelocityTracker(HeadsetVelocityTrackers);
        /// <summary>
        /// Retrieves the active Headset Detail Record that the TrackedAlias is using.
        /// </summary>
        public virtual DeviceDetailsRecord ActiveHeadsetDetails => GetFirstActiveDeviceRecord(HeadsetDeviceDetailRecords);
        /// <summary>
        /// Retrieves the active Headset Detail Tracking Begun status that the TrackedAlias is using.
        /// </summary>
        public virtual bool ActiveHeadsetTrackingHasBegun => GetFirstActiveDeviceRecord(HeadsetDeviceDetailRecords).TrackingHasBegun;
        /// <summary>
        /// Retrieves the active Headset Detail Is Connected status that the TrackedAlias is using.
        /// </summary>
        public virtual bool ActiveHeadsetIsConnected => GetFirstActiveDeviceRecord(HeadsetDeviceDetailRecords).IsConnected;
        /// <summary>
        /// Retrieves the active Headset Detail Manufacturer status that the TrackedAlias is using.
        /// </summary>
        public virtual string ActiveHeadsetManufacturer => GetFirstActiveDeviceRecord(HeadsetDeviceDetailRecords).Manufacturer;
        /// <summary>
        /// Retrieves the active Headset Detail Model status that the TrackedAlias is using.
        /// </summary>
        public virtual string ActiveHeadsetModel => GetFirstActiveDeviceRecord(HeadsetDeviceDetailRecords).Model;
        /// <summary>
        /// Retrieves the active Headset Detail Tracking Type status that the TrackedAlias is using.
        /// </summary>
        public virtual DeviceDetailsRecord.SpatialTrackingType ActiveHeadsetTrackingType => GetFirstActiveDeviceRecord(HeadsetDeviceDetailRecords).TrackingType;
        /// <summary>
        /// Retrieves the active Headset Detail Battery Level status that the TrackedAlias is using.
        /// </summary>
        public virtual float ActiveHeadsetBatteryLevel => GetFirstActiveDeviceRecord(HeadsetDeviceDetailRecords).BatteryLevel;
        /// <summary>
        /// Retrieves the active Headset Detail Battery Charge status that the TrackedAlias is using.
        /// </summary>
        public virtual BatteryStatus ActiveHeadsetBatteryChargeStatus => GetFirstActiveDeviceRecord(HeadsetDeviceDetailRecords).BatteryChargeStatus;
        #endregion

        #region Dominant Controller Properties
        /// <summary>
        /// Retrieves the active Headset Detail Record that the TrackedAlias is using.
        /// </summary>
        public virtual DominantControllerObserver ActiveDominantControllerObserver => GetFirstActiveDominantControllerObserver(DominantControllerObservers);
        /// <summary>
        /// Retrieves the active Dominant Controller <see cref="GameObject"/> that the TrackedAlias is using.
        /// </summary>
        public virtual GameObject ActiveDominantController => ActiveDominantControllerRecord != null ? ActiveDominantControllerRecord.gameObject : null;
        /// <summary>
        /// Retrieves the dominant connected controller node.
        /// </summary>
        public virtual XRNode ActiveDominantControllerNode => ActiveDominantControllerObserver != null ? ActiveDominantControllerObserver.DominantController : XRNode.Head;
        /// <summary>
        /// Retrieves the active Dominant Controller Velocity Tracker that the TrackedAlias is using.
        /// </summary>
        public virtual VelocityTracker ActiveDominantControllerVelocity => Configuration.DominantControllerVelocityTrackers;
        /// <summary>
        /// Retrieves the active Dominant Controller Haptic Process that the TrackedAlias is using.
        /// </summary>
        public virtual HapticProcess ActiveDominantHapticProcess => ActiveDominantControllerObserver != null ? GetFirstActiveHapticProcess(ActiveDominantControllerObserver.DominantController == XRNode.LeftHand ? LeftControllerHapticProcesses : RightControllerHapticProcesses) : null;
        /// <summary>
        /// Retrieves the active Dominant Controller Haptic Profiles that the TrackedAlias is using.
        /// </summary>
        public virtual HapticProcessObservableList ActiveDominantHapticProfiles => ActiveDominantControllerObserver != null ? GetFirstActiveHapticProfile(ActiveDominantControllerObserver.DominantController == XRNode.LeftHand ? LeftControllerHapticProfiles : RightControllerHapticProfiles) : null;
        /// <summary>
        /// Retrieves the active Dominant Controller Haptic Profile that has been most recently used.
        /// </summary>
        public virtual HapticProcess ActiveDominantHapticProfile { get; protected set; }
        /// <summary>
        /// Retrieves the active Dominant Controller Detail Record that the TrackedAlias is using.
        /// </summary>
        public virtual DeviceDetailsRecord ActiveDominantControllerRecord => ActiveDominantControllerObserver != null ? ActiveDominantControllerObserver.DominantControllerDetails : null;
        /// <summary>
        /// Retrieves the active Dominant Controller Detail Tracking Begun status that the TrackedAlias is using.
        /// </summary>
        public virtual bool ActiveDominantControllerTrackingHasBegun => ActiveDominantControllerRecord != null ? ActiveDominantControllerRecord.TrackingHasBegun : false;
        /// <summary>
        /// Retrieves the active Dominant Controller Detail Is Connected status that the TrackedAlias is using.
        /// </summary>
        public virtual bool ActiveDominantControllerIsConnected => ActiveDominantControllerRecord != null ? ActiveDominantControllerRecord.IsConnected : false;
        /// <summary>
        /// Retrieves the active Dominant Controller Detail Manufacturer status that the TrackedAlias is using.
        /// </summary>
        public virtual string ActiveDominantControllerManufacturer => ActiveDominantControllerRecord != null ? ActiveDominantControllerRecord.Manufacturer : null;
        /// <summary>
        /// Retrieves the active Dominant Controller Detail Model status that the TrackedAlias is using.
        /// </summary>
        public virtual string ActiveDominantControllerModel => ActiveDominantControllerRecord != null ? ActiveDominantControllerRecord.Model : null;
        /// <summary>
        /// Retrieves the active Dominant Controller Detail Tracking Type status that the TrackedAlias is using.
        /// </summary>
        public virtual DeviceDetailsRecord.SpatialTrackingType ActiveDominantControllerTrackingType => ActiveDominantControllerRecord != null ? ActiveDominantControllerRecord.TrackingType : DeviceDetailsRecord.SpatialTrackingType.Unknown;
        /// <summary>
        /// Retrieves the active Dominant Controller Detail Battery Level status that the TrackedAlias is using.
        /// </summary>
        public virtual float ActiveDominantControllerBatteryLevel => ActiveDominantControllerRecord != null ? ActiveDominantControllerRecord.BatteryLevel : -1f;
        /// <summary>
        /// Retrieves the active Dominant Controller Detail Battery Charge status that the TrackedAlias is using.
        /// </summary>
        public virtual BatteryStatus ActiveDominantControllerBatteryChargeStatus => ActiveDominantControllerRecord != null ? ActiveDominantControllerRecord.BatteryChargeStatus : BatteryStatus.Unknown;
        #endregion

        #region Left Controller Properties
        /// <summary>
        /// Retrieves the active Left Controller <see cref="GameObject"/> that the TrackedAlias is using.
        /// </summary>
        public virtual GameObject ActiveLeftController => GetFirstActiveGameObject(LeftControllers);
        /// <summary>
        /// Retrieves the left connected controller node.
        /// </summary>
        public virtual XRNode ActiveLeftControllerNode => GetFirstActiveDeviceRecord(LeftControllerDeviceDetailRecords).XRNodeType;
        /// <summary>
        /// Retrieves the active Left Controller Velocity Tracker that the TrackedAlias is using.
        /// </summary>
        public virtual VelocityTracker ActiveLeftControllerVelocity => GetFirstActiveVelocityTracker(LeftControllerVelocityTrackers);
        /// <summary>
        /// Retrieves the active Left Controller Haptic Process that the TrackedAlias is using.
        /// </summary>
        public virtual HapticProcess ActiveLeftHapticProcess => GetFirstActiveHapticProcess(LeftControllerHapticProcesses);
        /// <summary>
        /// Retrieves the active Left Controller Haptic Profiles that the TrackedAlias is using.
        /// </summary>
        public virtual HapticProcessObservableList ActiveLeftHapticProfiles => GetFirstActiveHapticProfile(LeftControllerHapticProfiles);
        /// <summary>
        /// Retrieves the active Left Controller Haptic Profile that has been most recently used.
        /// </summary>
        public virtual HapticProcess ActiveLeftHapticProfile { get; protected set; }
        /// <summary>
        /// Retrieves the active Left Controller Detail Record that the TrackedAlias is using.
        /// </summary>
        public virtual DeviceDetailsRecord ActiveLeftControllerDetails => GetFirstActiveDeviceRecord(LeftControllerDeviceDetailRecords);
        /// <summary>
        /// Retrieves the active Left Controller Detail Tracking Begun status that the TrackedAlias is using.
        /// </summary>
        public virtual bool ActiveLeftControllerTrackingHasBegun => GetFirstActiveDeviceRecord(LeftControllerDeviceDetailRecords).TrackingHasBegun;
        /// <summary>
        /// Retrieves the active Left Controller Detail Is Connected status that the TrackedAlias is using.
        /// </summary>
        public virtual bool ActiveLeftControllerIsConnected => GetFirstActiveDeviceRecord(LeftControllerDeviceDetailRecords).IsConnected;
        /// <summary>
        /// Retrieves the active Left Controller Detail Manufacturer status that the TrackedAlias is using.
        /// </summary>
        public virtual string ActiveLeftControllerManufacturer => GetFirstActiveDeviceRecord(LeftControllerDeviceDetailRecords).Manufacturer;
        /// <summary>
        /// Retrieves the active Left Controller Detail Model status that the TrackedAlias is using.
        /// </summary>
        public virtual string ActiveLeftControllerModel => GetFirstActiveDeviceRecord(LeftControllerDeviceDetailRecords).Model;
        /// <summary>
        /// Retrieves the active Left Controller Detail Tracking Type status that the TrackedAlias is using.
        /// </summary>
        public virtual DeviceDetailsRecord.SpatialTrackingType ActiveLeftControllerTrackingType => GetFirstActiveDeviceRecord(LeftControllerDeviceDetailRecords).TrackingType;
        /// <summary>
        /// Retrieves the active Left Controller Detail Battery Level status that the TrackedAlias is using.
        /// </summary>
        public virtual float ActiveLeftControllerBatteryLevel => GetFirstActiveDeviceRecord(LeftControllerDeviceDetailRecords).BatteryLevel;
        /// <summary>
        /// Retrieves the active Left Controller Detail Battery Charge status that the TrackedAlias is using.
        /// </summary>
        public virtual BatteryStatus ActiveLeftControllerBatteryChargeStatus => GetFirstActiveDeviceRecord(LeftControllerDeviceDetailRecords).BatteryChargeStatus;
        #endregion

        #region Right Controller Properties
        /// <summary>
        /// Retrieves the active Right Controller <see cref="GameObject"/> that the TrackedAlias is using.
        /// </summary>
        public virtual GameObject ActiveRightController => GetFirstActiveGameObject(RightControllers);
        /// <summary>
        /// Retrieves the right connected controller node.
        /// </summary>
        public virtual XRNode ActiveRightControllerNode => GetFirstActiveDeviceRecord(RightControllerDeviceDetailRecords).XRNodeType;
        /// <summary>
        /// Retrieves the active Right Controller Velocity Tracker that the TrackedAlias is using.
        /// </summary>
        public virtual VelocityTracker ActiveRightControllerVelocity => GetFirstActiveVelocityTracker(RightControllerVelocityTrackers);
        /// <summary>
        /// Retrieves the active Right Controller Haptic Process that the TrackedAlias is using.
        /// </summary>
        public virtual HapticProcess ActiveRightHapticProcess => GetFirstActiveHapticProcess(RightControllerHapticProcesses);
        /// <summary>
        /// Retrieves the active Right Controller Haptic Profiles that the TrackedAlias is using.
        /// </summary>
        public virtual HapticProcessObservableList ActiveRightHapticProfiles => GetFirstActiveHapticProfile(RightControllerHapticProfiles);
        /// <summary>
        /// Retrieves the active Right Controller Haptic Profile that has been most recently used.
        /// </summary>
        public virtual HapticProcess ActiveRightHapticProfile { get; protected set; }
        /// <summary>
        /// Retrieves the active Right Controller Detail Record that the TrackedAlias is using.
        /// </summary>
        public virtual DeviceDetailsRecord ActiveRightControllerDetails => GetFirstActiveDeviceRecord(RightControllerDeviceDetailRecords);
        /// <summary>
        /// Retrieves the active Right Controller Detail Tracking Begun status that the TrackedAlias is using.
        /// </summary>
        public virtual bool ActiveRightControllerTrackingHasBegun => GetFirstActiveDeviceRecord(RightControllerDeviceDetailRecords).TrackingHasBegun;
        /// <summary>
        /// Retrieves the active Right Controller Detail Is Connected status that the TrackedAlias is using.
        /// </summary>
        public virtual bool ActiveRightControllerIsConnected => GetFirstActiveDeviceRecord(RightControllerDeviceDetailRecords).IsConnected;
        /// <summary>
        /// Retrieves the active Right Controller Detail Manufacturer status that the TrackedAlias is using.
        /// </summary>
        public virtual string ActiveRightControllerManufacturer => GetFirstActiveDeviceRecord(RightControllerDeviceDetailRecords).Manufacturer;
        /// <summary>
        /// Retrieves the active Right Controller Detail Model status that the TrackedAlias is using.
        /// </summary>
        public virtual string ActiveRightControllerModel => GetFirstActiveDeviceRecord(RightControllerDeviceDetailRecords).Model;
        /// <summary>
        /// Retrieves the active Right Controller Detail Tracking Type status that the TrackedAlias is using.
        /// </summary>
        public virtual DeviceDetailsRecord.SpatialTrackingType ActiveRightControllerTrackingType => GetFirstActiveDeviceRecord(RightControllerDeviceDetailRecords).TrackingType;
        /// <summary>
        /// Retrieves the active Right Controller Detail Battery Level status that the TrackedAlias is using.
        /// </summary>
        public virtual float ActiveRightControllerBatteryLevel => GetFirstActiveDeviceRecord(RightControllerDeviceDetailRecords).BatteryLevel;
        /// <summary>
        /// Retrieves the active Right Controller Detail Battery Charge status that the TrackedAlias is using.
        /// </summary>
        public virtual BatteryStatus ActiveRightControllerBatteryChargeStatus => GetFirstActiveDeviceRecord(RightControllerDeviceDetailRecords).BatteryChargeStatus;
        #endregion

        #region Enumerables
        /// <summary>
        /// Retrieves all of the linked CameraRig PlayAreas.
        /// </summary>
        public virtual IEnumerable<GameObject> PlayAreas
        {
            get
            {
                if (CameraRigs == null)
                {
                    yield break;
                }

                foreach (LinkedAliasAssociationCollection cameraRig in CameraRigs.NonSubscribableElements)
                {
                    if (cameraRig == null)
                    {
                        continue;
                    }

                    GameObject playArea = cameraRig.PlayArea;
                    if (playArea != null)
                    {
                        yield return playArea;
                    }
                }
            }
        }
        /// <summary>
        /// Retrieves all of the linked CameraRig Headsets.
        /// </summary>
        public virtual IEnumerable<GameObject> Headsets
        {
            get
            {
                if (CameraRigs == null)
                {
                    yield break;
                }

                foreach (LinkedAliasAssociationCollection cameraRig in CameraRigs.NonSubscribableElements)
                {
                    if (cameraRig == null)
                    {
                        continue;
                    }

                    GameObject headset = cameraRig.Headset;
                    if (headset != null)
                    {
                        yield return headset;
                    }
                }
            }
        }
        /// <summary>
        /// Retrieves all of the linked CameraRig Headset Cameras.
        /// </summary>
        public virtual IEnumerable<Camera> HeadsetCameras
        {
            get
            {
                if (CameraRigs == null)
                {
                    yield break;
                }

                foreach (LinkedAliasAssociationCollection cameraRig in CameraRigs.NonSubscribableElements)
                {
                    if (cameraRig == null)
                    {
                        continue;
                    }

                    Camera headsetCamera = cameraRig.HeadsetCamera;
                    if (headsetCamera != null)
                    {
                        yield return headsetCamera;
                    }
                }
            }
        }
        /// <summary>
        /// Retrieves all of the linked CameraRig Headset Velocity Trackers.
        /// </summary>
        public virtual IEnumerable<VelocityTracker> HeadsetVelocityTrackers
        {
            get
            {
                if (CameraRigs == null)
                {
                    yield break;
                }

                foreach (LinkedAliasAssociationCollection cameraRig in CameraRigs.NonSubscribableElements)
                {
                    if (cameraRig == null)
                    {
                        continue;
                    }

                    VelocityTracker headsetVelocityTracker = cameraRig.HeadsetVelocityTracker;
                    if (headsetVelocityTracker != null)
                    {
                        yield return headsetVelocityTracker;
                    }
                }
            }
        }
        /// <summary>
        /// Retrieves all of the linked CameraRig Supplement Headset Camera.
        /// </summary>
        public virtual IEnumerable<Camera> HeadsetSupplementCameras
        {
            get
            {
                if (CameraRigs == null)
                {
                    yield break;
                }

                foreach (LinkedAliasAssociationCollection cameraRig in CameraRigs.NonSubscribableElements)
                {
                    if (cameraRig == null)
                    {
                        continue;
                    }

                    if (cameraRig.SupplementHeadsetCameras != null)
                    {
                        foreach (Camera headsetCamera in cameraRig.SupplementHeadsetCameras.NonSubscribableElements)
                        {
                            yield return headsetCamera;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Retrieves all of the linked CameraRig Headset Device Detail Record.
        /// </summary>
        public virtual IEnumerable<DeviceDetailsRecord> HeadsetDeviceDetailRecords
        {
            get
            {
                if (CameraRigs == null)
                {
                    yield break;
                }

                foreach (LinkedAliasAssociationCollection cameraRig in CameraRigs.NonSubscribableElements)
                {
                    if (cameraRig == null)
                    {
                        continue;
                    }

                    DeviceDetailsRecord headsetDetails = cameraRig.HeadsetDeviceDetails;
                    if (headsetDetails != null)
                    {
                        yield return headsetDetails;
                    }
                }
            }
        }
        /// <summary>
        /// Retrieves all of the linked CameraRig Dominant Controller Observers.
        /// </summary>
        public virtual IEnumerable<DominantControllerObserver> DominantControllerObservers
        {
            get
            {
                if (CameraRigs == null)
                {
                    yield break;
                }

                foreach (LinkedAliasAssociationCollection cameraRig in CameraRigs.NonSubscribableElements)
                {
                    if (cameraRig == null)
                    {
                        continue;
                    }

                    DominantControllerObserver dominantController = cameraRig.DominantController;
                    if (dominantController != null)
                    {
                        yield return dominantController;
                    }
                }
            }
        }
        /// <summary>
        /// Retrieves all of the linked CameraRig Left Controllers.
        /// </summary>
        public virtual IEnumerable<GameObject> LeftControllers
        {
            get
            {
                if (CameraRigs == null)
                {
                    yield break;
                }

                foreach (LinkedAliasAssociationCollection cameraRig in CameraRigs.NonSubscribableElements)
                {
                    if (cameraRig == null)
                    {
                        continue;
                    }

                    GameObject leftController = cameraRig.LeftController;
                    if (leftController != null)
                    {
                        yield return leftController;
                    }
                }
            }
        }
        /// <summary>
        /// Retrieves all of the linked CameraRig Right Controllers.
        /// </summary>
        public virtual IEnumerable<GameObject> RightControllers
        {
            get
            {
                if (CameraRigs == null)
                {
                    yield break;
                }

                foreach (LinkedAliasAssociationCollection cameraRig in CameraRigs.NonSubscribableElements)
                {
                    if (cameraRig == null)
                    {
                        continue;
                    }

                    GameObject rightController = cameraRig.RightController;
                    if (rightController != null)
                    {
                        yield return rightController;
                    }
                }
            }
        }
        /// <summary>
        /// Retrieves all of the linked CameraRig Left Controller Velocity Trackers.
        /// </summary>
        public virtual IEnumerable<VelocityTracker> LeftControllerVelocityTrackers
        {
            get
            {
                if (CameraRigs == null)
                {
                    yield break;
                }

                foreach (LinkedAliasAssociationCollection cameraRig in CameraRigs.NonSubscribableElements)
                {
                    if (cameraRig == null)
                    {
                        continue;
                    }

                    VelocityTracker leftControllerVelocityTracker = cameraRig.LeftControllerVelocityTracker;
                    if (leftControllerVelocityTracker != null)
                    {
                        yield return leftControllerVelocityTracker;
                    }
                }
            }
        }
        /// <summary>
        /// Retrieves all of the linked CameraRig Right Controller Velocity Trackers.
        /// </summary>
        public virtual IEnumerable<VelocityTracker> RightControllerVelocityTrackers
        {
            get
            {
                if (CameraRigs == null)
                {
                    yield break;
                }

                foreach (LinkedAliasAssociationCollection cameraRig in CameraRigs.NonSubscribableElements)
                {
                    if (cameraRig == null)
                    {
                        continue;
                    }

                    VelocityTracker rightControllerVelocityTracker = cameraRig.RightControllerVelocityTracker;
                    if (rightControllerVelocityTracker != null)
                    {
                        yield return rightControllerVelocityTracker;
                    }
                }
            }
        }
        /// <summary>
        /// Retrieves all of the linked CameraRig Left Controller Haptic Processes.
        /// </summary>
        public virtual IEnumerable<HapticProcess> LeftControllerHapticProcesses
        {
            get
            {
                if (CameraRigs == null)
                {
                    yield break;
                }

                foreach (LinkedAliasAssociationCollection cameraRig in CameraRigs.NonSubscribableElements)
                {
                    if (cameraRig == null)
                    {
                        continue;
                    }

                    HapticProcess leftControllerHapticProcess = cameraRig.LeftControllerHapticProcess;
                    if (leftControllerHapticProcess != null)
                    {
                        yield return leftControllerHapticProcess;
                    }
                }
            }
        }
        /// <summary>
        /// Retrieves all of the linked CameraRig Right Controller Haptic Processes.
        /// </summary>
        public virtual IEnumerable<HapticProcess> RightControllerHapticProcesses
        {
            get
            {
                if (CameraRigs == null)
                {
                    yield break;
                }

                foreach (LinkedAliasAssociationCollection cameraRig in CameraRigs.NonSubscribableElements)
                {
                    if (cameraRig == null)
                    {
                        continue;
                    }

                    HapticProcess rightControllerHapticProcess = cameraRig.RightControllerHapticProcess;
                    if (rightControllerHapticProcess != null)
                    {
                        yield return rightControllerHapticProcess;
                    }
                }
            }
        }
        /// <summary>
        /// Retrieves all of the linked CameraRig Left Controller Haptic Profiles.
        /// </summary>
        public virtual IEnumerable<HapticProcessObservableList> LeftControllerHapticProfiles
        {
            get
            {
                if (CameraRigs == null)
                {
                    yield break;
                }

                foreach (LinkedAliasAssociationCollection cameraRig in CameraRigs.NonSubscribableElements)
                {
                    if (cameraRig == null)
                    {
                        continue;
                    }

                    HapticProcessObservableList leftControllerHapticProfiles = cameraRig.LeftControllerHapticProfiles;
                    if (leftControllerHapticProfiles != null)
                    {
                        yield return leftControllerHapticProfiles;
                    }
                }
            }
        }
        /// <summary>
        /// Retrieves all of the linked CameraRig Right Controller Haptic Processes.
        /// </summary>
        public virtual IEnumerable<HapticProcessObservableList> RightControllerHapticProfiles
        {
            get
            {
                if (CameraRigs == null)
                {
                    yield break;
                }

                foreach (LinkedAliasAssociationCollection cameraRig in CameraRigs.NonSubscribableElements)
                {
                    if (cameraRig == null)
                    {
                        continue;
                    }

                    HapticProcessObservableList rightControllerHapticProfiles = cameraRig.RightControllerHapticProfiles;
                    if (rightControllerHapticProfiles != null)
                    {
                        yield return rightControllerHapticProfiles;
                    }
                }
            }
        }
        /// <summary>
        /// Retrieves all of the linked CameraRig Left Controller Device Detail Record.
        /// </summary>
        public virtual IEnumerable<DeviceDetailsRecord> LeftControllerDeviceDetailRecords
        {
            get
            {
                if (CameraRigs == null)
                {
                    yield break;
                }

                foreach (LinkedAliasAssociationCollection cameraRig in CameraRigs.NonSubscribableElements)
                {
                    if (cameraRig == null)
                    {
                        continue;
                    }

                    DeviceDetailsRecord leftControllerDetails = cameraRig.LeftControllerDeviceDetails;
                    if (leftControllerDetails != null)
                    {
                        yield return leftControllerDetails;
                    }
                }
            }
        }
        /// <summary>
        /// Retrieves all of the linked CameraRig Right Controller Device Detail Record.
        /// </summary>
        public virtual IEnumerable<DeviceDetailsRecord> RightControllerDeviceDetailRecords
        {
            get
            {
                if (CameraRigs == null)
                {
                    yield break;
                }

                foreach (LinkedAliasAssociationCollection cameraRig in CameraRigs.NonSubscribableElements)
                {
                    if (cameraRig == null)
                    {
                        continue;
                    }

                    DeviceDetailsRecord rightControllerDetails = cameraRig.RightControllerDeviceDetails;
                    if (rightControllerDetails != null)
                    {
                        yield return rightControllerDetails;
                    }
                }
            }
        }
        #endregion

        #region Object Follower Properties
        /// <summary>
        /// The alias follower for the PlayArea.
        /// </summary>
        public virtual ObjectFollower PlayAreaAlias => Configuration.PlayArea;
        /// <summary>
        /// The alias follower for the Headset.
        /// </summary>
        public virtual ObjectFollower HeadsetAlias => Configuration.Headset;
        /// <summary>
        /// The alias follower for the Headset Origin within the <see cref="PlayAreaAlias"/>.
        /// </summary>
        public virtual ObjectFollower HeadsetOriginAlias => Configuration.HeadsetOrigin;
        /// <summary>
        /// The alias follower for the Left Controller.
        /// </summary>
        public virtual ObjectFollower LeftControllerAlias => Configuration.LeftController;
        /// <summary>
        /// The alias follower for the Right Controller.
        /// </summary>
        public virtual ObjectFollower RightControllerAlias => Configuration.RightController;
        /// <summary>
        /// The alias follower for the Dominant Controller.
        /// </summary>
        public virtual ObjectFollower DominantControllerAlias => Configuration.DominantController;
        #endregion

        #region Haptic Methods
        /// <summary>
        /// Begins the haptic process on the Left Controller using the main <see cref="HapticProcess"/>.
        /// </summary>
        public virtual void BeginHapticProcessOnLeftController()
        {
            BeginHapticProcessOnController(ActiveLeftHapticProcess);
        }

        /// <summary>
        /// Begins a haptic process on the Left Controller using the given profile.
        /// </summary>
        /// <param name="profileIndex">The index of the haptic profile to use.</param>
        public virtual void BeginHapticProcessOnLeftController(int profileIndex)
        {
            ActiveLeftHapticProfile = BeginHapticProfile(ActiveLeftHapticProfiles, profileIndex);
            if (ActiveDominantControllerNode == ActiveLeftControllerNode)
            {
                ActiveDominantHapticProfile = ActiveLeftHapticProfile;
            }
        }

        /// <summary>
        /// Begins the haptic process on the Right Controller using the main <see cref="HapticProcess"/>.
        /// </summary>
        public virtual void BeginHapticProcessOnRightController()
        {
            BeginHapticProcessOnController(ActiveRightHapticProcess);
        }

        /// <summary>
        /// Begins a haptic process on the Right Controller using the given profile.
        /// </summary>
        /// <param name="profileIndex">The index of the haptic profile to use.</param>
        public virtual void BeginHapticProcessOnRightController(int profileIndex)
        {
            ActiveRightHapticProfile = BeginHapticProfile(ActiveRightHapticProfiles, profileIndex);
            if (ActiveDominantControllerNode == ActiveRightControllerNode)
            {
                ActiveDominantHapticProfile = ActiveRightHapticProfile;
            }
        }

        /// <summary>
        /// Begins the haptic process on the Dominant Controller using the main <see cref="HapticProcess"/>.
        /// </summary>
        public virtual void BeginHapticProcessOnDominantController()
        {
            BeginHapticProcessOnController(ActiveDominantHapticProcess);
        }

        /// <summary>
        /// Begins a haptic process on the Dominant Controller using the given profile.
        /// </summary>
        /// <param name="profileIndex">The index of the haptic profile to use.</param>
        public virtual void BeginHapticProcessOnDominantController(int profileIndex)
        {
            ActiveDominantHapticProfile = BeginHapticProfile(ActiveDominantHapticProfiles, profileIndex);
        }

        /// <summary>
        /// Cancels all haptic process currently running on the Left Controller.
        /// </summary>
        public virtual void CancelAllHapticsOnLeftController()
        {
            CancelAllHapticsOnController(ActiveLeftHapticProfiles, ActiveLeftHapticProcess, ActiveLeftHapticProfile);
        }

        /// <summary>
        /// Cancels the haptic process currently running on the Left Controller for the current haptic profile.
        /// </summary>
        public virtual void CancelActiveHapticProfileOnLeftController()
        {
            CancelHapticProcessOnController(ActiveLeftHapticProfile);
        }

        /// <summary>
        /// Cancels any haptic process currently running on the Left Controller using the main <see cref="HapticProcess"/>.
        /// </summary>
        public virtual void CancelHapticProcessOnLeftController()
        {
            CancelHapticProcessOnController(ActiveLeftHapticProcess);
        }

        /// <summary>
        /// Cancels the haptic process currently running on the Left Controller for the given profile.
        /// </summary>
        /// <param name="profileIndex">The index of the haptic profile to cancel.</param>
        public virtual void CancelHapticProcessOnLeftController(int profileIndex)
        {
            CancelHapticProfile(ActiveLeftHapticProfiles, profileIndex);
            ActiveLeftHapticProfile = null;
        }

        /// <summary>
        /// Cancels all haptic process currently running on the Right Controller.
        /// </summary>
        public virtual void CancelAllHapticsOnRightController()
        {
            CancelAllHapticsOnController(ActiveRightHapticProfiles, ActiveRightHapticProcess, ActiveRightHapticProfile);
        }

        /// <summary>
        /// Cancels the haptic process currently running on the Right Controller for the current haptic profile.
        /// </summary>
        public virtual void CancelActiveHapticProfileOnRightController()
        {
            CancelHapticProcessOnController(ActiveRightHapticProfile);
        }

        /// <summary>
        /// Cancels any haptic process currently running on the Right Controller using the main <see cref="HapticProcess"/>.
        /// </summary>
        public virtual void CancelHapticProcessOnRightController()
        {
            CancelHapticProcessOnController(ActiveRightHapticProcess);
        }

        /// <summary>
        /// Cancels the haptic process currently running on the Right Controller for the given profile.
        /// </summary>
        /// <param name="profileIndex">The index of the haptic profile to cancel.</param>
        public virtual void CancelHapticProcessOnRightController(int profileIndex)
        {
            CancelHapticProfile(ActiveRightHapticProfiles, profileIndex);
            ActiveRightHapticProfile = null;
        }

        /// <summary>
        /// Cancels all haptic process currently running on the Dominant Controller.
        /// </summary>
        public virtual void CancelAllHapticsOnDominantController()
        {
            CancelAllHapticsOnController(ActiveDominantHapticProfiles, ActiveDominantHapticProcess, ActiveDominantHapticProfile);
        }

        /// <summary>
        /// Cancels the haptic process currently running on the Left Controller for the current haptic profile.
        /// </summary>
        public virtual void CancelActiveHapticProfileOnDominantController()
        {
            CancelHapticProcessOnController(ActiveDominantHapticProfile);
        }

        /// <summary>
        /// Cancels any haptic process currently running on the Dominant Controller using the main <see cref="HapticProcess"/>.
        /// </summary>
        public virtual void CancelHapticProcessOnDominantController()
        {
            CancelHapticProcessOnController(ActiveDominantHapticProcess);
        }

        /// <summary>
        /// Cancels the haptic process currently running on the Dominant Controller for the given profile.
        /// </summary>
        /// <param name="profileIndex">The index of the haptic profile to cancel.</param>
        public virtual void CancelHapticProcessOnDominantController(int profileIndex)
        {
            CancelHapticProfile(ActiveDominantHapticProfiles, profileIndex);
            ActiveDominantHapticProfile = null;
        }
        #endregion

        protected virtual void OnEnable()
        {
            SubscribeToCameraRigsEvents();
        }

        protected virtual void OnDisable()
        {
            UnsubscribeFromCameraRigsEvents();
        }

        /// <summary>
        /// Subscribes to the events on the current <see cref="CameraRigs"/> collection.
        /// </summary>
        protected virtual void SubscribeToCameraRigsEvents()
        {
            if (CameraRigs == null)
            {
                return;
            }

            CameraRigs.Added.AddListener(OnCameraRigAdded);
            CameraRigs.Removed.AddListener(OnCameraRigRemoved);
        }

        /// <summary>
        /// Unsubscribes from the events on the current <see cref="CameraRigs"/> collection.
        /// </summary>
        protected virtual void UnsubscribeFromCameraRigsEvents()
        {
            if (CameraRigs == null)
            {
                return;
            }

            CameraRigs.Added.RemoveListener(OnCameraRigAdded);
            CameraRigs.Removed.RemoveListener(OnCameraRigRemoved);
        }

        /// <summary>
        /// Occurs when an item is added to the <see cref="CameraRigs"/> collection.
        /// </summary>
        /// <param name="cameraRig">The added element.</param>
        protected virtual void OnCameraRigAdded(LinkedAliasAssociationCollection cameraRig)
        {
            RefreshCameraRigsConfiguration();
        }

        /// <summary>
        /// Occurs when an item is removed from the <see cref="CameraRigs"/> collection.
        /// </summary>
        /// <param name="cameraRig">The removed element.</param>
        protected virtual void OnCameraRigRemoved(LinkedAliasAssociationCollection cameraRig)
        {
            RefreshCameraRigsConfiguration();
        }

        /// <summary>
        /// Refreshes any changes made to the <see cref="CameraRigs"/> collection.
        /// </summary>
        protected virtual void RefreshCameraRigsConfiguration()
        {
            Configuration.SetUpCameraRigsConfiguration();
        }

        /// <summary>
        /// Gets the first active <see cref="LinkedAliasAssociationCollection"/> found in the given collection.
        /// </summary>
        /// <param name="collection">The collection to look for the first active in.</param>
        /// <returns>The found first active element in the collection.</returns>
        protected virtual LinkedAliasAssociationCollection GetFirstActiveLinkedAliasAssociationCollection(IEnumerable<LinkedAliasAssociationCollection> collection)
        {
            foreach (LinkedAliasAssociationCollection element in collection)
            {
                if (element.gameObject.activeInHierarchy)
                {
                    return element;
                }
            }
            return null;
        }

        /// <summary>
        /// Gets the first active <see cref="GameObject"/> found in the given collection.
        /// </summary>
        /// <param name="collection">The collection to look for the first active in.</param>
        /// <returns>The found first active element in the collection.</returns>
        protected virtual GameObject GetFirstActiveGameObject(IEnumerable<GameObject> collection)
        {
            foreach (GameObject element in collection)
            {
                if (element.gameObject.activeInHierarchy)
                {
                    return element;
                }
            }
            return null;
        }

        /// <summary>
        /// Gets the first active <see cref="Camera"/> found in the given collection.
        /// </summary>
        /// <param name="collection">The collection to look for the first active in.</param>
        /// <returns>The found first active element in the collection.</returns>
        protected virtual Camera GetFirstActiveCamera(IEnumerable<Camera> collection)
        {
            foreach (Camera element in collection)
            {
                if (element.gameObject.activeInHierarchy)
                {
                    return element;
                }
            }
            return null;
        }

        /// <summary>
        /// Gets the first active <see cref="VelocityTracker"/> found in the given collection.
        /// </summary>
        /// <param name="collection">The collection to look for the first active in.</param>
        /// <returns>The found first active element in the collection.</returns>
        protected virtual VelocityTracker GetFirstActiveVelocityTracker(IEnumerable<VelocityTracker> collection)
        {
            foreach (VelocityTracker element in collection)
            {
                if (element.gameObject.activeInHierarchy)
                {
                    return element;
                }
            }
            return null;
        }

        /// <summary>
        /// Gets the first active <see cref="HapticProcess"/> found in the given collection.
        /// </summary>
        /// <param name="collection">The collection to look for the first active in.</param>
        /// <returns>The found first active element in the collection.</returns>
        protected virtual HapticProcess GetFirstActiveHapticProcess(IEnumerable<HapticProcess> collection)
        {
            foreach (HapticProcess element in collection)
            {
                if (element.gameObject.activeInHierarchy)
                {
                    return element;
                }
            }
            return null;
        }

        /// <summary>
        /// Gets the first active profile found in the given haptic profile collection.
        /// </summary>
        /// <param name="collection">The collection to look for the first active in.</param>
        /// <returns>The found first active profile collection in the collection.</returns>
        protected virtual HapticProcessObservableList GetFirstActiveHapticProfile(IEnumerable<HapticProcessObservableList> collection)
        {
            foreach (HapticProcessObservableList list in collection)
            {
                foreach (HapticProcess element in list.NonSubscribableElements)
                {
                    if (element.gameObject.activeInHierarchy)
                    {
                        return list;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Gets the first active <see cref="DominantControllerObserver"/> found in the given collection.
        /// </summary>
        /// <param name="collection">The collection to look for the first active in.</param>
        /// <returns>The found first active element in the collection.</returns>
        protected virtual DominantControllerObserver GetFirstActiveDominantControllerObserver(IEnumerable<DominantControllerObserver> collection)
        {
            foreach (DominantControllerObserver element in collection)
            {
                if (element.gameObject.activeInHierarchy)
                {
                    return element;
                }
            }
            return null;
        }

        /// <summary>
        /// Gets the first active <see cref="DeviceDetailsRecord"/> found in the given collection.
        /// </summary>
        /// <param name="collection">The collection to look for the first active in.</param>
        /// <returns>The found first active element in the collection.</returns>
        protected virtual DeviceDetailsRecord GetFirstActiveDeviceRecord(IEnumerable<DeviceDetailsRecord> collection)
        {
            foreach (DeviceDetailsRecord element in collection)
            {
                if (element.gameObject.activeInHierarchy)
                {
                    return element;
                }
            }
            return null;
        }

        /// <summary>
        /// Begins the haptic process for the specified profile.
        /// </summary>
        /// <param name="processes">The processes to begin.</param>
        /// <param name="profileIndex">The index of the process to use.</param>
        /// <returns>The haptic process being accessed.</returns>
        protected virtual HapticProcess BeginHapticProfile(HapticProcessObservableList processes, int profileIndex)
        {
            if (!IsValidHapticProfile(processes, profileIndex))
            {
                return null;
            }

            processes.NonSubscribableElements[profileIndex].Begin();
            return processes.NonSubscribableElements[profileIndex];
        }

        /// <summary>
        /// Cancels the haptic process for the specified profile.
        /// </summary>
        /// <param name="processes">The processes to cancel.</param>
        /// <param name="profileIndex">The index of the process to use.</param>
        /// <returns>The haptic process being accessed.</returns>
        protected virtual HapticProcess CancelHapticProfile(HapticProcessObservableList processes, int profileIndex)
        {
            if (!IsValidHapticProfile(processes, profileIndex))
            {
                return null;
            }

            processes.NonSubscribableElements[profileIndex].Cancel();
            return processes.NonSubscribableElements[profileIndex];
        }

        /// <summary>
        /// Determines whether the haptic profile is valid for the given index.
        /// </summary>
        /// <param name="processes">The processes to check.</param>
        /// <param name="profileIndex">The index of the process to check validity on.</param>
        /// <returns>Whether the given index is a valid profile.</returns>
        protected virtual bool IsValidHapticProfile(HapticProcessObservableList processes, int profileIndex)
        {
            return processes != null && profileIndex >= 0 && profileIndex < processes.NonSubscribableElements.Count;
        }

        /// <summary>
        /// Begins the haptic process on the given <see cref="HapticProcess"/>.
        /// </summary>
        /// <param name="process">The process to begin.</param>
        protected virtual void BeginHapticProcessOnController(HapticProcess process)
        {
            if (process == null)
            {
                return;
            }

            process.Begin();
        }

        /// <summary>
        /// Cancels all haptic process currently running on the specified Controller data.
        /// </summary>
        /// <param name="profileList">The profile list to cancel.</param>
        /// <param name="hapticProcess">The specific process to cancel.</param>
        /// <param name="hapticProfile">The specific profile to cancel.</param>
        protected virtual void CancelAllHapticsOnController(HapticProcessObservableList profileList, HapticProcess hapticProcess, HapticProcess hapticProfile)
        {
            CancelHapticProcessOnController(hapticProcess);
            CancelHapticProcessOnController(hapticProfile);

            if (profileList == null)
            {
                return;
            }

            foreach (HapticProcess process in profileList.NonSubscribableElements)
            {
                process.Cancel();
            }
        }

        /// <summary>
        /// Cancels any haptic process currently running on the specified <see cref="HapticProcess"/>.
        /// </summary>
        /// <param name="process">The process to cancel.</param>
        protected virtual void CancelHapticProcessOnController(HapticProcess process)
        {
            if (process == null)
            {
                return;
            }

            process.Cancel();
        }

        /// <summary>
        /// Called before <see cref="CameraRigs"/> has been changed.
        /// </summary>
        protected virtual void OnBeforeCameraRigsChange()
        {
            UnsubscribeFromCameraRigsEvents();
        }

        /// <summary>
        /// Called after <see cref="CameraRigs"/> has been changed.
        /// </summary>
        protected virtual void OnAfterCameraRigsChange()
        {
            SubscribeToCameraRigsEvents();
            RefreshCameraRigsConfiguration();
        }
    }
}
