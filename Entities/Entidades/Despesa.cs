﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Enums;
using System.Globalization;

namespace Entities.Entidades
{
    [Table("Despesa")]
    public class Despesa : Base
    {
        public decimal Valor { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }

        public EnumTipoDespesa TipoDespesa { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }
        public DateTime DataPagamento { get; set; }
        public DateTime DataVenvimento { get; set; }

        public bool Pago { get; set; }
        public bool DespesaAtrasada { get; set; }

        [ForeignKey("Categoria")]
        [Column(Order = 1)]
        public int IdSistema { get; set; }
        public int IdCategoria { get; set; }
        public virtual Despesa Categoria { get; set; }

        //public object ValidarPropriedadeStrign(string nome, string v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
