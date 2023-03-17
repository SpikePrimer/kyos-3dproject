using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class script : MonoBehaviour
{
    public GameObject Keytext;
    public GameObject garage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
           this.GetComponent<Collider>().enabled = false;
            this.GetComponent<Renderer>().enabled = false;
            StartCoroutine(keyText());
            garage.GetComponent<Collider>().enabled = false;
            garage.GetComponent<Renderer>().enabled = false;
        }
    }

    IEnumerator keyText()
    {
        Keytext.GetComponent<Text>().enabled = true; 
        yield return new WaitForSeconds(2f);
        Keytext.GetComponent<Text>().enabled = false;
    }
}
