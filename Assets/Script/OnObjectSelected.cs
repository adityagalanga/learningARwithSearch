using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnObjectSelected : MonoBehaviour
{
    public GameObject panelSearch;
    public GameObject panelBack;

    public void backToSearch()
    {
        if (panelBack != null)
        {
            bool isActive = panelBack.activeSelf;
            panelBack.SetActive(!isActive);
            panelSearch.SetActive(isActive);
            if (isActive == true)
            {
                Destroy(GameObject.FindWithTag("OnActiveObject"));
            }
        }
    }
}
