using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    public LineRenderer m_line;
    public LayerMask m_gateLayer;

    public string m_triggerName;
    private bool m_triggerHeld;

    private Transform m_gate;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis(m_triggerName) > 0.8f)
        {
            m_triggerHeld = true;
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, m_gateLayer))
            {
                m_line.enabled = true;
                m_line.SetPosition(0, transform.position);
                m_line.SetPosition(1, hit.point);
                m_gate = hit.transform;
            }
            else
            {
                m_line.enabled = true;
                m_line.SetPosition(0, transform.position);
                m_line.SetPosition(1, transform.position + transform.forward * 10f);
                m_gate = null;
            }
        }
        else if(Input.GetAxis(m_triggerName) < 0.8f && m_triggerHeld)
        {
            if(m_gate)
            {
                m_gate.gameObject.SendMessage("ToggleGate");
                m_gate = null;
            }
            m_line.enabled = false;
        }
    }
}
