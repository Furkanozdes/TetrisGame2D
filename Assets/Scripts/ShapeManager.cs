using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeManager : MonoBehaviour
{
    [SerializeField] private bool checkRotation=true;


    private void Start()
    {
        // InvokeRepeating("MoveDown", 1f,0.25f);
        StartCoroutine(MoveRoutine());
    }
    public void MoveLeft()
    {
        transform.Translate(Vector3.left);
    }

    public void MoveRight()
    {
        transform.Translate(Vector3.right);
    }

    public void MoveDown()
    {
        transform.Translate(Vector3.down);
    }

    public void MoveUp()
    {
        transform.Translate(Vector3.up);
    }


    public void RotateRight()
    {
        if (checkRotation)
        {
            transform.Rotate(0,0,-90);
        }
    }
    public void RotateLeftt()
    {
        if (checkRotation)
        {
            transform.Rotate(0, 0, 90);
        }
    }
    IEnumerator MoveRoutine()
    {
        while (true)
        {
            MoveDown();
            yield return new WaitForSeconds(.25f);
        }
    }
}
