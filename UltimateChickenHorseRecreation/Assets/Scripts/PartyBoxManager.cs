using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyBoxManager : MonoBehaviour
{
    public Animator anim;
    public Canvas partyBox;
    public Texture2D cursorCharacter;
    public GameObject poof;
    public GameObject[] objects;
    public GameObject[] spawned;
    public int spawnAmount;
    bool firstSpawn;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        firstSpawn = true;
    }

    private void Update()
    {
        if(anim.GetBool("gone"))
        {
            partyBox.enabled = false;
        }
    }

    public void SpawnObjects()
    {
        Debug.Log("Spawning Objects");
        for (int i = 0; i < spawnAmount; i++)
        {
            float randomXPos = Random.Range(-300, 300);
            float randomYPos = Random.Range(-300, 300);
            float lastX = 0, lastY = 0;
            Vector2 pos = new Vector2(0, 0);

            if (firstSpawn)
            {
                firstSpawn = false;
                lastX = randomXPos;
                lastY = randomYPos;
                pos = new Vector2(randomXPos, randomYPos);
            }
            else if (randomXPos != lastX && randomYPos != lastY)
            {
                lastX = randomXPos;
                lastY = randomYPos;
                pos = new Vector2(randomXPos, randomYPos);
            }
            GameObject newObj = objects[Random.Range(0, objects.Length)];
            newObj.layer = 5;
            newObj = Instantiate(newObj, pos, Quaternion.identity);
            newObj.transform.SetParent(partyBox.transform, false);
            newObj.transform.localScale = new Vector3(1, 1, 1);
            spawned[i] = newObj;
        }
    }

    public void ActivateCursor()
    {
        Cursor.visible = true;
        Cursor.SetCursor(cursorCharacter, new Vector2(190f, 60f), CursorMode.ForceSoftware);
    }

    public void ActivateBox()
    {
        partyBox.enabled = true;
        anim.Play("BoxAppear", 0, 0f);
    }

    public void DisappearBox()
    {
        anim.Play("BoxClose");
    }

    public void DestroySpawned()
    {
        for (int i = 0; i < spawned.Length; i++)
        {
            GameObject newPoof = Instantiate(poof, spawned[i].transform.localPosition, Quaternion.identity);
            newPoof.transform.SetParent(partyBox.transform, false);
            newPoof.transform.localScale = new Vector3(1, 1, 1);
            Destroy(spawned[i]);
        }
    }
}
