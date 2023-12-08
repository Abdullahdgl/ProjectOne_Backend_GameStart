using ProjectOne_Backend_GameStart.EntitesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOne_Backend_GameStart.BusinnessLayer.Abstract
{
    public interface IBaseService<T> 
    {
        void Add(T TEntity);
        void Remove(T TEntity);
        void Update(T TEntity);
    }
}
