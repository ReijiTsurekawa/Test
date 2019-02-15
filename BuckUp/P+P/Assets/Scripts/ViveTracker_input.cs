using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViveTracker_input : MonoBehaviour {

    public float ViveTracker_Rotate_X=0, ViveTracker_Rotate_Y=0, ViveTracker_Rotate_Z=0;
    public float ViveTracker_Pos_X=0, ViveTracker_Pos_Y=0, ViveTracker_Pos_Z=0;

    public void setRotate(float X, float Y, float Z)
    {
        ViveTracker_Rotate_X = X;
        ViveTracker_Rotate_Y = Y;
        ViveTracker_Rotate_Z = Z;
    }

    public void setPos(float X, float Y, float Z)
    {
        ViveTracker_Pos_X = X;
        ViveTracker_Pos_Y = Y;
        ViveTracker_Pos_Z = Z;
    }

    public float getRotate_X()
    {
        return ViveTracker_Rotate_X;
    }
    public float getRotate_Y()
    {
        return ViveTracker_Rotate_Y;
    }
    public float getRotate_Z()
    {
        return ViveTracker_Rotate_Z;
    }
}
