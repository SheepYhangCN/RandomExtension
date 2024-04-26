//By SheepYhangCN
using System;
using System.Collections.Generic;

namespace SheepYhangCN.RandomExtension
{
	public static class RandomX
	{
		public static T Choose<T>(this Random random,params T[] values)
		{
			return values[random.Next(values.Length)];
		}
		public static bool FiftyFifty(this Random random)
		{
			return Choose(random,false,true);
		}
		public static T FiftyFifty<T>(this Random random,T arg1,T arg2)
		{
			return Choose(random,arg1,arg2);
		}
		public static bool Chance(this Random random,double chance)
		{
			return chance >= random.NextDouble();
		}
		public static T Chance<T>(this Random random,double chance,T result,params T[] others)
		{
			return Chance(random,chance) ? result : Choose(random,others);
		}
		public static T ChancePerItem<T>(this Random random,Dictionary<T,int> items)
		{
			var r = random.Next(1,items.Count);
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