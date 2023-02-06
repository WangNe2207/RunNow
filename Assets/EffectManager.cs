using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    static public EffectManager instance;
    List<GameObject> effects = new List<GameObject>();
    private void Awake()
    {
        EffectManager.instance = this;
        this.LoadEffect();
    }

    protected virtual void LoadEffect()
    {
        foreach(Transform child in transform)
        {
            this.effects.Add(child.gameObject);
            child.gameObject.SetActive(false);
        }
    }

    public virtual void SpawnEffect(string EffectName, Vector3 position, Quaternion rot)
    {
        GameObject Effect = this.Get(EffectName);
        GameObject NewEffect = Instantiate(Effect, position, rot);
        NewEffect.SetActive(true);
    }
    protected virtual GameObject Get(string EffectName)
    {
        foreach(GameObject Child in this.effects)
        {
            if(Child.name == EffectName)
            {
                return Child;
            }
        }
        return null;
    }



}
