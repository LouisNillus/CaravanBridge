using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element : MonoBehaviour
{
    public enum ElementsType { Rod, Plank, Rope, Tendeur }
    public ElementsType type;
    [SerializeField] Transform firstBlock;
    [SerializeField] Transform secondBlock;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.right = secondBlock.position - transform.position;
        transform.localScale = new Vector2(Vector2.Distance(firstBlock.position, secondBlock.position) * 7, 1);
        transform.position = new Vector2((firstBlock.position.x + secondBlock.position.x) / 2, (firstBlock.position.y + secondBlock.position.y) / 2);
        if (type == ElementsType.Tendeur)
        {
            firstBlock.GetComponent<DistanceJoint2D>().distance -= 0.2f;
        }
    }

    public void SetAttachedBlocks(Transform firstB, Transform secondB)
    {
        firstBlock = firstB;
        secondBlock = secondB;
    }
}
