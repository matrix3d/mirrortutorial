using Mirror;
using Mono.CecilX;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMgr : NetworkBehaviour
{
    public Button btn;
    public GameObject cubePrefab;

    // Start is called before the first frame update
    void Start()
    {
		btn.onClick.AddListener(() => {
            CmdAddCube(Random.Range(0,10));
        });
    }

    [Command(requiresAuthority =false)]
    void CmdAddCube(int num, NetworkConnectionToClient owner=null)
    {
        print("addcube:"+num);
        var cube = Instantiate(cubePrefab);
		cube.GetComponent<NetCube>().num=num;
		//cube.GetComponent<NetCube>().setNum(num);
		NetworkServer.Spawn(cube/*, owner*/);//如果不想客户端退出，清除此客户端产生的cube，就不传这个netowrkconnection
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
