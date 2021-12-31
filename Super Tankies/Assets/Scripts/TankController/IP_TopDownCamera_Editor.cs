using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Cameras
{
    [CustomEditor(typeof(IP_TopDown_Camera))]
    public class IP_TopDownCamera_Editor : Editor
    {
        #region Variables
        private IP_TopDown_Camera targetCamera;
        #endregion

        #region Main Methods
        void OnEnable()
        {
            targetCamera = (IP_TopDown_Camera)target;
        }
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
        }

        void OnSceneGUI()
        {
            if (!targetCamera.m_Target)
            {
                return;
            }
            
            Transform camTarget = targetCamera.m_Target;

            

            Handles.color = new Color(1f, 0f, 0f, 0.15f);
            Handles.DrawSolidDisc(targetCamera.m_Target.position, Vector3.up, targetCamera.m_Distance);

            Handles.color = new Color(1f, 0f, 0f, 0.75f);
            Handles.DrawWireDisc(targetCamera.m_Target.position, Vector3.up, targetCamera.m_Distance);

            Handles.color = new Color(1f, 0f, 0f, 0.15f);
            targetCamera.m_Distance = Handles.ScaleSlider(targetCamera.m_Distance, camTarget.position, -camTarget.forward, Quaternion.identity, targetCamera.m_Distance, 1f);

            Handles.color = new Color(0f, 0f, 1f, 0.15f);
            targetCamera.m_Height = Handles.ScaleSlider(targetCamera.m_Height, camTarget.position, -camTarget.forward, Quaternion.identity, targetCamera.m_Height, 1f);
        }
        #endregion
    }
}

