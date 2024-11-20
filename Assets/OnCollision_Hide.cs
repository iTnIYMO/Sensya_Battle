using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 衝突したら、消す
public class OnCollision_Hide : MonoBehaviour
{
	public string tagName1 = "MikataBiru";
	public string tagName2 = "MikataBiru2";
	public string tagName3 = "MikataBiru3";
	public string hideObjectName1;
	public string hideObjectName2;
	public string hideObjectName3;

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == tagName1)
		{
			GameObject hideObject1 = GameObject.Find(hideObjectName1);
			if (hideObject1)
			{
				hideObject1.SetActive(false);
			}
        }else	if (collision.gameObject.tag == tagName2)
        {
			GameObject hideObject2 = GameObject.Find(hideObjectName2);
			if (hideObject2)
			{
				hideObject2.SetActive(false);
			}
		}else if (collision.gameObject.tag == tagName3)
		{
			GameObject hideObject3 = GameObject.Find(hideObjectName3);
			if (hideObject3)
			{
					hideObject3.SetActive(false);
			}
		}
	}
}
