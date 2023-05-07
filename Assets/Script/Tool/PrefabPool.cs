using System.Collections.Generic;
using UnityEngine;

public abstract class PrefabPool<T> : PoolBase<T> where T : MonoBehaviour, IPoolItem
{
	public Transform ParentTrans { get; private set; }
	protected virtual int initialCount { get; }
	public PrefabPool(Transform trans)
	{
		ParentTrans = trans;
	}
    public virtual void Init()
	{
		if (!initialStack)
		{
			return;
		}
		List<T> list = new List<T>();
		for (int i = 0; i < initialCount; i++)
		{
			list.Add(Get());
		}
		foreach (T item in list)
		{
			Release(item);
		}
	}

}
