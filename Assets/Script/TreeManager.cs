using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeManager : MonoBehaviour
{
    public GameObject trunkPrefab;
    public GameObject leafPrefab;
    public int initialTreeCount;
    public GameObject planeObject;
    //public Vector3 areaSize = new Vector3(100, 1, 100);

    private void Start()
    {
        MeshRenderer planeRenderer = planeObject.GetComponent<MeshRenderer>();
        Vector3 planeSize = planeRenderer.bounds.size;
        initialTreeCount = Random.Range(1, 100);
        for(int i=0; i<initialTreeCount;i++)
        {
            Vector3 position = new Vector3(Random.Range(-planeSize.x / 2, planeSize.x / 2), 0, Random.Range(-planeSize.z / 2, planeSize.z / 2));
            CreateTree(position);
        }

    }

    void CreateTree(Vector3 position)
    {
        int treeType = Random.Range(0, 4);
        switch (treeType)
        {
            case 0:
                CreateType1Tree(position);
                break;
            case 1:
                CreateType2Tree(position);
                break;
            case 2:
                CreateType3Tree(position);
                break;
            case 3:
                CreateType4Tree(position);
                break;
        }
    }

    void CreateType1Tree(Vector3 position)
    {
        int trunkHeight = Random.Range(3, 6);
        float leafHeight = Random.Range(2, 3);

        // 飘贩农 积己
        for (int i = 0; i < trunkHeight; i++)
        {
            Vector3 trunkPosition = position + new Vector3(0, i, 0);
            Instantiate(trunkPrefab, trunkPosition, Quaternion.identity);
        }

        // 蕾 积己
        Vector3 leafPosition = position + new Vector3(0, trunkHeight, 0);
        GameObject leaf = Instantiate(leafPrefab, leafPosition, Quaternion.identity);
        leaf.transform.localScale = new Vector3(3, leafHeight, 3);
    }

    void CreateType2Tree(Vector3 position)
    {
        int trunkHeight = Random.Range(6, 10);
        float leafHeight = Random.Range(4, 6);

        // 飘贩农 积己
        for (int i = 0; i < trunkHeight; i++)
        {
            Vector3 trunkPosition = position + new Vector3(0, i, 0);
            Instantiate(trunkPrefab, trunkPosition, Quaternion.identity);
        }

        // 蕾 积己 (歹 奴 唱公)
        Vector3 leafPosition = position + new Vector3(0, trunkHeight, 0);
        GameObject leaf = Instantiate(leafPrefab, leafPosition, Quaternion.identity);
        leaf.transform.localScale = new Vector3(4, leafHeight, 4);
    }

    void CreateType3Tree(Vector3 position)
    {
        int trunkHeight = Random.Range(2, 5);
        int numLeaves = Random.Range(3, 6);

        // 飘贩农 积己
        for (int i = 0; i < trunkHeight; i++)
        {
            Vector3 trunkPosition = position + new Vector3(0, i, 0);
            Instantiate(trunkPrefab, trunkPosition, Quaternion.identity);
        }

        // 蕾 积己 (累绊 苟模 唱公)
        for (int i = 0; i < numLeaves; i++)
        {
            Vector3 leafPosition = position + new Vector3(0, trunkHeight + i, 0);
            GameObject leaf = Instantiate(leafPrefab, leafPosition, Quaternion.identity);
            leaf.transform.localScale = new Vector3(2 - i * 0.3f, 1, 2 - i * 0.3f);
        }
    }

    void CreateType4Tree(Vector3 position)
    {
        int trunkHeight = Random.Range(8, 12);
        int numLeavesLayers = Random.Range(4, 7);

        // 飘贩农 积己
        for (int i = 0; i < trunkHeight; i++)
        {
            Vector3 trunkPosition = position + new Vector3(0, i, 0);
            Instantiate(trunkPrefab, trunkPosition, Quaternion.identity);
        }

        // 蕾 积己 (臭绊 摸摸捞 乐绰 唱公)
        for (int i = 0; i < numLeavesLayers; i++)
        {
            float scale = Mathf.Lerp(4, 1, (float)i / numLeavesLayers);
            Vector3 leafPosition = position + new Vector3(0, trunkHeight + i, 0);
            GameObject leaf = Instantiate(leafPrefab, leafPosition, Quaternion.identity);
            leaf.transform.localScale = new Vector3(scale, 1, scale);
        }
    }


    // void CreateTree(Vector3 position)
    // {
    //     int trunkHeight = Random.Range(3, 6);
    //     float leafHeight = Random.Range(2, 5);
    //
    //     // 飘贩农 积己
    //     for (int i = 0; i < trunkHeight; i++)
    //     {
    //         Vector3 trunkPosition = position + new Vector3(0, i, 0);
    //         Instantiate(trunkPrefab, trunkPosition, Quaternion.identity);
    //     }
    //
    //     // 蕾 积己
    //     Vector3 leafPosition = position + new Vector3(0, trunkHeight, 0);
    //     GameObject leaf = Instantiate(leafPrefab, leafPosition, Quaternion.identity);
    //     leaf.transform.localScale = new Vector3(3, leafHeight, 3);
    // }

}
