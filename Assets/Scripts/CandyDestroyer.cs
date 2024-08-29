using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyDestroyer : MonoBehaviour
{
    public CandyManager candyManager;
    public int reward;
    public GameObject effectPrefab;
    public Vector3 effectRotation;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Candy")
        {
            // 指定数だけCandyのストックを増やす          
            candyManager.AddCandy(reward);

            // オブジェクトの削除
            Destroy(other.gameObject);

            if (effectPrefab != null)
            {
                // Candyが落下した場合、エフェクトを発生させる。
                Instantiate(effectPrefab, other.transform.position, Quaternion.Euler(effectRotation)
                );
            }
        }
    }
}