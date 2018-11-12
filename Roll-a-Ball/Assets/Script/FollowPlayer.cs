using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
    public Transform target; // ターゲットへの参照
    private Vector3 offset; // 相対位置

    private void Start()
    {
        // 自分自身とtargetとの相対距離を求める
        offset = GetComponent<Transform>().position - target.position;
    }

    private void Update(){
        // 自分の座表にtargetの座標を代入する
        GetComponent<Transform>().position = target.position + offset;
    }

}
