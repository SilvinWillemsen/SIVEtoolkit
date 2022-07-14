# Installing the package

> * Level: Beginner
>
> * Reading Time: 2 minutes
>
> * Checked with: Unity 2018.3.14f1

## Introduction

The [Unity Input Manager] prefabs provide a collection of wrapped Zinnia Actions that make it possible to listen for keyboard, mouse, button, axis changes on input peripherals via the Unity Input Manager framework. A collection of popular controller mappings is also included to save time on needing to manually build up the required actions to map to a controller type.

The provided controller mapping prefabs map directly to the internal input mappings provided by Unity:

* Xbox Gamepad - [Xbox Gamepad Input Map]
* OpenVR controller - [OpenVR Input Map]
* Oculus Remote - [Oculus Input Map]
* Oculus Touch controller - [Oculus Input Map]
* Windows Mixed Reality controller - [Windows Mixed Reality Input Map]

These prefabs can be included in a [Unity] software project via the [Unity Package Manager].

## Let's Start

### Step 1: Creating a Unity project

> You may skip this step if you already have a Unity project to import the package into.

* Create a new project in the Unity software version `2018.3.10f1` (or above) using `3D Template` or open an existing project.

### Step 2: Configuring the Unity project

* Ensure the project `Scripting Runtime Version` is set to `.NET 4.x Equivalent`:
  * In the Unity software select `Main Menu -> Edit -> Project Settings` to open the `Project Settings` inspector.
  * Select `Player` from the left hand menu in the `Project Settings` window.
  * In the `Player` settings panel expand `Other Settings`.
  * Ensure the `Scripting Runtime Version` is set to `.NET 4.x Equivalent`.

### Step 3: Adding the package to the Unity project manifest

* Navigate to the `Packages` directory of your project.
* Adjust the [project manifest file][Project-Manifest] `manifest.json` in a text editor.
  * Ensure `https://registry.npmjs.org/` is part of `scopedRegistries`.
    * Ensure `io.extendreality` is part of `scopes`.
  * Add `io.extendreality.tilia.input.unityinputmanager` to `dependencies`, stating the latest version.

  A minimal example ends up looking like this. Please note that the version `X.Y.Z` stated here is to be replaced with [the latest released version][Latest-Release] which is currently [![Release][Version-Release]][Releases].
  ```json
  {
    "scopedRegistries": [
      {
        "name": "npmjs",
        "url": "https://registry.npmjs.org/",
        "scopes": [
          "io.extendreality"
        ]
      }
    ],
    "dependencies": {
      "io.extendreality.tilia.input.unityinputmanager": "X.Y.Z",
      ...
    }
  }
  ```
* Switch back to the Unity software and wait for it to finish importing the added package.

### Step 4: Creating the required Unity Input Manager axis definitions.

The Unity software has no way of accessing axis data unless the axis is specifically defined in the Unity Input Manager UI. The axis definitions used by this package can be automatically created by using the `Manage Unity Input Manager Axis Definitions` window.

The `Manage Unity Input Manager Axis Definitions` window should automatically display once the package has loaded into the Unity software.

If it doesn't automatically load then it can be accessed by going to `Main Menu -> Window -> Tilia -> Input -> Manage Unity Input Manager Axis Definitions`.

Click the `Add Input Definitions` button and this will create 18 additional axis definitions that relate to many different popular input peripherals.

### Done

The `Tilia Input UnityInputManager` package will now be available in your Unity project `Packages` directory ready for use in your project.

The package will now also show up in the Unity Package Manager UI. From then on the package can be updated by selecting the package in the Unity Package Manager and clicking on the `Update` button or using the version selection UI.

[Unity Input Manager]: https://docs.unity3d.com/Manual/class-InputManager.html
[Xbox Gamepad Input Map]: https://wiki.unity3d.com/index.php/Xbox360Controller
[OpenVR Input Map]: https://docs.unity3d.com/Manual/OpenVRControllers.html
[Oculus Input Map]: https://docs.unity3d.com/Manual/OculusControllers.html
[Windows Mixed Reality Input Map]: https://docs.unity3d.com/Manual/Windows-Mixed-Reality-Input.html
[Unity]: https://unity3d.com/
[Unity Package Manager]: https://docs.unity3d.com/Manual/upm-ui.html
[Project-Manifest]: https://docs.unity3d.com/Manual/upm-manifestPrj.html
[Version-Release]: https://img.shields.io/github/release/ExtendRealityLtd/Tilia.Input.UnityInputManager.svg
[Releases]: ../../../../../releases
[Latest-Release]: ../../../../../releases/latest