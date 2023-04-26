﻿using System.Collections.Generic;
using TesteList.Domain.Entities;

namespace TesteList.Domain.Repositories
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> GetAll();
        Produto GetById(int id);
        void Add(Produto produto);
        void Update(Produto produto);
        void Delete(int id);
    }
}
