using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<TModel, TAge>
    {
        TModel[] models;
        TAge [] ages;

        public MyDictionary()
        {
            models = new TModel[0];
            ages = new TAge[0];
        }

        public void Add(TModel model, TAge age)
        {
            TModel [] tempModel = models;
            models = new TModel[tempModel.Length+1];

            for (int i = 0; i < tempModel.Length; i++)
            {
                models[i] = tempModel[i];
            }

            models[models.Length - 1] = model;

            TAge[] tempAge = ages;
            ages = new TAge[tempAge.Length + 1];

            for (int i = 0; i < tempAge.Length; i++)
            {
                ages[i] = tempAge[i];
            }

            ages[ages.Length - 1] = age;

            Console.WriteLine();

        }

        public void List()
        {
            for (int i = 0; i < models.Length; i++)
            {
                Console.WriteLine("Model: " + models[i] + " yaş: "+ ages[i]) ;
            }
        }

        
    }
}
