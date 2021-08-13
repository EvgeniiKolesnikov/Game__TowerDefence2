using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourseManager : MonoBehaviour
{
    public Text goldText;
    public int gold, towerCost, enemyCost;

    void Start()
    {
        
    }

    void Update()
    {
        goldText.text = "Gold: " + gold;
    }

    public void BuildTower() {
        gold -= towerCost;
    }

    public void EnemyKill() {
        gold += enemyCost;
    }
}
