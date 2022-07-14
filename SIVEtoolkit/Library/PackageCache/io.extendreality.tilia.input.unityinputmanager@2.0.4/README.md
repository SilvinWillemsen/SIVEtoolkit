[![Tilia logo][Tilia-Image]](#)

> ### Input -> Unity Input Manager
> Input wrappers for the legacy Unity Input Manager and a collection of common input prefabs.

[![Release][Version-Release]][Releases]
[![License][License-Badge]][License]
[![Backlog][Backlog-Badge]][Backlog]

## Introduction

The Unity Input Manager package provides a collection of [Zinnia] Actions that wrap [Unity] inputs from the legacy [Unity Input Manager]. These Actions can be used to map keyboard/button presses or axis data via the Unity Input Manager.

A collection of useful prefabs are also provided with pre-defined button and axis mappings for common controller types:

* Xbox Gamepad
* OpenVR controller
* Oculus Remote
* Oculus Touch controller
* Windows Mixed Reality controller

This package will also prompt to create any required and missing Unity Input Manager axes.

The new [Unity Input System] is available in Unity `2019.1.0f1` and to use that instead then see the [Tilia.Input.UnityInputSystem] repository.

> **Requires** the Unity software version `2018.3.10f1` (or above).

## Getting Started

Please refer to the [installation] guide to install this package.

## Documentation

Please refer to the [How To Guides] for usage of this package.

Further documentation can be found within the [Documentation] directory and at https://academy.vrtk.io

## Contributing

Please refer to the Extend Reality [Contributing guidelines] and the [project coding conventions].

## Code of Conduct

Please refer to the Extend Reality [Code of Conduct].

## License

Code released under the [MIT License][License].

[License-Badge]: https://img.shields.io/github/license/ExtendRealityLtd/Tilia.Input.UnityInputManager.svg
[Version-Release]: https://img.shields.io/github/release/ExtendRealityLtd/Tilia.Input.UnityInputManager.svg
[project coding conventions]: https://github.com/ExtendRealityLtd/.github/blob/master/CONVENTIONS/UNITY3D.md

[Tilia-Image]: https://raw.githubusercontent.com/ExtendRealityLtd/related-media/main/github/readme/tilia.png
[License]: LICENSE.md
[Documentation]: Documentation/
[How To Guides]: Documentation/HowToGuides/
[Installation]: Documentation/HowToGuides/Installation/README.md
[Backlog]: http://tracker.vrtk.io
[Backlog-Badge]: https://img.shields.io/badge/project-backlog-78bdf2.svg
[Releases]: ../../releases
[Contributing guidelines]: https://github.com/ExtendRealityLtd/.github/blob/master/CONTRIBUTING.md
[Code of Conduct]: https://github.com/ExtendRealityLtd/.github/blob/master/CODE_OF_CONDUCT.md

[Zinnia]: https://github.com/ExtendRealityLtd/Zinnia.Unity
[Unity]: https://unity3d.com/
[Unity Input Manager]: https://docs.unity3d.com/Manual/class-InputManager.html
[Unity Input System]: https://docs.unity3d.com/Manual/com.unity.inputsystem.html
[Tilia.Input.UnityInputSystem]: https://github.com/ExtendRealityLtd/Tilia.Input.UnityInputSystem