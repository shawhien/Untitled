using UnityEngine;

public class HeroController : MonoBehaviour {
    //implement click to move on left click
    private void MoveToCursor()
    {
        //create variable parameters for Raycast()
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        // https://docs.unity3d.com/ScriptReference/RaycastHit.html
        RaycastHit hit;
        //when hasHit is true, store position of raycast in (out) hit.
        bool hasHit = Physics.Raycast(ray, out hit);
        if (hasHit)
        {
            //https://docs.unity3d.com/ScriptReference/RaycastHit-point.html
            MoveTo(hit.point);
        }
    }
}