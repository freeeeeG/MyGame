using System.Collections.Generic;

public abstract class ObjectPool<T> : PoolBase<T> where T : class, IPoolItem
{

	public static ObjectPool<T> I;
	protected virtual int initialCapacity { get; }
	public ObjectPool()
	{
		Init();
	}
	public virtual void Init()
	{
		if (initialStack)
		{
			if (typeof(T).GetInterface(typeof(IPoolItemWithInitialCapacity).Name) != null)
			{
				for (int i = 0; i < initialCapacity; i++)
				{
					T val = CreateNewOne();
					(val as IPoolItemWithInitialCapacity).OnInitialCreate();
					countAll++;
					m_Stack.Push(val);
				}
			}
			else
			{
				List<T> list = new List<T>();
				for (int j = 0; j < initialCapacity; j++)
				{
					list.Add(Get());
				}
				foreach (T item in list)
				{
					Release(item);
				}
			}
		}
		I = this;
	}

}
