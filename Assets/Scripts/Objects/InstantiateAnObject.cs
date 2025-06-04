using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateAnObject : MonoBehaviour
{
    public GameObject anObject;
    public void Instantiation()
    {
        Instantiate(anObject, gameObject.transform.position, Quaternion.identity);
    }
}
