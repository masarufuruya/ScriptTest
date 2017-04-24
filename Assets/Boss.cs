using System.Collections;
using UnityEngine;

public class Boss : MonoBehaviour {
	//体力
	private int hp;
	//攻撃力
	private int power = 10;
	//魔力
	private int mp = 53;

	//攻撃
	public void Attack() {
		Debug.Log (this.power + "のダメージを与えた");
	}

	//魔法攻撃
	public void Magic() {
		if ((this.mp - 5) < 0) {
			Debug.Log ("MPが足りないため魔法が使えない。");
			return;
		}
		this.mp -= 5;
		Debug.Log ("魔法攻撃をした。残りMPは" + this.mp + "。");
	}

	//防御
	public void Defence(int damage) {
		Debug.Log (damage + "のダメージを受けた");
		this.hp -= damage;
	}
}
