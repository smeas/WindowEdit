using System.Runtime.InteropServices;

namespace Window_Edit {
	[StructLayout(LayoutKind.Sequential)]
	public struct SIZE {
		public int cx;
		public int cy;

		public int Width {
			get => cx;
			set => cx = value;
		}

		public int Height {
			get => cy;
			set => cy = value;
		}

		public SIZE(int cx, int cy) {
			this.cx = cx;
			this.cy = cy;
		}

		public bool Equals(SIZE other) {
			return cx == other.cx && cy == other.cy;
		}

		public override bool Equals(object obj) {
			if (ReferenceEquals(null, obj)) return false;
			return obj is SIZE size && Equals(size);
		}

		public override int GetHashCode() {
			unchecked {
				return (cx * 397) ^ cy;
			}
		}

		public static bool operator ==(SIZE a, SIZE b) {
			return a.cx == b.cx && a.cy == b.cy;
		}

		public static bool operator !=(SIZE a, SIZE b) {
			return a.cx != b.cx || a.cy != b.cy;
		}
	}
}
