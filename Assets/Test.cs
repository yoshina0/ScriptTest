using System.Collections;
using System.Collections.Generic;
using UnityEngine;







public class Test : MonoBehaviour
{
    // 発展課題：Bossクラスに、変数mpとMagic関数を作成してStart関数から呼び出しましょう --ここから--
    public class Boss
    {
        private int mp = 53;

        public void Magic()
        {
            this.mp -= 5;
            if (mp + 5 >= 5)
            {
                Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
            }
            else
            {
                Debug.Log("MPが足りないため魔法が使えない。");
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Boss lastboss = new Boss();

        for (int i = 11; i > 0; i--)
        {
            lastboss.Magic();
        }
        // --ここまで--


        // 課題：配列を宣言して出力しましょう --ここから--
        int[] array = { 20, 30, 40, 50, 60 };

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
        // --ここまで--
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
