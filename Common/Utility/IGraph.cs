﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Utility
{
    public interface IGraph<TVertex, TEdge>
        where TEdge : IEdge<TVertex>
    {
        bool IsDirected { get; }
        bool AllowParallelEdges { get; }
    }
}
