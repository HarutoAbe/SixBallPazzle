using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// シーンの名前を管理するクラス
/// </summary>
public class SceneInstance : SingletonMonoBehaviour<SceneInstance>
{
    [Header("タイトルシーン")]
    public static string TITLE_SCENE = "TitleScene";

    [Header("メインシーン")]
    public static string MAIN_SCENE = "MainScene";

    public void LoadSceneTitle()
    {
        SceneManager.LoadScene(TITLE_SCENE);
    }

    public void LoadSceneMain()
    {
        SceneManager.LoadScene(MAIN_SCENE);
    }
}
