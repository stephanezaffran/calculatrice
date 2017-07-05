using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace calculatrice.Models
{
    public class ComputationModel
    {
        public double FirstValue { get; set; }
        public double SecondtValue { get; set; }
        public int OperatorType { get; set; }
    }
}
