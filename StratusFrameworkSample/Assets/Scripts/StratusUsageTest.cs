using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Stratus;

namespace StratusTest
{
	public class StratusUsageTest : Stratus.StratusBehaviour
	{
		private void Awake()
		{
			StratusDebug.Log("Boop!");
		}
	}

}