using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine.UI;
using TMPro;

 [System.Serializable]
    public class UnityWebRequest : MonoBehaviour {

    private float nextActionTime = 0.0f;
    public float period = 0.1f;
 
public TextMeshPro Text;  

    void Start() {

        Text = FindObjectOfType<TextMeshPro>();

   }

    IEnumerator GetText() {
       
       UnityWebRequest www = UnityWebRequest.Get("xxx");

             www.SetRequestHeader("Content-Type", "application/JSON");
             www.SetRequestHeader("Accept", "application/JSON");
             www.SetRequestHeader("x-thingworx-session", "true");
             www.SetRequestHeader("appKey", "xxx");

        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success) {
            
        }
        else {
            string results = www.downloadHandler.text;
            string result2 =  results[195] + "" + results[196] + "" + results[197] + "" + results[198];
            Text.text = result2;
            
    }

 }

 void Update () {

    StartCoroutine(GetText());
      
 }

}



 

             
