using System;
using System.Collections.Generic;
using System.Text;

namespace SAOS.Series
{
    public abstract class EntidadeBase
    {
        public int Id { get; protected set; }
        public bool Excluido { get; set; }
    }
}
