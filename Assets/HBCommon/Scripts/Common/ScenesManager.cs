using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScenesManager : Singleton<ScenesManager> {
	[SerializeField]
	private UIView loadingView;
	public void LoadScene(string _sceneName,bool _isLoading = false)
	{
		if (!_isLoading)
		{
			SceneManager.LoadScene(_sceneName);
		}
		else
			StartCoroutine(LoadSceneIE(_sceneName));
	}
	IEnumerator LoadSceneIE(string _sceneName)
	{
		yield return new WaitForEndOfFrame();
		loadingView.SetData(0);
		loadingView.Show();
		AsyncOperation async = SceneManager.LoadSceneAsync(_sceneName);
		async.allowSceneActivation = false;
		while (!async.isDone)
		{
			loadingView.SetData(async.progress);
			if (async.progress == 0.9f)
			{				
				yield return new WaitForSeconds(1);
				loadingView.SetData(1,null,()=> { async.allowSceneActivation = true; });
				loadingView.Hide();
				yield return null;				
			}
			yield return null;
		}
	}
}
