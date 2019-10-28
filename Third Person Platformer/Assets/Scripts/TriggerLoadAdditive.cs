using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerLoadAdditive : MonoBehaviour
{
    // TODO 1 - A�adir string p�blico que ser� el nombre del nivel a cargar

    /// <summary>
    /// La comprobaci�n del tipo de gameobject que entra en el trigger se hace por tag
    /// El valor del tag que nos interesa se guarda en esta variable
    /// </summary>
    private string m_PlayerTag = "Player";
    public GameManager.DoorColor m_LevelToLoad;

	/// <summary>
	/// Detecta cu�ndo un GameObject entra en el trigger al cual est� asignado este componente.
	/// En nuestro caso, realizamos la carga aditiva del nivel indicado en el atributo
	/// p�blico "LevelToLoadName"
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

    // TODO 2 - Hacer funci�n que cargue un nivel de forma aditiva.
    // Ser� necesario pasarle el gameObject que ha colisionado con el trigger
    // Tras cargar el nivel, desactivamos el trigger
    
}