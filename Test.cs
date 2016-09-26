using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
public class Test : MonoBehaviour {


	void Start () {
		new TestFacade (gameObject);
	}
}
