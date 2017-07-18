using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {
	float t;
	   int blendShapeCount;
       SkinnedMeshRenderer skinnedMeshRenderer;
       Mesh skinnedMesh;
       float blendOne = 0f;
       float blendTwo = 0f;
       public float blendSpeed = 1f;
       bool blendOneFinished = false;
 
       void Awake ()
       {
          skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer> ();
          skinnedMesh = GetComponent<SkinnedMeshRenderer> ().sharedMesh;
       }
 
       void Start ()
       {
          blendShapeCount = skinnedMesh.blendShapeCount; 
       }
 
       void Update ()
       {
 
                 if (blendOne < 100f) {
                    skinnedMeshRenderer.SetBlendShapeWeight (0, blendOne);
                    blendOne += blendSpeed;
                 } else {
                    blendOne = 0;
                 }
       }
}
