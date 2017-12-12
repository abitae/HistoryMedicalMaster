namespace HistoryMedicalModels
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class PhysicalExplorationModel
    {
        [Key]
        public int IdPhysicalExploration { get; set; }
        public DateTime ExplorationDate { get; set; } //Fecha de Exploracion
        public decimal Weight { get; set; } //Peso
        public decimal Size { get; set; } //Talla
        public decimal BodyMass { get; set; } //Masa Corporal
        public decimal Temperature { get; set; } //Temperatura
        public decimal Pressure { get; set; } //Presion
        public decimal HeartRate { get; set; } //Frecuencia Cardiaca
        public decimal BreathingFrequency { get; set; } //Frecuencia Cardiaca
    }
}
