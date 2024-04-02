
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;


public class InSceneVideo : MonoBehaviour
{
    //the name of the vide fle. Include Extension. No extra spaces or stange characters
    public string videoFileName;

    //the name of the scene to load at the end of the video (needs to be added to the build setting)
    public string scenetoLoad;

    //
    public bool LoadSceneAfterMovieEnds = false;
    


    // Start is called before the first frame update
    void Start()
    {
        PlayVideo();
    }

    public void PlayVideo()
    {
        VideoPlayer videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.url = System.IO.Path.Combine(Application.streamingAssetsPath, videoFileName);
        videoPlayer.Play();

//Load level at the end of the movie
        if (LoadSceneAfterMovieEnds)
        {
            videoPlayer.loopPointReached += LoadScene;
        }
    }

    //Load Level from video
    void LoadScene(UnityEngine.Video.VideoPlayer vp)
    {
        //load specific level
        SceneManager.LoadScene(scenetoLoad);

    }

}
