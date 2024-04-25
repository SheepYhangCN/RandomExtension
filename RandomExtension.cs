//By SheepYhangCN
using System;
using System.Collections.Generic;
using System.Linq;

namespace SheepYhangCN.RandomExtension
{
	public static class RandomX
	{
		public static T Choose<T>(Random random,params T[] values)
		{
			return values[random.Next(values.Length)];
		}
		public static T ChooseInList<T>(Random random,T[] values)
		{
			return values[random.Next(values.Length)];
		}
		public static bool FiftyFifty(Random random)
		{
			return Choose(random,false,true);
		}
		public static T FiftyFifty<T>(Random random,T arg1,T arg2)
		{
			return Choose(random,arg1,arg2);
		}
		public static bool Chance(Random random,int chance_percent)
		{
			return ChooseInList(random,Enumerable.Range(1,100).ToArray()) >= chance_percent;
		}
		public static T Chance<T>(Random random,int chance_percent,T result,params T[] others)
		{
			return Chance(random,chance_percent) ? result : ChooseInList(random,others);
		}
		public static T ChanceInList<T>(Random random,int chance_percent,T result,T[] others)
		{
			return Chance(random,chance_percent) ? result : ChooseInList(random,others);
		}
		public static T ChancePerItem<T>(Random random,Dictionary<T,int> items)
		{
			var r = ChooseInList(random,Enumerable.Range(1,items.Count).ToArray());
			var n = 0;
			var result = default(T);
			foreach (var a in items)
			{
				n += a.Value;
				if (n >= r)
				{
					result = a.Key;
					break;
				}
			}
			return result;
		}
	}
}