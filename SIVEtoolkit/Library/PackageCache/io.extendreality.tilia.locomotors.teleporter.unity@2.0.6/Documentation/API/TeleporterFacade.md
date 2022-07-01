# Class TeleporterFacade

The public interface into the Teleporter Prefab.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [Teleported]
  * [Teleporting]
* [Properties]
  * [ApplyDestinationRotation]
  * [CameraValidity]
  * [Configuration]
  * [DestinationOffset]
  * [Offset]
  * [OffsetUsage]
  * [SnapToFloorBlinkThreshold]
  * [SnapToFloorEnabled]
  * [SnapToFloorThreshold]
  * [Target]
  * [TargetValidity]
* [Methods]
  * [ClearCameraValidity()]
  * [ClearConfiguration()]
  * [ClearOffset()]
  * [ClearTarget()]
  * [ClearTargetValidity()]
  * [OnAfterApplyDestinationRotationChange()]
  * [OnAfterCameraValidityChange()]
  * [OnAfterDestinationOffsetChange()]
  * [OnAfterOffsetChange()]
  * [OnAfterOffsetUsageChange()]
  * [OnAfterSnapToFloorBlinkThresholdChange()]
  * [OnAfterSnapToFloorEnabledChange()]
  * [OnAfterSnapToFloorThresholdChange()]
  * [OnAfterTargetChange()]
  * [OnAfterTargetValidityChange()]
  * [SetOffsetUsage(Int32)]
  * [Teleport(GameObject)]
  * [Teleport(Transform)]
  * [Teleport(TransformData)]
  * [Teleport(Vector3)]

## Details

##### Inheritance

* System.Object
* TeleporterFacade

##### Namespace

* [Tilia.Locomotors.Teleporter]

##### Syntax

```
public class TeleporterFacade : MonoBehaviour
```

### Fields

#### Teleported

Emitted when the teleporting has completed.

##### Declaration

```
public TransformPropertyApplier.UnityEvent Teleported
```

#### Teleporting

Emitted when the teleporting is about to initiate.

##### Declaration

```
public TransformPropertyApplier.UnityEvent Teleporting
```

### Properties

#### ApplyDestinationRotation

Determines if the teleport destination Transform.rotation will be applied to the [Target].

##### Declaration

```
public bool ApplyDestinationRotation { get; set; }
```

#### CameraValidity

The Rule of scene Cameras to apply a fade to.

##### Declaration

```
public RuleContainer CameraValidity { get; set; }
```

#### Configuration

The linked Internal Setup.

##### Declaration

```
public TeleporterConfigurator Configuration { get; protected set; }
```

#### DestinationOffset

The position amount to offset the destination teleport position.

##### Declaration

```
public Vector3 DestinationOffset { get; set; }
```

#### Offset

The offset to compensate the teleported target position by for both floor snapping and position movement.

##### Declaration

```
public GameObject Offset { get; set; }
```

#### OffsetUsage

Determines how to use the [Offset] when calculating the teleport location.

##### Declaration

```
public TeleporterFacade.OffsetType OffsetUsage { get; set; }
```

#### SnapToFloorBlinkThreshold

The distance between the previous floor and current floor to determine if the screen should blink when snapping to the new floor.

##### Declaration

```
public float SnapToFloorBlinkThreshold { get; set; }
```

#### SnapToFloorEnabled

Whether to always attempt to teleport the [Target] to the nearest found floor every frame.

##### Declaration

```
public bool SnapToFloorEnabled { get; set; }
```

#### SnapToFloorThreshold

The distance between the previous floor and current floor to determine if a snap to the new floor is required.

##### Declaration

```
public float SnapToFloorThreshold { get; set; }
```

#### Target

The target to move to the teleported position.

##### Declaration

```
public GameObject Target { get; set; }
```

#### TargetValidity

Allows to optionally determine targets based on the set rules.

##### Declaration

```
public RuleContainer TargetValidity { get; set; }
```

### Methods

#### ClearCameraValidity()

Clears [CameraValidity].

##### Declaration

```
public virtual void ClearCameraValidity()
```

#### ClearConfiguration()

Clears [Configuration].

##### Declaration

```
public virtual void ClearConfiguration()
```

#### ClearOffset()

Clears [Offset].

##### Declaration

```
public virtual void ClearOffset()
```

#### ClearTarget()

Clears [Target].

##### Declaration

```
public virtual void ClearTarget()
```

#### ClearTargetValidity()

Clears [TargetValidity].

##### Declaration

```
public virtual void ClearTargetValidity()
```

#### OnAfterApplyDestinationRotationChange()

Called after [ApplyDestinationRotation] has been changed.

##### Declaration

```
protected virtual void OnAfterApplyDestinationRotationChange()
```

#### OnAfterCameraValidityChange()

Called after [CameraValidity] has been changed.

##### Declaration

```
protected virtual void OnAfterCameraValidityChange()
```

#### OnAfterDestinationOffsetChange()

Called after [DestinationOffset] has been changed.

##### Declaration

```
protected virtual void OnAfterDestinationOffsetChange()
```

#### OnAfterOffsetChange()

Called after [Offset] has been changed.

##### Declaration

```
protected virtual void OnAfterOffsetChange()
```

#### OnAfterOffsetUsageChange()

Called after [OffsetUsage] has been changed.

##### Declaration

```
protected virtual void OnAfterOffsetUsageChange()
```

#### OnAfterSnapToFloorBlinkThresholdChange()

Called after [SnapToFloorBlinkThreshold] has been changed.

##### Declaration

```
protected virtual void OnAfterSnapToFloorBlinkThresholdChange()
```

#### OnAfterSnapToFloorEnabledChange()

Called after [SnapToFloorEnabled] has been changed.

##### Declaration

```
protected virtual void OnAfterSnapToFloorEnabledChange()
```

#### OnAfterSnapToFloorThresholdChange()

Called after [SnapToFloorThreshold] has been changed.

##### Declaration

```
protected virtual void OnAfterSnapToFloorThresholdChange()
```

#### OnAfterTargetChange()

Called after [Target] has been changed.

##### Declaration

```
protected virtual void OnAfterTargetChange()
```

#### OnAfterTargetValidityChange()

Called after [TargetValidity] has been changed.

##### Declaration

```
protected virtual void OnAfterTargetValidityChange()
```

#### SetOffsetUsage(Int32)

Sets [OffsetUsage].

##### Declaration

```
public virtual void SetOffsetUsage(int offsetTypeIndex)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | offsetTypeIndex | The index of the [TeleporterFacade.OffsetType]. |

#### Teleport(GameObject)

Attempts to teleport the [Target].

##### Declaration

```
public virtual void Teleport(GameObject destination)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| GameObject | destination | The location to attempt to teleport to. |

#### Teleport(Transform)

Attempts to teleport the [Target].

##### Declaration

```
public virtual void Teleport(Transform destination)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Transform | destination | The location to attempt to teleport to. |

#### Teleport(TransformData)

Attempts to teleport the [Target].

##### Declaration

```
public virtual void Teleport(TransformData destination)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TransformData | destination | The location to attempt to teleport to. |

#### Teleport(Vector3)

Attempts to teleport the [Target] to the given world position.

##### Declaration

```
public virtual void Teleport(Vector3 destinationPosition)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| Vector3 | destinationPosition | n/a |

[Tilia.Locomotors.Teleporter]: README.md
[Target]: TeleporterFacade.md#Target
[TeleporterConfigurator]: TeleporterConfigurator.md
[Offset]: TeleporterFacade.md#Offset
[Target]: TeleporterFacade.md#Target
[CameraValidity]: TeleporterFacade.md#CameraValidity
[Configuration]: TeleporterFacade.md#Configuration
[Offset]: TeleporterFacade.md#Offset
[Target]: TeleporterFacade.md#Target
[TargetValidity]: TeleporterFacade.md#TargetValidity
[ApplyDestinationRotation]: TeleporterFacade.md#ApplyDestinationRotation
[CameraValidity]: TeleporterFacade.md#CameraValidity
[DestinationOffset]: TeleporterFacade.md#DestinationOffset
[Offset]: TeleporterFacade.md#Offset
[OffsetUsage]: TeleporterFacade.md#OffsetUsage
[SnapToFloorBlinkThreshold]: TeleporterFacade.md#SnapToFloorBlinkThreshold
[SnapToFloorEnabled]: TeleporterFacade.md#SnapToFloorEnabled
[SnapToFloorThreshold]: TeleporterFacade.md#SnapToFloorThreshold
[Target]: TeleporterFacade.md#Target
[TargetValidity]: TeleporterFacade.md#TargetValidity
[OffsetUsage]: TeleporterFacade.md#OffsetUsage
[TeleporterFacade.OffsetType]: TeleporterFacade.OffsetType.md
[Target]: TeleporterFacade.md#Target
[Target]: TeleporterFacade.md#Target
[Target]: TeleporterFacade.md#Target
[Target]: TeleporterFacade.md#Target
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[Teleported]: #Teleported
[Teleporting]: #Teleporting
[Properties]: #Properties
[ApplyDestinationRotation]: #ApplyDestinationRotation
[CameraValidity]: #CameraValidity
[Configuration]: #Configuration
[DestinationOffset]: #DestinationOffset
[Offset]: #Offset
[OffsetUsage]: #OffsetUsage
[SnapToFloorBlinkThreshold]: #SnapToFloorBlinkThreshold
[SnapToFloorEnabled]: #SnapToFloorEnabled
[SnapToFloorThreshold]: #SnapToFloorThreshold
[Target]: #Target
[TargetValidity]: #TargetValidity
[Methods]: #Methods
[ClearCameraValidity()]: #ClearCameraValidity
[ClearConfiguration()]: #ClearConfiguration
[ClearOffset()]: #ClearOffset
[ClearTarget()]: #ClearTarget
[ClearTargetValidity()]: #ClearTargetValidity
[OnAfterApplyDestinationRotationChange()]: #OnAfterApplyDestinationRotationChange
[OnAfterCameraValidityChange()]: #OnAfterCameraValidityChange
[OnAfterDestinationOffsetChange()]: #OnAfterDestinationOffsetChange
[OnAfterOffsetChange()]: #OnAfterOffsetChange
[OnAfterOffsetUsageChange()]: #OnAfterOffsetUsageChange
[OnAfterSnapToFloorBlinkThresholdChange()]: #OnAfterSnapToFloorBlinkThresholdChange
[OnAfterSnapToFloorEnabledChange()]: #OnAfterSnapToFloorEnabledChange
[OnAfterSnapToFloorThresholdChange()]: #OnAfterSnapToFloorThresholdChange
[OnAfterTargetChange()]: #OnAfterTargetChange
[OnAfterTargetValidityChange()]: #OnAfterTargetValidityChange
[SetOffsetUsage(Int32)]: #SetOffsetUsageInt32
[Teleport(GameObject)]: #TeleportGameObject
[Teleport(Transform)]: #TeleportTransform
[Teleport(TransformData)]: #TeleportTransformData
[Teleport(Vector3)]: #TeleportVector3
