# Class TeleporterConfigurator

Sets up the Teleport Prefab based on the provided user settings.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [allowSnapToFloorBlinkThresholdSet]
  * [cachedLocators]
  * [cachedSnapToFloorBlinkThreshold]
  * [resetCachedDataRoutine]
* [Properties]
  * [CameraColorOverlays]
  * [Facade]
  * [ModifyTeleporter]
  * [SnapToFloorBlinkThresholdController]
  * [SnapToFloorContainer]
  * [SnapToFloorThresholdController]
  * [SurfaceLocatorAliases]
  * [SurfaceLocatorRules]
  * [SurfaceTeleporter]
  * [TransformPropertyApplierAliases]
  * [TransformPropertyApplierIgnoreOffsetAliases]
* [Methods]
  * [ConfigureCameraColorOverlays()]
  * [ConfigureRotationAbility(Boolean)]
  * [ConfigureSnapToFloor()]
  * [ConfigureSurfaceChangeActions(Single, Single)]
  * [ConfigureSurfaceLocatorAliases()]
  * [ConfigureSurfaceLocatorOffsets()]
  * [ConfigureSurfaceLocatorRules()]
  * [ConfigureTransformPropertyAppliers()]
  * [DisableRotations()]
  * [EnableRotations()]
  * [NotifyTeleported(TransformPropertyApplier.EventData)]
  * [NotifyTeleporting(TransformPropertyApplier.EventData)]
  * [OnEnable()]
  * [ResetOffsetAtEndOfFrame()]
  * [Teleport(TransformData)]

## Details

##### Inheritance

* System.Object
* TeleporterConfigurator

##### Namespace

* [Tilia.Locomotors.Teleporter]

##### Syntax

```
public class TeleporterConfigurator : MonoBehaviour
```

### Fields

#### allowSnapToFloorBlinkThresholdSet

Whether the Facade.SnapToFloorBlinkThreshold can be changed and affects the configuration.

##### Declaration

```
protected bool allowSnapToFloorBlinkThresholdSet
```

#### cachedLocators

A SurfaceLocator collection to store cached versions that get mutated but need changing back after process.

##### Declaration

```
protected List<SurfaceLocator> cachedLocators
```

#### cachedSnapToFloorBlinkThreshold

the Facade.SnapToFloorBlinkThreshold value before it is mutated.

##### Declaration

```
protected float cachedSnapToFloorBlinkThreshold
```

#### resetCachedDataRoutine

The routine for resetting cached data.

##### Declaration

```
protected Coroutine resetCachedDataRoutine
```

### Properties

#### CameraColorOverlays

The scene Cameras to set the CameraColorOverlays to affect.

##### Declaration

```
public List<CameraColorOverlay> CameraColorOverlays { get; protected set; }
```

#### Facade

The public interface facade.

##### Declaration

```
public TeleporterFacade Facade { get; protected set; }
```

#### ModifyTeleporter

The TransformPropertyApplier to use for the teleporting event.

##### Declaration

```
public TransformPropertyApplier ModifyTeleporter { get; protected set; }
```

#### SnapToFloorBlinkThresholdController

The SurfaceChangeAction that holds the threshold of whether a blink should occur when snapping to floor.

##### Declaration

```
public SurfaceChangeAction SnapToFloorBlinkThresholdController { get; protected set; }
```

#### SnapToFloorContainer

The GameObject that contains the snap to floor controller logic.

##### Declaration

```
public GameObject SnapToFloorContainer { get; protected set; }
```

#### SnapToFloorThresholdController

The SurfaceChangeAction that holds the threshold of whether a snap to floor should even occur.

##### Declaration

```
public SurfaceChangeAction SnapToFloorThresholdController { get; protected set; }
```

#### SurfaceLocatorAliases

The SurfaceLocator to set aliases on.

##### Declaration

```
public List<SurfaceLocator> SurfaceLocatorAliases { get; protected set; }
```

#### SurfaceLocatorRules

The SurfaceLocator to set rules on.

##### Declaration

```
public List<SurfaceLocator> SurfaceLocatorRules { get; protected set; }
```

#### SurfaceTeleporter

The SurfaceLocator to use for the teleporting event.

##### Declaration

```
public SurfaceLocator SurfaceTeleporter { get; protected set; }
```

#### TransformPropertyApplierAliases

The TransformPropertyApplier collection to set aliases on.

##### Declaration

```
public List<TransformPropertyApplier> TransformPropertyApplierAliases { get; protected set; }
```

#### TransformPropertyApplierIgnoreOffsetAliases

The TransformPropertyApplier collection to ignore offsets on.

##### Declaration

```
public List<TransformPropertyApplier> TransformPropertyApplierIgnoreOffsetAliases { get; protected set; }
```

### Methods

#### ConfigureCameraColorOverlays()

Configures the camera color overlays with the scene cameras provided in the facade.

##### Declaration

```
public virtual void ConfigureCameraColorOverlays()
```

#### ConfigureRotationAbility(Boolean)

Configures whether the teleporter will apply the destination rotation to the target.

##### Declaration

```
public virtual void ConfigureRotationAbility(bool shouldRotate)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Boolean | shouldRotate | n/a |

#### ConfigureSnapToFloor()

Configures the snap to floor logic based on the Facade.SnapToFloorEnabled setting.

##### Declaration

```
public virtual void ConfigureSnapToFloor()
```

#### ConfigureSurfaceChangeActions(Single, Single)

Configures the surface change actions that determine the snap to floor functionality.

##### Declaration

```
public virtual void ConfigureSurfaceChangeActions(float snapToFloorThreshold, float snapToFloorBlinkThreshold)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Single | snapToFloorThreshold | The threshold of whether the change distance should do a new snap to the found floor. |
| System.Single | snapToFloorBlinkThreshold | The threshold of whether to blink the view. |

#### ConfigureSurfaceLocatorAliases()

Configures the surface locator aliases with the offset provided in the facade.

##### Declaration

```
public virtual void ConfigureSurfaceLocatorAliases()
```

#### ConfigureSurfaceLocatorOffsets()

Configures the surface locator rules with the valid targets provided in the facade.

##### Declaration

```
public virtual void ConfigureSurfaceLocatorOffsets()
```

#### ConfigureSurfaceLocatorRules()

Configures the surface locator rules with the valid targets provided in the facade.

##### Declaration

```
public virtual void ConfigureSurfaceLocatorRules()
```

#### ConfigureTransformPropertyAppliers()

Configures the transform properties applies with the settings applied in the facade.

##### Declaration

```
public virtual void ConfigureTransformPropertyAppliers()
```

#### DisableRotations()

Disables the ability to rotate the target.

##### Declaration

```
protected virtual void DisableRotations()
```

#### EnableRotations()

Enables the ability to rotate the target.

##### Declaration

```
protected virtual void EnableRotations()
```

#### NotifyTeleported(TransformPropertyApplier.EventData)

Notifies that the teleporter has completed.

##### Declaration

```
public virtual void NotifyTeleported(TransformPropertyApplier.EventData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TransformPropertyApplier.EventData | data | The location data. |

#### NotifyTeleporting(TransformPropertyApplier.EventData)

Notifies that the teleporter is about to initiate.

##### Declaration

```
public virtual void NotifyTeleporting(TransformPropertyApplier.EventData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| TransformPropertyApplier.EventData | data | The location data. |

#### OnEnable()

##### Declaration

```
protected virtual void OnEnable()
```

#### ResetOffsetAtEndOfFrame()

Resets the data mutated by the destination offset update to the original cached values.

##### Declaration

```
protected virtual IEnumerator ResetOffsetAtEndOfFrame()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.IEnumerator | An Enumerator to manage the running of the Coroutine. |

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

[Tilia.Locomotors.Teleporter]: README.md
[TeleporterFacade]: TeleporterFacade.md
[Target]: TeleporterFacade.md#Tilia_Locomotors_Teleporter_TeleporterFacade_Target
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[allowSnapToFloorBlinkThresholdSet]: #allowSnapToFloorBlinkThresholdSet
[cachedLocators]: #cachedLocators
[cachedSnapToFloorBlinkThreshold]: #cachedSnapToFloorBlinkThreshold
[resetCachedDataRoutine]: #resetCachedDataRoutine
[Properties]: #Properties
[CameraColorOverlays]: #CameraColorOverlays
[Facade]: #Facade
[ModifyTeleporter]: #ModifyTeleporter
[SnapToFloorBlinkThresholdController]: #SnapToFloorBlinkThresholdController
[SnapToFloorContainer]: #SnapToFloorContainer
[SnapToFloorThresholdController]: #SnapToFloorThresholdController
[SurfaceLocatorAliases]: #SurfaceLocatorAliases
[SurfaceLocatorRules]: #SurfaceLocatorRules
[SurfaceTeleporter]: #SurfaceTeleporter
[TransformPropertyApplierAliases]: #TransformPropertyApplierAliases
[TransformPropertyApplierIgnoreOffsetAliases]: #TransformPropertyApplierIgnoreOffsetAliases
[Methods]: #Methods
[ConfigureCameraColorOverlays()]: #ConfigureCameraColorOverlays
[ConfigureRotationAbility(Boolean)]: #ConfigureRotationAbilityBoolean
[ConfigureSnapToFloor()]: #ConfigureSnapToFloor
[ConfigureSurfaceChangeActions(Single, Single)]: #ConfigureSurfaceChangeActionsSingle-Single
[ConfigureSurfaceLocatorAliases()]: #ConfigureSurfaceLocatorAliases
[ConfigureSurfaceLocatorOffsets()]: #ConfigureSurfaceLocatorOffsets
[ConfigureSurfaceLocatorRules()]: #ConfigureSurfaceLocatorRules
[ConfigureTransformPropertyAppliers()]: #ConfigureTransformPropertyAppliers
[DisableRotations()]: #DisableRotations
[EnableRotations()]: #EnableRotations
[NotifyTeleported(TransformPropertyApplier.EventData)]: #NotifyTeleportedTransformPropertyApplier.EventData
[NotifyTeleporting(TransformPropertyApplier.EventData)]: #NotifyTeleportingTransformPropertyApplier.EventData
[OnEnable()]: #OnEnable
[ResetOffsetAtEndOfFrame()]: #ResetOffsetAtEndOfFrame
[Teleport(TransformData)]: #TeleportTransformData
