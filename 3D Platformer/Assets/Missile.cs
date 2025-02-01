using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position +=
        transform.forward *
        speed * Time.deltaTime;
    }
    public void OnTriggerEnter(Collider other)
    {
        //����������� �����
        Enemy enemy = other.GetComponent<Enemy>();
        Destroy(enemy.gameObject);

        //����������� �������
        Destroy(gameObject);
    }
}