using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetCube : NetworkBehaviour
{

	[SyncVar]
	public int num;
	// Start is called before the first frame update
	void Start()
    {
        setNum(num);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setNum(int num)
    {
        GetComponentInChildren<TextMesh>().text = num.ToString();
    }
}
