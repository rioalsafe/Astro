using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerGold : MonoBehaviour
{
   [SerializeField]
    private float startgold = 20;     // 최대 체력
    private float currentGold;      // 현재 체력

    public float Startgold => startgold;
    public float CurrentGold => currentGold;

    void Update()
    {
        
    }

    private void Awake()
    {
        currentGold = startgold;          // 현재 체력을 최대 체력과 같게 설정
    }

    public void TakeGold(int gold)
    {
        // 현재 체력을 damage만큼 감소
        currentGold += gold;
        Debug.Log("gold : " + currentGold);

        // 체력이 0이 되면 게임오버
        if (currentGold <= 0)
        {
        }
    }
}