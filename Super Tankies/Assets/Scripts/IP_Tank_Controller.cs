using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tanky
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(IP_Tank_Inputs))]
    public class IP_Tank_Controller : MonoBehaviour
    {

        #region Variables
        [Header("Movement Properties")]
        public float tankSpeed = 15f;
        public float tankRotationSpeed = 20f;

        private Rigidbody rb;
        private IP_Tank_Inputs input;
        #endregion

        #region Builtin Methods
        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
            input = GetComponent<IP_Tank_Inputs>();
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if(rb && input)
            {
                HandleMovement();
            }
        }
        #endregion


        #region Custom Methods
        protected virtual void HandleMovement()
        {
            //Move Tank forward
            Vector3 wantedPosition = transform.position + (transform.forward * input.ForwardInput * tankSpeed * Time.deltaTime);
            rb.MovePosition(wantedPosition);

            //Rotate the Tank
            Quaternion wantedRotation = transform.rotation * Quaternion.Euler(Vector3.up * (tankRotationSpeed * input.RotationInput * Time.deltaTime));
            rb.MoveRotation(wantedRotation);
        }
        #endregion
    }
}
