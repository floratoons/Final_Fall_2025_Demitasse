using UnityEngine;
using TMPro;

public class WalletManager : MonoBehaviour
{
    public int cash;

    public void calcCash(int money)
    {
        cash += money;
        GetComponent<TextMeshProUGUI>().text = "Credit card debt: -" + cash.ToString();
    }

    public void cashReceive()
    {
        Debug.Log("Bought an object");
    }

}

