﻿using System;
using System.IO;

namespace People.Droid
{
	public class FileAccessHelper
	{
		public static string GetLocalFilePath(string filename) 
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

			return Path.Combine(path,filename);
		}
	}
}
