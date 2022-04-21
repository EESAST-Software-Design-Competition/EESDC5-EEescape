using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject target;
    public float xzdistance;
    public float heightdistance;
    public float dampingy=0.2f;
    public float dampingz=0.2f;
    public float dampingx=0.2f;
    public float dampingr=0.2f;

    public float cameraspeed=1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate() 
    {
        if(!target)
            return;
        float wantedRotationAngle = target.transform.eulerAngles.y; 
        float wantedHeight = target.transform.position.y+heightdistance;
        float wantedx = target.transform.position.z-xzdistance;
        float wantedz = target.transform.position.x-xzdistance;
        
        float currentR = this.transform.eulerAngles.y;
        float currentHeight = this.transform.position.y;
        float currentz = this.transform.position.z;
        float currentx = this.transform.position.x;

        currentR = Mathf.LerpAngle(currentR,wantedRotationAngle,dampingr*Time.deltaTime);
        currentHeight = Mathf.Lerp(currentHeight,wantedHeight,dampingy*Time.deltaTime);
        currentz = Mathf.Lerp(currentz,wantedz,dampingz*Time.deltaTime);
        currentx = Mathf.Lerp(currentx,wantedx,dampingx*Time.deltaTime);

        Quaternion currentRotation = Quaternion.Euler(0,currentR,0);
        transform.position -= currentRotation*Vector3.forward*xzdistance;
        
        Vector3 pos=new Vector3(currentx,currentHeight,currentz);
        transform.position=pos;

        var Camerarotation = Quaternion.LookRotation(target.transform.position - this.transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation,Camerarotation,Time.deltaTime*cameraspeed);
    }
}
