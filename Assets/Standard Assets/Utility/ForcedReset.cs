using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // ʹ���µ� UI ϵͳ
using UnityStandardAssets.CrossPlatformInput;

public class ForcedReset : MonoBehaviour
{
    // ����ѡ�����һ�� UI.Image ��Ϊ��ʾ
    public Image resetPrompt;

    private void Update()
    {
        // ����Ƿ񴥷����ò���
        if (CrossPlatformInputManager.GetButtonDown("ResetObject"))
        {
            // �������ʾ�� Image������ʾ����
            if (resetPrompt != null)
            {
                resetPrompt.enabled = true;
            }

            // ���¼��ص�ǰ����
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        }
    }
}
