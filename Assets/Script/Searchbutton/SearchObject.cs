using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SearchObject : MonoBehaviour
{
    public List<GameObject> listButtonObject = new List<GameObject>();
    public InputField searchBar;
    public GameObject searchResult;

    public void onSearch()
    {
        if (searchBar.text == "")
        {
            searchResult.SetActive(true);
            foreach (GameObject prefab in listButtonObject)
            {
                    prefab.SetActive(true);
            }
        }
        else
        {
            searchResult.SetActive(true);
            foreach(GameObject prefab in listButtonObject)
            {
                if (prefab.name.Contains(searchBar.text))
                {
                    prefab.SetActive(true);
                }
                else
                {
                    prefab.SetActive(false);
                }

            }
        }
    }
}
