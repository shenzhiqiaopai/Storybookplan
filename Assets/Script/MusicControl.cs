using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour
{
    private AudioSource audio;//定义声音组件
    public AudioClip Music;//放置音乐    

    // Start is called before the first frame update
    void Start()
    {
        audio = this.GetComponent<AudioSource>();//得到声音组件
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMusicControl()
{
    audio.clip = Music;
    if (audio.isPlaying == false)
    {
        audio.Play();
    }
    else
    {
        audio.Stop();
    }
}
}
