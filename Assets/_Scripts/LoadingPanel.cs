using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class LoadingPanel : UIView {
	[SerializeField]
	private Text txtLoadingProgress;
	[SerializeField]
	private Slider sliderLoadingProgress;
	public override void SetData(object _param, UnityAction _openCallback = null, UnityAction _closeCallback = null)
	{
		base.SetData(_param, _openCallback, _closeCallback);
		float progress = float.Parse(_param.ToString());
		float progressPercen = progress * 100f;
		Debug.Log(progressPercen);
		txtLoadingProgress.text = string.Format("{0} %",progressPercen); ;
		sliderLoadingProgress.value = progress;
	}
}
