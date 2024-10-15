using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creates : MonoBehaviour
{

    public GameObject traps;
    public GameObject Platform;

    float m_Time = 0.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        m_Time += Time.deltaTime;
        if (m_Time >= 3.0f)
        {
            Create();
            m_Time = 0.0f;
        }

    }

    void Create()
    {
        int rangeNum = Random.Range(0, 5);
        GameObject tempObject = null;
        if (rangeNum == 0)
        {
            tempObject = traps;
        }
        else
        {
            tempObject = Platform;
        }
        Instantiate(tempObject, new Vector3(Random.Range(-4.5f, 4.5f), -6f, 0f), Quaternion.identity);
    }
}
