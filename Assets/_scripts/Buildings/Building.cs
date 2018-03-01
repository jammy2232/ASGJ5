using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Building : ScriptableObject 
{

	// This is the pubic informaiton available for editing
	public string name;
	public string description;
	public int constuctionTime;
	public float constuctionCost;
	public float maintenanceCost;

	// This is for graphical purposes
	public Image uiIcon;
	public GameObject PrefabModel;

	// Game fuction 
	[HideInInspector]
	public bool available = false;
	[HideInInspector]
	public bool active = false;
	[HideInInspector]
	public int constructionProgress = 0;
	private int turnsBuilt_ = 0;

	// Functions tracks construction of the asset and returns if the building is complete
	public virtual bool Construction()
	{
		if (turnsBuilt_ != constuctionTime) {
			turnsBuilt_++;
			constructionProgress += (100 / constuctionTime);
			return false;
		} else 
		{
			constructionProgress = 100;
			available = true;
			return true;
		}
	}

	// Function to destrcut asset
	public virtual bool Destruction()
	{

		available = false;

		if (turnsBuilt_ == 0) {
			turnsBuilt_--;
			constructionProgress -= (100 / constuctionTime);
			return false;
		} else 
		{
			constructionProgress = 0;
			available = false;
			return true;
		}
	}
		
}
