﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Globalization;
using System.Drawing;
using System.Drawing.Imaging;
/*using PhysVector3 = BEPUutilities.Vector3;
using PhysMatrix = BEPUutilities.Matrix;
using PhysQuat = BEPUutilities.Quaternion;*/

namespace libTech {
	public unsafe static class Utils {
		/*public static Vector3 ToVec3(this PhysVector3 V) {
			return new Vector3(V.X, V.Y, V.Z);
		}

		public static PhysVector3 ToPhysVec3(this Vector3 V) {
			return new PhysVector3(V.X, V.Y, V.Z);
		}

		public static IEnumerable<Vector3> ToVec3(this IEnumerable<PhysVector3> Vecs) {
			foreach (var V in Vecs)
				yield return V.ToVec3();
		}

		public static IEnumerable<PhysVector3> ToPhysVec3(this IEnumerable<Vector3> Vecs) {
			foreach (var V in Vecs)
				yield return V.ToPhysVec3();
		}

		public static PhysMatrix ToPhysMatrix(this Matrix4x4 M) {
			return new PhysMatrix(M.M11, M.M12, M.M13, M.M14, M.M21, M.M22, M.M23, M.M24, M.M31, M.M32, M.M33, M.M34, M.M41, M.M42, M.M43, M.M44);
		}

		public static PhysQuat ToPhysQuat(this Quaternion Q) {
			return new PhysQuat(Q.X, Q.Y, Q.Z, Q.W);
		}

		public static Quaternion ToQuat(this PhysQuat Q) {
			return new Quaternion(Q.X, Q.Y, Q.Z, Q.W);
		}*/

		public static Vector2 Max(this Vector2 V, Vector2 V2) {
			return new Vector2(Math.Max(V.X, V2.X), Math.Max(V.Y, V2.Y));
		}

		public static Vector3 XYZ(this Vector4 V) {
			return new Vector3(V.X, V.Y, V.Z);
		}

		public static float ToRad(this float Deg) {
			return Deg * (float)Math.PI / 180;
		}

		public static IEnumerable<int> Range(this int Count) {
			for (int i = 0; i < Count; i++)
				yield return i;
		}

		public static float Clamp(this float Val, float Min, float Max) {
			if (Val < Min)
				return Min;
			if (Val > Max)
				return Max;
			return Val;
		}

		public static string NormalizeFilePath(this string Str) {
			return Str.Replace('\\', '/');
		}

		public static float ParseToFloat(this string Str) {
			return float.Parse(Str, NumberStyles.Any, CultureInfo.InvariantCulture);
		}

		public static void Copy(IntPtr source, int sourceOffset, IntPtr destination, int destinationOffset, int count) {
			byte* src = (byte*)source + sourceOffset;
			byte* dst = (byte*)destination + destinationOffset;
			byte* end = dst + count;

			while (dst != end)
				*dst++ = *src++;
		}
	}
}
