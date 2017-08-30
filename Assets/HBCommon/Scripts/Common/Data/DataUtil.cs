using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataUtil : MonoBehaviour {

	protected class DataDefault
	{
		public const string STRING_DEFAULT = "";
		public const int INT_DEFAULT = 0;
		public const float FLOAT_DEFAULT = 0f;
		public const bool BOOL_DEFAULT = false;
	}
	protected class Bool
	{
		public const int False = 0;
		public const int True = 1;
	}
	public static int GetInt(string _key, int _defaultValue = DataDefault.INT_DEFAULT)
	{
		return PlayerPrefs.GetInt(_key, _defaultValue);
	}
	public static float GetFloat(string _key, float _defaultValue = DataDefault.FLOAT_DEFAULT)
	{
		return PlayerPrefs.GetFloat(_key, _defaultValue);
	}
	public static string GetString(string _key, string _defaultValue = DataDefault.STRING_DEFAULT)
	{
		return PlayerPrefs.GetString(_key, _defaultValue);
	}	
	public static bool GetBool(string _key, bool _defaultValue = DataDefault.BOOL_DEFAULT)
	{
		int intValue = GetInt(_key,(_defaultValue? Bool.True : Bool.False));
		return intValue == Bool.True;
	}
	public static void Save(string _key,int _value)
	{
		PlayerPrefs.SetInt(_key,_value);
	}
	public static void Save(string _key, float _value)
	{
		PlayerPrefs.SetFloat(_key,_value);
	}
	public static void Save(string _key, string _value)
	{
		PlayerPrefs.SetString(_key,_value);
	}
	public static void Save(string _key, bool _value)
	{
		Save(_key,(_value? Bool.True : Bool.False));
	}
	
	public static void Delete(string _key)
	{
		PlayerPrefs.DeleteKey(_key);
	}
	public static void DeleteAll()
	{
		PlayerPrefs.DeleteAll();
	}
	public static bool ContainKey(string _key)
	{
		return PlayerPrefs.HasKey(_key);
	}
}
