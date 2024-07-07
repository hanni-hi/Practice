using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player; // 플레이어의 Transform을 할당합니다.
    public Vector3 offset = new Vector3(0, 5, -5); // 카메라와 플레이어 사이의 거리

    private void LateUpdate()
    {
        // 카메라의 위치를 플레이어의 위치 + 오프셋으로 설정합니다.
        transform.position = player.position + offset;
        // 카메라가 항상 플레이어를 바라보게 설정합니다.
        transform.LookAt(player);
    }


}
