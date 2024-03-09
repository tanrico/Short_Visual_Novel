using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    public VideoPlayer player;
    public GameObject scenePrev;
    public GameObject sceneNext;

    // Start is called before the first frame update
    void Start()
    {
        sceneNext.SetActive(false);

        player = GetComponent<VideoPlayer>();
        player.loopPointReached += VideoFinished;
    }



    // Update is called once per frame
    void Update()
    {

    }

    void VideoFinished(VideoPlayer vp)
    {
        Debug.Log("video finished");
        sceneNext.SetActive(true);
        scenePrev.SetActive(false);
    }
}
