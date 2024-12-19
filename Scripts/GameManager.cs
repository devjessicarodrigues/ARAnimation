using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject vi; 
    public ParticleSystem smoke; 

    private void Start()
    {
        if (vi != null)
        {
            vi.SetActive(false);
        }

        if (smoke != null)
        {
            smoke.gameObject.SetActive(false);
        }

        StartCoroutine(DelayedStart());
    }

    private IEnumerator DelayedStart()
    {
        yield return new WaitForSeconds(3f);

        if (vi != null)
        {
            vi.SetActive(true);
        }

        if (smoke != null)
        {
            smoke.gameObject.SetActive(true);
            smoke.Play();

            Destroy(smoke.gameObject, 5f);
        }
    }
}

