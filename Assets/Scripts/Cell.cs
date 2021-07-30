using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public Material mainMaterial;
    public Material overMaterial;
    public bool canBuild;

	private void OnMouseOver()
	{
		if (canBuild)
		{
			GetComponent<Renderer>().material = overMaterial;
		}
	}

	private void OnMouseExit()
	{
		GetComponent<Renderer>().material = mainMaterial;
	}
}
