using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerLoadAdditive : MonoBehaviour
{
    // TODO 1 - Añadir string público que será el nombre del nivel a cargar

    /// <summary>
    /// La comprobación del tipo de gameobject que entra en el trigger se hace por tag
    /// El valor del tag que nos interesa se guarda en esta variable
    /// </summary>
    private string m_PlayerTag = "Player";
    public GameManager.DoorColor m_LevelToLoad;

	/// <summary>
	/// Detecta cuándo un GameObject entra en el trigger al cual está asignado este componente.
	/// En nuestro caso, realizamos la carga aditiva del nivel indicado en el atributo
	/// público "LevelToLoadName"
	/// </summary>
	void OnTriggerEnter(Collider other)
	{
        LoadLevelAdditive(other.gameObject);
	}

    void LoadLevelAdditive(GameObject objeto)
    {
        if(objeto.tag == m_PlayerTag)
        {
            GameObject goMan = GameObject.FindGameObjectWithTag("GameManager");
            GameManager gameManager = goMan.GetComponent<GameManager>();
            gameManager.TriggerLoadAdditive(m_LevelToLoad);
        }
    }

    // TODO 2 - Hacer función que cargue un nivel de forma aditiva.
    // Será necesario pasarle el gameObject que ha colisionado con el trigger
    // Tras cargar el nivel, desactivamos el trigger
    
}