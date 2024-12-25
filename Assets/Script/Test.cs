using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private ParticleSystem particle;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) particle.Play();
        if (Input.GetKeyDown(KeyCode.LeftShift)) particle.Stop();
    }
}
