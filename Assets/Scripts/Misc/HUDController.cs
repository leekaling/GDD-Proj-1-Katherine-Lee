using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDController : MonoBehaviour
{
    #region Editor Variables
    [SerializeField]
    [Tooltip("")]    
    private RectTransform m_HeathBar;
    #endregion

    #region Private Variables
	private float p_HealthBarOrigWidth;
    #endregion

    #region Initialization
    private void Awake()
    {
    	p_HealthBarOrigWidth = m_HeathBar.sizeDelta.x;
    }
    #endregion

    #region Update Health Bar 
    public void UpdateHealth(float percent)
    {
    	m_HeathBar.sizeDelta = new Vector2(p_HealthBarOrigWidth * percent, m_HeathBar.sizeDelta.y);
    }
    #endregion

}
