using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScore : MonoBehaviour
{
    public TextMesh scoreText;
    public void ShowScore(float score)
    {
        if (score >= 0) scoreText.text = "+" + score;
        else scoreText.text = "-" + score;
    }
    private void Update()
    {
        MoveScore();
    }
    public void MoveScore()
    {
        transform.position += Vector3.up * Time.deltaTime;
    }
    public void DestroyAfterAnimation()
    {
        Destroy(gameObject);
    }
}
