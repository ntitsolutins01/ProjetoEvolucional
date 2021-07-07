﻿using System.Collections.Generic;
using Evolucional.Domain.Common;

namespace Evolucional.Domain.Entities
{
    public class Disciplina : AuditableEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
