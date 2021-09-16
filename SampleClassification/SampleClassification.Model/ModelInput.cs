//*****************************************************************************************
//*                                                                                       *
//* This is an auto-generated file by Microsoft ML.NET CLI (Command-Line Interface) tool. *
//*                                                                                       *
//*****************************************************************************************

using Microsoft.ML.Data;

namespace SampleClassification.Model
{
    public class ModelInput
    {
        [ColumnName("col0"), LoadColumn(0)]
        public float Col0 { get; set; }


        [ColumnName("card"), LoadColumn(1)]
        public string Card { get; set; }


        [ColumnName("reports"), LoadColumn(2)]
        public float Reports { get; set; }


        [ColumnName("age"), LoadColumn(3)]
        public float Age { get; set; }


        [ColumnName("income"), LoadColumn(4)]
        public float Income { get; set; }


        [ColumnName("share"), LoadColumn(5)]
        public float Share { get; set; }


        [ColumnName("expenditure"), LoadColumn(6)]
        public float Expenditure { get; set; }


        [ColumnName("owner"), LoadColumn(7)]
        public bool Owner { get; set; }


        [ColumnName("selfemp"), LoadColumn(8)]
        public bool Selfemp { get; set; }


        [ColumnName("dependents"), LoadColumn(9)]
        public float Dependents { get; set; }


        [ColumnName("months"), LoadColumn(10)]
        public float Months { get; set; }


        [ColumnName("majorcards"), LoadColumn(11)]
        public float Majorcards { get; set; }


        [ColumnName("active"), LoadColumn(12)]
        public float Active { get; set; }


    }
}
