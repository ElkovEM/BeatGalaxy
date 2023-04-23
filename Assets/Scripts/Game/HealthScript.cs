using UnityEngine;

public class HealthScript : MonoBehaviour
{
    public int health; // ��������� �������� ��������
    public int damageAmount; // ���������� �����

    public void Damage(int damageAmount)
    {
        health -= damageAmount; // �������� ���������� ����� �� ��������
        if (health <= 0)
        {
            Die(); // ���� �������� ������ ��� ����� ����, �������
        }
    }

    private void Die()
    {
        // �������������� �������� ��� ������ �������, ���� �����
        Destroy(gameObject); // ���������� ������
    }

    void OnCollisionEnter2D(Collision2D other)
    {

       
    }
}