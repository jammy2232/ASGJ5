using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "EnergyProducer", menuName = "EnergyProducer")]
public abstract class EnergyProducer : Building 
{

	// Energy Producer will need a way to input a Resource/Fuel and output an energy Amount
	public ResourceStream fuel;
	public float fuelConsumption;
	public ResourceStream pollutant;
	public float pollutionRate;

	// These function are called each tick of the game 

	// Function to consume a quantity of resource stream and produce energy
	public abstract void GeneratePower();

	// enable the toggle of building
	public virtual void Turn(bool BuildingOn)
	{
		active = BuildingOn;
	}

}
