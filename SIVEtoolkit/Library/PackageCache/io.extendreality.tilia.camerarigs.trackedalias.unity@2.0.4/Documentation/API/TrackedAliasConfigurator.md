# Class TrackedAliasConfigurator

Sets up the Tracked Alias Prefab based on the provided user settings.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [cachedCurrentDominantController]
  * [cachedHeadsetBatteryChargeStatus]
  * [cachedHeadsetConnectionStatus]
  * [cachedHeadsetSpatialTrackingType]
  * [cachedHeadsetTrackingBegun]
  * [cachedLeftControllerBatteryChargeStatus]
  * [cachedLeftControllerConnectionStatus]
  * [cachedLeftControllerSpatialTrackingType]
  * [cachedLeftControllerTrackingBegun]
  * [cachedLinkedAlias]
  * [cachedRightControllerBatteryChargeStatus]
  * [cachedRightControllerConnectionStatus]
  * [cachedRightControllerSpatialTrackingType]
  * [cachedRightControllerTrackingBegun]
  * [DominantControllerIsChangingEventHandler]
  * [HeadsetBatteryChargeStatusChangedEventHandler]
  * [HeadsetConnectionChangedEventHandler]
  * [HeadsetTrackingBegunEventHandler]
  * [HeadsetTrackingTypeChangedEventHandler]
  * [LeftControllerBatteryChargeStatusChangedEventHandler]
  * [LeftControllerConnectionChangedEventHandler]
  * [LeftControllerTrackingBegunEventHandler]
  * [LeftControllerTrackingTypeChangedEventHandler]
  * [RightControllerBatteryChargeStatusChangedEventHandler]
  * [RightControllerConnectionChangedEventHandler]
  * [RightControllerTrackingBegunEventHandler]
  * [RightControllerTrackingTypeChangedEventHandler]
* [Properties]
  * [DominantController]
  * [DominantControllerVelocityTrackers]
  * [Facade]
  * [Headset]
  * [HeadsetOrigin]
  * [HeadsetVelocityTrackers]
  * [IncludeHeadsetSupplementCameras]
  * [LeftController]
  * [LeftControllerVelocityTrackers]
  * [PlayArea]
  * [RightController]
  * [RightControllerVelocityTrackers]
  * [ValidCameras]
* [Methods]
  * [CacheAndRaiseEventWithoutPayload<TValue, TEvent>(TValue, ref TValue, TEvent)]
  * [CacheAndRaiseEventWithPayload<TValue, TEvent>(TValue, ref TValue, TEvent)]
  * [CheckAndRaiseEventWithoutPayload<TValue, TEvent>(ref TValue, TValue, TEvent)]
  * [CheckAndRaiseEventWithPayload<TValue, TEvent>(ref TValue, TValue, TEvent)]
  * [CheckExistingEventStatus()]
  * [NotifyHeadsetTrackingBegun()]
  * [NotifyLeftControllerTrackingBegun()]
  * [NotifyRightControllerTrackingBegun()]
  * [NotifyTrackedAliasChanged(GameObject)]
  * [OnDisable()]
  * [OnEnable()]
  * [SetUpCameraRigsConfiguration()]
  * [SetUpDominantTracking(DeviceDetailsRecord)]
  * [SubscribeToDetailsEvents()]
  * [UnsubscribeToDetailsEvents()]

## Details

##### Inheritance

* System.Object
* TrackedAliasConfigurator

##### Namespace

* [Tilia.CameraRigs.TrackedAlias]

##### Syntax

```
public class TrackedAliasConfigurator : MonoBehaviour
```

### Fields

#### cachedCurrentDominantController

The current cached dominant controller.

##### Declaration

```
protected DeviceDetailsRecord cachedCurrentDominantController
```

#### cachedHeadsetBatteryChargeStatus

The current cached headset battery charge status.

##### Declaration

```
protected BatteryStatus cachedHeadsetBatteryChargeStatus
```

#### cachedHeadsetConnectionStatus

The current cached headset connection status.

##### Declaration

```
protected bool cachedHeadsetConnectionStatus
```

#### cachedHeadsetSpatialTrackingType

The current cached headset tracking type.

##### Declaration

```
protected DeviceDetailsRecord.SpatialTrackingType cachedHeadsetSpatialTrackingType
```

#### cachedHeadsetTrackingBegun

The current cached headset tracking begun status.

##### Declaration

```
protected bool cachedHeadsetTrackingBegun
```

#### cachedLeftControllerBatteryChargeStatus

The current cached left controller battery charge status.

##### Declaration

```
protected BatteryStatus cachedLeftControllerBatteryChargeStatus
```

#### cachedLeftControllerConnectionStatus

The current cached left controller connection status.

##### Declaration

```
protected bool cachedLeftControllerConnectionStatus
```

#### cachedLeftControllerSpatialTrackingType

The current cached left controller tracking type.

##### Declaration

```
protected DeviceDetailsRecord.SpatialTrackingType cachedLeftControllerSpatialTrackingType
```

#### cachedLeftControllerTrackingBegun

The current cached left controller tracking begun status.

##### Declaration

```
protected bool cachedLeftControllerTrackingBegun
```

#### cachedLinkedAlias

The current cached Linked Alias Association Collection.

##### Declaration

```
protected LinkedAliasAssociationCollection cachedLinkedAlias
```

#### cachedRightControllerBatteryChargeStatus

The current cached right controller battery charge status.

##### Declaration

```
protected BatteryStatus cachedRightControllerBatteryChargeStatus
```

#### cachedRightControllerConnectionStatus

The current cached right controller connection status.

##### Declaration

```
protected bool cachedRightControllerConnectionStatus
```

#### cachedRightControllerSpatialTrackingType

The current cached right controller tracking type.

##### Declaration

```
protected DeviceDetailsRecord.SpatialTrackingType cachedRightControllerSpatialTrackingType
```

#### cachedRightControllerTrackingBegun

The current cached right controller tracking begun status.

##### Declaration

```
protected bool cachedRightControllerTrackingBegun
```

#### DominantControllerIsChangingEventHandler

The event handler to run when the bubbled dominant controller is changing is raised.

##### Declaration

```
protected UnityAction<DeviceDetailsRecord> DominantControllerIsChangingEventHandler
```

#### HeadsetBatteryChargeStatusChangedEventHandler

The event handler to run when the bubbled headset event for battery charge status changed is raised.

##### Declaration

```
protected UnityAction<BatteryStatus> HeadsetBatteryChargeStatusChangedEventHandler
```

#### HeadsetConnectionChangedEventHandler

The event handler to run when the bubbled headset event for connection changed is raised.

##### Declaration

```
protected UnityAction<bool> HeadsetConnectionChangedEventHandler
```

#### HeadsetTrackingBegunEventHandler

The event handler to run when the bubbled headset event for tracking begun is raised.

##### Declaration

```
protected UnityAction HeadsetTrackingBegunEventHandler
```

#### HeadsetTrackingTypeChangedEventHandler

The event handler to run when the bubbled headset event for tracking type changed is raised.

##### Declaration

```
protected UnityAction<DeviceDetailsRecord.SpatialTrackingType> HeadsetTrackingTypeChangedEventHandler
```

#### LeftControllerBatteryChargeStatusChangedEventHandler

The event handler to run when the bubbled left controller event for battery charge status changed is raised.

##### Declaration

```
protected UnityAction<BatteryStatus> LeftControllerBatteryChargeStatusChangedEventHandler
```

#### LeftControllerConnectionChangedEventHandler

The event handler to run when the bubbled left controller event for connection changed is raised.

##### Declaration

```
protected UnityAction<bool> LeftControllerConnectionChangedEventHandler
```

#### LeftControllerTrackingBegunEventHandler

The event handler to run when the bubbled left controller event for tracking begun is raised.

##### Declaration

```
protected UnityAction LeftControllerTrackingBegunEventHandler
```

#### LeftControllerTrackingTypeChangedEventHandler

The event handler to run when the bubbled left controller event for tracking type changed is raised.

##### Declaration

```
protected UnityAction<DeviceDetailsRecord.SpatialTrackingType> LeftControllerTrackingTypeChangedEventHandler
```

#### RightControllerBatteryChargeStatusChangedEventHandler

The event handler to run when the bubbled right controller event for battery charge status changed is raised.

##### Declaration

```
protected UnityAction<BatteryStatus> RightControllerBatteryChargeStatusChangedEventHandler
```

#### RightControllerConnectionChangedEventHandler

The event handler to run when the bubbled right controller event for connection changed is raised.

##### Declaration

```
protected UnityAction<bool> RightControllerConnectionChangedEventHandler
```

#### RightControllerTrackingBegunEventHandler

The event handler to run when the bubbled right controller event for tracking begun is raised.

##### Declaration

```
protected UnityAction RightControllerTrackingBegunEventHandler
```

#### RightControllerTrackingTypeChangedEventHandler

The event handler to run when the bubbled right controller event for tracking type changed is raised.

##### Declaration

```
protected UnityAction<DeviceDetailsRecord.SpatialTrackingType> RightControllerTrackingTypeChangedEventHandler
```

### Properties

#### DominantController

The ObjectFollower component for the current Dominant Controller.

##### Declaration

```
public ObjectFollower DominantController { get; protected set; }
```

#### DominantControllerVelocityTrackers

The VelocityTrackerProcessor component containing the current Dominant Controller Velocity Trackers.

##### Declaration

```
public VelocityTrackerProcessor DominantControllerVelocityTrackers { get; protected set; }
```

#### Facade

The public facade.

##### Declaration

```
public TrackedAliasFacade Facade { get; protected set; }
```

#### Headset

The ObjectFollower component for the Headset.

##### Declaration

```
public ObjectFollower Headset { get; protected set; }
```

#### HeadsetOrigin

The ObjectFollower component for the HeadsetOrigin within the PlayArea Alias.

##### Declaration

```
public ObjectFollower HeadsetOrigin { get; protected set; }
```

#### HeadsetVelocityTrackers

The VelocityTrackerProcessor component containing the Headset Velocity Trackers.

##### Declaration

```
public VelocityTrackerProcessor HeadsetVelocityTrackers { get; protected set; }
```

#### IncludeHeadsetSupplementCameras

Determines whether to include the CameraRig HeadsetSupplementCameras in the [ValidCameras] collection.

##### Declaration

```
public bool IncludeHeadsetSupplementCameras { get; protected set; }
```

#### LeftController

The ObjectFollower component for the Left Controller.

##### Declaration

```
public ObjectFollower LeftController { get; protected set; }
```

#### LeftControllerVelocityTrackers

The VelocityTrackerProcessor component containing the Left Controller Velocity Trackers.

##### Declaration

```
public VelocityTrackerProcessor LeftControllerVelocityTrackers { get; protected set; }
```

#### PlayArea

The ObjectFollower component for the PlayArea.

##### Declaration

```
public ObjectFollower PlayArea { get; protected set; }
```

#### RightController

The ObjectFollower component for the Right Controller.

##### Declaration

```
public ObjectFollower RightController { get; protected set; }
```

#### RightControllerVelocityTrackers

The VelocityTrackerProcessor component containing the Right Controller Velocity Trackers.

##### Declaration

```
public VelocityTrackerProcessor RightControllerVelocityTrackers { get; protected set; }
```

#### ValidCameras

The ListContainsRule for defining the valid Camera collection.

##### Declaration

```
public ListContainsRule ValidCameras { get; protected set; }
```

### Methods

#### CacheAndRaiseEventWithoutPayload<TValue, TEvent>(TValue, ref TValue, TEvent)

Caches the given new value and raises the given event.

##### Declaration

```
protected virtual void CacheAndRaiseEventWithoutPayload<TValue, TEvent>(TValue newValue, ref TValue cachedValue, TEvent output)
    where TEvent : UnityEvent, new()
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TValue | newValue | The new value to cache. |
| TValue | cachedValue | The existing cached value. |
| TEvent | output | The event to raise. |

##### Type Parameters

| Name | Description |
| --- | --- |
| TValue | The variable type of the given values. |
| TEvent | The UnityEvent type to raise. |

#### CacheAndRaiseEventWithPayload<TValue, TEvent>(TValue, ref TValue, TEvent)

Caches the given new value and raises the given event with the new value as the payload.

##### Declaration

```
protected virtual void CacheAndRaiseEventWithPayload<TValue, TEvent>(TValue newValue, ref TValue cachedValue, TEvent output)
    where TEvent : UnityEvent<TValue>, new()
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TValue | newValue | The new value to cache. |
| TValue | cachedValue | The existing cached value. |
| TEvent | output | The event to raise. |

##### Type Parameters

| Name | Description |
| --- | --- |
| TValue | The variable type of the given values. |
| TEvent | The UnityEvent type to raise. |

#### CheckAndRaiseEventWithoutPayload<TValue, TEvent>(ref TValue, TValue, TEvent)

Checks if the two given values equal and raises the given event if they are not.

##### Declaration

```
protected virtual void CheckAndRaiseEventWithoutPayload<TValue, TEvent>(ref TValue comparer, TValue comparator, TEvent output)
    where TEvent : UnityEvent, new()
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TValue | comparer | The source value to compare from. |
| TValue | comparator | The target value to compare with. |
| TEvent | output | The event to raise if the two values are not equal. |

##### Type Parameters

| Name | Description |
| --- | --- |
| TValue | The variable type to check equality with. |
| TEvent | The UnityEvent type to raise. |

#### CheckAndRaiseEventWithPayload<TValue, TEvent>(ref TValue, TValue, TEvent)

Checks if the two given values equal and raises the given event with the relevant payload if they are not.

##### Declaration

```
protected virtual void CheckAndRaiseEventWithPayload<TValue, TEvent>(ref TValue comparer, TValue comparator, TEvent output)
    where TEvent : UnityEvent<TValue>, new()
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TValue | comparer | The source value to compare from. |
| TValue | comparator | The target value to compare with. |
| TEvent | output | The event to raise if the two values are not equal. |

##### Type Parameters

| Name | Description |
| --- | --- |
| TValue | The variable type to check equality with. |
| TEvent | The UnityEvent type to raise. |

#### CheckExistingEventStatus()

Check the existing status of the event values and raise a new event if it has changed.

##### Declaration

```
protected virtual void CheckExistingEventStatus()
```

#### NotifyHeadsetTrackingBegun()

Notifies that the headset has started being tracked.

##### Declaration

```
public virtual void NotifyHeadsetTrackingBegun()
```

#### NotifyLeftControllerTrackingBegun()

Notifies that the left controller has started being tracked.

##### Declaration

```
public virtual void NotifyLeftControllerTrackingBegun()
```

#### NotifyRightControllerTrackingBegun()

Notifies that the right controller has started being tracked.

##### Declaration

```
public virtual void NotifyRightControllerTrackingBegun()
```

#### NotifyTrackedAliasChanged(GameObject)

Notifies when the tracked alias source has changed.

##### Declaration

```
public virtual void NotifyTrackedAliasChanged(GameObject _)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| GameObject | \_ | n/a |

#### OnDisable()

##### Declaration

```
protected virtual void OnDisable()
```

#### OnEnable()

##### Declaration

```
protected virtual void OnEnable()
```

#### SetUpCameraRigsConfiguration()

Sets up the TrackedAlias prefab with the specified settings.

##### Declaration

```
public virtual void SetUpCameraRigsConfiguration()
```

#### SetUpDominantTracking(DeviceDetailsRecord)

Sets up the dominant controller alias tracking.

##### Declaration

```
public virtual void SetUpDominantTracking(DeviceDetailsRecord dominantRecord)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| DeviceDetailsRecord | dominantRecord | The current dominant controller record. |

#### SubscribeToDetailsEvents()

Subscribe to the events of each DeviceDetailsRecord.

##### Declaration

```
protected virtual void SubscribeToDetailsEvents()
```

#### UnsubscribeToDetailsEvents()

Unsubscribes from the events of each DeviceDetailsRecord.

##### Declaration

```
protected virtual void UnsubscribeToDetailsEvents()
```

[Tilia.CameraRigs.TrackedAlias]: README.md
[TrackedAliasFacade]: TrackedAliasFacade.md
[ValidCameras]: TrackedAliasConfigurator.md#ValidCameras
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[cachedCurrentDominantController]: #cachedCurrentDominantController
[cachedHeadsetBatteryChargeStatus]: #cachedHeadsetBatteryChargeStatus
[cachedHeadsetConnectionStatus]: #cachedHeadsetConnectionStatus
[cachedHeadsetSpatialTrackingType]: #cachedHeadsetSpatialTrackingType
[cachedHeadsetTrackingBegun]: #cachedHeadsetTrackingBegun
[cachedLeftControllerBatteryChargeStatus]: #cachedLeftControllerBatteryChargeStatus
[cachedLeftControllerConnectionStatus]: #cachedLeftControllerConnectionStatus
[cachedLeftControllerSpatialTrackingType]: #cachedLeftControllerSpatialTrackingType
[cachedLeftControllerTrackingBegun]: #cachedLeftControllerTrackingBegun
[cachedLinkedAlias]: #cachedLinkedAlias
[cachedRightControllerBatteryChargeStatus]: #cachedRightControllerBatteryChargeStatus
[cachedRightControllerConnectionStatus]: #cachedRightControllerConnectionStatus
[cachedRightControllerSpatialTrackingType]: #cachedRightControllerSpatialTrackingType
[cachedRightControllerTrackingBegun]: #cachedRightControllerTrackingBegun
[DominantControllerIsChangingEventHandler]: #DominantControllerIsChangingEventHandler
[HeadsetBatteryChargeStatusChangedEventHandler]: #HeadsetBatteryChargeStatusChangedEventHandler
[HeadsetConnectionChangedEventHandler]: #HeadsetConnectionChangedEventHandler
[HeadsetTrackingBegunEventHandler]: #HeadsetTrackingBegunEventHandler
[HeadsetTrackingTypeChangedEventHandler]: #HeadsetTrackingTypeChangedEventHandler
[LeftControllerBatteryChargeStatusChangedEventHandler]: #LeftControllerBatteryChargeStatusChangedEventHandler
[LeftControllerConnectionChangedEventHandler]: #LeftControllerConnectionChangedEventHandler
[LeftControllerTrackingBegunEventHandler]: #LeftControllerTrackingBegunEventHandler
[LeftControllerTrackingTypeChangedEventHandler]: #LeftControllerTrackingTypeChangedEventHandler
[RightControllerBatteryChargeStatusChangedEventHandler]: #RightControllerBatteryChargeStatusChangedEventHandler
[RightControllerConnectionChangedEventHandler]: #RightControllerConnectionChangedEventHandler
[RightControllerTrackingBegunEventHandler]: #RightControllerTrackingBegunEventHandler
[RightControllerTrackingTypeChangedEventHandler]: #RightControllerTrackingTypeChangedEventHandler
[Properties]: #Properties
[DominantController]: #DominantController
[DominantControllerVelocityTrackers]: #DominantControllerVelocityTrackers
[Facade]: #Facade
[Headset]: #Headset
[HeadsetOrigin]: #HeadsetOrigin
[HeadsetVelocityTrackers]: #HeadsetVelocityTrackers
[IncludeHeadsetSupplementCameras]: #IncludeHeadsetSupplementCameras
[LeftController]: #LeftController
[LeftControllerVelocityTrackers]: #LeftControllerVelocityTrackers
[PlayArea]: #PlayArea
[RightController]: #RightController
[RightControllerVelocityTrackers]: #RightControllerVelocityTrackers
[ValidCameras]: #ValidCameras
[Methods]: #Methods
[CacheAndRaiseEventWithoutPayload<TValue, TEvent>(TValue, ref TValue, TEvent)]: #CacheAndRaiseEventWithoutPayload<TValue-TEvent>TValue-ref TValue-TEvent
[CacheAndRaiseEventWithPayload<TValue, TEvent>(TValue, ref TValue, TEvent)]: #CacheAndRaiseEventWithPayload<TValue-TEvent>TValue-ref TValue-TEvent
[CheckAndRaiseEventWithoutPayload<TValue, TEvent>(ref TValue, TValue, TEvent)]: #CheckAndRaiseEventWithoutPayload<TValue-TEvent>ref TValue-TValue-TEvent
[CheckAndRaiseEventWithPayload<TValue, TEvent>(ref TValue, TValue, TEvent)]: #CheckAndRaiseEventWithPayload<TValue-TEvent>ref TValue-TValue-TEvent
[CheckExistingEventStatus()]: #CheckExistingEventStatus
[NotifyHeadsetTrackingBegun()]: #NotifyHeadsetTrackingBegun
[NotifyLeftControllerTrackingBegun()]: #NotifyLeftControllerTrackingBegun
[NotifyRightControllerTrackingBegun()]: #NotifyRightControllerTrackingBegun
[NotifyTrackedAliasChanged(GameObject)]: #NotifyTrackedAliasChangedGameObject
[OnDisable()]: #OnDisable
[OnEnable()]: #OnEnable
[SetUpCameraRigsConfiguration()]: #SetUpCameraRigsConfiguration
[SetUpDominantTracking(DeviceDetailsRecord)]: #SetUpDominantTrackingDeviceDetailsRecord
[SubscribeToDetailsEvents()]: #SubscribeToDetailsEvents
[UnsubscribeToDetailsEvents()]: #UnsubscribeToDetailsEvents
