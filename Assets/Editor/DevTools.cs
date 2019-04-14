using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public class DevTools : Editor
{
    [MenuItem("Custom/Remove Copy Names")]
    private static void RemoveCopyNames()
    {
        GameObject[] objs = Selection.gameObjects;
        foreach (GameObject o in objs)
            o.name = o.name.Substring(0, o.name.Length - 4);
    }

	[MenuItem("Custom/Pause Game %e")]
    private static void PauseTheGame()
    {
        EditorApplication.isPaused = !EditorApplication.isPaused;
    }

    [MenuItem("Custom/Play &p")]
    private static void Play()
    {
        EditorSceneManager.OpenScene("Assets/_Scenes/Menu.unity");
        EditorApplication.isPlaying = true;
    }
}
