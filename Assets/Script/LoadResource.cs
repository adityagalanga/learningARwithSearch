using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadResource : MonoBehaviour
{
    public SearchObject searchObjectclass;
    public GameObject sampleListButton;
    Object[] obj;

    void Start()
    {
        obj = Resources.LoadAll("Object/");
        StartCoroutine(makebutton());
    }

    IEnumerator makebutton()
    {
        Debug.Log("asup");
        foreach(Object objName in obj)
        {
            GameObject list = Instantiate(sampleListButton,sampleListButton.transform.parent) as GameObject;
            list.GetComponent<TextButton>().ObjectName.text = objName.name;
            list.SetActive(true);
            list.tag = "listButton";
            list.name = objName.name;
            searchObjectclass.listButtonObject.Add(list);
        }
        return null;
    }
    
    
}
