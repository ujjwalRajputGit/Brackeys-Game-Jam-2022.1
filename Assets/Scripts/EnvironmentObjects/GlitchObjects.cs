using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlitchObjects : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer spriteRenderer;

    private Collider glitchcollider;

    private void Awake()
    {
        EventManager.instance.onMakeGlitchSolid += GetSolid;
        EventManager.instance.onMakeGlitchTransparent += GetTransparent;
    }
    void Start()
    {
        glitchcollider = this.GetComponent<Collider>();
        GetTransparent();
    }

 

    void GetSolid()
    {
        glitchcollider.enabled = true;
        Color color = spriteRenderer.color;
        color.a = 1;
        spriteRenderer.color = color;
    }

    void GetTransparent()
    {
        glitchcollider.enabled = false ;
        Color color = spriteRenderer.color;
        color.a = 0.5f;
        spriteRenderer.color = color;
    }

    private void OnDisable()
    {
        EventManager.instance.onMakeGlitchSolid -= GetSolid;
        EventManager.instance.onMakeGlitchTransparent -= GetTransparent;
    }
}
