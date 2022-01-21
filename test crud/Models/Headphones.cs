﻿namespace test_crud.Models
{
    public class Headphones
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Manafacturer { get; set; }
        //Общие характеристики
        public string Type { get; set; }
        public string Form { get; set; }
        public string Microphone { get; set; }
        public string NoiseSuppression { get; set; }
        public string TheLowerLimitOfTheFrequencyRange { get; set; }
        public string TheUpperLimitOfTheFrequencyRange { get; set; }
        public string SurroundSound { get; set; }
        public string Impedance { get; set; }
        public int Sensitivity { get; set; }
        public string VolumeControl { get; set; }
        public int Weight { get; set; }
        public string EarCushionsMaterial { get; set; }
        public string BodyMaterial { get; set; }
        public string Color { get; set; }
        public string MicrophoneDesign { get; set; }
        //Конструкция
        public int NumberOfEmitters { get; set; }
        public string AcousticDesignType { get; set; }
        public string MountType { get; set; }
        public string DiaphragmDiameter { get; set; }
        public string FoldableDesign { get; set; }
        public string CableConnection { get; set; }
        //Подключение
        public string Connector { get; set; }
        public string ConnectorShape { get; set; }
        public int CableLength { get; set; }
        //Если наушники беспроводные:Питание
        public string BatteryCapacity { get; set; }
        public int ChargingTime { get; set; }
        public string FastCharge { get; set; }
        //Беспроводные
        public string DataTransmissionChannel { get; set; }
        public string Bluetooth { get; set; }
        public string BluetoothProfiles { get; set; }
        ////
        public int Guarantee { get; set; }
        public string ManufacturerCountry { get; set; }
        ///
        public string ReplaceableEarPads { get; set; }
        public int CountOfReplaceableEarPads { get; set; }

    }
}
