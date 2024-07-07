using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float swingSpeed = 5;
    public float swingAngle = 45;

    private bool isSwinging = false;
    private float startAngle;
    private float targetAngle;
    private float currentAngle;
    private float swingDirection=1f;

    void Start()
    {
        startAngle = transform.localEulerAngles.y;
        currentAngle = startAngle;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isSwinging)
        {
            isSwinging = true;
            targetAngle = startAngle + swingAngle * swingDirection;
        }

        if(isSwinging)
        {
            currentAngle = Mathf.MoveTowards(currentAngle, targetAngle, swingSpeed * Time.deltaTime);
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, currentAngle, transform.localEulerAngles.z);
        if(Mathf.Approximately(currentAngle,targetAngle))
            {
                swingDirection *= -1f;
                targetAngle = startAngle + swingAngle * swingDirection;
                isSwinging = false;
            }
        }
        }
}
