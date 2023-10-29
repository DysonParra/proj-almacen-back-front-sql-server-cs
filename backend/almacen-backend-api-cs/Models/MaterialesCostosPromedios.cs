/*
 * @fileoverview    {MaterialesCostosPromedios}
 *
 * @version         2.0
 *
 * @author          Dyson Arley Parra Tilano <dysontilano@gmail.com>
 *
 * @copyright       Dyson Parra
 * @see             github.com/DysonParra
 *
 * History
 * @version 1.0     Implementation done.
 * @version 2.0     Documentation added.
 */
using System;
using System.ComponentModel.DataAnnotations;

/**
 * TODO: Description of {@code MaterialesCostosPromedios}.
 *
 * @author Dyson Parra
 */
namespace Project.Models {

    public class MaterialesCostosPromedios {

        [Key]
        public Int64? IntIdMaterialCostoPromedio { get; set; }
        public Decimal? DecCostoPromedio { get; set; }
        public DateTime? DtFechaInicial { get; set; }
        public DateTime? DtFechaFinal { get; set; }
        public String? StrUsuario { get; set; }
        public DateTime? DtFecha { get; set; }
        public Int64? IntIdMaterial { get; set; }
        public String? StrCodigoMaterial { get; set; }

    }

}