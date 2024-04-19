
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private Text CoinCount;
    [SerializeField] private int Coins;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Coins")
        {
            Coins++;
            CoinCount.text = Coins.ToString();
            Destroy(other.gameObject);
        }
    }
}
