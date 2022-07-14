# Installing the package

> * Level: Beginner
>
> * Reading Time: 2 minutes
>
> * Checked with: Unity 2019.1.0f2

## Introduction

The [Unity Input System] package provides a collection of Zinnia Transformers that make it easy to convert the Unity Input System events into data types that can be passed into Zinnia Actions.

The provided Input Samples include:

* GenericXR - Generic XR controller mappings.

These Input Samples can be included in a [Unity] software project via the [Unity Package Manager].

## Let's Start

### Step 1: Creating a Unity project

> You may skip this step if you already have a Unity project to import the package into.

* Create a new project in the Unity software version `2019.1.0f2` (or above) using `3D Template` or open an existing project.

### Step 2: Configuring the Unity project

* Ensure the project `Scripting Runtime Version` is set to `.NET 4.x Equivalent`:
  * In the Unity software select `Main Menu -> Edit -> Project Settings` to open the `Project Settings` inspector.
  * Select `Player` from the left hand menu in the `Project Settings` window.
  * In the `Player` settings panel expand `Other Settings`.
  * Ensure the `Scripting Runtime Version` is set to `.NET 4.x Equivalent`.
* Change the project `Active Input Handling` to `Input System`:
  * Still in the `Other Settings` panel in the `Player` settings, change the `Active Input Handling` option to `Input System (Preview)`.
  * Click `Apply` on the popup window instructing to restart the Unity editor.
* Activate the `Input System Package`:
  * Select `Input System Package` from the left hand menu in the `Project Settings` window to activate the new Unity Input System.

### Step 3: Adding the package to the Unity project manifest

* Navigate to the `Packages` directory of your project.
* Adjust the [project manifest file][Project-Manifest] `manifest.json` in a text editor.
  * Ensure `https://registry.npmjs.org/` is part of `scopedRegistries`.
    * Ensure `io.extendreality` is part of `scopes`.
  * Add `io.extendreality.tilia.input.unityinputsystem` to `dependencies`, stating the latest version.

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
      "io.extendreality.tilia.input.unityinputsystem": "X.Y.Z",
      ...
    }
  }
  ```
* Switch back to the Unity software and wait for it to finish importing the added package.

### Done

The `Tilia Input UnityInputSystem` package will now be available in your Unity project `Packages` directory ready for use in your project.

The package will now also show up in the Unity Package Manager UI. From then on the package can be updated by selecting the package in the Unity Package Manager and clicking on the `Update` button or using the version selection UI.

Any sample Input mappings will also be available to download from the `Samples` section on the package in the Unity Package Manager UI. Any installed samples will show up in the `Project -> Assets -> Samples -> Tilia Input UnityInputSystem` directory.

[Unity Input System]: https://docs.unity3d.com/Manual/com.unity.inputsystem.html
[Unity]: https://unity3d.com/
[Unity Package Manager]: https://docs.unity3d.com/Manual/upm-ui.html
[Project-Manifest]: https://docs.unity3d.com/Manual/upm-manifestPrj.html
[Version-Release]: https://img.shields.io/github/release/ExtendRealityLtd/Tilia.Input.UnityInputSystem.svg
[Releases]: ../../../../../releases
[Latest-Release]: ../../../../../releases/latest