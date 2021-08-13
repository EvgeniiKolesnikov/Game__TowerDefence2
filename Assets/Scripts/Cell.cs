using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public Material mainMaterial;
    public Material canMaterial;
    public Material cantMaterial;
    public bool canBuild;
    public Tower towerPrefab;

    ResourseManager rm;

    private void Start()
    {
        rm = FindObjectOfType<ResourseManager>(); 
    }

	private void OnMouseUp()
	{
        if (canBuild && rm.gold >= rm.towerCost) {
            rm.BuildTower();
            Tower tower = Instantiate(
                towerPrefab, 
                transform.position, 
                Quaternion.Euler(-90, Random.Range(0, 360), 0)).GetComponent<Tower>();
            canBuild = false;
        }
    }
	private void OnMouseOver()
  {
    if (canBuild)
    {
      GetComponent<Renderer>().material = canMaterial;
    }
    else
    {
      GetComponent<Renderer>().material = cantMaterial;
    }
  }

  private void OnMouseExit()
  {
    GetComponent<Renderer>().material = mainMaterial;
  }
}
