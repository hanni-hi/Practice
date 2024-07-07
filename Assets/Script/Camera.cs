using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player; // �÷��̾��� Transform�� �Ҵ��մϴ�.
    public Vector3 offset = new Vector3(0, 5, -5); // ī�޶�� �÷��̾� ������ �Ÿ�

    private void LateUpdate()
    {
        // ī�޶��� ��ġ�� �÷��̾��� ��ġ + ���������� �����մϴ�.
        transform.position = player.position + offset;
        // ī�޶� �׻� �÷��̾ �ٶ󺸰� �����մϴ�.
        transform.LookAt(player);
    }


}
