﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonListController : MonoBehaviour
{
    [SerializeField]
    private GameObject buttonTemplate;

    void Start()
    {
    	for (int i=1; i <= 20; i++)
    	{
    		GameObject button = Instantiate(buttonTemplate) as GameObject;
    		button.SetActive(true);

    		button.GetComponent<ButtonListButton>().SetText($"Button #{i}");

    		button.transform.SetParent(buttonTemplate.transform.parent, false);
    	}
    }

    void GenerateButtons()
    {

    }

}
