using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CapsuleScore : MonoBehaviour
{
    [SerializeField] private TextMeshPro tmp;
    private int counter = 0;
    public void counterInc()
    {
        counter++;
        tmp.text = counter.ToString();
    }
}
