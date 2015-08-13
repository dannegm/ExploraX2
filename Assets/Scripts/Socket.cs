using UnityEngine;
using System.Collections;

public class Socket : MonoBehaviour {

	public static void emit (string name, string vlaue) {
		PlayerPrefs.SetString (name, vlaue);
	}

	public static string recieve (string name) {
		string value = PlayerPrefs.GetString (name, "undefined");
		PlayerPrefs.DeleteKey (name);
		return value;
	}

}
