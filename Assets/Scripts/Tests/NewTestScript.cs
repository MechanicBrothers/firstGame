using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class MyPlayModeTest
{
    [UnityTest]
    public IEnumerator TestSceneTransition()
    {
        // Load the first scene
        SceneManager.LoadScene("FirstGame");

        // Wait for the scene to be loaded
        yield return null;

        // Find the "Play" button
        Button playButton = GameObject.Find("PlayButton").GetComponent<Button>();

        // Simulate a click on the "Play" button
        playButton.onClick.Invoke();

        // Wait for the next scene to be loaded
        yield return new WaitForSeconds(1f);

        // Check that the current scene is the second scene
        Assert.AreEqual("scene1", SceneManager.GetActiveScene().name);
    }
}