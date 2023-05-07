using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PoolBase<T> where T : class, IPoolItem
{
	protected Stack<T> m_Stack = new Stack<T>();

	protected virtual bool initialStack { get; }

	public int countAll { get; set; }

	public int countActive => countAll - countInactive;

	public int countInactive => m_Stack.Count;

	protected abstract T CreateNewOne();

	public T Get()
	{
		if (this is IPoolItemWithMaxCapacity poolItemWithMaxCapacity && countAll >= poolItemWithMaxCapacity.CapacityLimit && countInactive == 0)
		{
			return null;
		}
		T val;
		if (m_Stack.Count == 0)
		{
			val = CreateNewOne();
			countAll++;
		}
		else
		{
			val = m_Stack.Pop();
		}
		val.OnGet();
		return val;
	}

	public virtual void Release(T element)
	{
		element.OnRelease();
		m_Stack.Push(element);
	}

}
