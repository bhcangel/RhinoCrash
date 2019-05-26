using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour {

    GameObject hpGauge; 
	// Use this for initialization
	void Start () {
        this.hpGauge = GameObject.Find("hpGauge");
	}
	
	public void DecreaseHp()
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
        Debug.Log("collision detected");
    }

    public void Dead()
    {
        SceneManager.LoadScene("DeadScene");
        MobController.Damaged_count = 0;
        mobGenerator.count = 0;
        ItemController.itemcount = 0;
    }
}
