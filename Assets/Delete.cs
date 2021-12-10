using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{

    //Unityちゃんのオブジェクト
    private GameObject unitychan;
    //Unityちゃんとカメラの距離
    private float difference2;

    // Start is called before the first frame update
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
        //Unityちゃんとカメラの位置の差を求める
        this.difference2 = unitychan.transform.position.z - this.transform.position.z;

    }

    // Update is called once per frame
    void Update()
    {
        //Unityちゃんに合わせてCubeを移動
        this.transform.position = new Vector3(0, 0, this.unitychan.transform.position.z-difference2);
    }

    //トリガーモードで他のオブジェクトと接触した場合の処理
    void OnTriggerEnter(Collider other)
    {
        //Coinに衝突した場合
        if(other.gameObject.tag == "CoinTag")
        {
            //接触したコインオブジェクトを破棄
            Destroy(other.gameObject);
        }
        //Carに衝突した場合
        else if(other.gameObject.tag == "CarTag")
        {
            //接触したコインオブジェクトを破棄
            Destroy(other.gameObject);
        }
        //Coneに衝突した場合
        else if(other.gameObject.tag == "TrafficConeTag")
        {
            //接触したコインオブジェクトを破棄
            Destroy(other.gameObject);
        }
    }
}