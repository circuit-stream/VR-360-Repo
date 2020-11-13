using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamplePointer : MonoBehaviour
{
    public LineRenderer m_line;

    public string m_triggerName;
    private bool m_triggerHeld;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis(m_triggerName) > 0.8f)
        {
            m_triggerHeld = true;

            m_line.enabled = true;
            m_line.SetPosition(0, transform.position);
            m_line.SetPosition(1, transform.position + transform.forward * 10f);
        }
        else if (Input.GetAxis(m_triggerName) < 0.8f && m_triggerHeld)
        {
            m_triggerHeld = false;
            m_line.enabled = false;
        }
    }
}
