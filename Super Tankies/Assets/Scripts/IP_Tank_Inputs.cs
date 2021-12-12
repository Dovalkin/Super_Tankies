using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tanky
{
    public class IP_Tank_Inputs : MonoBehaviour
    {
        #region Variables
        [Header("Input Properties")]
        public Camera gameCamera;
        #endregion

        #region Properties
        private Vector3 reticlePosition;
        public Vector3 ReticlePosition
        {
            get { return reticlePosition; }
        }

        private Vector3 reticleNormal;
        public Vector3 ReticleNormal
        {
            get { return reticleNormal; }
        }

        private float forwardInput;
        public float ForwardInput
        {
            get { return forwardInput; }
        }

        private float rotationInput;
        public float RotationInput
        {
            get { return rotationInput; }
        }
        #endregion

        #region Builtin Methods
        // Update is called once per frame
        void Update()
        {
            if (gameCamera)
            {
                HandleInputs();
            }
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(reticlePosition, 0.5f);
        }
        #endregion

        #region Custom Methods
        protected virtual void HandleInputs()
        {
            Ray screenRay = gameCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(screenRay, out hit))
            {
                reticlePosition = hit.point;
                reticleNormal = hit.normal;
            }

            forwardInput = Input.GetAxis("Vertical");
            rotationInput = Input.GetAxis("Horizontal");
        }
        #endregion
    }
}

