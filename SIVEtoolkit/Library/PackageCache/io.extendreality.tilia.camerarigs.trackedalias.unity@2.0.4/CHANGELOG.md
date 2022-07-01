# Changelog

### [2.0.4](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v2.0.3...v2.0.4) (2022-06-16)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 2.2.0 to 2.3.0 ([d34c5cc](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/d34c5cce2c2b7ba11adbd3bf233a82c3b4cdd447))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 2.2.0 to 2.3.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v2.2.0...v2.3.0)

### [2.0.3](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v2.0.2...v2.0.3) (2022-05-20)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 2.1.0 to 2.2.0 ([994e3fa](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/994e3fa045bdec65bef1721c613953188be1a4a8))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 2.1.0 to 2.2.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v2.1.0...v2.2.0)

### [2.0.2](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v2.0.1...v2.0.2) (2022-05-09)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 2.0.0 to 2.1.0 ([aed1d61](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/aed1d61a0f605f93f704128c0bd406464e6b7e16))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 2.0.0 to 2.1.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v2.0.0...v2.1.0)

### [2.0.1](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v2.0.0...v2.0.1) (2022-04-28)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.47.1 to 2.0.0 ([22e0839](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/22e08393ed3a5a1dbcc6c1595c2bfda8009e3adf))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.47.1 to 2.0.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.47.1...v2.0.0)

## [2.0.0](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.9.0...v2.0.0) (2022-04-28)

#### :warning: BREAKING CHANGES :warning:

* **Malimbe:** This removes the last remaining elements of Malimbe and whilst it does not cause any breaking changes within this package, it removes Malimbe as a dependency which other projects that rely on this package may piggy back off this Malimbe dependency so it will break any project like that.

All of the previous functionality from Malimbe has been replicated in standard code without the need for it to be weaved by the Malimbe helper tags. ([05de5b1](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/05de5b11f1eab22498a494f6530b791086d62d40))

#### Features

* **Malimbe:** remove malimbe dependency ([05de5b1](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/05de5b11f1eab22498a494f6530b791086d62d40))

## [1.9.0](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.8.2...v1.9.0) (2022-03-22)

#### Features

* **prefab:** provide dominant controller alias ([71ddef5](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/71ddef595c75a6cfae537b536d174ba2792b33a5))
  > The dominant controller alias is now part of the TrackedAlias Aliases collection and will track the position/orientation of whatever the current dominant controller is.
  > 
  > This can be used to set up tracking objects to whatever the dominant controller is rather than having to always use the left/right controller.
  > 
  > There are also new events that are raised when the left/right controller become dominant or when the headset becomes the dominant controller.
  > 
  > Additional Facade properties for dominant controller data has also been added for completeness.

### [1.8.2](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.8.1...v1.8.2) (2022-03-15)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.47.0 to 1.47.1 ([bb696bb](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/bb696bb9135090c2498b2838a4f214813a5074a3))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.47.0 to 1.47.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.47.0...v1.47.1)

### [1.8.1](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.8.0...v1.8.1) (2022-03-15)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.46.0 to 1.47.0 ([9f1cd19](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/9f1cd19d16b64ce188afcbbb32deb7333003d975))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.46.0 to 1.47.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.46.0...v1.47.0)

## [1.8.0](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.7.2...v1.8.0) (2022-03-02)

#### Features

* **package.json:** add information urls to package ([b9ac848](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/b9ac848987d12cc36be6bb5124607ef8e1e01b7f))
  > The changelog, documentation and license url has been added to the package.json as these are used within the Unity package manager.

### [1.7.2](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.7.1...v1.7.2) (2022-02-14)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.45.0 to 1.46.0 ([9840d26](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/9840d262579215443f5919d396bf7ec84e680dfd))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.45.0 to 1.46.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.45.0...v1.46.0)

### [1.7.1](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.7.0...v1.7.1) (2022-02-05)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.44.0 to 1.45.0 ([ab29d7e](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/ab29d7ec00e12741ce1abcf909afb0bdc52d8f37))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.44.0 to 1.45.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.44.0...v1.45.0)

## [1.7.0](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.6.14...v1.7.0) (2022-01-17)

#### Features

* **Facade:** expose device details and provide new events ([57eda80](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/57eda80d82f588a1f123d2b422af7176ff3b383e))
  > The DeviceDetailsRecord which can now be stored on a CameraRig is now exposed via the TrackedAliasFacade so it's possible to get the current CameraRig's device details as well as the current determined dominant controller.
  > 
  > There are also new events that have been added to the Facade that bubble up the events from the internal device records to make it easier to know when device statuses change.

### [1.6.14](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.6.13...v1.6.14) (2022-01-17)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.43.0 to 1.44.0 ([fd9737d](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/fd9737d010ca9b1f2ee24673e6939bbd48b36326))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.43.0 to 1.44.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.43.0...v1.44.0)

### [1.6.13](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.6.12...v1.6.13) (2022-01-13)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.42.0 to 1.43.0 ([bb772e5](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/bb772e5b3367962bcb45120bc107e6e808a484be))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.42.0 to 1.43.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.42.0...v1.43.0)

### [1.6.12](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.6.11...v1.6.12) (2022-01-13)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.41.0 to 1.42.0 ([a1c5fa9](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/a1c5fa9157386b204324dad7933118b288146772))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.41.0 to 1.42.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.41.0...v1.42.0)

### [1.6.11](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.6.10...v1.6.11) (2022-01-12)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.40.0 to 1.41.0 ([2597ba8](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/2597ba826f213a535f4b9aaef4601129dbc72d2b))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.40.0 to 1.41.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.40.0...v1.41.0)

### [1.6.10](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.6.9...v1.6.10) (2022-01-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.39.0 to 1.40.0 ([2ac0770](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/2ac07701375016f35d50bd5b8ef0367c081b9d5d))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.39.0 to 1.40.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.39.0...v1.40.0)

### [1.6.9](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.6.8...v1.6.9) (2021-12-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.38.1 to 1.39.0 ([40e0a81](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/40e0a81716124203be8b2d4b52b77d4b54334c43))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.38.1 to 1.39.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.38.1...v1.39.0)

### [1.6.8](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.6.7...v1.6.8) (2021-07-21)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.38.0 to 1.38.1 ([f0c3397](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/f0c33974316d99dff829233f55f466a13b863c13))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.38.0 to 1.38.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.38.0...v1.38.1)

### [1.6.7](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.6.6...v1.6.7) (2021-07-19)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.37.0 to 1.38.0 ([eb489c8](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/eb489c8eee357959cef63f5d28865e9f75d89b8e))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.37.0 to 1.38.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.37.0...v1.38.0)

### [1.6.6](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.6.5...v1.6.6) (2021-06-24)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.36.2 to 1.37.0 ([2df65fd](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/2df65fdbd76f2001950e10bce6ff9568648088ec))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.36.2 to 1.37.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.36.2...v1.37.0)

### [1.6.5](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.6.4...v1.6.5) (2021-06-19)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.36.1 to 1.36.2 ([28c548c](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/28c548cc41f1a34b71d591f1693cc104ec582b17))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.36.1 to 1.36.2. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.36.1...v1.36.2)

### [1.6.4](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.6.3...v1.6.4) (2021-06-10)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.36.0 to 1.36.1 ([e69f7f5](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/e69f7f593cf0a592bf58214eaa231a94bfd4f634))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.36.0 to 1.36.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.36.0...v1.36.1)
* **README.md:** update title logo to related-media repo ([8da2cfb](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/8da2cfb552e79e5e8b2de6d9185c45b266ee2de2))
  > The title logo is now located on the related-media repo.

### [1.6.3](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.6.2...v1.6.3) (2021-05-09)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.35.0 to 1.36.0 ([ca6c326](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/ca6c3261e39b5f698ced749f6402481da7d65714))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.35.0 to 1.36.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.35.0...v1.36.0)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

### [1.6.2](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.6.1...v1.6.2) (2021-05-08)

#### Bug Fixes

* **Facade:** prevent null exception with canceling haptic profiles ([1ae58c1](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/1ae58c1aa90908b33b369d48f85f977052a93268))
  > There was an issue where calling cancel haptic profiles on a rig that had no profiles set up (like the simulator) would cause a null exception error because it would try to access the haptics list on an object that didn't exist.

### [1.6.1](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.6.0...v1.6.1) (2021-05-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.34.1 to 1.35.0 ([edd236b](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/edd236b93e9f4efc6787e61097b21fa617dd0efb))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.34.1 to 1.35.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.34.1...v1.35.0)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

## [1.6.0](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.5.10...v1.6.0) (2021-04-07)

#### Features

* **Utility:** add prefab creator ([059a55e](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/059a55ed82fe7b312b339906e3befac6452af8e8))
  > The latest version of Zinnia has the basis of a prefab creator that can be used to enable easy adding of prefabs to a scene without needing to drag and drop from directories. Instead a new menu item is added for quickly adding prefabs. The guide has been updated to accommodate this and the FodyWeavers.xml is now located in the root to serve both the Runtime and Editor scripts.

#### Bug Fixes

* **package.json:** add missing reference to Editor directory ([c3dd4df](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/c3dd4df54940bbf114693c1a04b0f455963ba433))
  > The build will fail without referencing this new Editor directory so it has now been added to the package.

### [1.5.10](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.5.9...v1.5.10) (2021-03-29)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.31.1 to 1.33.0 ([f89b808](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/f89b8084f24ff6c71e31dee96a8d4ca8e394b0ae))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.31.1 to 1.33.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.31.1...v1.33.0)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

### [1.5.9](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.5.8...v1.5.9) (2021-03-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.31.0 to 1.31.1 ([1987661](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/19876619f9d5fc713597078f7db5484f7d8e7fbc))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.31.0 to 1.31.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.31.0...v1.31.1)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

### [1.5.8](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.5.7...v1.5.8) (2021-02-27)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.30.0 to 1.31.0 ([5e7fc5b](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/5e7fc5b043c0f0a2721bd0e00c1b77b5626d7d77))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.30.0 to 1.31.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.30.0...v1.31.0)
  > 
  > Signed-off-by: dependabot[bot] <support@github.com>

### [1.5.7](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.5.6...v1.5.7) (2021-02-04)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.29.0 to 1.30.0 ([a63b84d](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/a63b84dcdcac0339e2356f06628bdba32c81c1ba))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.29.0 to 1.30.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.29.0...v1.30.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.5.6](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.5.5...v1.5.6) (2021-01-07)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.28.1 to 1.29.0 ([0db906f](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/0db906fe9152fc00443cd1c4c9a2b86e7c3f0088))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.28.1 to 1.29.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.28.1...v1.29.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.5.5](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.5.4...v1.5.5) (2020-12-21)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.28.0 to 1.28.1 ([38adc26](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/38adc26ecf454b62e3c8c4fcffbbbd06358cdea4))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.28.0 to 1.28.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.28.0...v1.28.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.5.4](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.5.3...v1.5.4) (2020-12-17)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.27.0 to 1.28.0 ([a51baed](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/a51baed043c4fbb202cb04dec69f7b0299490c97))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.27.0 to 1.28.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.27.0...v1.28.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.5.3](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.5.2...v1.5.3) (2020-12-12)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.25.1 to 1.27.0 ([9717038](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/9717038f5d601a2039afbf8efecb514dd5734e9a))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.25.1 to 1.27.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.25.1...v1.27.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.5.2](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.5.1...v1.5.2) (2020-12-11)

#### Bug Fixes

* **HowToGuides:** apply document styling guidelines ([2c4a99f](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/2c4a99f66a57e24fd3290d776c483864aad876c7))
  > The document style guidelines have been updated and now have been applied to the guides in this repo.

### [1.5.1](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.5.0...v1.5.1) (2020-11-01)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.25.0 to 1.25.1 ([525daee](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/525daee52467112553591cc38f341a47a04d81b9))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.25.0 to 1.25.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.25.0...v1.25.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

## [1.5.0](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.4.5...v1.5.0) (2020-10-02)

#### Features

* **Haptics:** add ability to access haptic profiles on linked aliases ([30654c8](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/30654c801f8ce79ca46bb9c0f1b92f421d39d04a))
  > The 1.25.0 version of Zinnia allows the LinkedAliasAssociationCollection to specify a collection of haptic profiles and this update allows the TrackedAliasFacade to directly call these profiles via simple public methods.
  > 
  > This allows for different haptic outputs to be described within the various CamerRigs and can be called for various situations.

### [1.4.5](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.4.4...v1.4.5) (2020-08-29)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.23.0 to 1.24.0 ([9923312](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/99233125dfedc692407f99fa292edeac4cc123f8))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.23.0 to 1.24.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.23.0...v1.24.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.4.4](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.4.3...v1.4.4) (2020-08-15)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.22.0 to 1.23.0 ([6d158b9](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/6d158b967231f5adab755d7caa725412b5d16679))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.22.0 to 1.23.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.22.0...v1.23.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.4.3](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.4.2...v1.4.3) (2020-08-14)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.21.0 to 1.22.0 ([9da1bb4](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/9da1bb4f6642f8c52dc6cf18be8739cd288d24c5))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.21.0 to 1.22.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.21.0...v1.22.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.4.2](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.4.1...v1.4.2) (2020-07-28)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.20.0 to 1.21.0 ([c64066b](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/c64066bed1d55f5fe1d8f776c9e6584cb8e8a470))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.20.0 to 1.21.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.20.0...v1.21.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.4.1](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.4.0...v1.4.1) (2020-07-11)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.19.0 to 1.20.0 ([dd35113](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/dd351133396bb9df0bfda2ebbf3b8825f52763a6))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.19.0 to 1.20.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.19.0...v1.20.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

## [1.4.0](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.3.1...v1.4.0) (2020-07-03)

#### Features

* **API:** add auto-generated API documentation ([897fa18](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/897fa186d5c1fd4c2a53f4268ff97cda5a5608c3))
  > The API documentation is auto generated with docfx and converted to markdown via turndown in a custom nodejs script.

#### Bug Fixes

* **package.json:** add docfx.json file ([eead73c](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/eead73c20a17aa38248634589b9fcbb13d0e97ca))
  > The docfx.json file was missing from the package.json causing the build process to fail. It has now been added.

### [1.3.1](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.3.0...v1.3.1) (2020-06-21)

#### Bug Fixes

* **Documentation:** apply style guidelines ([957487d](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/957487d8c7e17aaa4ed1accf0348d1b3255394f9))
  > The guide has had the style guidelines applied to it to make it more consistent.

## [1.3.0](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.2.2...v1.3.0) (2020-06-08)

#### Features

* **prefab:** emit event when linked tracked alias changes ([244459d](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/244459d448970c966bd2b4d340d0836b4d15946c))
  > A new event is emitted when the linked Tracked Alias changes based on the knowledge that the headset alias follow source changes.

### [1.2.2](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.2.1...v1.2.2) (2020-06-08)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.18.0 to 1.19.0 ([1a8c8b4](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/1a8c8b48ce96a792176e85aeee7cdee2a836100b))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.18.0 to 1.19.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.18.0...v1.19.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.2.1](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.2.0...v1.2.1) (2020-05-31)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.17.1 to 1.18.0 ([49872a6](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/49872a6541b8b44de792bfeed9d322187ec34b73))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.17.1 to 1.18.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.17.1...v1.18.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

## [1.2.0](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.1.5...v1.2.0) (2020-05-28)

#### Features

* **Prefab:** add headset origin GameObject within PlayArea Alias ([78d1f6e](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/78d1f6ea4b4c3123c9c61d763146bbd6880a41b6))
  > The Headset Origin GameObject is a child of the PlayArea Alias GameObject and follows around the headset location. This new origin can be used as a pivot point when dealing with offsetting play area rotations.

### [1.1.5](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.1.4...v1.1.5) (2020-05-22)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.17.0 to 1.17.1 ([19b97b1](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/19b97b19f9f5e5acc063c477cb7e9dfcaf273ca6))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.17.0 to 1.17.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.17.0...v1.17.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.4](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.1.3...v1.1.4) (2020-05-22)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.16.0 to 1.17.0 ([804b74f](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/804b74f5d40d6b4ebfc0b7ac7e43ee89b7178bb9))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.16.0 to 1.17.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.16.0...v1.17.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.3](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.1.2...v1.1.3) (2020-04-21)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.15.0 to 1.16.0 ([c4623fc](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/c4623fcac0cb3e25a766f607cce0c731a08b7ea5))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.15.0 to 1.16.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.15.0...v1.16.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.2](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.1.1...v1.1.2) (2020-04-14)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.14.1 to 1.15.0 ([5fbd237](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/5fbd237fe3393ca7d952aa2f31a81ec8bb9a8369))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.14.1 to 1.15.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.14.1...v1.15.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.1](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.1.0...v1.1.1) (2020-04-03)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.14.0 to 1.14.1 ([828070a](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/828070af2f6878a20a29b1d09b7d0c6eee55e500))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.14.0 to 1.14.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.14.0...v1.14.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

## [1.1.0](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.0.9...v1.1.0) (2020-03-04)

#### Features

* **Facade:** expose linked haptic processes ([a908de4](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/a908de47a40383588d219d63bce3fd92b27e2f12))
  > It is now possible to provide references to the  haptic processes that are provided to the linked alias associations.
* **Facade:** utilize linked alias headset supplement cameras ([8f78187](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/8f7818752e73a6a9037d4808706b07d18f2bdac3))
  > The LinkedAliasAssociationCollection now has the ability of providing a list of additional supplement cameras associated to the headset.
  > 
  > The TrackedAlias now utilizes this additional list and adds them to the valid scene cameras.

### [1.0.9](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.0.8...v1.0.9) (2020-03-04)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.12.0 to 1.14.0 ([171f868](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/171f868d1db32670e270947faca1b7f0b6e58b83))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.12.0 to 1.14.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.12.0...v1.14.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.8](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.0.7...v1.0.8) (2020-02-24)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.11.0 to 1.12.0 ([4f60219](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/4f602192240da9e1896b23d5827dbcd58a368560))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.11.0 to 1.12.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.11.0...v1.12.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.7](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.0.6...v1.0.7) (2020-01-02)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.9.0 to 1.11.0 ([9af9218](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/9af921814ace6864b7abe37f520e7d93aacaae0c))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.9.0 to 1.11.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.9.0...v1.11.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.6](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.0.5...v1.0.6) (2019-12-02)

#### Bug Fixes

* **Facade:** remove isPlaying check from change handler ([8be4188](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/8be4188d0711b7d3146c5cba15306139bb55220c))
  > There was an issue with Malimbe where change handler properties were running at edit time which would cause issues with the setup of the prefab. The original solution was to add in an isPlaying check to prevent this. A Malimbe fix has now been pushed so the latest version of Zinnia now contains the fix in Malimbe and therefore this check is now no longer required.

### [1.0.5](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.0.4...v1.0.5) (2019-12-02)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.8.1 to 1.9.0 ([2c66ff0](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/2c66ff002c5eca959602622bb6d3e9d32f73ecf8))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.8.1 to 1.9.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.8.1...v1.9.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.4](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.0.3...v1.0.4) (2019-11-27)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.8.0 to 1.8.1 ([c5ed829](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/c5ed829369d3ccce3fda50e81bac7f7c210437ec))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.8.0 to 1.8.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.8.0...v1.8.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.3](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.0.2...v1.0.3) (2019-11-07)

#### Bug Fixes

* **Prefab:** update prefab name to include namespace ([7a1b9a3](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/7a1b9a318bb5ba0eb2bbb855c756288af5e07220))
  > The Tilia prefabs are always prefixed by their namespace for easier identification, however the TrackedAlias was missing this prefix.
  > 
  > This has now been renamed and all of the documentation has been updated to reflect the name change.

### [1.0.2](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.0.1...v1.0.2) (2019-11-07)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.7.0 to 1.8.0 ([4075632](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/4075632ab041abea825a9c4ad45ff416d6472eb1))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.7.0 to 1.8.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.7.0...v1.8.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.1](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/compare/v1.0.0...v1.0.1) (2019-11-07)

#### Bug Fixes

* **HowToGuides:** provide correct package name in installation guide ([eeee49d](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/eeee49dc94286aaeb4198972fa1c7e5bd85f692e))
  > The package name does not include dots and therefore should be written without any dot separators.

## 1.0.0 (2019-11-07)

#### Features

* **structure:** create initial prefab and user guides ([b361c77](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/b361c770c3763f7a6a432047c2310a65a6358a87))
  > The structure of the repository has been created with all the required files for the package, the prefab and the documentation.

#### Bug Fixes

* **HowToGuides:** add missing meta file for image ([8ed4b84](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/8ed4b84441fca0c87c2863be305ed5a3b95c6d70))
  > There was a missing image .meta file which will cause the build to break. It has been auto generated by Unity and added now.
* **package.json:** remove erroneous comma from dependencies list ([b41402f](https://github.com/ExtendRealityLtd/Tilia.CameraRigs.TrackedAlias.Unity/commit/b41402fbe26d69b3f654db1ab90a882b34246389))
  > The comma at the end of the dependencies list is not valid and will cause the build to fail.
