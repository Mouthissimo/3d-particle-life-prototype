﻿using UnityEngine;

public class DetectorBlue : DetectorMAIN
{
    //
    //  OnTriggerStay Function
    //
    void OnTriggerStay(Collider col)
    {
        //  Checking if collider is a particle different from the parent
        if (col.GetComponent<ParticleScript>() != null && col.GetComponent<ParticleScript>().pType != ParticleScript.ParticleType.TYPE_3)
        {
            ParticleScript pColScript = col.GetComponent<ParticleScript>();
            float distance = Vector3.Distance(transform.parent.transform.position, col.transform.position);

            //  Getting the position and type of the particle detected
            Vector3 pColPosition = col.transform.position;
            ParticleScript.ParticleType pColType = pColScript.pType;

            //  Applying physics behavior
            if (pColType == ParticleScript.ParticleType.TYPE_1)
            {
                AttractParticle(pColPosition, distance);
            }

            if (pColType == ParticleScript.ParticleType.TYPE_2)
            {
                RepulseParticle(pColPosition, distance);
            }
        }
    }
}