using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerAttackInfo
{
    #region Editor Variables
    [SerializeField]
    [Tooltip("")]    
    private string m_Name;
    public string AttackName
    {
    	get
    	{
    		return m_Name;
    	}
    }

    [SerializeField]
    [Tooltip("")]    
    private string m_Button;
    public string Button
    {
    	get
    	{
    		return m_Button;
    	}
    }

    [SerializeField]
    [Tooltip("")]    
    private string m_TriggerName;
    public string TriggerName
    {
    	get
    	{
    		return m_TriggerName;
    	}
    }

    [SerializeField]
    [Tooltip("")]    
    private GameObject m_AbilityGO;
    public GameObject AbilityGO
    {
    	get
    	{
    		return m_AbilityGO;
    	}
    }

    [SerializeField]
    [Tooltip("")]    
    private Vector3 m_Offset;
    public Vector3 Offset
    {
    	get
    	{
    		return m_Offset;
    	}
    }

    [SerializeField]
    [Tooltip("")]    
    private float m_WindUpTime;
    public float WindUpTime
    {
    	get
    	{
    		return m_WindUpTime;
    	}
    }

    [SerializeField]
    [Tooltip("")]    
    private float m_FrozenTime;
    public float FrozenTime
    {
    	get
    	{
    		return m_FrozenTime;
    	}
    }

    [SerializeField]
    [Tooltip("")]    
    private float m_Cooldown;
    
    [SerializeField]
    [Tooltip("")]    
    private int m_HealthCost;
    public int HealthCost 
    {
    	get
    	{
    		return m_HealthCost;
    	}
    }

    [SerializeField]
    [Tooltip("")]    
    private Color m_Color;
    public Color AbilityColor 
    {
    	get
    	{
    		return m_Color;
    	}
    }
    #endregion

    #region Public Variables
    public float Cooldown
    {
    	get;
    	set;
    }
    #endregion

    #region Cooldown Methods
    public void ResetCooldown()
    {
    	Cooldown = m_Cooldown;
    }

    public bool IsReady()
    {
    	return Cooldown <= 0;
    }
    #endregion



}
