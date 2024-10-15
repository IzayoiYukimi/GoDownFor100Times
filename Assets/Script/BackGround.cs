using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{

    [SerializeField] private List<GameObject> m_BackGround;

    Vector3 ScrollSpeed = new Vector3(0.0f, 0.1f, 0.0f);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < m_BackGround.Count; i++)
        {
            m_BackGround[i].transform.position += ScrollSpeed;

            if (m_BackGround[i].transform.position.y >= 24.0f)
            {
                m_BackGround[i].transform.position = new Vector3(0.0f, -24.0f, 0.0f);
            }
        }


    }
}
