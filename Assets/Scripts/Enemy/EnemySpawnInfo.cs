using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemySpawnInfo
{
    #region Editor Variables
    [SerializeField]
    [Tooltip("")]    
    private string m_Name;
    public string EnemyName
    {
    	get
    	{
    		return m_Name;
    	}
    }

    [SerializeField]
    [Tooltip("")]    
    private GameObject m_EnemyGO;
    public GameObject EnemyGO
    {
    	get
    	{
    		return m_EnemyGO;
    	}
    }

    [SerializeField]
    [Tooltip("")]    
    private float m_TimeToNextSpawn;
    public float TimeToNextSpawn
    {
    	get
    	{
    		return m_TimeToNextSpawn;
    	}
    }

    [SerializeField]
    [Tooltip("")]    
    private int m_NumberToSpawn;
    public int NumberToSpawn
    {
    	get
    	{
    		return m_NumberToSpawn;
    	}
    }
    #endregion
}

