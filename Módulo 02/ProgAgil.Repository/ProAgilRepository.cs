using System;

namespace ProgAgil.Repository
{
    public class ProAgilRepository : IProAgilRepository
    {
        public void Add<T>(T entity) where T: class
        {
            throw new System.NotImplementedException();
        }
    }
}