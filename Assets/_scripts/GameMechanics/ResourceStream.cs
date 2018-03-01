using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class ResourceStream : ScriptableObject
{
	
	// key information about the stream
	public string name;
	public string description;
	public Image uiIcon;
	public List<ResourceStream> streamImpact = new List<ResourceStream>();
	public List<float> impacts = new List<float> ();

	// private interals 
	private float amount_;

	// key functions of a stream
	// put resource into a stream
	public virtual void InputToStream(float amount, string stream)
	{
		amount_ += amount;
	}

	// request resource out of a stream
	public virtual float OutputFrom (float amountReqested)
	{
		// is there enough
		if (amount_ >= amountReqested)
		{
			amount_ -= amountReqested;
			return amountReqested;
		}

		float availableAmount = amount_;
		amount_ = 0.0f;
		return availableAmount;

	}

	// Effect of resource in stream
	public abstract void GenerateEffect();

}
