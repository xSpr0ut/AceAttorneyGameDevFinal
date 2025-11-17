using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TESTING
{
    public class Testing_Architect : MonoBehaviour
    {
        DialogueSystem ds;
        TextArchitect architect;

        string[] lines = new string[5]
        {
            "This is a random line of dialogue ",
            "I am Furina! ",
            "Hello... ",
            "Blah Blah Blah ",
            "I am the best "
        };

        void Start()
        {
            ds = DialogueSystem.instance;
            architect = new TextArchitect(ds.dialogueContainer.dialogueText);
            architect.buildMethod = TextArchitect.BuildMethod.typewriter;
            architect.speed = 0.5f;
        }

        // Update is called once per frame
        void Update()
        {
            string longLine = "this is a very line that makes no sense but i am just populating it with stuff because i am trying to test if this shit works. dfk;ajfsld kjf;lsakdfj ;lksajdfjklsa ;djf;ljasdfj lasjdfj;salkdjf;lksadjfklsajdlk;fjsdf";
            if(Input.GetKeyDown(KeyCode.Space)) //Single Click Build New Line
            {
                if(architect.isBuilding) //Check if something is building
                {
                    if(!architect.hurryUp) //Second Click = Hurry Up (Speed Up)
                        architect.hurryUp = true;
                    
                    else //Third Click = Complete Line
                        architect.ForceComplete();
                }
                else
                {
                    architect.Build(longLine);
                    //architect.Build(lines[Random.Range(0, lines.Length)]);
                }
            }
            else if (Input.GetKeyDown(KeyCode.A)) //Append Line
            {
                architect.Append(longLine);
                //architect.Append(lines[Random.Range(0, lines.Length)]);
            }

        }
    }
}
