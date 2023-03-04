using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteRandom : MonoBehaviour
{

    public float deleteTime; // オブジェクトを消去時間の定義

    // Start is called before the first frame update
    void Start()
    {
        deleteTime = Random.Range(3.5f,5.8f); // 消去する時間をランダムに設定
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void OnClick()
    {   
        Destroy(gameObject,deleteTime); // ボタンを押してからdeletetime後にオブジェクトを消す
    }

}
