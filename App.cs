using Bridge;
using Bridge.Html5;
using Newtonsoft.Json;
using System;

namespace CarpWeb {
	public class App {
		public static void Main() {
			HTMLDivElement FileBrowser = Document.GetElementById<HTMLDivElement>("file_browser");
			if (FileBrowser != null)
				MainFileBrowser(FileBrowser);


		}

		static void MainFileBrowser(HTMLDivElement FileBrowser) {
			Console.WriteLine("This is a file browser");
		}
	}
}