using UnityEngine;
using System.Collections;

public class Buy : MonoBehaviour {

	// Use this for initialization
	void Start () {//開始方法
        Debug.Log("你好 my C# unity project");
        //Unity 提供的方法 可以輸出一組文字 

        string 紙條 = "去幫我買pizza";
        int 奶茶數量 = 2;
        float 奶茶甜度 = 0.3f;
        bool 要切 = false; //pizza 是否要切 是否?

        Debug.Log(紙條);

        int pizza張數 = 3;

        Debug.Log("我要"+pizza張數 + "張pizza");

        string 口味 = "海鮮總匯";
        Debug.Log("老闆我要" + 口味 + "口味的pizza" + pizza張數 +"張");

        Debug.Log("還有" + 奶茶數量 + "杯奶茶");
        Debug.Log("奶茶甜度" + 奶茶甜度);

        if(要切)
        {
            Debug.Log("阿對了 老闆 我的pizza要切");
        }
        else
        {
            Debug.Log("阿對了 老闆 我的pizza不要切");
        }



	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
