using UnityEngine;

public class StartButtonScript : MonoBehaviour
{
    public void OnClick()
    {
        TitleManager.Instance.StartGame();
        Debug.Log("クリックされました。");
    }
}
