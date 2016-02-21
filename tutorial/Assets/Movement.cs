using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public GameObject character;
    Vector3 newPosition;
    float speed = 0.1F;
    int[] xGoals = { 0, 0, -50, -50, -25, -25 };
    int[] zGoals = { 0, 50, 50, -50, -50, 0 };
    int xGoal;
    int zGoal;
    int stage = 0;

    // Use this for initialization
    void Start () {
	    newPosition = character.transform.position;
        xGoal = xGoals[stage];
        zGoal = zGoals[stage];

    }//end start
	
	// Update is called once per frame
	void Update () {
        
        Debug.Log("Position X: " + newPosition.x);
        Debug.Log("Position Z: " + newPosition.z);

        if(!((newPosition.x<xGoal+1 && newPosition.x>xGoal-1) && (newPosition.z < zGoal + 1 && newPosition.z > zGoal - 1)))
        {
            if (newPosition.x > xGoal)
            {
                xDecrease();

            }//end if
            else
            {
                xIncrease();

            }//end else


            if (newPosition.z > zGoal)
            {
                zDecrease();

            }//end if z
            else
            {
                zIncrease();

            }
            
        }//end check if not at goal
        else
        {
            //Debug.Log("YOU FOUND IT!\n\n\nHELLO MO FUGGA\n\n\n");
            stage++;
            xGoal = xGoals[stage];
            zGoal = zGoals[stage];

            if (stage == 5)
            {
                stage = -1;
            }

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            newPosition.x++;
            character.transform.position = newPosition;

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            newPosition.x--;
            character.transform.position = newPosition;

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            newPosition.z++;
            character.transform.position = newPosition;

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            newPosition.z--;
            character.transform.position = newPosition;

        }//end if statements for movement

    }//end update

    void xIncrease()
    {
        newPosition.x += 1 * speed;
        character.transform.position = newPosition;

    }//end xIncrement

    void xDecrease()
    {
        newPosition.x -= 1 * speed;
        character.transform.position = newPosition;

    }//end xDecrease
    
    void zIncrease()
    {
        newPosition.z += 1 * speed;
        character.transform.position = newPosition;

    }

    void zDecrease()
    {
        newPosition.z -= 1 * speed;
        character.transform.position = newPosition;

    }//end zDecrease

}//end file
