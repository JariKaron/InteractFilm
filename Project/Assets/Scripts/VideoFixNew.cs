using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoFixNew : MonoBehaviour
{
    public VideoPlayer theVideo;
    public string videoName;


    void Start()
    {
        theVideo.url = System.IO.Path.Combine (Application.streamingAssetsPath, videoName);
    }


}
