# Changelog

### [2.0.6](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v2.0.5...v2.0.6) (2022-06-19)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.utilities.shaders.unity ([db11271](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/db11271177bfbcb5858450bebc70a48fd2baca6e))
  > Bumps [io.extendreality.tilia.utilities.shaders.unity](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity) from 1.3.0 to 1.3.1. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/compare/v1.3.0...v1.3.1)

### [2.0.5](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v2.0.4...v2.0.5) (2022-06-16)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 2.2.0 to 2.3.0 ([ebad968](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/ebad968dd2d85344adb81907125a7fa87b2f8d2e))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 2.2.0 to 2.3.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v2.2.0...v2.3.0)

### [2.0.4](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v2.0.3...v2.0.4) (2022-05-20)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 2.1.0 to 2.2.0 ([693e8a5](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/693e8a51f5f21a93221e9ca92fb9ff2450309fe4))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 2.1.0 to 2.2.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v2.1.0...v2.2.0)

### [2.0.3](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v2.0.2...v2.0.3) (2022-05-09)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 2.0.0 to 2.1.0 ([271e2c6](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/271e2c6ebf0c69a21ae4a11f2a7a0eec9765ec53))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 2.0.0 to 2.1.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v2.0.0...v2.1.0)

### [2.0.2](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v2.0.1...v2.0.2) (2022-04-28)

#### Bug Fixes

* **prefabs:** ensure snap to floor enabled turns off correct object ([3468aaa](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/3468aaa4fa1a994b3558c8278fc4b66a12ab37e8))
  > The `Snap To Floor Enabled` property was not working correctly as it was turning off the entire Snap To Floor prefab meaning the blink logic was also not working as the blink/fade logic is contained within the Snap To Floor prefab.
  > 
  > The fix is to just turn off the actual surface location logic so the blink is still accessible.

### [2.0.1](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v2.0.0...v2.0.1) (2022-04-28)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.47.1 to 2.0.0 ([b491b9a](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/b491b9a30a5420a950032eb7df8b5f80aefdb779))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.47.1 to 2.0.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.47.1...v2.0.0)

## [2.0.0](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.8.2...v2.0.0) (2022-04-28)

#### :warning: BREAKING CHANGES :warning:

* **Malimbe:** This removes the last remaining elements of Malimbe and whilst it does not cause any breaking changes within this package, it removes Malimbe as a dependency which other projects that rely on this package may piggy back off this Malimbe dependency so it will break any project like that.

All of the previous functionality from Malimbe has been replicated in standard code without the need for it to be weaved by the Malimbe helper tags. ([08a47bd](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/08a47bd1b17c4d2fd10bdcfe629c3b99e82bce0e))

#### Features

* **Malimbe:** remove malimbe dependency ([08a47bd](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/08a47bd1b17c4d2fd10bdcfe629c3b99e82bce0e))

### [1.8.2](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.8.1...v1.8.2) (2022-03-19)

#### Bug Fixes

* **SnapToFloor:** re-enable the camera color overlay component ([dfcbd7f](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/dfcbd7f11362a1473fe337bf2363bdf95188cef0))
  > The CameraColorOverlay component had been disabled to prevent an initial blink when the teleporter started at an offset height but this caused the blink to be always disabled if no offset height was provided.
  > 
  > The component is now enabled by default and at a later date a further fix for the offset height blink will be added.

### [1.8.1](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.8.0...v1.8.1) (2022-03-15)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.47.0 to 1.47.1 ([0bf1ea8](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/0bf1ea80844137160d2f7dbf39da8ff45f7cbec7))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.47.0 to 1.47.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.47.0...v1.47.1)

## [1.8.0](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.7.2...v1.8.0) (2022-03-15)

#### Features

* **Facade:** add toggle to enable/disable snap to floor logic ([e2a21e3](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/e2a21e33fc280b37bf10e487993e7ece9ec691ae))
  > The Snap To Floor logic can now be turned on or off by using the new `Snap To Floor Enabled` checkbox on the Teleporter Facade to make it easier and more obvious to change the state of this container that holds the snapping logic.

#### Bug Fixes

* **SnapToFloor:** disable camera color overlay by default ([7fefc11](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/7fefc1149380abc7eab189f9dffcb3a3cf140c7b))
  > If the CameraColorOverlay object is not disabled by default then the camera will do an initial fade if the destination offset is higher than 0 for the Y axis. The process is already there to enable the CameraColorOverlay after the first snap to floor logic run but the GameObject was left enabled by default so it will do the fade on the first snap to floor logic run.
* **TeleporterConfigurator:** configure offsets when enabled ([59504e9](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/59504e9def52be8786d39de8722750e7bce05c91))
  > The Surface Locator offsets were not being configured and setup when the configurator was enabled and the code that did the configuration required the entire facade to be disabled then re-enabled which would cause an infinite loop if called in the OnEnable.
  > 
  > This has been fixed by not needing the whole Facade to be disabled and instead a simple flag has been added that delays the setting of the threshold until the offsets have been set up, which means the offset set up can be run in the OnEnable.

### [1.7.2](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.7.1...v1.7.2) (2022-03-15)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.46.0 to 1.47.0 ([f346a88](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/f346a88d11c095a1ef23bf35703dcce2f918c812))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.46.0 to 1.47.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.46.0...v1.47.0)

### [1.7.1](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.7.0...v1.7.1) (2022-03-02)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.utilities.shaders.unity ([1e2ab4f](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/1e2ab4f0db336b621888b2cde26198d1030ce5a2))
  > Bumps [io.extendreality.tilia.utilities.shaders.unity](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity) from 1.2.0 to 1.3.0. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/compare/v1.2.0...v1.3.0)

## [1.7.0](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.6.17...v1.7.0) (2022-03-02)

#### Features

* **package.json:** add information urls to package ([1cc6ad5](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/1cc6ad52d33f5de667daf81ae0f3d0db215779c7))
  > The changelog, documentation and license url has been added to the package.json as these are used within the Unity package manager.

### [1.6.17](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.6.16...v1.6.17) (2022-02-14)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.45.0 to 1.46.0 ([49d3e3b](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/49d3e3bc375dc1e96aea6b6f7c28d0ad172af18b))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.45.0 to 1.46.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.45.0...v1.46.0)

### [1.6.16](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.6.15...v1.6.16) (2022-02-05)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.44.0 to 1.45.0 ([5f0c2d6](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/5f0c2d69a9c9aa18012e66a48e395a3adbf41375))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.44.0 to 1.45.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.44.0...v1.45.0)

### [1.6.15](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.6.14...v1.6.15) (2022-01-17)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.43.0 to 1.44.0 ([b240de2](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/b240de2479f28dbd6edf215e4974e0d84313b78c))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.43.0 to 1.44.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.43.0...v1.44.0)

### [1.6.14](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.6.13...v1.6.14) (2022-01-13)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.42.0 to 1.43.0 ([82f9e6a](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/82f9e6a1dd3a559f0a463e7702249e956dad262f))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.42.0 to 1.43.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.42.0...v1.43.0)

### [1.6.13](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.6.12...v1.6.13) (2022-01-13)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.41.0 to 1.42.0 ([f5a7b9f](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/f5a7b9f63db1804d2d1980a859061d4f7d23af3e))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.41.0 to 1.42.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.41.0...v1.42.0)

### [1.6.12](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.6.11...v1.6.12) (2022-01-12)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.40.0 to 1.41.0 ([67d6ad2](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/67d6ad248a8231dc704ad61e4d660950758ac2b4))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.40.0 to 1.41.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.40.0...v1.41.0)

### [1.6.11](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.6.10...v1.6.11) (2022-01-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.39.0 to 1.40.0 ([530ef2a](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/530ef2a10e8f53df8c91a2880e88e865363256b3))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.39.0 to 1.40.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.39.0...v1.40.0)

### [1.6.10](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.6.9...v1.6.10) (2021-12-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.38.1 to 1.39.0 ([70aab4d](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/70aab4d07f6ff4248b1f42e9996a84ac7b3a489d))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.38.1 to 1.39.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.38.1...v1.39.0)

### [1.6.9](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.6.8...v1.6.9) (2021-07-21)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.38.0 to 1.38.1 ([c244d25](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/c244d25620cc01ff827b1a238c5a930ff8fb9fab))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.38.0 to 1.38.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.38.0...v1.38.1)

### [1.6.8](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.6.7...v1.6.8) (2021-07-19)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.37.0 to 1.38.0 ([d842d07](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/d842d076b3ba9b497a9872985b476d5025fd3e25))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.37.0 to 1.38.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.37.0...v1.38.0)

### [1.6.7](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.6.6...v1.6.7) (2021-06-24)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.36.2 to 1.37.0 ([795d5f2](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/795d5f28ebfe89593edb2465427f6adf2e8ab812))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.36.2 to 1.37.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.36.2...v1.37.0)

### [1.6.6](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.6.5...v1.6.6) (2021-06-19)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.36.1 to 1.36.2 ([4c62d02](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/4c62d02df6a94926b75f2c6e1f5a499532d86b8a))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.36.1 to 1.36.2. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.36.1...v1.36.2)

### [1.6.5](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.6.4...v1.6.5) (2021-06-10)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.36.0 to 1.36.1 ([ea45666](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/ea456668027bdc32b4e3336fe9b756db2065834d))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.36.0 to 1.36.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.36.0...v1.36.1)

### [1.6.4](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.6.3...v1.6.4) (2021-06-10)

#### Bug Fixes

* **Materials:** update fade material to use better shader ([1934e48](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/1934e486ad4dccc01f594bce555fa44fb54f83b0))
  > The new TransparentColorBlockout shader is a better, more simpler shader to use for screen fading and it is also compatible with the URP approach to screen fading.

### [1.6.3](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.6.2...v1.6.3) (2021-06-10)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.utilities.shaders.unity ([8145885](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/8145885795ef980ff6b7e70102d66f96ccbe59df))
  > Bumps [io.extendreality.tilia.utilities.shaders.unity](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity) from 1.1.0 to 1.2.0. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/compare/v1.1.0...v1.2.0)
* **README.md:** update title logo to related-media repo ([a93a5e5](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/a93a5e506eb9ee184a1be00ede9c418f14154ab8))
  > The title logo is now located on the related-media repo.

### [1.6.2](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.6.1...v1.6.2) (2021-05-09)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.35.0 to 1.36.0 ([64bb26d](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/64bb26d7d385b627f4d4031aaecc913a5b12401f))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.35.0 to 1.36.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.35.0...v1.36.0)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

### [1.6.1](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.6.0...v1.6.1) (2021-05-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.34.1 to 1.35.0 ([9af445e](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/9af445e2bc4dd142a8a57bbfd286e4b9822b35aa))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.34.1 to 1.35.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.34.1...v1.35.0)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

## [1.6.0](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.5.7...v1.6.0) (2021-04-07)

#### Features

* **Utility:** add prefab creator ([c9c64e9](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/c9c64e914143b0210038fa4e6ad439df96404cdd))
  > The latest version of Zinnia has the basis of a prefab creator that can be used to enable easy adding of prefabs to a scene without needing to drag and drop from directories. Instead a new menu item is added for quickly adding prefabs. The guide has been updated to accommodate this and the FodyWeavers.xml is now located in the root to serve both the Runtime and Editor scripts.

#### Bug Fixes

* **package.json:** add missing reference to Editor directory ([ad92ddb](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/ad92ddb9c7039b72cb7962c6c74b46f0fea4b39c))
  > The build will fail without referencing this new Editor directory so it has now been added to the package.

### [1.5.7](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.5.6...v1.5.7) (2021-03-29)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.31.1 to 1.33.0 ([496a035](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/496a0350da55a7a5379a4a7d9ade57a73a657fde))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.31.1 to 1.33.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.31.1...v1.33.0)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

### [1.5.6](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.5.5...v1.5.6) (2021-03-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.31.0 to 1.31.1 ([addfbc4](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/addfbc4cc6632f00ee94f095a724dc01511c61fa))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.31.0 to 1.31.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.31.0...v1.31.1)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

### [1.5.5](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.5.4...v1.5.5) (2021-02-27)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.30.0 to 1.31.0 ([1de35c7](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/1de35c7c22ab890fc2579f06420089247e29792b))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.30.0 to 1.31.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.30.0...v1.31.0)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

### [1.5.4](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.5.3...v1.5.4) (2021-02-04)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.29.0 to 1.30.0 ([75beb24](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/75beb246fc706794f4262b7acc300ea30fbd335e))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.29.0 to 1.30.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.29.0...v1.30.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.5.3](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.5.2...v1.5.3) (2021-01-07)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.28.1 to 1.29.0 ([1abab30](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/1abab30388e92f3303e17ae4b2973e6623ed06cb))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.28.1 to 1.29.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.28.1...v1.29.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.5.2](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.5.1...v1.5.2) (2020-12-21)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.28.0 to 1.28.1 ([8b17e63](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/8b17e63b63d6984c0613b41ed13f2e1a8469a9b0))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.28.0 to 1.28.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.28.0...v1.28.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.5.1](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.5.0...v1.5.1) (2020-12-17)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.27.0 to 1.28.0 ([9afd885](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/9afd885708df8726c08bc4835b49417b961804e3))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.27.0 to 1.28.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.27.0...v1.28.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

## [1.5.0](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.4.0...v1.5.0) (2020-12-16)

#### Features

* **Facade:** allow teleport to given Vector3 ([53d1334](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/53d13341636e728d2be9df3dc4eb4f7b5250b363))
  > A new `Teleport` method has been added that simply takes a Vector3 as the property and will auto create the relevant Transform to use in the teleport, then destroy it at the end of the method call.

## [1.4.0](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.3.10...v1.4.0) (2020-12-13)

#### Features

* **Facade:** add destination offset property ([3517a86](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/3517a86cbe9f433b2163795ed49b9b7e0d26ddc5))
  > The new destination offset property allows the teleport destination to be offset by a given position so it is easier to raise and lower the character avatar against the found floor surface.

### [1.3.10](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.3.9...v1.3.10) (2020-12-12)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.25.1 to 1.27.0 ([061fd07](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/061fd07e0205cb6742fc77a8426a49904ef26253))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.25.1 to 1.27.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.25.1...v1.27.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.3.9](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.3.8...v1.3.9) (2020-12-11)

#### Bug Fixes

* **HowToGuides:** apply document styling guidelines ([dbefd45](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/dbefd4530c02e13f580daf7b565d643a00672e5b))
  > The document style guidelines have been updated and now have been applied to the guides in this repo.

### [1.3.8](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.3.7...v1.3.8) (2020-11-01)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.25.0 to 1.25.1 ([df9fb9c](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/df9fb9cfa04940539aabb9ad162938f22764916d))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.25.0 to 1.25.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.25.0...v1.25.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.3.7](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.3.6...v1.3.7) (2020-10-02)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.24.0 to 1.25.0 ([c78faab](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/c78faab8a386167560d9c20f8cde3f377d14a511))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.24.0 to 1.25.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.24.0...v1.25.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.3.6](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.3.5...v1.3.6) (2020-08-29)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.23.0 to 1.24.0 ([073ace2](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/073ace245721b6c35de12ad6da1a4286b424ac9f))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.23.0 to 1.24.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.23.0...v1.24.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.3.5](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.3.4...v1.3.5) (2020-08-15)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.22.0 to 1.23.0 ([1d9bbbb](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/1d9bbbbc5ae3f344a068e69934483951ff82f382))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.22.0 to 1.23.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.22.0...v1.23.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.3.4](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.3.3...v1.3.4) (2020-08-14)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.21.0 to 1.22.0 ([227737d](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/227737d1ea02494f86fb006561f17828e7c241b9))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.21.0 to 1.22.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.21.0...v1.22.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.3.3](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.3.2...v1.3.3) (2020-07-28)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.20.0 to 1.21.0 ([a617341](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/a617341d887026d589cbc1389555b119c0de5a4e))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.20.0 to 1.21.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.20.0...v1.21.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.3.2](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.3.1...v1.3.2) (2020-07-11)

#### Bug Fixes

* **Facade:** use extension method to set enum value ([2e4e9ca](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/2e4e9caaeeefe105aae9e96516d20eb74e9556f6))
  > The SetOffsetUsage method now uses the Zinnia EnumExtensions helper method to set the value of the enum by the index instead of repeating the same logic.

### [1.3.1](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.3.0...v1.3.1) (2020-07-11)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.19.0 to 1.20.0 ([2877e6a](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/2877e6a961e2ad9cb2c2a3139e1c8bc3bec221ea))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.19.0 to 1.20.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.19.0...v1.20.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

## [1.3.0](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.2.1...v1.3.0) (2020-07-03)

#### Features

* **API:** add auto-generated API documentation ([724c2c4](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/724c2c4634be1df45ad338b0315166d111081bef))
  > The API documentation is auto generated with docfx and converted to markdown via turndown in a custom nodejs script.

#### Bug Fixes

* **package.json:** add docfx.json file ([cc8a9f2](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/cc8a9f2828928be7550093aefa7139972f2ab0d7))
  > The docfx.json file was missing from the package.json causing the build process to fail. It has now been added.

### [1.2.1](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.2.0...v1.2.1) (2020-06-21)

#### Bug Fixes

* **Documentation:** apply style guidelines ([3d5ef4f](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/3d5ef4ffd0de93c72d009df58804a7edb53e108c))
  > The guide has had the style guidelines applied to it to make it more consistent.

## [1.2.0](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.1.6...v1.2.0) (2020-06-11)

#### Features

* **prefab:** add ability to customise snap to floor thresholds ([61bd64e](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/61bd64e00c548ee7f6d80ac64e391790cae1ca4e))
  > The snap to floor threshold has now been exposed in the facade and the snap to floor mechanism has been updated so two Surface Change Actions are now used. The first one determines if a snap to the nearest floor can even take place (if the distance between the old and new floor exceeds the threshold). The second one determines if the snap teleport will blink the view.
  > 
  > This enables now certain small changes in floor height not to teleport the target at all and to only blink the view when the floor height has changed substantially enough.

### [1.1.6](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.1.5...v1.1.6) (2020-06-08)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.18.0 to 1.19.0 ([20194e4](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/20194e4980f63bbad861072106e2e021f04fb07b))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.18.0 to 1.19.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.18.0...v1.19.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.5](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.1.4...v1.1.5) (2020-05-31)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.17.1 to 1.18.0 ([0007362](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/00073623aceece117ea477769b9ed8d45b3a16a0))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.17.1 to 1.18.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.17.1...v1.18.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.4](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.1.3...v1.1.4) (2020-05-24)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.utilities.shaders.unity ([8a22804](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/8a228044dc5d526c45732ccf5a3eab26d1af1289))
  > Bumps [io.extendreality.tilia.utilities.shaders.unity](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity) from 1.0.2 to 1.1.0. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/compare/v1.0.2...v1.1.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.3](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.1.2...v1.1.3) (2020-05-22)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.17.0 to 1.17.1 ([0e7b524](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/0e7b524ba889f2ff8eb254c603aa585ff7dac4ed))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.17.0 to 1.17.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.17.0...v1.17.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.2](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.1.1...v1.1.2) (2020-05-22)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.16.0 to 1.17.0 ([232231a](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/232231af22dc0338ce8f9b40c3cb88c3969ba3ef))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.16.0 to 1.17.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.16.0...v1.17.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.1](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.1.0...v1.1.1) (2020-04-21)

#### Bug Fixes

* **Prefabs:** allow teleport to same location as previous location ([b9ed929](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/b9ed9293aec99eabce9ad5fe887624a04e9983bd))
  > Zinnia 1.16.0 has some changes to the SurfaceLocator and the TransformPropertyApplier that allows both components to still operate if the previous location is the same as the current loaction.
  > 
  > This limitation in Zinnia 1.15.0 meant that you could not teleport to the same position that you were currently on, which was fine in most cases but there are some occasions where you do want to teleport back to where you're currently standing. This is now the default setting, but its still possible to switch the settings to have it work the way it did before.

## [1.1.0](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.0.6...v1.1.0) (2020-04-14)

#### Features

* **HowToGuides:** add guide for adding teleporter ([8e536a4](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/8e536a4f499de42d884dfd8870dadfd19b2dff8e))
  > added guided to demonstrate how to add a teleporter and to move around with the pointer.

#### Bug Fixes

* **HowToGuides:** add missing .meta files for guide ([ce62132](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/ce62132e9a81f7182f9d505c2e98a1b04d9e8528))
  > The Adding A Teleporter guide has no Unity meta files for any of the files within the guide. These have now been generated and added.

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.11.0 to 1.12.0 ([e3501e1](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/e3501e10be53f04fe7addfb14d1a560f6de11213))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.11.0 to 1.12.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.11.0...v1.12.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>
* **deps:** bump io.extendreality.zinnia.unity from 1.12.0 to 1.14.0 ([cf656e6](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/cf656e6f4e5de7337fa0ff4db4ffeec7d72f6588))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.12.0 to 1.14.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.12.0...v1.14.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>
* **deps:** bump io.extendreality.zinnia.unity from 1.14.0 to 1.14.1 ([f86060b](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/f86060b58c9e48193c647be46b01005e37d998ab))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.14.0 to 1.14.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.14.0...v1.14.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>
* **deps:** bump io.extendreality.zinnia.unity from 1.14.1 to 1.15.0 ([6adc08c](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/6adc08c66684443ccebe9afb0dfeff1fd8ce64a1))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.14.1 to 1.15.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.14.1...v1.15.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.6](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.0.5...v1.0.6) (2020-01-02)

#### Bug Fixes

* **README.md:** provide correct URL for version release badge ([2e77507](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/2e77507ca53128567ee806d13fa1ee6be29a28a3))
  > The URL in the version release badge was not valid and therefore the version number badge was not displaying.

### [1.0.5](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.0.4...v1.0.5) (2020-01-02)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.9.0 to 1.11.0 ([8106a29](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/8106a2907565adaa5543515e0fcd21990ee99687))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.9.0 to 1.11.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.9.0...v1.11.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.4](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.0.3...v1.0.4) (2019-12-17)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.utilities.shaders.unity ([c2c665b](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/c2c665bd0213a7872fc1a2db42c7beef45bf2b02))
  > Bumps [io.extendreality.tilia.utilities.shaders.unity](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity) from 1.0.1 to 1.0.2. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/compare/v1.0.1...v1.0.2)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.3](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.0.2...v1.0.3) (2019-12-16)

#### Bug Fixes

* **Scripts:** update namespace to correct tilia namespace ([7a87008](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/7a87008ba0160f9e09d846a19834a92a4adfaa41))
  > The code still had the VRTK.Prefabs namespace as it was copied over from the VRTK.Prefabs repo, this has now been updated to be in line with the Tilia repo name instead.

### [1.0.2](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.0.1...v1.0.2) (2019-12-16)

#### Bug Fixes

* **package.json:** provide correct version to shader dependency ([3a2bc9f](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/3a2bc9fa15508cf8503c37a8ce89c604991a8cd7))
  > The wrong shader package version was used due to an issue with the README on the shader repo displaying the wrong version. This has now been fixed by providing the correct version for the shader package dependency.

### [1.0.1](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.0.0...v1.0.1) (2019-12-16)

#### Bug Fixes

* **HowToGuides:** update incorrect package name ([c8efe03](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/c8efe039d6b0c1ad2cc7ed74bd3e0638d2ef32b2))
  > The package name was missing the tilia prefix and therefore was not correct and provided incorrect installation instructions.

## 1.0.0 (2019-12-16)

#### Features

* **structure:** create initial prefab and user guides ([2c9aab8](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/2c9aab8330d7ee1bfa81be5838d2a9060914c2d0))
  > The structure of the repository has been created with all the required files for the package, the prefab and the documentation.

#### Bug Fixes

* **package.json:** remove erroneous comma from dependencies ([e23a27c](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/e23a27c589928122be2f7d62629add945dcc77ba))
  > There was an extra comma at the end of the dependencies causing the package.json to be invalid. It has now been removed.
