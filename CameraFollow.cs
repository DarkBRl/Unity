using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class CameraFollow : MonoBehaviour
{
	public static GameObject objectToFollow ;
   
	public float speed = 200.0f;

	public int i ;


	void Update ()
	{

		float interpolation = speed * Time.deltaTime;

		Vector3 position = this.transform.position;
		position.y = Mathf.Lerp (this.transform.position.y, objectToFollow.transform.position.y, interpolation);
		position.x = Mathf.Lerp (this.transform.position.x, objectToFollow.transform.position.x, interpolation);

		this.transform.position = position;





	}

	public void OnLobbyClientConnect()
	{

		objectToFollow = GameObject.FindGameObjectsWithTag ("Player") [NetworkServer.connections.Count-1];

		Debug.Log("asdsadsadsadsadsadasdasd");

	}
	public void OnClientExitLobby()
	{

		objectToFollow = GameObject.FindGameObjectsWithTag ("Player") [NetworkServer.connections.Count-1];

		Debug.Log("asdsadsadsadsadsadasdasd");

	}
	public void OnLobbyClientEnter()
	{

		objectToFollow = GameObject.FindGameObjectsWithTag ("Player") [NetworkServer.connections.Count-1];

		Debug.Log("asdsadsadsadsadsadasdasd");

	}
	public void OnLobbyStartHost()
	{

		objectToFollow = GameObject.FindGameObjectsWithTag ("Player") [NetworkServer.connections.Count-1];

		Debug.Log("asdsadsadsadsadsadasdasd");

	}
	public void OnLobbyStartServer()
	{

		objectToFollow = GameObject.FindGameObjectsWithTag ("Player") [NetworkServer.connections.Count-1];

		Debug.Log("asdsadsadsadsadsadasdasd");

	}




}
