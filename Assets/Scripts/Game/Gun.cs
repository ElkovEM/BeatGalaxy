using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab; // ������ �������
    public float bulletSpeed = 10f; // �������� ������ �������
    public float fireRate = 20f; // �������� ����� ����������
    private float nextFireTime = 0f; // ����� ���������� ��������
    public float bulletOffset = 0.5f;

    private void Update()
    {
        if (Time.time >= nextFireTime)
        {
            nextFireTime = Time.time + fireRate; // ��������� ����� ���������� ��������
            Shoot(); // ����� ������ ��������
        }
    }

    private void Shoot()
    {
        Vector3 spawnPos = transform.position + transform.up * bulletOffset;

        // ������� ������ �� �������
        GameObject bullet = Instantiate(bulletPrefab, spawnPos, Quaternion.identity, transform.parent);

        // ���������� ������ ������
        bullet.GetComponent<Rigidbody2D>().velocity = transform.up * bulletSpeed;

        // ���������, ��� ������ �� ����� �� ������� �����
        if (bullet.transform.position.y > 80f)
        {
            Destroy(bullet);
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Enemy"))
        {
            collider.gameObject.GetComponent<Enemy_1>().LoseHealth();
            Destroy(bulletPrefab);
        }
    }
}