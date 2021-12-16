using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDisplay : MonoBehaviour
{
    public GameObject AttackDisplayPrefab;

    public IEnumerator DisplayAttackCoroutine(Vector2Int Position)
    {
        GameObject AttackDisplay = Instantiate(AttackDisplayPrefab, new Vector3(Position.x, Position.y, 0), Quaternion.identity);
        yield return new WaitForSeconds(0.5f);
        Destroy(AttackDisplay);
    }


    public void OnAttack(Vector2Int Position)
    {
        StartCoroutine(DisplayAttackCoroutine(Position));
    }
}
