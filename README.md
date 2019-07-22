# UnityDebugMsgSupport
====
## Overview
This code is for convenient use of Unity debug messages.

It also shows the name of the method and class that invoked the message.

## Install
Just put "DebugMsg.cs" in the Unity project.

## HowToUse
using DebugMsgSupport and call DebugMsg.Text()

## Example

```cs:DebugTestClass.cs

using UnityEngine;
using DebugMsgSupport;

public class DebugTestClass: MonoBehaviour
{
    void Start()
    {
        DebugMsg.Text("LogMessage",DebugMsg.MessageType.Log);
        DebugMsg.Text("WarningMessage",DebugMsg.MessageType.Warning);
        DebugMsg.Text("ErrorMessage",DebugMsg.MessageType.Error);
    }

}

```


