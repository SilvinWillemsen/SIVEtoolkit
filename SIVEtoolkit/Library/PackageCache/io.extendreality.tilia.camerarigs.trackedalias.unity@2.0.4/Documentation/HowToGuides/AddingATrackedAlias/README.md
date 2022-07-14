# Adding A Tracked Alias

> * Level: Beginner
>
> * Reading Time: 2 minutes
>
> * Checked with: Unity 2018.3.14f1

## Introduction

The `CameraRigs.TrackedAlias` prefab provides a way of attaching elements to CameraRig configurations without specifically tying them to the underlying SDK CameraRig.

This is useful if you want to support multiple SDK CameraRigs in your scene but don’t want to duplicate the same child GameObjects of all the relevant SDK CameraRigs.

## Prerequisites

* [Add the Tilia.CameraRigs.SpatialSimulator.Unity -> CameraRigs.SpatialSimulator] prefab to the scene hierarchy.
* [Add the Tilia.CameraRigs.UnityXR -> CameraRigs.UnityXR] prefab to the scene hierarchy.
* [Install the Tilia.CameraRigs.TrackedAlias.Unity] package dependency in to your [Unity] project.

## Let's Start

### Step 1

Add a `CameraRigs.TrackedAlias` prefab to the Unity project hierarchy by selecting `GameObject -> Tilia -> Prefabs -> CameraRigs -> CameraRigs.TrackedAlias` from the Unity main top menu.

### Step 2

Select the `CameraRigs.TrackedAlias` GameObject in the Unity Hierarchy window then increase the `CameraRigs -> Elements -> Size` property by `2` on the `Tracked Alias Facade` component.

> The size property will be `0` by default so change it to `2`.

![Update TrackedAlias Elements Size](assets/images/UpdateTrackedAliasElementsSize.png)

### Step 3

Drag and drop the `CameraRigs.SpatialSimulator` GameObject into the newly created `Element 0` property value within the `Camera Rigs` property on the `Tracked Alias Facade` component.

![Drag And Drop Spatial Simulator Into TrackedAlias](assets/images/DragAndDropSpatialSimulatorIntoTrackedAlias.png)

### Step 4

Drag and drop the `CameraRigs.UnityXR` GameObject into the newly created `Element 1` property value  within the `Camera Rigs` property on the `Tracked Alias Facade` component.

![Drag And Drop UnityXR Into TrackedAlias](assets/images/DragAndDropUnityXRIntoTrackedAlias.png)

### Step 5

Disable the `CameraRigs.UnityXR` GameObject so there is only one active CameraRig in the scene.

![Disable UnityXR GameObject](assets/images/DisableUnityXRGameObject.png)

### Done

Now you have a TrackedAlias in your scene that will track the first active valid CameraRig that is set in the CameraRigs list. If you play the Unity scene you will have the TrackedAlias linked to the Spatial Simulator as it's first in the list and is the active CameraRig in the scene.

As you move the Spatial Simulator around the scene, the TrackedAlias controllers will follow the orientation of the Spatial Simulator controllers and if you move the TrackedAlias play area then the Spatial Simulator play area will follow along.

If you disable the `CameraRigs.SpatialSimulator` GameObject in the scene and enable the `CameraRigs.UnityXR` GameObject in the scene then the TrackedAlias will switch to following the UnityXR CameraRig in the scene as it has become the next active CameraRig available.

You can now place other GameObjects in the TrackedAlias child GameObjects and they will follow the active SDK Camera Rig without being specifically tied to it.

![TrackedAlias In Scene With Example Avatar Objects](assets/images/TrackedAliasInSceneWithExampleAvatarObjects.png)

[Add the Tilia.CameraRigs.SpatialSimulator.Unity -> CameraRigs.SpatialSimulator]: https://github.com/ExtendRealityLtd/Tilia.CameraRigs.SpatialSimulator.Unity/blob/master/Documentation/HowToGuides/AddingASpatialSimulatorCameraRig/README.md
[Add the Tilia.CameraRigs.UnityXR -> CameraRigs.UnityXR]: https://github.com/ExtendRealityLtd/Tilia.CameraRigs.UnityXR/blob/master/Documentation/HowToGuides/AddingAUnityXRCameraRig/README.md
[Install the Tilia.CameraRigs.TrackedAlias.Unity]: ../Installation/README.md
[Unity]: https://unity3d.com/