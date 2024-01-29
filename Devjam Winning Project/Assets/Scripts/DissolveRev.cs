using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveRev : MonoBehaviour
{
    public List<MeshRenderer> lm;
    // public GameObject objectToDissolve;

    private void Start()
    {
        foreach (MeshRenderer renderer in lm)
        {
            foreach (Material rendererMaterial in renderer.materials)
            {
                rendererMaterial.SetFloat("_Dissolve", 1);
            }
        }
    }

    public void dissolveRev()
    {
        
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
        float value = 1f;
        while (value >= 0.1f)
        {
            material.SetFloat("_Dissolve", value);
            value -= 0.005f;
            yield return null;
        }
        
    }
}
