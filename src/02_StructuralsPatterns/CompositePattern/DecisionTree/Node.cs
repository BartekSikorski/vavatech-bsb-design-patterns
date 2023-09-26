using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.DecisionTree
{
    // Abstract Component
    public abstract class Node
    {
        public string Content { get; set; }

        protected Node(string content)
        {
            Content = content;
        }

        public abstract void Render();
    }


}
