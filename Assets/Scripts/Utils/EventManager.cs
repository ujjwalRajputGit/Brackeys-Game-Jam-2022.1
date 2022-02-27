using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class EventManager : MonoBehaviour
{
    public static EventManager instance;
    public  event Action onMakeGlitchSolid;
    public  event Action onMakeGlitchTransparent;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    public void SolidGlitch()
    {
        onMakeGlitchSolid?.Invoke();
    }

    public void TransparentGlitch()
    {
        onMakeGlitchTransparent?.Invoke();
    }
}
