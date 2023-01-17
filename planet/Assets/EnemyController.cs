using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public PlayerHP playerHP;
    public PlayerGold playerGold;

    void Awake()
    {
        
    }

    public void AttackEnemy(int Damage)
    {
        playerHP.GetComponent<PlayerHP>().TakeDamage(Damage);
    }

    public void KillEnemy(int Gold)
    {
        playerGold.GetComponent<PlayerGold>().TakeGold(Gold);
    }
}
