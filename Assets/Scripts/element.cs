using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class element : MonoBehaviour
{
    public GameObject itemLi;
    IEnumerator coolCounter;
    WaitForFixedUpdate fixedUpdate = new WaitForFixedUpdate();
    float coolTime;
    float filledTime;

    IEnumerator CountCool()
    {
        itemLi.SetActive(false);
        coolTime = 3f;
        filledTime = 0f;

        for(;;)
        {
            if(filledTime < coolTime)
            {
                yield return fixedUpdate;

                filledTime += Time.deltaTime;
            }
            else
            {
                itemLi.SetActive(true);
                yield break;
            }
        }
    }

    void Start()
    {
        itemLi = this.GetComponent<GameObject>();
        coolCounter = CountCool();
    }

//    public void ItemDrop()
//    {
//        //Ramdom Ratio Item Drop
//        //int ran = Random.Range(0, 10);
//        //if (ran < 10)
//        coolTime = 3f;
//        filledTime = 0f;

//        for(;;)
//        {
//            if(filledTime < coolTime)
//            {
//                yield return fixedUpdate;

//                filledTime += Time.deltaTime;
//            }
//        }
//        if(curTime > 0)
//            Instantiate(itemLi, transform.position, itemLi.transform.rotation);

//    }

}
