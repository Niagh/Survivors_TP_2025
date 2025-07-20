using UnityEngine;

public class UpgradeUI : MonoBehaviour
{
    public GameObject panel;

    public void ShowUpgrade()
    {
        panel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void HideUpgrade()
    {
        panel.SetActive(false);
        Time.timeScale = 1f;
    }
}