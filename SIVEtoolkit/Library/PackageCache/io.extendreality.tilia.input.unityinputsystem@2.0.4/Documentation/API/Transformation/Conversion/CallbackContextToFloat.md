# Class CallbackContextToFloat

Transforms a InputAction.CallbackContext to a System.Single.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Methods]
  * [Process(InputAction.CallbackContext)]

## Details

##### Inheritance

* System.Object
* [CallbackContextTransformer]<System.Single, [CallbackContextToFloat.UnityEvent]\>
* CallbackContextToFloat

##### Inherited Members

[CallbackContextTransformer<Single, CallbackContextToFloat.UnityEvent>.ContextToProcess]

[CallbackContextTransformer<Single, CallbackContextToFloat.UnityEvent>.ProcessResult(InputAction.CallbackContext)]

##### Namespace

* [Tilia.Input.UnityInputSystem.Transformation.Conversion]

##### Syntax

```
public class CallbackContextToFloat : CallbackContextTransformer<float, CallbackContextToFloat.UnityEvent>
```

### Methods

#### Process(InputAction.CallbackContext)

Transforms the given input InputAction.CallbackContext to the equivalent System.Single value.

##### Declaration

```
protected override float Process(InputAction.CallbackContext input)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InputAction.CallbackContext | input | The value to transform. |

##### Returns

| Type | Description |
| --- | --- |
| System.Single | The transformed value. |

[CallbackContextTransformer]: CallbackContextTransformer-2.md
[CallbackContextToFloat.UnityEvent]: CallbackContextToFloat.UnityEvent.md
[CallbackContextTransformer<Single, CallbackContextToFloat.UnityEvent>.ContextToProcess]: CallbackContextTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_CallbackContextTransformer_2_ContextToProcess
[CallbackContextTransformer<Single, CallbackContextToFloat.UnityEvent>.ProcessResult(InputAction.CallbackContext)]: CallbackContextTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_CallbackContextTransformer_2_ProcessResult_InputAction_CallbackContext_
[Tilia.Input.UnityInputSystem.Transformation.Conversion]: README.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Methods]: #Methods
[Process(InputAction.CallbackContext)]: #ProcessInputAction.CallbackContext
