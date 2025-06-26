using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour
{
    private int score = 0;
    private void OnEnable()
    {
        RayShooter shooter = Camera.main.GetComponent<RayShooter>();
        if (shooter != null)
        {
            shooter.OnRayHit += HandleRayHit;
        }
    }

    private void OnDisable()
    {
        RayShooter shooter = Camera.main.GetComponent<RayShooter>();
        if (shooter != null)
        {
            shooter.OnRayHit -= HandleRayHit;
        }
    }

    public void ReactToHit()
    {
        WanderingAI behavior = GetComponent<WanderingAI>();
        if (behavior != null)
        {
            behavior.SetAlive(false);
        }
        StartCoroutine(Die());
    }

    private IEnumerator Die()
    {
        this.transform.Rotate(-75, 0, 0);

        yield return new WaitForSeconds(1.5f);

        Destroy(this.gameObject);
    }

    private void HandleRayHit(GameObject hitObject, Vector3 hitPoint)
    { 
        if (hitObject == this.gameObject)
        {
            score++;
            Debug.Log($"Score: {score}");
        }
    }

}
