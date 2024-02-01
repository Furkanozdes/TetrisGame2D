using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    [SerializeField] private Transform TilePrefab;

    public int height = 22;
    public int width = 10;

    private void Start()
    {
        SpawnerEmpty();
    }
    void SpawnerEmpty()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                Transform tile = Instantiate(TilePrefab, new Vector3(i, j, 0), Quaternion.identity);
                tile.name="x "+ i.ToString()+ "," + "y"+j.ToString();
                tile.parent = this.transform;
            }
        }
    }

}
