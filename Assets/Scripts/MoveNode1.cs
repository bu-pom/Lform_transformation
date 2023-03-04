using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D; // SpriteShapeControllerの使用のため追加

public class MoveNode1 : MonoBehaviour
{
    private bool isMove = false; // 動きの定義(true=動く、false＝動かない)

    public SpriteShapeController spriteShapeController; // SpriteshapeControllerの変数を定義
    public int index = 0; // Node番号の定義（適当な初期値）
    public int index1 = 1; // Node番号の定義（適当な初期値）、２つのNodeを動かすため追加
    private Spline spline;
    private Vector3 nodePosition; // indexで指定されるNodeを動かす位置の定義
    private Vector3 nodePosition1; // index1で指定されるNodeを動かす位置の定義
    private float shiftX, shiftY; // Nodeの移動量(x,y)

    // クリックするとfalseとtrueが変わる
    public void OnClick()
    {
        if (isMove == false)
        {
            isMove = true;
        }
        else if(isMove == true)
        {
            isMove = false;
        }
    }

    void Start()
    {
        spline = spriteShapeController.spline;
        nodePosition = spline.GetPosition(index); // indexで指定したNodeの位置を取得
        nodePosition1 = spline.GetPosition(index1); // index1で指定したNodeの位置を取得
    }

    void Update()
    {
        if(isMove == true)
        {
            spline.SetPosition(index, nodePosition); // indexで指定したNodeをnodePositionへ移動
            shiftX = Random.Range(-0.020f,-0.008f); // Nodeのx座標を動かす量をランダムに定義
            shiftY = Random.Range(-0.020f,-0.008f); // Nodeのy座標を動かす量をランダムに定義
            nodePosition += new Vector3(shiftX,shiftY,0); // nodePositionにshiftXとshiftY分可算

            spline.SetPosition(index1,nodePosition1);
            nodePosition1 += new Vector3(shiftX,shiftY,0);
        }
    }

}