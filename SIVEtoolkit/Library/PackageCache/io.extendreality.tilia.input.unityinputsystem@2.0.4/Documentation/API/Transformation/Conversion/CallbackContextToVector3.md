# Class CallbackContextToVector3

Transforms a InputAction.CallbackContext to a Vector3.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Methods]
  * [Process(InputAction.CallbackContext)]

## Details

##### Inheritance

* System.Object
* [CallbackContextTransformer]<Vector3, [CallbackContextToVector3.UnityEvent]\>
* CallbackContextToVector3

##### Inherited Members

[CallbackContextTransformer<Vector3, CallbackContextToVector3.UnityEvent>.ContextToProcess]

[CallbackContextTransformer<Vector3, CallbackContextToVector3.UnityEvent>.ProcessResult(InputAction.CallbackContext)]

##### Namespace

* [Tilia.Input.UnityInputSystem.Transformation.Conversion]

##### Syntax

```
public class CallbackContextToVector3 : CallbackContextTransformer<Vector3, CallbackContextToVector3.UnityEvent>
```

### Methods

#### Process(InputAction.CallbackContext)

Transforms the given input InputAction.CallbackContext to the equivalent Vector3 value.

##### Declaration

```
protected override Vector3 Process(InputAction.CallbackContext input)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InputAction.CallbackContext | input | The value to transform. |

##### Returns

| Type | Description |
| --- | --- |
| Vector3 | The transformed value. |

[CallbackContextTransformer]: CallbackContextTransformer-2.md
[CallbackContextToVector3.UnityEvent]: CallbackContextToVector3.UnityEvent.md
[CallbackContextTransformer<Vector3, CallbackContextToVector3.UnityEvent>.ContextToProcess]: CallbackContextTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_CallbackContextTransformer_2_ContextToProcess
[CallbackContextTransformer<Vector3, CallbackContextToVector3.UnityEvent>.ProcessResult(InputAction.CallbackContext)]: CallbackContextTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_CallbackContextTransformer_2_ProcessResult_InputAction_CallbackContext_
[Tilia.Input.UnityInputSystem.Transformation.Conversion]: README.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Methods]: #Methods
[Process(InputAction.CallbackContext)]: #ProcessInputAction.CallbackContext
