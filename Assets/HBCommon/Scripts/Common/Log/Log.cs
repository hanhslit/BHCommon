﻿
using UnityEngine;
using System.Diagnostics;
using Debug = UnityEngine.Debug;


public class Log
{
	[Conditional("ENABLE_LOG")]
	public static void Info(object message)
	{
		Debug.Log("Info : " + message);
	}

	[Conditional("ENABLE_LOG")]
	public static void Warning(object message)
	{
		Debug.LogWarning("Warning : " + message);
	}

	[Conditional("ENABLE_LOG")]
	public static void Error(object message)
	{
		Debug.LogError("Error : " + message);
	}
}