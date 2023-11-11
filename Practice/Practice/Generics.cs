using System;
using Practice.Models;

namespace Practice
{
	internal class Generics<T> where T : BaseEntity
	{
		private T[] _list;

		public Generics()
		{
			_list = new T[0];
		}

		public T[] Add(T item)
		{
			Array.Resize(ref _list, _list.Length + 1);
			_list[_list.Length - 1] = item;
			return _list;

		}

		public T[] ShowAll()
		{
			return _list;
		}

		public T GetById(int id) => _list.FirstOrDefault(x => x.Id == id);

		public T[] Delete(int id)
		{
			return _list.Where(x => x.Id != id).ToArray();
		}
		
	}
}

