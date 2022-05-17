

using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityEngine.UI;

 [System.Serializable]
public class PTCconnect : MonoBehaviour {

 private float nextActionTime = 0.0f;
 public float period = 0.00f;
 public string textGameObject;


    void Start() {
     //   StartCoroutine(GetText());
   }

  
    IEnumerator GetText() {
  UnityWebRequest www = UnityWebRequest.Get("http://10.90.22.13:8080/Thingworx/Things/UPPE/Properties/TIT-102-FF");
                                             
             www.SetRequestHeader("Content-Type", "application/JSON");
             www.SetRequestHeader("Accept", "application/JSON");
             www.SetRequestHeader("x-thingworx-session", "true");
             www.SetRequestHeader("appKey", "635bd18c-cd4d-48e7-a7ee-f0a6c4c94c04");

        yield return www.SendWebRequest();
 
        if (www.result != UnityWebRequest.Result.Success) {
            
        }
        else {
            // Show results as text
          //  Debug.Log(www.downloadHandler.text);
 
            // Or retrieve results as binary data
            string results = www.downloadHandler.text;
            string result2 =  results[195] + "" + results[196] + "" + results[197] + "" + results[198] + "" + results[199];
            Debug.Log(result2);

          Text txtMy = GameObject.Find ("Canvas/Text").GetComponent<Text>();
          txtMy.text = result2;
     
    }


 }

 void Update () {

     if (Time.time > nextActionTime ) {
        nextActionTime += period;
       StartCoroutine(GetText());
        

     }
 }




}



 

             