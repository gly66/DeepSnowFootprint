using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // 使用新的 UI 系统
using UnityStandardAssets.CrossPlatformInput;

public class ForcedReset : MonoBehaviour
{
    // 可以选择关联一个 UI.Image 作为提示
    public Image resetPrompt;

    private void Update()
    {
        // 检测是否触发重置操作
        if (CrossPlatformInputManager.GetButtonDown("ResetObject"))
        {
            // 如果有提示的 Image，就显示出来
            if (resetPrompt != null)
            {
                resetPrompt.enabled = true;
            }

            // 重新加载当前场景
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        }
    }
}
