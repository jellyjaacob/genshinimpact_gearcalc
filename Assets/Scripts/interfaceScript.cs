using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class interfaceScript : MonoBehaviour
{

    public TMP_Dropdown sub1, sub2, sub3, sub4;
    public TMP_InputField subValue1, subValue2, subValue3, subValue4;

    public int percentATK, percentDEF, percentHP, flatATK, flatDEF, flatHP, CR, CD, EM, ER;
    public string percentATK1, percentDEF1, percentHP1, flatATK1, flatDEF1, flatHP1, CR1, CD1, EM1, ER1;
    public int value;

    public List<string> substatValue;



    // Start is called before the first frame update
    void Start()
    {
        assignGameObject();
        assignList();

    }

    void assignGameObject()
    {
        // assigns the dropdown and inputfields
        sub1 = GameObject.Find("Dropdown1").GetComponent<TMP_Dropdown>();
        sub2 = GameObject.Find("Dropdown2").GetComponent<TMP_Dropdown>();
        sub3 = GameObject.Find("Dropdown3").GetComponent<TMP_Dropdown>();
        sub4 = GameObject.Find("Dropdown4").GetComponent<TMP_Dropdown>();
        subValue1 = GameObject.Find("SubValue1").GetComponent<TMP_InputField>();
        subValue2 = GameObject.Find("SubValue2").GetComponent<TMP_InputField>();
        subValue3 = GameObject.Find("SubValue3").GetComponent<TMP_InputField>();
        subValue4 = GameObject.Find("SubValue4").GetComponent<TMP_InputField>();
    }

    void assignList()
    {
        List<TMP_Dropdown.OptionData> substatList = sub1.GetComponent<TMP_Dropdown>().options; // puts it into a list
        /* List<TMP_Dropdown.OptionData> substat2List = sub2.GetComponent<TMP_Dropdown>().options;
        List<TMP_Dropdown.OptionData> substat3List = sub3.GetComponent<TMP_Dropdown>().options;
        List<TMP_Dropdown.OptionData> substat4List = sub4.GetComponent<TMP_Dropdown>().options; */
    }
       
    void typeofSubstat()
    {
        
        int holder1 = sub1.GetComponent<TMP_Dropdown>().value;   // gets index

        switch (holder1)
        {
            //case 0:
                


        }
    }

    void calcPercentATK(TMP_InputField subValue)
    {
        int value = Convert.ToInt32(subValue.text);


    }

    void calculateGear()
    {
        // will calculate how much of the rolls if its maximum

        List<TMP_Dropdown.OptionData> substatList = sub1.GetComponent<TMP_Dropdown>().options; // puts it into a list
        // if substat name = a certain name, call that particular method to calculate the rolls

    }
}
