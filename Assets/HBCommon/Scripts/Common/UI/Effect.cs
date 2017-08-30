using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class Effect : MonoBehaviour {
	public abstract void Show(UnityAction _callback = null);
	public abstract void Hide(UnityAction _callback = null);
}
