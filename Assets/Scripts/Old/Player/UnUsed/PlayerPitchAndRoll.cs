/*using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using BeardedManStudios.Network;

public class PlayerPitchAndRoll : SimpleNetworkedMonoBehavior {
    static float currentPitch = 0f;
    static float pitchSpeed = 50f;
    static float currentYaw = 0f;
    static float yawSpeed = 50f;

    Vector3 pitchAndYaw;

    PitchAndYaw _pitchAndYaw;

    // Update is called once per frame
    void FixedUpdate() {
        currentPitch = CrossPlatformInputManager.GetAxis("Horizontal");
        //currentPitch += _pitchAndYaw.newPos.x;
        //currentYaw += _pitchAndYaw.newPos.y;
        //currentPitch += CrossPlatformInputManager.GetAxis("Horizontal");
        //currentYaw += CrossPlatformInputManager.GetAxis("Vertical");
        Debug.Log(CrossPlatformInputManager.GetAxis("Horizontal"));
        //Debug.Log("Current Pitch " + currentPitch);
        //Debug.Log("Current Yaw " + currentYaw);
        //GetComponent<Rigidbody>().AddRelativeTorque(currentPitch*pitchSpeed*Time.deltaTime, currentYaw*yawSpeed*Time.deltaTime, 0);
        Vector3 pitchRoll = new Vector3(currentPitch * pitchSpeed, currentYaw * yawSpeed, 0);
        //transform.Rotate(pitchRoll);
    }
}
*/