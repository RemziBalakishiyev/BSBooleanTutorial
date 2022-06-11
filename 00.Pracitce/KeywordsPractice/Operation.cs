using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Pracitce.KeywordsPractice
{
    internal class Operation
    {
        readonly string ServerKey = "Boolean";
        readonly IOperation _operation;
        public Operation(IOperation operation)// new Book
        {
            _operation = operation;
        }

        public void Add()
        {
            _operation.Add();
        }

        public void Delete()
        {
            _operation.Delete();
        }

        public void Show()
        {
            _operation.Show();
        }
    }
}
