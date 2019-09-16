using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowEdit.Interop {

	/// <summary>
	///     The POINT structure defines the x- and y- coordinates of a point.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public struct POINT {
		/// <summary>The x-coordinate of the point.</summary>
		public int x;

		/// <summary>The x-coordinate of the point.</summary>
		public int y;

		public POINT(int x, int y) {
			this.x = x;
			this.y = y;
		}

		/// <summary>The x-coordinate of the point.</summary>
		public int X {
			get => x;
			set => x = value;
		}

		/// <summary>The x-coordinate of the point.</summary>
		public int Y {
			get => y;
			set => y = value;
		}


		public bool Equals(POINT other) {
			return x == other.x && y == other.y;
		}

		public override bool Equals(object obj) {
			if (ReferenceEquals(null, obj)) return false;
			return obj is POINT point && Equals(point);
		}

		public override int GetHashCode() {
			unchecked {
				return (x * 397) ^ y;
			}
		}

		public static bool operator ==(POINT a, POINT b) {
			return a.x == b.x && a.y == b.y;
		}

		public static bool operator !=(POINT a, POINT b) {
			return a.x != b.x || a.y != b.y;
		}
	}
}
