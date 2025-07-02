using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGodzilla : MonoBehaviour
{
    [SerializeField] Animation godzillaAnim;
    private void Update()
    {
        MoveGodzillaForward();
    }
    public void MoveGodzillaForward()
    {
        gameObject.transform.position = Vector3.Lerp(transform.position, new Vector3(-20,0,0) * transform.localScale.x + new Vector3(0,transform.position.y,0), Time.deltaTime);
        PlayGodzillaAnim();
    }
    public void PlayGodzillaAnim()
    {
        godzillaAnim.Play();
    }
}
