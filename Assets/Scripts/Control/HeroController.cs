using UnityEngine;
using RPG.Movement;
using RPG.Core;


namespace RPG.Control
{
    public class HeroController : MonoBehaviour
    {

        private void Update()
        {
            //ctrl + . to automatically create function below
            CombatInteraction();
            MovementInteraction();
        }

        private void CombatInteraction()
        {
            //option 8/8. returns all the things that get hit in an array.
            //https://docs.unity3d.com/ScriptReference/Physics.RaycastAll.html
            RaycastHit[] hits = Physics.RaycastAll(GetMouseRay());
            //Return a list of each hit foreach hit
        }
        private void MovementInteraction()
        {
            //Raycast from camera to left mouse-click location
            if (Input.GetMouseButtonDown(1))
            {
                MoveToCursor();
            }
        }

        //implement click to move on left click
        private void MoveToCursor()
        {
            
            //https://docs.unity3d.com/ScriptReference/RaycastHit.html
            RaycastHit hit;
            //when hasHit is true, store position of raycast in (out) hit.
            bool hasHit = Physics.Raycast(GetMouseRay(), out hit);
            if (hasHit)
            {
                //Be able to Raycast to components, not just terrain
                GetComponent<Mover>().MoveTo(hit.point);
            }
        }
        private static Ray GetMouseRay()
        {
            return Camera.main.ScreenPointToRay(Input.mousePosition);
        }

    }
}