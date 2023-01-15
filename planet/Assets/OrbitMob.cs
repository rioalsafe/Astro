using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitMob : MonoBehaviour
{
    public GameObject target;
    public float moveSpeed;
    public Vector3 direction = Vector3.up;
    public PlayerHP player;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, direction, moveSpeed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Colliderd " + collision.name);
        player.GetComponent<PlayerHP>().TakeDamage(1);
        // 뭐에 충돌했는지를 인지를 못함 if 문 쓰면 될듯
    }
}
