using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParent : MonoBehaviour
{
    [SerializeField] GameObject parent;
    public void DestroyParentObject()
    {
        Destroy(parent);
    }
}
