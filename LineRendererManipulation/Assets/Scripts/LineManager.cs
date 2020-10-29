using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineManager : MonoBehaviour
{
    //line renderers
    [SerializeField] private LineRenderer line;
    [SerializeField] private LineRenderer duplicateLine;

    void Start()
    {
        //Get array of line renderer positions
        Vector3[] linePositionsArray = new Vector3[line.positionCount];
        line.GetPositions(linePositionsArray);

        duplicateLine.positionCount = line.positionCount;

        //set duplicate line positions based off array of positions
        for (int i = 0; i < duplicateLine.positionCount; i++)
        {
            duplicateLine.SetPosition(i, linePositionsArray[i]);
        }
    }
}
