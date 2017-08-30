using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class Dialog : UIView {
	protected UnityAction onConfirm;
	protected UnityAction onCancel;
	[SerializeField]
	private Text txtTitle;
	[SerializeField]
	private Text txtMessage;
	[SerializeField]
	private Button confirmButton;
	[SerializeField]
	private Button cancelButton;
	[SerializeField]
	private Text txtConfirmButton;
	[SerializeField]
	private Text txtCancelButton;
	public void SetData(string _title,string _message, UnityAction _okAction = null, UnityAction _cancelAction = null)
	{
		if (_okAction != null)
		{
			onConfirm = _okAction;
		}
		else
			confirmButton.gameObject.SetActive(false);

		if (_cancelAction != null)
		{
			onCancel = _cancelAction;
		}else
			cancelButton.gameObject.SetActive(false);
	}
	public void SetTextConfirmButton(string _text)
	{
		txtConfirmButton.text = _text;
	}
	public void SetActiveConfirmButton(bool _value)
	{
		confirmButton.gameObject.SetActive(_value);
	}
	public void SetActiveCancelButton(bool _value)
	{
		cancelButton.gameObject.SetActive(_value);
	}
	public void SetTextCancelButton(string _text)
	{
		txtCancelButton.text = _text;
	}
	protected override void OnOpened()
	{
		base.OnOpened();
	}
	protected override void OnClosed()
	{
		base.OnClosed();		
	}
	private void OnConfirmBtnClick()
	{
		onClosed = onConfirm;	
		Hide();
	}
	private void OnCancelBtnClick()
	{
		onClosed = onCancel;
		Hide();
	}
}
