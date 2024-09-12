using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollisdion : MonoBehaviour
{
    [SerializeField] int coinValue = 1;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        GameManager.instance.IncreaseScore(coinValue);
        Destroy(gameObject);
    }
}
