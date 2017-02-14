using UnityEngine;
using System.Collections;

public class loopLearn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	//班上有五位同學你喜歡第四個同學
        //                 A        C
        for(int i=1 ;   i<=4    ;   i++)
        {   //B
            if (i == 4)
                Debug.Log("for_情書給第"+i+"個同學");
            
        }

        int w = 1;
        while( w <=4 )
        {
            Debug.Log("while_情書傳給第"+ w +"位同學");
            w++;
        }

        int d = 1;

        do
        {
            Debug.Log("do_while_情書傳給第" + d + "位同學");
            d++;
        }
        while (d<=4);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
