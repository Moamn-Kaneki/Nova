using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Video;


public class ClimateVideo : MonoBehaviour
{
    VideoPlayer videoPlayer;
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }
    private void Update()
    {
        if (videoPlayer.isPaused)
        {
            SceneManager.LoadScene("TreeTempSim");
        }
    }
}
