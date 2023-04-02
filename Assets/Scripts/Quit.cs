using UnityEngine;

public class UIManager : MonoBehaviour
{
    public void ExitGame()
    {
        Application.Quit();
    }
    public void ExampleFunction()
    {
        Debug.Log("Это пример публичной функции!");
    }
}