using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Cameras
{
    public class IP_Camera_Menu : MonoBehaviour
    {
        [MenuItem("Super Tankies/Cameras/Top Down Camera")]
        public static void CreateTopDownCamera()
        {
            GameObject[] selectedGO = Selection.gameObjects;

            if(selectedGO.Length > 0 && selectedGO[0].GetComponent<Camera>())
            {
                if (selectedGO.Length < 2)
                {
                    AttachTopDownScript(selectedGO[0].gameObject, null);
                }
                else if (selectedGO.Length == 2)
                {
                    AttachTopDownScript(selectedGO[0].gameObject, selectedGO[1].transform);
                }
                else if(selectedGO.Length == 3)
                {
                    EditorUtility.DisplayDialog("Camera Tools", "You can only select two GameObjects in the scene for this to work", "OK");
                }
            }
            else
            {
                EditorUtility.DisplayDialog("Camera Tools", "You need to select a GameObject in the that has a Camera component assigned to it!", "OK");
            }
        }

        static void AttachTopDownScript(GameObject aCamera, Transform aTarget)
        {
            IP_TopDown_Camera cameraScript = null;
            if (aCamera)
            {
                cameraScript = aCamera.AddComponent<IP_TopDown_Camera>();
            }
            if(cameraScript && aTarget)
            {
                cameraScript.m_Target = aTarget.transform;
            }
        }
    }
}