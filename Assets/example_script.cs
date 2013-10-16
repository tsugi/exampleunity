// single_script.cs
// Example code for small Unity project using C#

using UnityEngine;
using System.Collections;

public class example_script : MonoBehaviour {

   	public Texture aTexture;

    void OnGUI() {
#if UNITY_EDITOR
        if (!aTexture) {
            Debug.LogError("Assign a Texture in the inspector.");
            return;
        }
#endif
		// Draws a single image in a square the size of the screen
		int width = Screen.width;
		int height = Screen.height;
		int left = 0;
		int top  = 0;

		if (width > height)
			width = height;
		else
			height = width;

		left = Screen.width/2 - width/2;
		top = Screen.height/2 - height/2;
		
		GUI.DrawTexture(new Rect(left, top, width, height), aTexture);
    }
}
