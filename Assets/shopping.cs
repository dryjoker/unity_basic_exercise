using UnityEngine;
using System.Collections;

public class shopping : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string 產品名稱 = "好折凳";
        string 產品別稱 = "七大武器之首";

        Debug.Log("主持人:各位觀眾 走過別錯過");
        Debug.Log("主持人:今天介紹" + 產品名稱 + "也就是傳說中的" + 產品別稱 + "他的特色有....");

        Color 顧客喜好顏色 = Color.blue;
        Color 折凳顏色 = Color.blue;//藍色
        //Unity內建提供的顏色

        int 顧客需要的大小 = 90;
        int 折凳寬 = 90;


        if (顧客喜好顏色 == 折凳顏色 || 顧客需要的大小 < 折凳寬 )
        {
            Debug.Log("顧客:我要買這個折凳 這個顏色我喜歡");
        }
        else
        {
            Debug.Log("顧客: 我不感興趣");
        }

        int 產品價格 = 540;
        int 其他同類產品最低價 = 550;
        bool 產品多用途 = true;
        string 產品品牌 = "牛頭牌";

        //  600         550                 true
        if(產品價格 < 其他同類產品最低價 && 產品多用途)
        {
            Debug.Log("龜毛顧客: 多方考慮後買下"+ 產品名稱 + "會很划算");
        }
        else
        {
            Debug.Log("龜毛顧客: 我不要買這了");
        }
        

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
