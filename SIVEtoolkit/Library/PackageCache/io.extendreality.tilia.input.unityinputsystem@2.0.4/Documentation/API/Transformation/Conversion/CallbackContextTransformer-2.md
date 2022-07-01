# Class CallbackContextTransformer<TOutput, TEvent>

Provides an abstract base to transform a given InputAction.CallbackContext to the TOutput data type.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [ContextToProcess]
* [Methods]
  * [ProcessResult(InputAction.CallbackContext)]

## Details

##### Inheritance

* System.Object
* CallbackContextTransformer<TOutput, TEvent>
* [CallbackContextToBoolean]
* [CallbackContextToFloat]
* [CallbackContextToVector2]
* [CallbackContextToVector3]

##### Namespace

* [Tilia.Input.UnityInputSystem.Transformation.Conversion]

##### Syntax

```
public abstract class CallbackContextTransformer<TOutput, TEvent> : Transformer<InputAction.CallbackContext, TOutput, TEvent> where TEvent : UnityEvent<TOutput>, new()
```

##### Type Parameters

| Name | Description |
| --- | --- |
| TOutput | The variable type that will be output from the result of the transformation. |
| TEvent | The UnityEvent type the transformation will emit. |

### Properties

#### ContextToProcess

The [CallbackContextTransformer<TOutput, TEvent>.ContextType] event to process the transformation for.

##### Declaration

```
public CallbackContextTransformer<TOutput, TEvent>.ContextType ContextToProcess { get; set; }
```

### Methods

#### ProcessResult(InputAction.CallbackContext)

Processes the given input into the output result as long as the context event is allowed to be processed based on the [ContextToProcess] value.

##### Declaration

```
protected override TOutput ProcessResult(InputAction.CallbackContext input)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InputAction.CallbackContext | input | The value to transform. |

##### Returns

| Type | Description |
| --- | --- |
| TOutput | The transformed value. |

[CallbackContextToBoolean]: CallbackContextToBoolean.md
[CallbackContextToFloat]: CallbackContextToFloat.md
[CallbackContextToVector2]: CallbackContextToVector2.md
[CallbackContextToVector3]: CallbackContextToVector3.md
[Tilia.Input.UnityInputSystem.Transformation.Conversion]: README.md
[CallbackContextTransformer<TOutput, TEvent>.ContextType]: CallbackContextTransformer-2.ContextType.md
[CallbackContextTransformer.ContextType]: CallbackContextTransformer-2.ContextType.md
[ContextToProcess]: CallbackContextTransformer-2.md#Tilia_Input_UnityInputSystem_Transformation_Conversion_CallbackContextTransformer_2_ContextToProcess
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[ContextToProcess]: #ContextToProcess
[Methods]: #Methods
[ProcessResult(InputAction.CallbackContext)]: #ProcessResultInputAction.CallbackContext
