using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide_Building : MonoBehaviour
{
    public string mTeki;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == mTeki)
        {
            this.gameObject.SetActive(false);
        }
    }
}
