using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoEndHandler : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public RawImage rawImage;

    void Start()
    {
        if (videoPlayer != null)
        {
            videoPlayer.loopPointReached += OnVideoEnd;
        }
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        if (rawImage != null)
        {
            rawImage.gameObject.SetActive(false);
        }
    }
}
