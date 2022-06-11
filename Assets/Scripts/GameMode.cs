using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
public class GameMode : MonoBehaviour
{

    [SerializeField]
    InputsManager _inputsManager;
    private async void Start()
    {
        /*while(true)
        {
            if(GameManage.instance != null)
            {
                GameManage.instance.GameMode = this;
                break;
            }
            yield return null;
        }*/

        while (GameManage.instance == null)
        {
            await Task.Yield();

        }

        GameManage.instance.GameMode = this;
    }

    public InputsManager InputsManager => _inputsManager;
}
