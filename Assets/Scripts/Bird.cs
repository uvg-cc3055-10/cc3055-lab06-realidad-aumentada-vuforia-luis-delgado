﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

    Animator anim;
    AudioSource audios;


	// Use this for initialization
	void Start () {
        //obtiene el animator y el audio source
        anim = GetComponent<Animator>();
        audios = GetComponent<AudioSource>();
	}


    void ResetHopInt()
    {
        anim.SetInteger("hop", 0);
    }

    void PlaySong()
    {
        audios.Play();
    }

}
