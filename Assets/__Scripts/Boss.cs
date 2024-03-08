using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : Enemy
{
    private Vector3 pos1;
    public override void Move()
    {
        
            float widMinRad = bndCheck.camWidth - bndCheck.radius;
            float hgtMinRad = bndCheck.camHeight - bndCheck.radius;

            pos1.x = Random.Range(-widMinRad, widMinRad);
            pos1.y = Random.Range(-hgtMinRad, hgtMinRad);

            this.transform.position = Vector3.MoveTowards(transform.position, pos1, speed * Time.deltaTime);


    }
    // Start is called before the first frame update
    void Start()
    {
        pos1.x = Random.Range(-bndCheck.camWidth, bndCheck.camWidth);
        pos1.y = Random.Range(-bndCheck.camHeight, bndCheck.camHeight);

    }
}
