using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tunecontroller : MonoBehaviour
{
    public AudioClip[] Musictunes;
    public AudioSource Mysource;
    public void Pianotune1()
    {
        Mysource.clip = Musictunes[0];
        Mysource.Play();
    }

    public void Pianotune2()
    {
        Mysource.clip = Musictunes[1];
        Mysource.Play();
    }

    public void Pianotune3()
    {
        Mysource.clip = Musictunes[2];
        Mysource.Play();
    }

    public void Guitartune1()
    {
        Mysource.clip = Musictunes[3];
        Mysource.Play();
    }

    public void Guitartune2()
    {
        Mysource.clip = Musictunes[4];
        Mysource.Play();
    }

    public void Guitartune3()
    {
        Mysource.clip = Musictunes[5];
        Mysource.Play();
    }

    public void Drumtune1()
    {
        Mysource.clip = Musictunes[6];
        Mysource.Play();
    }

    public void Drumtune2()
    {
        Mysource.clip = Musictunes[7];
        Mysource.Play();
    }

    public void Drumtune3()
    {
        Mysource.clip = Musictunes[8];
        Mysource.Play();
    }

    public void Trumpettune1()
    {
        Mysource.clip = Musictunes[9];
        Mysource.Play();
    }

    public void Trumpettune2()
    {
        Mysource.clip = Musictunes[10];
        Mysource.Play();
    }

    public void Trumpettune3()
    {
        Mysource.clip = Musictunes[11];
        Mysource.Play();
    }
    public void Tunestop()
    {
        
        Mysource.Stop();
    }

}
