using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoScript : MonoBehaviour
{
    public GameObject cone;
    public Video.VideoClip icsuri;
    
    // Start is called before the first frame update
    void Start()
    {
        var videoPlayer = cone.AddComponent<UnityEngine.Video.VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
