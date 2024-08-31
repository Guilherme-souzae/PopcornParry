using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SequenciaFuncoes : MonoBehaviour
{
    void Start()
    {
        // Iniciar a sequ�ncia em loop
        StartCoroutine(LoopExecutarSequencia());
    }

    // Coroutine para Funcao1
    private IEnumerator Funcao1()
    {
        Debug.Log("In�cio de Funcao1");

        // Simula algum trabalho com uma espera
        yield return new WaitForSeconds(2.0f);

        Debug.Log("Fim de Funcao1");
    }

    // Coroutine para Funcao2
    private IEnumerator Funcao2()
    {
        Debug.Log("In�cio de Funcao2");

        // Simula outro trabalho com uma espera
        yield return new WaitForSeconds(3.0f);

        Debug.Log("Fim de Funcao2");
    }

    // Coroutine para gerenciar a sequ�ncia das fun��es
    private IEnumerator ExecutarSequencia()
    {
        // Executa Funcao1 e espera sua conclus�o
        yield return StartCoroutine(Funcao1());

        // Depois que Funcao1 terminar, executa Funcao2
        yield return StartCoroutine(Funcao2());

        Debug.Log("Sequ�ncia completa");
    }

    // Coroutine para manter a sequ�ncia em loop
    private IEnumerator LoopExecutarSequencia()
    {
        while (true) // Loop infinito
        {
            yield return StartCoroutine(ExecutarSequencia());

            // Adiciona uma espera opcional entre cada loop, se necess�rio
            yield return new WaitForSeconds(1.0f); // Espera 1 segundo antes de reiniciar a sequ�ncia
        }
    }
}
