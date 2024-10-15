using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMPlayer : MonoBehaviour
{
    public AudioClip bgmClip; // �������ڲ��ŵı�������

    private AudioSource bgmSource; // AudioSource������ڲ�������

    void Start()
    {
        // ��ȡ�����AudioSource���
        bgmSource = GetComponent<AudioSource>();
        if (bgmSource == null)
        {
            bgmSource = gameObject.AddComponent<AudioSource>();
        }

        // ���ñ�������
        bgmSource.clip = bgmClip;
        bgmSource.loop = true; // ����Ϊѭ������

        // ���ű�������
        bgmSource.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }

}