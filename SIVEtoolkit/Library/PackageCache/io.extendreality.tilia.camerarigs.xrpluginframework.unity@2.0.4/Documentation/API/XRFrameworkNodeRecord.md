# Class XRFrameworkNodeRecord

Provides the description for a XR Plugin Framework CameraRig node element.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [NodeType]
  * [Priority]
  * [XRNodeType]
* [Methods]
  * [SetNodeType(Int32)]

## Details

##### Inheritance

* System.Object
* XRFrameworkNodeRecord

##### Namespace

* [Tilia.CameraRigs.XRPluginFramework]

##### Syntax

```
public class XRFrameworkNodeRecord : BaseDeviceDetailsRecord
```

### Properties

#### NodeType

The Node Type for the record.

##### Declaration

```
public XRNode NodeType { get; set; }
```

#### Priority

##### Declaration

```
public override int Priority { get; protected set; }
```

#### XRNodeType

##### Declaration

```
public override XRNode XRNodeType { get; protected set; }
```

### Methods

#### SetNodeType(Int32)

Sets the [NodeType].

##### Declaration

```
public virtual void SetNodeType(int index)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| System.Int32 | index | The index of the XRNode. |

[Tilia.CameraRigs.XRPluginFramework]: README.md
[NodeType]: XRFrameworkNodeRecord.md#NodeType
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[NodeType]: #NodeType
[Priority]: #Priority
[XRNodeType]: #XRNodeType
[Methods]: #Methods
[SetNodeType(Int32)]: #SetNodeTypeInt32
