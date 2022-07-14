# Changelog

### [1.3.1](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/compare/v1.3.0...v1.3.1) (2022-06-19)

#### Bug Fixes

* **Shaders:** add support for single pass instanced rendering ([ceb1656](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/commit/ceb165644ed59b19837afed002d1d9ad91b79694))
  > A couple of the shaders were not working with single pass instanced rendering and were only rendering the object in the left eye camera.
  > 
  > This has been fixed by following the guide in the Unity Documentation: https://docs.unity3d.com/Manual/SinglePassInstancing.html

#### Miscellaneous Chores

* **dependabot:** remove bddckr from reviewers ([2955ea4](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/commit/2955ea4d98d056de6f94a6811cce555e8bcd189e))
  > Chris hasn't been actively part of the project for a while.

## [1.3.0](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/compare/v1.2.0...v1.3.0) (2022-03-02)

#### Features

* **package.json:** add information urls to package ([91e6acd](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/commit/91e6acd5c7f082304f5be39658c9a9fcd9c11e22))
  > The changelog, documentation and license url has been added to the package.json as these are used within the Unity package manager.

## [1.2.0](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/compare/v1.1.0...v1.2.0) (2021-06-10)

#### Features

* **Unlit:** add transparent color shader that blocks out complete view ([37792b7](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/commit/37792b7552688750f2fa9dc9993aa2201a8f9c79))
  > The Unlit Transparent Color Blockout shader will completely block the camera view with the color provided.

#### Miscellaneous Chores

* **README.md:** update title logo to related-media repo ([1b7a824](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/commit/1b7a82498b9dea43eefa99e2085fd219511f4790))
  > The title logo is now located on the related-media repo.

## [1.1.0](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/compare/v1.0.2...v1.1.0) (2020-05-24)

#### Features

* **Screen:** screen overlay shader for crosshair ([df5d744](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/commit/df5d7445c69f50a3908e2204b23023c104d365fa))
  > The Screen Overlay shader draws over everything else in the scene but draws within the world space so can be used as a 3d crosshair that will draw over any object it is pointing at.

### [1.0.2](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/compare/v1.0.1...v1.0.2) (2019-12-16)

#### Bug Fixes

* **README.md:** provide correct project links for license and version ([0f1377a](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/commit/0f1377a7edb8248749babea7781735b50dc94914))
  > The project link was incorrect for the License badge and the version release so it was showing the incorrect data on the README. This has now been updated to the correct project link.

### [1.0.1](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/compare/v1.0.0...v1.0.1) (2019-12-12)

#### Bug Fixes

* **Runtime:** remove unrequired assembly definition file ([46fab73](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/commit/46fab738a2fee822b818b165131bc585aaaf0d20))
  > The shader code does not require an assembly definition file as the shader code is not compiled into an assembly for use elsewhere.
  > 
  > It is simply used inside of the Unity software.

## 1.0.0 (2019-11-21)

#### Features

* **structure:** create shader code and installation guide ([62e43c8](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/commit/62e43c8f1fbc8485beebf6a49caa85569ef2ab71))
  > The structure of the repository has been created with all the required files for the package.
