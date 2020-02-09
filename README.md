## Introduction

A NotificationCenterManager object (or simply, notification center) provides a mechanism for broadcasting information within a program. A NotificationCenterManager object is essentially a notification dispatch table.

Objects register with a notification center to receive notifications (Notification objects) using the AddObserver method. Each invocation of this method specifies a set of notifications. Therefore, objects may register as observers of different notification sets by calling these methods several times.

Each running C# program has a default notification center. You typically don’t create your own. A NotificationCenterManager object can deliver notifications only within a single program. 

## Background

There can be a few conflicting techniques to solve a problem. Any can be chosen to achieve your goal. However, sometimes I want to know what can fit better for this and that. One of those conflicting techniques are Events (using delegates) and Notification in a same process or a task. An Event is to have an object that fires an event when it's happened. Notification is to send an alarm to a monitoring object if something happens. For both, a monitoring object should be registered to some entities. So, mostly they are very similar.

But Notification is free form to be connected to another object. For example the mains form can send a notification to a User Control inside in another User Control without no connection between them.
