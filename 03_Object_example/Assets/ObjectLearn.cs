using UnityEngine;
using System.Collections;

public class ObjectLearn : MonoBehaviour {

    //捨麼是人類
    class 人類
    {
        //屬性
        public string 稱號;
        public int 胃容量 = 100;
        //方法(行為)1
        public void 報上大名()
        {
            Debug.Log(稱號 + "的大名你沒有聽過嗎 哇哈哈!!!");
        }

        //方法(行為)2
        public void 吃東西(店家 某個店家)
        {
            int 剩餘胃容量 = 胃容量 - 20;
            某個店家.產品數量 -= 1;
            Debug.Log(稱號 + "吃了一份" + 某個店家.產品名);
            Debug.Log(稱號 + "的胃容量" + 剩餘胃容量 + "%");
            Debug.Log(某個店家.產品名 + "的數量:" + 某個店家.產品數量);
        }
    }

    class 店家
    {
        //屬性
        public string 店家名;
        public string 產品名;
        public int 產品數量;
        //方法(行為)
        public void 吆喝()
        {
            Debug.Log(店家名 + "的老闆吆喝著: " + "好吃的" + 產品名 +"裡面坐喔~~");
        }
        
    }

	// Use this for initialization
	void Start () {

        人類 周晏玲 = new 人類();//生出一個"人類"物件
        
        周晏玲.稱號 = "大胃王";
        周晏玲.報上大名();


        店家 臭豆腐店 = new 店家();
        臭豆腐店.店家名 = "阿春臭豆腐";
        臭豆腐店.產品名 = "臭豆腐";
        臭豆腐店.產品數量 = 30;

        臭豆腐店.吆喝();


        周晏玲.吃東西(臭豆腐店);//Object Name

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
