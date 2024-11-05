using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CounterPresents : MonoBehaviour
{
    [SerializeField] private TMP_Text _redText;
    [SerializeField] private TMP_Text _greenText;
    [SerializeField] private TMP_Text _blueText;

    public void OnPresentChange(Color color, int count)
    {
        Debug.Log(color);
        Debug.Log(count);
            if(color.CompareRGB(Color.red)) _redText.text = (int.Parse(_redText.text) + count).ToString(); 
            else if(color.CompareRGB(Color.green)) _greenText.text = (int.Parse(_greenText.text) + count).ToString(); 
            else if(color.CompareRGB(Color.blue)) _blueText.text = (int.Parse(_blueText.text) + count).ToString(); 
        
    }


}
