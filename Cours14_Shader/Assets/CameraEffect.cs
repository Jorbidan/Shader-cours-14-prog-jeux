using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CameraEffect : MonoBehaviour
{

    private Material leMat;
    
    // Start is called before the first frame update
    void Awake()
    {
        leMat = new Material(Shader.Find("Hidden/Image_EFFECT_SHADER"));
    }

    // Update is called once per frame
    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, leMat);
    }
}
