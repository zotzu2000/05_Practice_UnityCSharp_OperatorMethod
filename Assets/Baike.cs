
using UnityEngine;
using UnityEngine.UI;   // 引用 介面 API  using UnityEngine.UI;
using System;

public class Baike : MonoBehaviour  //建立蝙蝠腳本
{
    //定義欄位
    // 文字欄位  public Text result;
    [Header("血量")]
    public int Hp;          //血量
    [Header("攻擊力")]
    public int Attack;      //攻擊力
    [Header("治癒量")]
    public int AddHp;       //治癒量
    //[Header("顯示訊息")]
    //public Text Word;     //顯示訊息(文字介面)
    //[Header("史萊姆")]
    //public Slimo Slimo;    //史萊姆
    
    public void Att()    //1. 攻擊 - 呼叫史萊姆受傷方法並將攻擊力傳遞給史萊姆
    {
        
    }
    public void SubHp()     //2. 受傷 - 帶有一個接收傷害值的參數、扣血、顯示訊息
    {

    }
    public void Add()     //3. 治癒 - 補血、顯示訊息
    {

    }
    //4. 套用腳本製蝙蝠物件上
    //5. 史萊姆同上

    //文字要換行可以使用跳脫字元 “\n”
    // 換行   result.text = "第一行" + "\n" + "第二行";
}
