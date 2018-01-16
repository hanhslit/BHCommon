using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class EventDispatcherExtension {

    /// Use for registering with EventsManager
    public static void RegisterListener(this MonoBehaviour listener, int eventID, UnityAction<object> callback)
    {
        EventDispatcher.Instance.RegisterListener(eventID, callback);
    }

    /// Post event with param
    public static void PostEvent(this MonoBehaviour listener, int eventID, object param)
    {
        EventDispatcher.Instance.PostEvent(eventID, param);
    }

    /// Post event with no param (param = null)
    public static void PostEvent(this MonoBehaviour sender, int eventID)
    {
        EventDispatcher.Instance.PostEvent(eventID, null);
    }
}
