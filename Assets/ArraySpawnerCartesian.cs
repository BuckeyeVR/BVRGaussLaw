using UnityEngine;
using System.Collections;

public class ArraySpawnerCartesian : MonoBehaviour {
    [SerializeField]
    Transform thing;
	[SerializeField]
	float xmax;
	[SerializeField]
	float xIncrementor;
	

    // Use this for initialization
    void Start () {
	//	Debug.Log ("I started_arr");
	//	for (int radInc = 0; radInc < radii.Length; radInc++) {
	//		for (float z = zmin; z < zmax; z+=zIncrementor) {
	//			for (int phi=0; phi < 360; phi+=phiIncrementor) {
	//				Instantiate (thing, new Vector3 (radii[radInc] * Mathf.Cos (phi * Mathf.Deg2Rad), z, radii[radInc] * Mathf.Sin (phi * Mathf.Deg2Rad)), Quaternion.identity);
		Debug.Log ("I started_arr");
		for (float x = -xmax; x < xmax; x = x+xIncrementor) {
			for (float y = -xmax; y < xmax; y = y+xIncrementor) {
				for (float z = -xmax; z < xmax; z = z+xIncrementor) {
					Instantiate (thing, new Vector3 (x, y, z), Quaternion.identity);

				}
			}
		}
	}
}