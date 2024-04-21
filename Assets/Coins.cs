
using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    [SerializeField] private Text CoinCount;
    [SerializeField] private int coins;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Coins")
        {
            coins++;
            CoinCount.text = coins.ToString();
            Destroy(other.gameObject);
        }
    }
}
