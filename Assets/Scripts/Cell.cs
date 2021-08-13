using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
  public Material mainMaterial;
  public Material canMaterial;
	public Material cantMaterial;
  public bool canBuild;

  private void OnMouseOver()
  {
    if (canBuild)
    {
      GetComponent<Renderer>().material = canMaterial;
    } else {
			GetComponent<Renderer>().material = cantMaterial;
		}
  }

  private void OnMouseExit()
  {
    GetComponent<Renderer>().material = mainMaterial;
  }
}
