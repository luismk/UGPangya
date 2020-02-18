﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PangyaAPI
{
    public class GenericDisposableCollection<T> where T : class, IDisposeable
    {
        private List<T> _model;

        public int Count { get { return _model.Count; } }

        public List<T> Model
        {
            get
            {
                //Rmove pessoas Disposed
                _model?.RemoveAll(p => p != null && p.Disposed);

                return _model;
            }
            set { _model = value; }
        }

        public T this[int index]
        {
            get
            {
                return Model[index];
            }
            set
            {
                Model[index] = value;
            }
        }

        public GenericDisposableCollection()
        {
            Model = new List<T>();
        }

        public void Add(T pessoa)
        {
            Model.Add(pessoa);
        }

        public List<T> ToList()
        {
            return Model;
        }
    }
}
