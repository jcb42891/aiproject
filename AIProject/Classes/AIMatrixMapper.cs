using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AIProject.DAL;
using System.Data;

namespace AIProject.Classes
{
    public class AIMatrixMapper
    {
        // Section to assign column indexes to properties
        private static Dictionary<string, int> m_AIMatrix_ColIndexes = new Dictionary<string, int>
        {
            { "Insurer", 0 },
            { "PolicyType", 1},
            { "FormNumber", 2},
            { "FormEditionDate", 3},
            { "FormIsUnacceptable", 4},
            { "WhoIsFormDesignedFor", 5},
            { "FormTitle", 6},
            { "BIandPD", 7},
            { "PIandAI", 8},
            { "PrivityOfContractReqd", 9},
            { "LimitsLessLang", 10},
            { "FormHasSchedule", 11},
            { "PremAndOps", 12},
            { "ProdCompOps", 13},
            { "UnacceptableStdLang", 14},
            { "CommentsStdLang", 15},
            { "SpfcActsOrOmissionsLang", 16},
            { "SpfcThoseActingBehalfLang", 17},
            { "RequiresContractExec", 18},
            { "SpfcOnlyCoversWorkSubjContractLang", 19},
            { "SpfcAIRequiredLang", 20},
            { "SpfcNoDutyToDefendLang", 21},
            { "UnacceptableAdvLang", 22},
            { "CommentsAdvLang", 23},
            { "PrimaryLang", 24},
            { "NonContributoryLang", 25},
            { "WaiverOfSubroLang", 26},
            { "AgentUnacceptableLang", 27},
        };

        // Function to map the column indexes on the CSV file to the properties in the AIMatrix class.
        public static AIMatrix mapMatrixRow(DataRow matrixDataRow)
        {
            AIMatrix matrix = new AIMatrix();

            matrix.Insurer = matrixDataRow[m_AIMatrix_ColIndexes["Insurer"]].ToString();
            matrix.PolicyType = matrixDataRow[m_AIMatrix_ColIndexes["PolicyType"]].ToString();
            matrix.FormNumber = matrixDataRow[m_AIMatrix_ColIndexes["FormNumber"]].ToString();
            matrix.FormEditionDate = matrixDataRow[m_AIMatrix_ColIndexes["FormEditionDate"]].ToString();
            matrix.FormIsUnacceptable = (matrixDataRow[m_AIMatrix_ColIndexes["FormIsUnacceptable"]].ToString() == "X");
            matrix.WhoIsFormDesignedFor = matrixDataRow[m_AIMatrix_ColIndexes["WhoIsFormDesignedFor"]].ToString();
            matrix.FormTitle = matrixDataRow[m_AIMatrix_ColIndexes["FormTitle"]].ToString();
            matrix.BIandPD = (matrixDataRow[m_AIMatrix_ColIndexes["BIandPD"]].ToString() == "X");
            matrix.PIandAI = (matrixDataRow[m_AIMatrix_ColIndexes["PIandAI"]].ToString() == "X");
            matrix.PrivityOfContractReqd = (matrixDataRow[m_AIMatrix_ColIndexes["PrivityOfContractReqd"]].ToString() == "X");
            matrix.LimitsLessLang = (matrixDataRow[m_AIMatrix_ColIndexes["LimitsLessLang"]].ToString() == "X");
            matrix.FormHasSchedule = (matrixDataRow[m_AIMatrix_ColIndexes["FormHasSchedule"]].ToString() == "X");
            matrix.PremAndOps = (matrixDataRow[m_AIMatrix_ColIndexes["PremAndOps"]].ToString() == "X");
            matrix.ProdCompOps = (matrixDataRow[m_AIMatrix_ColIndexes["ProdCompOps"]].ToString() == "X");
            matrix.UnacceptableStdLang = matrixDataRow[m_AIMatrix_ColIndexes["UnacceptableStdLang"]].ToString();
            matrix.CommentsStdLang = matrixDataRow[m_AIMatrix_ColIndexes["CommentsStdLang"]].ToString();
            matrix.SpfcActsOrOmissionsLang = (matrixDataRow[m_AIMatrix_ColIndexes["SpfcActsOrOmissionsLang"]].ToString() == "X");
            matrix.SpfcThoseActingBehalfLang = (matrixDataRow[m_AIMatrix_ColIndexes["SpfcThoseActingBehalfLang"]].ToString() == "X");
            matrix.RequiresContractExec = (matrixDataRow[m_AIMatrix_ColIndexes["RequiresContractExec"]].ToString() == "X");
            matrix.SpfcOnlyCoversWorkSubjContractLang = (matrixDataRow[m_AIMatrix_ColIndexes["SpfcOnlyCoversWorkSubjContractLang"]].ToString() == "X");
            matrix.SpfcAIRequiredLang = (matrixDataRow[m_AIMatrix_ColIndexes["SpfcAIRequiredLang"]].ToString() == "X");
            matrix.SpfcNoDutyToDefendLang = (matrixDataRow[m_AIMatrix_ColIndexes["SpfcNoDutyToDefendLang"]].ToString() == "X");
            matrix.CommentsAdvLang = matrixDataRow[m_AIMatrix_ColIndexes["CommentsAdvLang"]].ToString();
            matrix.PrimaryLang = (matrixDataRow[m_AIMatrix_ColIndexes["PrimaryLang"]].ToString() == "X");
            matrix.NonContributoryLang = (matrixDataRow[m_AIMatrix_ColIndexes["NonContributoryLang"]].ToString() == "X");
            matrix.WaiverOfSubroLang = (matrixDataRow[m_AIMatrix_ColIndexes["WaiverOfSubroLang"]].ToString() == "X");
            matrix.AgentUnacceptableLang = matrixDataRow[m_AIMatrix_ColIndexes["AgentUnacceptableLang"]].ToString();

            return matrix;

        }

    }
}