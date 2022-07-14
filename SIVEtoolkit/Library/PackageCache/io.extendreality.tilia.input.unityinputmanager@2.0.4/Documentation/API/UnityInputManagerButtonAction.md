# Class UnityInputManagerButtonAction

Listens for the specified [KeyCode] state and emits the appropriate action.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [KeyCode]
* [Methods]
  * [Process()]
* [Implements]

## Details

##### Inheritance

* System.Object
* UnityInputManagerButtonAction

##### Implements

IProcessable

##### Namespace

* [Tilia.Input.UnityInputManager]

##### Syntax

```
public class UnityInputManagerButtonAction : BooleanAction, IProcessable
```

### Properties

#### KeyCode

The UnityEngine.KeyCode to listen for state changes on.

##### Declaration

```
public KeyCode KeyCode { get; set; }
```

### Methods

#### Process()

##### Declaration

```
public void Process()
```

### Implements

IProcessable

[KeyCode]: UnityInputManagerButtonAction.md#KeyCode
[Tilia.Input.UnityInputManager]: README.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[KeyCode]: #KeyCode
[Methods]: #Methods
[Process()]: #Process
[Implements]: #Implements
