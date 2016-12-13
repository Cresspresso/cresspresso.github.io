---
scriptname: everything.cs
codetype: csharp
---
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

/*
multi-line
comment
*/

namespace MyGame {
	public static class Controller : MonoBehaviour {
		public int value = 3;
		public string thing = "well this is awkward";

		public struct Vector3 {
			public float x, y, z;
			public Vector3(float x, float y, float z) {
				this.x = x;
				this.y = y;
				this.z = z;
			}
		}

		// single line comment
		public List<Vector3> vertices = new List<Vector3>() {
			new Vector3(2f,5f,1f),
			new Vector3(5f,1f,-4f),
		};

		public void PrintVertices() {
			MeshFilter f = GetComponent<MeshFilter>();
			f.mesh = new Mesh();
			f.mesh.vertices = vertices.ToArray();
			f.mesh.RecalculateNormals();
			f.mesh.RecalculateBounds;

			thing = thing + "no plz";
		}
	}
}