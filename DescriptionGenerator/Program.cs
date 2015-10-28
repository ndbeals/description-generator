using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace DescriptionGenerator
{
	public class Description
	{
        private string Template = "";
        private DateTime Date { get; set; }
        public string ProgramName	{ get; set; }
		public string ProjectName	{ get; set; }
		public string AuthorName	{ get; set; }
		public string Body			{ get; set; }
        public string Output        { get; set; }

		public Description( string programName , string projectName , string authorName , string description )
		{
			ProgramName	= programName;
			ProjectName	= projectName;
			AuthorName	= authorName;
			Body		= description;

			Date = DateTime.Now;
		}

        public string GenerateOutput(string filler)
        {
            List<string> ret = new List<string>();

            ret.Add((" {.f} Program Name:\t" + ProgramName).Replace("{.f}", filler));

            ret.Add((" {.f} Project Name:\t" + ProjectName).Replace("{.f}", filler));

            ret.Add((" {.f} Author Name:\t\t" + AuthorName).Replace("{.f}", filler));

            ret.Add((" {.f} Date:\t\t\t" + Date.ToString("dd/MM/yyyy")).Replace("{.f}", filler));
			
            ret.Add((" {.f}").Replace("{.f}", filler));


			string[] bodyLines = Body.Split( new string [] {"\n"} , StringSplitOptions.None );

			for (int l = 0; l < bodyLines.Length; l++)
			{
				string line = bodyLines[l];
				int multiLine = Math.Min(line.Length, 99);

				if (l == 0)
				{
					ret.Add((" {.f} Description:\t\t" + line.Substring(0, multiLine)).Replace("{.f}", filler));
				}
				else
				{
					ret.Add((" {.f} \t\t\t\t\t" + line.Substring(0, multiLine)).Replace("{.f}", filler));
				}

				for (int i = 100; i < line.Length; i += 100)
				{
					multiLine = Math.Min(line.Length - i, 99);
					ret.Add(((" {.f} \t\t\t\t\t" + line.Substring(i, multiLine)).Replace(Environment.NewLine, Environment.NewLine + " {.f} ")).Replace("{.f}", filler));
				}
			}            

            int longestLine = 0;

            foreach (string line in ret)
            {
                longestLine = Math.Max( line.Replace("\t" , "    " ).Length , longestLine );
            }			

            ret.Insert(0, "/*" + string.Concat(Enumerable.Repeat(filler, longestLine - 2)));

            ret.Add(" " + string.Concat(Enumerable.Repeat(filler, longestLine - 2) ) + "*/");

            Output = String.Join("\n", ret);

            return Output;            
		}
	}
	
	static class Program
	{
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]
		static void Main()
		{
			//Debug.WriteLine("HEELLO");
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new UserInput());
		}

		public static float Lerp(this float start, float end, float amount)
		{
			float difference = end - start;
			float adjusted = difference * amount;
			return start + adjusted;
		}


		public static Color Lerp(this Color colour, Color to, float amount)
		{
			// start colours as lerp-able floats
			float sr = colour.R, sg = colour.G, sb = colour.B;

			// end colours as lerp-able floats
			float er = to.R, eg = to.G, eb = to.B;

			// lerp the colours to get the difference
			int r = (int)Lerp(sr, er, amount);
			int g = (int)Lerp(sg, eg, amount);
			int b = (int)Lerp(sb, eb, amount);

			// return the new colour 
			return Color.FromArgb(r, g, b);
		}

	}
}
