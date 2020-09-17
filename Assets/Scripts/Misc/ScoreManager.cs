using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager singleton;

    #region Private Variables
    private int m_Curscore;
    #endregion

    #region Initialization
    private void Awake()
    {
        if(singleton == null)
        {
            singleton = this;
        } else if (singleton != this)
        {
            Destroy(gameObject);
        }
        m_Curscore = 0;
    }
    #endregion

    #region Score Methods
    public void IncreseScore(int amount)
    {
        m_Curscore += amount;
    }

    private void UpdateHighScore()
    {
        if (!PlayerPrefs.HasKey("HS"))
        {
            PlayerPrefs.SetInt("HS", m_Curscore);
            return;
        }

        int hs = PlayerPrefs.GetInt("HS");
        if(hs < m_Curscore)
        {
            PlayerPrefs.SetInt("HS", m_Curscore);
        }
    }
    #endregion

    #region Destruction
    private void OnDisable()
    {
        UpdateHighScore();
    }
    #endregion

}
