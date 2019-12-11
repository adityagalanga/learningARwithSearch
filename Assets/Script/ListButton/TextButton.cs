using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextButton : MonoBehaviour
{
    public Text ObjectName;
    public GameObject targetImageObj;

    public AudioSource AudioObj;
    public Text ObjNameView;

    public void spawnObject()
    {
        ObjNameView.text = ObjectName.text;
        string linkObj = "Object/" + ObjectName.text;
        string linkAudio = "Sound/" + ObjectName.text;
        AudioObj.clip = Resources.Load(linkAudio, typeof(AudioClip)) as AudioClip;
        GameObject Object = Resources.Load(linkObj,typeof(GameObject)) as GameObject;
        GameObject ActiveObject = Instantiate(Object,targetImageObj.transform ) as GameObject;
        ActiveObject.tag = "OnActiveObject";
        GameObject.FindWithTag("GameController").GetComponent<OnObjectSelected>().backToSearch();
    }
}
