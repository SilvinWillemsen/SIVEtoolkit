# Installing the package

> * Level: Beginner
>
> * Reading Time: 2 minutes
>
> * Checked with: Unity 2019.3.0f6

## Introduction

The `CameraRigs.UnityXRPluginFramework` prefab provides a spatial camera rig and controller setup utilizing the XR Plugin Framework provided by the Unity software. This prefab can be included in a [Unity] software project via the [Unity Package Manager].

## Let's Start

### Step 1: Creating a Unity project

> You may skip this step if you already have a Unity project to import the package into.

* Create a new project in the Unity software version `2019.3.0f6` (or above) using `3D Template` or open an existing project.

### Step 2: Configuring the Unity project

* Configure the project for XR:
  * In the Unity software select `Main Menu -> Edit -> Project Settings` to open the `Project Settings` inspector.
  * Select `XR Plug-in Management`. Click `Install XR Plug-in Management` if the package hasn’t been installed already. You can also install it from the Package Manager window.
  * After installation completes, select a Plug-in Provider to enable it for the corresponding build target. To do this:
    * Select a build target (for example, Android).
    * Select the checkbox to the left of each plug-in you want to use for that build target.
  * After a plug-in loads, it displays in the left-hand navigation, under XR Plug-in Management. Click the plug-in to configure its settings for each build target.

> The `Configure the project for XR` steps are adapted from the official Unity [Configuring your Unity Project for XR] guide.

### Step 3: Adding the package to the Unity project manifest

* Navigate to the `Packages` directory of your project.
* Adjust the [project manifest file][Project-Manifest] `manifest.json` in a text editor.
  * Ensure `https://registry.npmjs.org/` is part of `scopedRegistries`.
    * Ensure `io.extendreality` is part of `scopes`.
  * Add `io.extendreality.tilia.camerarigs.xrpluginframework.unity` to `dependencies`, stating the latest version.

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
      "io.extendreality.tilia.camerarigs.xrpluginframework.unity": "X.Y.Z",
      ...
    }
  }
  ```
* Switch back to the Unity software and wait for it to finish importing the added package.

### Done

The `Tilia CameraRigs XRPluginFramework Unity` package will now be available in your Unity project `Packages` directory ready for use in your project.

The package will now also show up in the Unity Package Manager UI. From then on the package can be updated by selecting the package in the Unity Package Manager and clicking on the `Update` button or using the version selection UI.

[Unity]: https://unity3d.com/
[Unity Package Manager]: https://docs.unity3d.com/Manual/upm-ui.html
[Project-Manifest]: https://docs.unity3d.com/Manual/upm-manifestPrj.html
[Version-Release]: https://img.shields.io/github/release/ExtendRealityLtd/Tilia.CameraRigs.XRPluginFramework.Unity.svg
[Releases]: ../../../../../releases
[Latest-Release]: ../../../../../releases/latest
[Configuring your Unity Project for XR]: https://docs.unity3d.com/2019.3/Documentation/Manual/configuring-project-for-xr.html