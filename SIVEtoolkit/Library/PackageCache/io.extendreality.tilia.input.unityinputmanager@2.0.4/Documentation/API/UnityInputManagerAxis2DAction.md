# Class UnityInputManagerAxis2DAction

Listens for the specified axes and emits the appropriate action.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [XAxisName]
  * [XMultiplier]
  * [YAxisName]
  * [YMultiplier]
* [Methods]
  * [Process()]
* [Implements]

## Details

##### Inheritance

* System.Object
* UnityInputManagerAxis2DAction

##### Implements

IProcessable

##### Namespace

* [Tilia.Input.UnityInputManager]

##### Syntax

```
public class UnityInputManagerAxis2DAction : Vector2Action, IProcessable
```

### Properties

#### XAxisName

The named x axis to listen for state changes on.

##### Declaration

```
public string XAxisName { get; set; }
```

#### XMultiplier

Multiplies the x axis value.

##### Declaration

```
public float XMultiplier { get; set; }
```

#### YAxisName

The named y axis to listen for state changes on.

##### Declaration

```
public string YAxisName { get; set; }
```

#### YMultiplier

Multiplies the y axis value.

##### Declaration

```
public float YMultiplier { get; set; }
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
[XAxisName]: #XAxisName
[XMultiplier]: #XMultiplier
[YAxisName]: #YAxisName
[YMultiplier]: #YMultiplier
[Methods]: #Methods
[Process()]: #Process
[Implements]: #Implements
