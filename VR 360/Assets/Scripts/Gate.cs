using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public GameObject m_currentGate;
    public GameObject m_nextGate;
    void ToggleGate()
    {
        m_currentGate.SetActive(false);
        m_nextGate.SetActive(true);
    }
}
