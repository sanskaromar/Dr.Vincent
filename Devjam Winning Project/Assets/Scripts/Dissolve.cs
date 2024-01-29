using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissolve : MonoBehaviour
{
    public List<MeshRenderer> lm;
    // public GameObject objectToDissolve;

    private void Start()
    {
        foreach (MeshRenderer renderer in lm)
        {
            foreach (Material rendererMaterial in renderer.materials)
            {
                rendererMaterial.SetFloat("_Dissolve", 0);
            }
        }
    }

    public void dissolve()
    {
        if (lm.Count == 0)
        {
            Destroy(gameObject);
        }
        foreach (MeshRenderer renderer in lm)
        {
            foreach (Material rendererMaterial in renderer.materials)
            {
                StartCoroutine(enumerator(rendererMaterial));
            }
        }
    }

    IEnumerator enumerator(Material material)
    {
        float value = 0.1f;
        while (value <= 1)
        {
            material.SetFloat("_Dissolve", value);
            value += 0.005f;
            yield return null;
        }
        Destroy(gameObject);
    }
}
    