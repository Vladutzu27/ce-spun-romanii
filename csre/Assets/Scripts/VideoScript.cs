using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video; // Required to use VideoPlayer

public class VideoScript : MonoBehaviour
{
    // Reference to the cone GameObject with the VideoPlayer component
    public GameObject cone;

    public static VideoScript instance;

    void Awake() {  instance = this; }

    // Define the clip variables publicly so you can assign them in the Editor
    public VideoClip clip1;
    public VideoClip clip2;
    public VideoClip clip3;
    public VideoClip clip4;
    public VideoClip clip5;
    public VideoClip clip6;

    public VideoPlayer videoPlayer;
    

    // Start is called before the first frame update
    void Start()
    {
        // Get the VideoPlayer component from the cone GameObject
        videoPlayer = cone.GetComponent<VideoPlayer>();

        // Optionally, start by playing the first video clip
        videoPlayer.clip = clip1;
        videoPlayer.Play();
    }

    // Function to switch video clips
    public void ChangeVideoClip(string videoName)
    {
        videoPlayer.Stop(); // Stop current video
        videoPlayer.url = System.IO.Path.Combine (Application.streamingAssetsPath,videoName); 
        videoPlayer.Play(); // Play the new clip
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void PlayIt()
    {
        videoPlayer.Play();
    }
}
