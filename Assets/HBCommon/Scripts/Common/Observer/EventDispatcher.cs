using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class EventDispatcher : Singleton<EventDispatcher> {

    private Dictionary<int, UnityAction<object>> listeners = new Dictionary<int, UnityAction<object>>();

    public void RegisterListener (int eventId,UnityAction<object> callback)
    {
        if (listeners.ContainsKey(eventId))
        {
            listeners[eventId] += callback;
        }else
        {
            listeners.Add(eventId, callback);
        }
    }

    public void RemoveListener(int eventId, UnityAction<object> callback)
    {
        if (listeners.ContainsKey(eventId))
        {
            listeners[eventId] -= callback;
        }
        else
        {
            Log.Warning("EventId not found");
        }
    }

    public void PostEvent(int eventId, object param = null)
    {
        if (listeners.ContainsKey(eventId))
        {
            var callback = listeners[eventId];
            if (callback != null)
            {
                callback.Invoke(param);
            }else
            {
                Log.Info("No listener this event "+eventId);
            }
        }
        else
        {
            Log.Warning("EventId not found");
        }
    }
}
