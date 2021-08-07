using UnityEngine;

public class GameObjectScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TestLib.OnHtmlButtonClick += TestLib_OnHtmlButtonClick;
    }

    private void TestLib_OnHtmlButtonClick(int arg)
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
