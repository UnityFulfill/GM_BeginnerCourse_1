using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);
    void Update()
    {
        // 1. MoveTowars (단순 등속 이동)
        // transform.position = Vector3.MoveTowards(transform.position, target, 0.1f);

        // 2. SmoothDamp (미끄러지듯이 감속 이동)
        // Vector3 velo = Vector3.zero;
        // transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.01f);

        // 3. Lerp (선형 보간)
        // transform.position = Vector3.Lerp(transform.position, target, 0.1f);

        // 4. Slerp (구면 선형 보간)
        // transform.position = Vector3.Slerp(transform.position, target, 0.1f);
    }
}
