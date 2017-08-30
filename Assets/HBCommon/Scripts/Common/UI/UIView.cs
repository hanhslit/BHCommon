using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[System.Serializable]
public abstract class UIView : MonoBehaviour {

	protected UnityAction onOpened;
	protected UnityAction onClosed;
	protected Effect effect;
	public virtual void SetData(object _param, UnityAction _openCallback = null, UnityAction _closeCallback = null)
	{
		if (effect == null)
		{
			effect = gameObject.GetComponent<Effect>();
		}
		if (_openCallback != null)
		{
			onOpened = _openCallback;
		}
		if (_closeCallback != null)
		{
			onClosed = _closeCallback;
		}
	}
	public virtual void Show()
	{
		if (effect != null)
		{
			effect.Show(OnOpened);
		}
		else
		{
			gameObject.SetActive(true);
			OnOpened();		
		}
	}	
	public virtual void Hide()
	{
		if (effect != null)
		{
			effect.Hide(OnClosed);
		}
		else
		{
			gameObject.SetActive(false);
			OnClosed();
		}
	}
	protected virtual void OnOpened()
	{
		if (onOpened != null)
		{
			onOpened.Invoke();
		}
	}
	protected virtual void OnClosed()
	{
		if (onClosed != null)
		{
			onClosed.Invoke();
		}
	}
}
