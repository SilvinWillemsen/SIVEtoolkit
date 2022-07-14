# Creating Proxy Actions And Chaining Actions

> * Level: Beginner
>
> * Reading Time: 5 minutes
>
> * Checked with: Unity 2018.3.14f1

## Introduction

It is sometimes desirable to have many different input actions all have the same outcome. It is possible to simply do this by wiring up all of the events in all of the actions to have the same output, however this can get cumbersome and hard to maintain.

The [Zinnia] Actions can be used as proxies to enable chaining of Actions to all drive the same outcome defined in one place.

Following on from the scene created in [Using The Unity Button Action], we’re going to move the Action functionality to a Proxy Action and then chain the button press Action and keyboard Action to this newly created Proxy Action. This will move our output functionality into one place and allow us to call it from many different actions.

### Prerequisites 

* [Add the Tilia.Input.UnityInputManager -> Input.UnityInputManager.ButtonAction] prefab to the scene hierarchy.

## Let's Start

### Step 1

Create an empty `GameObject` in the Unity Hierarchy window and rename it to `FloorToggler` then click the `Add Component` button and select the `Boolean Action` component.
This newly created `Boolean Action` will be the action that defines how we toggle the active state of the `Floor` GameObject.

![Creating The Floor Toggler](assets/images/CreatingTheFloorToggler.png)

### Step 2

Click the `+` symbol in the bottom right corner of the `Activated` event parameter in the `Boolean Action` component and then drag and drop the `Floor` GameObject into the box that appears and displays `None (Object)`.

![Creating The Boolean](assets/images/CreatingTheBoolean.png)

Select a `Function` to perform when the `Activated` event is emitted. For this example, select `GameObject -> SetActive(bool)` (be sure not to select `Dynamic bool - SetActive` for this example).

![Set Activated Listener To Game Object SetActive Action](assets/images/SetActivatedListenerToGameObjectSetActiveAction.png)

### Step 3

Do the same as [Step 2] but for the `Deactivated` event parameter in the `Boolean Action` component, but tick the checkbox under the `GameObject.SetActive` function.

![Deactivating The Boolean](assets/images/DeactivatingTheBoolean.png)

### Step 4

Now we have a generic Action that will disable the `Floor` GameObject when the Action receives `true` and will re-enable the `Floor` GameObject when the Action receives `false`.

We could hook up the `Unity Input Manager Button Action` `Value Changed` event to simply call the `Receive` method on our `FloorToggler` GameObject `BooleanAction` component and this will pass the state of the `Unity Input Manager Button Action` over to the `Boolean Action` whenever the value changes. However, doing this means for every input action, we’d need to wire up their `Value Changed` event to point to the `Receive` method on our `BooleanAction` component. This can again get very cumbersome and hard to maintain, so instead we’re going to use the `Sources` parameter that is available on a `Zinnia.Action.`

The `Sources` parameter allows us to specify other Actions for our `BooleanAction` to monitor changes on and re-emit any events that happen on those source actions.

Expand the `Sources` parameter and enter the desired number of other Actions to monitor in the `Size` parameter field. In this example, we want to watch two other Actions (the `Input.UnityInputManager.ButtonAction` and the `Input.UnityInputManager.XboxController -> Input Actions -> ButtonA_Press[0]`) so enter `2` into the `Size` parameter field.

> The size property will be `0` by default, so change it to `2`.

![Update Sources Parameter On Boolean Action](assets/images/UpdateSourcesParameterOnBooleanAction.png)

### Step 5 

Drag and drop the `Input.UnityInputManager.ButtonAction` GameObject into the `Sources -> Size -> Element 0` slot on the `FloorToggler` GameObject `BooleanAction` component.

> This will link the `Input.UnityInputManager.ButtonAction` `BooleanAction` component as a source value for the `FloorToggler` `BooleanAction` component, which means whenever the `Input.UnityInputManager.ButtonAction` `BooleanAction` component value changes then it will automatically send that updated value to the `FloorToggler` `BooleanAction` component.

Drag and drop the `Input.UnityInputManager.XboxController -> Input Actions -> ButtonA_Press[0]` GameObject that contains the `Unity Input Manager Button Action` component that is working with the Xbox Controller A Button into the `Sources -> Size -> Element` 1 slot on the `FloorToggler` GameObject `BooleanAction` component as well.

![Drag and Drop Source Actions](assets/images/DragAndDropSourceActions.png)

### Step 6 

The `Unity Input Manager Button Action` events still have actions to perform when either the Space Key is pressed or the Xbox Controller A Button is pressed, we no longer need those actions on those `Unity Input Manager Button Action` components now as they are being chained to our new `FloorToggler` GameObject `BooleanAction` component. So let’s remove the event listeners from the other `Unity Input Manager Button Action` components.

Select the `Input.UnityInputManager.XboxController -> Input Actions -> ButtonA_Press[0]` GameObject and click the `-` symbol in the bottom right corner of the `Activated` event parameter and the `Deactivated` event parameter on the `Unity Input Manager Button Action` component. This will remove those event listeners and make this `Unity Input Manager Button Action` component an Action that on its own does nothing other than listen for button presses on the Xbox Controller A Button.

![Remove Event Listeners From The Xbox Controller A Button](assets/images/RemoveEventListenersFromTheXboxControllerAButton.png)

Let’s do the same with the `Unity Input Manager Button Action` component on the `Input.UnityInputManager.ButtonAction` GameObject that is set up to listen for the Space Key press. Select the `Input.UnityInputManager.ButtonAction` GameObject and click the `-` symbol in the bottom right corner of the `Activated` event parameter and the `Deactivated` event parameter on the `Unity Input Manager Button Action` component.

![Remove Event Listeners From The Space Key.png](assets/images/RemoveEventListenersFromTheSpaceKey.png)

### Done

There is now a single defined action in the scene that controls the active state of the `Floor` GameObject and we’ve hooked up two other actions that deal with listening for input from the Space Key and the Xbox Controller Button A to perform the output action of toggling the floor state.

This ability to create a Proxy Action and then chain other Actions makes it possible to drive a single output Action based on multiple different input Actions.

Play the Unity scene and you will be able to press the Space Key to make the `Floor` GameObject disappear or you can press the Xbox Controller Button A to also make the `Floor` GameObject disappear.

[Zinnia]: https://github.com/ExtendRealityLtd/Zinnia.Unity
[Using The Unity Button Action]: ../UsingTheUnityButtonAction/README.md
[Add the Tilia.Input.UnityInputManager -> Input.UnityInputManager.ButtonAction]: ../UsingTheUnityButtonAction/README.md
[Step 2]: #Step-2