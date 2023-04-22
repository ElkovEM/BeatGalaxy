using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_3 : MonoBehaviour
{
    public int health, attackPower;
    public float moveSpeed;

    private const float TIMER_MAX_TIME = 1f; //����� �������
    private float timerCurrentTime = TIMER_MAX_TIME;

    public Animator animator;
    public float attackInterval;

    void Update()
    {
        if (timerCurrentTime > 0)
        {
            timerCurrentTime -= Time.deltaTime; //��������� ���������� ����������
        }
        else
        {
            timerCurrentTime = TIMER_MAX_TIME; //������� �������
            Move(); //��������� ��� ��������� ������ ����������
        }
    }

    //Moving forward
    void Move()
    {
        transform.Translate(-transform.up * moveSpeed);
    }

    public void LoseHealth_3()
    {
        health--;
        if (health <= 0)
            Destroy(gameObject);
    }

}