using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DialogManager : Singleton<DialogManager> {
	[SerializeField]
	private Dialog dialogView;
	public void ShowDialog(string _title, string _message,DialogType _type, UnityAction _okAction = null, UnityAction _cancelAction = null)
	{
		switch (_type)
		{
			case DialogType.None:
				dialogView.SetActiveCancelButton(false);
				dialogView.SetActiveConfirmButton(false);
				break;
			case DialogType.OkDialog:
				dialogView.SetTextConfirmButton("OK");
				dialogView.SetActiveCancelButton(false);
				dialogView.SetActiveConfirmButton(true);
				break;
			case DialogType.YesNoDialog:
				dialogView.SetTextConfirmButton("Yes");
				dialogView.SetTextCancelButton("No");
				dialogView.SetActiveCancelButton(true);
				dialogView.SetActiveConfirmButton(true);
				break;
			default:
				break;
		}
		dialogView.SetData(_title,_message,_okAction,_cancelAction);
		dialogView.Show();
	}
}