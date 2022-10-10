using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherEffects : MonoBehaviour
{
    public GameObject lightning;
    public float timeRangeStartSecs, timeRangeEndSecs;
    bool playing;
    public AudioClip lightningSound;
    // Update is called once per frame
    void Update()
    {
        if (!playing)
        {
            Invoke("Lightning", Random.Range(timeRangeStartSecs, timeRangeEndSecs));
            playing = true;
        }
    }

    void Lightning()
    {
        lightning.GetComponent<AudioSource>().PlayOneShot(lightningSound);
        GetComponent<Animator>().SetTrigger("lightning");
        Invoke("playingReset", 3f);
    }

    void playingReset()
    {
        playing = false;
    }
}