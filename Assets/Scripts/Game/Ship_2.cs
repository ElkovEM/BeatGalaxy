using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_2 : MonoBehaviour
{
    public GameObject firstPrefab; // ������ �� ������ ������
    public GameObject newObject; // ������ �� ����� ������

    private void OnTriggerEnter2D(Collider2D collider)
    {

            // ������� ����� ������ � ������� ��� ������
        Instantiate(newObject, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Destroy(collider.gameObject);

    }

}
