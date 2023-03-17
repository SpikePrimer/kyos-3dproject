using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
=======
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{

    public void PlayTheGameNow()
    {
        SceneManager.LoadScene(1);
>>>>>>> e85897d43467c69d1671c89508ef54c56a3f853d
    }
}
