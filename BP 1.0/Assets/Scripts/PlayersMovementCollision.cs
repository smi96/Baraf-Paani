using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Networking.Types;
using UnityEngine.Networking.Match;
using UnityEngine.Networking.NetworkSystem;
using UnityEngine.UI;
using Prototype.NetworkLobby;
using AssemblyCSharp;
public class PlayersMovementCollision : NetworkBehaviour {

	public float speed;
	public float rspeed;
	public KeyCode left;
	public KeyCode right;
	public KeyCode up;
	public KeyCode down;
	public KeyCode rleft;
	public KeyCode rright;
	private Rigidbody rb;
	public bool upmove;
	public bool downmove;
	public bool leftmove;
	public bool rightmove;
	public bool rotateleft;
	public bool rotateright;
	[SyncVar]
	public bool freeze;
	[SyncVar]
	public string tag;
	[SyncVar]
	public Color objColor;
	LobbyPlayer lobbyPlayer;
	public Text wintext;
	//private Camera cam;


	/*public static class GlobalVariables{
		public static int numfreeze; 
	}*/


	void Start () {

		rb = GetComponent<Rigidbody> ();
		rb.GetComponent<MeshRenderer> ().material.color = objColor;
		freeze = false;
		GlobalVariables.numfreeze = 0;
		//cam = this.transform.GetChild(0).GetComponent<Camera> ();
		//wintext = GetComponent<Text> ();


		/*lobbyPlayer = GetComponent<LobbyPlayer> ();

		if (lobbyPlayer.tag.Equals("Dan"))   {
			print ("1");
			this.GetComponent<MeshRenderer> ().material.color = Color.red;
		} else {
			print ("2");
			this.GetComponent<MeshRenderer>().material.color = Color.blue;
		}*/


		/*if (GetComponent<NetworkIdentity> ().isServer && isLocalPlayer) {
			this.GetComponent<MeshRenderer>().material.color = Color.red;

		}*/
		/*else if(  ) {
			GetComponent<MeshRenderer>().material.color = Color.blue;
		}*/

if (isLocalPlayer) {
	this.transform.GetChild (0).gameObject.GetComponent<Camera> ().enabled = true;
} else {
	this.transform.GetChild (0).gameObject.GetComponent<Camera> ().enabled = false;
}
}

/*void OnGUI(){
	rb.GetComponent<MeshRenderer>().material.color = lobbyPlayer.playerColorType;
	}
*/
void Update () {

		if (freeze) {
			rb.GetComponent<MeshRenderer> ().material.color = Color.white;
		} else {

			if (this.tag.Equals ("Runner"))
				rb.GetComponent<MeshRenderer> ().material.color = Color.blue;
			else
				rb.GetComponent<MeshRenderer> ().material.color = Color.red;
		}

		if (!isLocalPlayer) {
			return;
		}


		if (freeze) {
			rb.velocity = new Vector3 (0.0f, 0.0f, 0.0f);
			if (rotateleft)
				transform.Rotate (0, -rspeed, 0);
			if (rotateright)
				transform.Rotate (0, rspeed, 0);
		} else {
			if (leftmove) {
				transform.Translate (-speed * Time.deltaTime, 0, 0, transform);
				print ("left");
			}
			if (rightmove)
				transform.Translate (speed * Time.deltaTime, 0, 0, transform);
			if (upmove)
				transform.Translate (0, 0, speed * Time.deltaTime, transform);
			if (downmove)
				transform.Translate (0, 0, -speed * Time.deltaTime, transform);
			if (rotateleft)
				transform.Rotate (0, -rspeed, 0);
			if (rotateright)
				transform.Rotate (0, rspeed, 0);
		}
		if (Input.GetKey (left)) {
			//rb.velocity = new Vector3 (-speed, 0.0f, rb.velocity.z);
			rb.transform.Translate (-speed * Time.deltaTime, 0, 0, rb.transform);
		}
		if (Input.GetKey (right)) {
			//rb.velocity = new Vector3 (speed, 0.0f, rb.velocity.z);
			rb.transform.Translate (speed * Time.deltaTime, 0, 0, rb.transform);
		}
		if (Input.GetKey (up)) {
			//rb.velocity = new Vector3 (rb.velocity.x, 0.0f, speed);
			rb.transform.Translate (0, 0, speed * Time.deltaTime, rb.transform);
		}
		if (Input.GetKey (down)) {
			//rb.velocity = new Vector3 (rb.velocity.x, 0.0f, -speed);
			rb.transform.Translate (0, 0, -speed * Time.deltaTime, rb.transform);
		}
		if (Input.GetKey (rleft)) {
			rb.transform.Rotate (0, -rspeed, 0);
			//this.transform.GetChild(0).GetComponent<Camera> ().transform.Rotate (0, -rspeed, 0);
		}
		if (Input.GetKey (rright)) {
			rb.transform.Rotate (0, rspeed, 0);
			//this.transform.GetChild(0).GetComponent<Camera> ().transform.Rotate (0, rspeed, 0);
		}/*else {
		rb.velocity = new Vector3 (0.0f, 0.0f, 0.0f);	
	}*/

	}

	//print (GlobalVariables.numfreeze);

	//Game end Code here ....


	/*if(!isLocalPlayer)
	{
		return;
	}
	if (freeze) {
		rb.velocity = new Vector3 (0.0f, 0.0f, 0.0f);
	}
	else if (Input.GetKey (left)) {
		//rb.velocity = new Vector3 (-speed, 0.0f, rb.velocity.z);
		rb.transform.Translate (-speed * Time.deltaTime, 0, 0, rb.transform);
	} else if (Input.GetKey (right)) {
		//rb.velocity = new Vector3 (speed, 0.0f, rb.velocity.z);
		rb.transform.Translate (speed * Time.deltaTime, 0, 0, rb.transform);
	} else if (Input.GetKey (up)) {
		//rb.velocity = new Vector3 (rb.velocity.x, 0.0f, speed);
		rb.transform.Translate (0, 0, speed * Time.deltaTime, rb.transform);
	} else if (Input.GetKey (down)) {
		//rb.velocity = new Vector3 (rb.velocity.x, 0.0f, -speed);
		rb.transform.Translate (0, 0, -speed * Time.deltaTime, rb.transform);
	}
	else if (Input.GetKey (rleft)) {
			rb.transform.Rotate (0, -rspeed, 0);
		//this.transform.GetChild(0).GetComponent<Camera> ().transform.Rotate (0, -rspeed, 0);
	}
	else if (Input.GetKey (rright)) {
			rb.transform.Rotate (0, rspeed, 0);
		    //this.transform.GetChild(0).GetComponent<Camera> ().transform.Rotate (0, rspeed, 0);
	}else {
		rb.velocity = new Vector3 (0.0f, 0.0f, 0.0f);	
	}

	//print (GlobalVariables.numfreeze);

	//Game end Code here ....(MIshra code)*/ 



/*public override void OnStartLocalPlayer()
	{
		if (GetComponent<NetworkIdentity> ().isServer) {
			GetComponent<MeshRenderer> ().material.color = Color.red;
		}
	}*/


/*public override void OnStartServer()
{
	base.OnStartServer ();
	if (GetComponent<NetworkIdentity> ().isServer) {
		GetComponent<MeshRenderer> ().material.color = Color.red;
	}
}*/
/*public override void OnStartClient()
{
	base.OnStartClient ();
	GetComponent<MeshRenderer> ().material.color = Color.blue;
}*/


//Collision Starts here
void OnCollisionEnter(Collision other)
	{
		var c = other.collider.GetComponent<PlayersMovementCollision> ().tag;
		//print ("My tag " + this.tag + " other tag " + c);
		/*if (c.Equals("Runner") && GetComponent<NetworkIdentity> ().isServer && isLocalPlayer) {
				other.gameObject.GetComponent<PlayersMovementCollision> ().freeze = true;
				GlobalVariables.numfreeze = GlobalVariables.numfreeze + 1;
			}
		else if (c.Equals("Runner") && other.gameObject.GetComponent<PlayersMovementCollision> ().freeze == true)
			{
				other.gameObject.GetComponent<PlayersMovementCollision> ().freeze = false;
				GlobalVariables.numfreeze = GlobalVariables.numfreeze - 1;
			}*/

		if (c.Equals ("Runner") && this.tag.Equals ("Runner"))
		{
			this.freeze = false;
			other.collider.GetComponent<PlayersMovementCollision> ().freeze = false;
			GlobalVariables.numfreeze--;
		} 
		else if (c.Equals ("Dan") || this.tag.Equals ("Dan"))
		{
			if (c.Equals ("Dan") && this.freeze == false)
			{
				this.freeze = true;
				GlobalVariables.numfreeze++;
			} 
			else if(this.tag.Equals("Dan") && other.collider.GetComponent<PlayersMovementCollision> ().freeze==false)
			{
			other.collider.GetComponent<PlayersMovementCollision> ().freeze = true;
				GlobalVariables.numfreeze++;
			}	
	
		}

		

		
		
	}
	
	

}
