using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//5個のint型の配列arrayを宣言して初期化
		int[] heights = {170,175,160,180,150};
		//配列の各要素の値を順番に表示
		for (int i = 0; i < heights.Length; i++) {
			Debug.Log (heights [i]);
		}
		//配列の各要素を逆に表示
		int length = heights.Length - 1;
		for (int i = length; i >= 0; i--) {
			Debug.Log (heights [i]);
		}
		//↓発展課題
		Boss boss = new Boss();
		for (int i = 11; i > 0; i--) {
			boss.Magic ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
