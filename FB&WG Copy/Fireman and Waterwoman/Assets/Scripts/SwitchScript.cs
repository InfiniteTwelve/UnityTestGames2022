using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour
{

    public GameObject buttonBlock;

    private void OnCollisionEnter2D(Collision2D ButtonCollider)
    {
        buttonBlock.SetActive(true);
    }

    private void OnCollisionExit2D(Collision2D ButtonCollider)
    {
        buttonBlock.SetActive(false);
    }
}
