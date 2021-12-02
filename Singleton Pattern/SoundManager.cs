using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum eBGM
{
    None
}

public enum eEffect
{
    None
}

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance = null;

    [SerializeField]
    private AudioClip[] m_bgmClips = null;
    
    [SerializeField]
    private AudioClip[] m_effectClips = null;

    private AudioClip m_bgmPlayer = null;


    private void Start()
    {
        if(instance == null)
        {
            instance = this;
        }

        m_bgmPlayer = this.GetComponent<AudioSource>();
    }


    public void PlayBgmSound(eBGM a_type)
    {
        m_bgmPlayer.clip = m_bgmClips[(int)a_type];
        m_bgmPlayer.Play();
    }


    public void PlayEffectSound(eEffect a_type)
    {
        AudioSource AS = new GameObject("EffectSound").AddComponent<AudioSource>();

        AS.Clip = m_effectClips[(int)a_type];
        AS.Play();
    }
}