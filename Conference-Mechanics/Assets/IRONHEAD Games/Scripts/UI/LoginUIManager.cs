using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginUIManager : MonoBehaviour
{
    public GameObject ConnectOptionsPanelGameObject;
    public GameObject ConnectWithNamePanelGameOject;

    #region
    // Start is called before the first frame update
    void Start()
    {
        ConnectOptionsPanelGameObject.SetActive(true);
        ConnectWithNamePanelGameOject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion
}
