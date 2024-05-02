using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Video;

public class VPController : MonoBehaviour
{ //variables & refrence 
    private VideoPlayer Vplayer;
    public Button playbut;
    public Button turnOn;
    public Button pausebut;
    public Button forward10sec;
    public Button backward10sec;
    public VideoClip[] videoClips;
    [SerializeField]public GameObject galleryDropdown;




    void Awake()
    {
        Vplayer = GetComponent<VideoPlayer>();
       

    }

    void Start()
    {
        
    }


    void Update()
    {

    }

    // for the playing functionality of the video 
    public void Play()
    {
        Vplayer.Play();
        playbut.gameObject.SetActive(false);
        pausebut.gameObject.SetActive(true);


    }

    // for the pausing functionality of the video 
    public void Pause()
    { 
        Vplayer.Pause();
        pausebut.gameObject.SetActive(false);
        playbut.gameObject.SetActive(true);
    }

    // for the forward of the clip 
    public void Forward10Seconds()
    {
        Vplayer.time += 10.0f;
    }

    // for the backward of the clip 
    public void Backward10Seconds()
    {
        Vplayer.time -= 10.0f;
    }
 
    // turn on button functionality 
    public void TurnOnTheVideoPlayer()
    {
        galleryDropdown.SetActive(true);
        Vplayer.clip = videoClips[0];       
        Vplayer.Play();
        turnOn.gameObject.SetActive(false);
        pausebut.gameObject.SetActive(true);    

    }
     
    // for the clip selection 
    public void PlaySelectedVideo(int selectedIndex)
    {
       
        if (selectedIndex >= 0 && selectedIndex < videoClips.Length)
        {
            Vplayer.clip = videoClips[selectedIndex];
            Vplayer.Play();
        }
    }
}