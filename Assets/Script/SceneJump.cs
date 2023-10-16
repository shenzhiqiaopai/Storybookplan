using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneJump : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void JumpH ()//第一个场景 
	{
		SceneManager.LoadScene(0);
	}
	public void Jump1() //第二个场景
	{
		SceneManager.LoadScene(1);
	}
    public void Jump2() //第三个场景
	{
		SceneManager.LoadScene(2);
	}
    public void Jump3() //第四个场景
	{
		SceneManager.LoadScene(3);
	}
    public void Jump4() //第五个场景
	{
		SceneManager.LoadScene(4);
	}
    public void Jump5() //第六个场景
	{
		SceneManager.LoadScene(5);
	}
    public void JumpC() //第七个场景
	{
		SceneManager.LoadScene(6);
	}
}
