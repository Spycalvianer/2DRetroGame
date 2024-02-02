using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCrash : MonoBehaviour
{
    void OnAnimationDestroy()
    {
        Destroy(gameObject);
    }
}
