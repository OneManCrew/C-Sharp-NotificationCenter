## Introduction

A NotificationCenterManager object (or simply, notification center) provides a mechanism for broadcasting information within a program. A NotificationCenterManager object is essentially a notification dispatch table.

Objects register with a notification center to receive notifications (Notification objects) using the AddObserver method. Each invocation of this method specifies a set of notifications. Therefore, objects may register as observers of different notification sets by calling these methods several times.

Each running C# program has a default notification center. You typically don’t create your own. A NotificationCenterManager object can deliver notifications only within a single program. 

## Background

There can be a few conflicting techniques to solve a problem. Any can be chosen to achieve your goal. However, sometimes I want to know what can fit better for this and that. One of those conflicting techniques are Events (using delegates) and Notification in a same process or a task. An Event is to have an object that fires an event when it's happened. Notification is to send an alarm to a monitoring object if something happens. For both, a monitoring object should be registered to some entities. So, mostly they are very similar.

## Using the code
But Notification is free form to be connected to another object. For example the mains form can send a notification to a User Control inside in another User Control without no connection between them.


First of all create a NotificationCenterManager object. NotificationCenterManager uses the Singleton pattern so get an instance like his:
```
using NotificationCenter;
NotificationCenterManager notificationCenterManager = NotificationCenterManager.Instance;
```
Next use the NotificationCenterManager instance to register to Notification with the method AddObserver:
```
public class Observer
{
    public Observer()
    {
        NotificationCenterManager notificationCenterManager = NotificationCenterManager.Instance;
        notificationCenterManager.AddObserver(OnNotification, 
           "SomeNotification");// register to Notification "SomeNotification".
    }
    private void OnNotification(Notification p_notification)
    {
        DoSomething();
    }
}
```
Next use the NotificationCenterManager instance to post  a Notification with "Empty Message" with the method PostNotification:
```
NotificationCenterManager.Instance.PostNotification("SomeNotification ");
// Post Notification "SomeNotification".
```
Use the NotificationCenterManager instance to post a Notification with "Notification Message" with the method PostNotification:
```
Notification notification=new Notification(this,"Some Object With Message");
NotificationCenterManager.Instance.PostNotification("SomeNotification", notification);
// Post Notification "SomeNotification".
```
To remove matching entries from the receiver’s dispatch table use the NotificationCenterManager instance to unregister from 
Notification with the method RemoveObserver:
```
NotificationCenterManager.Instance.RemoveObserver(OnNotification, "SomeNotification");
// OnNotification is the delegate to the Observer.
```
