# Class UnityInputManagerAxis1DAction

Listens for the specified axis and emits the appropriate action.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [AxisName]
  * [Multiplier]
* [Methods]
  * [Process()]
* [Implements]

## Details

##### Inheritance

* System.Object
* UnityInputManagerAxis1DAction

##### Implements

IProcessable

##### Namespace

* [Tilia.Input.UnityInputManager]

##### Syntax

```
public class UnityInputManagerAxis1DAction : FloatAction, IProcessable
```

### Properties

#### AxisName

The named axis to listen for state changes on.

##### Declaration

```
public string AxisName { get; set; }
```

#### Multiplier

Multiplies the axis value.

##### Declaration

```
public float Multiplier { get; set; }
```

### Methods

#### Process()

##### Declaration

```
public void Process()
```

### Implements

IProcessable

[Tilia.Input.UnityInputManager]: README.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[AxisName]: #AxisName
[Multiplier]: #Multiplier
[Methods]: #Methods
[Process()]: #Process
[Implements]: #Implements
