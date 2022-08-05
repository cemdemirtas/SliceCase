using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Gold : MonoBehaviour
{
    public static Gold Instance;
    public int goldAmount;
   [SerializeField] TextMeshProUGUI goldtxt;
    private void Awake()
    {
        if (Instance==null)
        {
            Instance = this;
        }
    }
    public void takeGold(int award)
    {
        goldAmount += award;
        goldtxt.text = goldAmount.ToString();
    }

}
