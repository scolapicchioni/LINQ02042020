using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoSupport.KC.FoodForThought.Shared.Core.Models
{
	public class DagcodeResponse
	{
		public string Dagcode { get; set; } = string.Empty;
		public bool Correct { get; set; }
	}
}
