using System;
using System.Collections.Generic;

namespace Lizandra.Interfaces
{
    public class CalculateService
    {
        public T Max<T>(List<T> list) where  T : IComparable
        {
            if (list.Count == 0)
            {
                throw new  Exception("Não possui elemento no array");
            }

            var max  = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}