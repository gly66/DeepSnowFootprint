using System;
using UnityEngine;
using UnityEngine.UI; // ���� Unity UI ϵͳ

namespace UnityStandardAssets.Utility
{
    public class SimpleActivatorMenu : MonoBehaviour
    {
        // �� UI.Text ��� GUIText
        public Text camSwitchButton;
        public GameObject[] objects;

        private int m_CurrentActiveObject;

        private void OnEnable()
        {
            // ����Ķ���������еĵ�һ����ʼ
            m_CurrentActiveObject = 0;
            UpdateCameraSwitchButton();
        }

        public void NextCamera()
        {
            int nextActiveObject = m_CurrentActiveObject + 1 >= objects.Length ? 0 : m_CurrentActiveObject + 1;

            for (int i = 0; i < objects.Length; i++)
            {
                objects[i].SetActive(i == nextActiveObject);
            }

            m_CurrentActiveObject = nextActiveObject;
            UpdateCameraSwitchButton();
        }

        private void UpdateCameraSwitchButton()
        {
            if (camSwitchButton != null && m_CurrentActiveObject >= 0 && m_CurrentActiveObject < objects.Length)
            {
                camSwitchButton.text = objects[m_CurrentActiveObject].name;
            }
        }
    }
}
