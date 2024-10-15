using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMPlayer : MonoBehaviour
{
    public AudioClip bgmClip; // 定义用于播放的背景音乐

    private AudioSource bgmSource; // AudioSource组件用于播放音乐

    void Start()
    {
        // 获取或添加AudioSource组件
        bgmSource = GetComponent<AudioSource>();
        if (bgmSource == null)
        {
            bgmSource = gameObject.AddComponent<AudioSource>();
        }

        // 设置背景音乐
        bgmSource.clip = bgmClip;
        bgmSource.loop = true; // 设置为循环播放

        // 播放背景音乐
        bgmSource.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }

}