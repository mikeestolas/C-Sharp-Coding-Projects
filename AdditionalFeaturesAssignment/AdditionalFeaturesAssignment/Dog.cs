using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesAssignment
{
    public class Dog
    {
		private string Color;

		public Dog(string Color)
		{
			this.Color = Color;
		}

		public string GetColor()
		{
			return Color;
		}

		public string Speak()
		{
			return "Ahoooooooooooooo";
		}
	}
}
