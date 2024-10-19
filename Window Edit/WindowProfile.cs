using System;

namespace WindowEdit {
	[Serializable]
	public class WindowProfile {
		public string Name { get; set; }
		public int PosX, PosY;
		public int SizeX, SizeY;
		public bool Topmost;
	}
}
