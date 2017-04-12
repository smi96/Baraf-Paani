using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class touch : NetworkBehaviour {

	private PlayersMovementCollision[] psingle;
	private PlayersMovementCollision p;

	// Use this for initialization
	void Start () {
		print ("start");
		psingle = FindObjectsOfType<PlayersMovementCollision> ();
		foreach (PlayersMovementCollision ps in psingle) {
			if (ps.isLocalPlayer) {
				p = ps;
				break;
			}
		}
			
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LeftArrow()
	{
		if (!p.isLocalPlayer)
			return;
		print ("lhere");
		p.rightmove = false;
		p.leftmove = true;

	}
	public void RightArrow()
	{
		if (!p.isLocalPlayer)
			return;
		print ("rhere");
		p.rightmove = true;
		p.leftmove = false;
	}
	public void topArrow()
	{
		if (!p.isLocalPlayer)
		return;
		print ("uhere");
		p.upmove = true;
		p.downmove = false;
	}
	public void downArrow()
	{
		if (!p.isLocalPlayer)
			return;
		print ("dhere");
		p.downmove = true;
		p.upmove = false;
	}
	public void ReleaseLeftArrow()
	{
		if (!p.isLocalPlayer)
			return;
		print ("rlhere");
		p.leftmove = false;
	}
	public void ReleaseRightArrow()
	{
		if (!p.isLocalPlayer)
			return;
		print ("rrhere");
		p.rightmove = false;

	}
	public void ReleasetopArrow()
	{
		if (!p.isLocalPlayer)
			return;
		p.upmove = false;
	}
	public void ReleasedownArrow()
	{
		if (!p.isLocalPlayer)
			return;
		p.downmove = false;

	}
	public void rleftArrow()
	{
		if (!p.isLocalPlayer)
			return;
		p.rotateleft = true;
		p.rotateright = false;

	}
	public void RRightArrow()
	{
		if (!p.isLocalPlayer)
			return;
		p.rotateleft = false;
		p.rotateright = true;

	}
	public void ReleaserLeftArrow()
	{
		if (!p.isLocalPlayer)
			return;
		p.rotateleft = false;
	}
	public void ReleaserRightArrow()
	{
		if (!p.isLocalPlayer)
			return;
		p.rotateright = false;

	}
}
