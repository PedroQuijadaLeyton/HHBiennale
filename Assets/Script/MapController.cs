using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    [SerializeField] private GameObject bankDetail;

    void Start ()
    {
		
	}
	
	void Update ()
    {
	}

    public void OnBankClicked()
    {
        bankDetail.SetActive(!bankDetail.activeSelf);
    }

}
