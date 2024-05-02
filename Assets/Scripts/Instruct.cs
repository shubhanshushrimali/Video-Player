using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class Instruct : MonoBehaviour
{
    // refrences 
    [SerializeField]Button gotit1;
    [SerializeField]Button gotit2;
    [SerializeField]Button gotit3;
    [SerializeField]GameObject TO;
    [SerializeField]GameObject TOA;
    [SerializeField]GameObject DD;
    [SerializeField]GameObject DDA;
    [SerializeField] GameObject pauseplay;
    [SerializeField] GameObject pauseplayarrow;
    [SerializeField] GameObject forwardarrow;
    [SerializeField] GameObject backwardarrow;  

    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    // first next button 
    public void Next1()
    {
        gotit1.gameObject.SetActive(false);
        TOA.SetActive(false);
        TO.SetActive(false); 
        DDA.SetActive(false);
        DD.SetActive(false);
        pauseplay.SetActive(true);
        pauseplayarrow.SetActive(true);
        gotit2.gameObject.SetActive(true); 
        
    }

    //second next button 
    public void Next2() 
    {
        gotit2.gameObject.SetActive(false);
        pauseplay.SetActive(false);
        pauseplayarrow.SetActive(false);
        forwardarrow.SetActive(true);
        backwardarrow.SetActive(true);  
        gotit3.gameObject.SetActive(true);
    }

    // third next button 
    public void Next3() 
    {
        SceneManager.LoadScene(1); 
      
    }
}
