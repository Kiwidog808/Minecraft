using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGenerator : MonoBehaviour
{
    public GameObject trunkBlock;
    public GameObject leafBlock;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 growPoint = new Vector3Int(-5, 1, -7);
        GameObject block = Instantiate(trunkBlock, growPoint, trunkBlock.transform.rotation);
        growPoint += new Vector3Int(0, 1, 0);
        block = Instantiate(gameObject, growPoint, trunkBlock.transform.rotation);
        growPoint += new Vector3Int(-1, 1, 0);
        Instantiate(gameObject, growPoint, trunkBlock.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
