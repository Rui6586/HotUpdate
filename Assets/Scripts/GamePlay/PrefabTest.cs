using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GamePlay
{
    public class PrefabTest : MonoBehaviour
    {
        void Start()
        {
            Debug.LogError("PrefabTest");
            Introduce();
        }

        void Introduce()
        {
            Debug.LogError("--- I am: " + gameObject.transform.name);
            if (gameObject.GetComponent<MeshRenderer>() != null)
            {
                Debug.LogError(transform.GetComponent<MeshRenderer>().materials[0].name);
            }
            else
            {
                Debug.LogError("There is no mesh renderer here.");
            }
            Debug.LogError("--- great wishes ---" + System.DateTime.Now.Date);
            Debug.LogError("--- 2nd wishes ---" + System.DateTime.Now.Date);
        }

        void Update()
        {
        }
    }
}