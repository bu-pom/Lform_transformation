using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    private float[] RandomFloatArray = new float[3]; // 配列の作成
    public float scaleShift = 0.001f; // 移動量の調製
    public float scaleRotate = 1.5f; // 回転量の調製


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 乱数を配列に入れる
        RandomFloatArray[0] = Random.Range(-0.1f, 0.1f);
        RandomFloatArray[1] = Random.Range(-0.1f, 0.1f);
        RandomFloatArray[2] = Random.Range(-1.0f, 1.0f);
        
        // オブジェクトを、乱数分だけ移動、回転
        transform.position += new Vector3(RandomFloatArray[0], RandomFloatArray[1], 0) * scaleShift;
        transform.Rotate(0, 0, RandomFloatArray[2] * scaleRotate);

    }

    
}
