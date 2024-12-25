using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartParticle : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem myParticle;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Teki")
        {
            ParticleSystem newParticle = Instantiate(myParticle);

            newParticle.transform.position = this.gameObject.transform.position;

            newParticle.Play();

            Destroy(newParticle.gameObject,5f);
        }
    }
}
