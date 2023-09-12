// See https://aka.ms/new-console-template for more information
using BMIValidation;
using OfficeOpenXml;
using System.Drawing;

ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

// path to your excel file
string path = "D:\\Projects\\BMIValidation1\\BMIValidation\\bin\\Debug\\net6.0\\mjerenja.xlsx";
FileInfo fileInfo = new FileInfo(path);

ExcelPackage package = new ExcelPackage(fileInfo);

foreach (var worksheet in package.Workbook.Worksheets)
{
    int rows = worksheet.Dimension.Rows; // 10

    var measurmentDate = DateTime.Parse("12.10.2022");

    Console.WriteLine(worksheet.Name);

    // loop through the worksheet rows
    for (int i = 7; i <= rows; i++)
    {
        // replace occurences

        if (worksheet.Cells[i, 4].Value == null)
        {
            continue;
        }

        var gender = (double)worksheet.Cells[i, 4].Value;
        
        if (worksheet.Cells[i, 5].Value == null || worksheet.Cells[i, 6].Value == null || worksheet.Cells[i, 7].Value == null)
        {
            continue;
        }

        var dateOfBirth = DateTime.FromOADate((double)worksheet.Cells[i, 5].Value);

        var months = Math.Round(measurmentDate.Subtract(dateOfBirth).Days / (365.25 / 12),0);

        var weight = (double)worksheet.Cells[i, 7].Value;
        var height = (double)worksheet.Cells[i, 6].Value;

        var bmi = CalculateBmi(weight, height);
        var bmiForAge = GetBmiForAge(bmi, months, gender);
        worksheet.Cells[i, 8].Value = bmiForAge;

        SetColor(bmiForAge, worksheet.Cells[i, 8]);

        Console.WriteLine(bmiForAge);
    }
}

void SetColor(double bmiForAge, ExcelRange range)
{
    range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;

    if (bmiForAge < 5)
    {
        range.Style.Fill.BackgroundColor.SetColor(Color.MediumPurple);
    }

    if (bmiForAge >= 5 && bmiForAge < 85)
    {
        range.Style.Fill.BackgroundColor.SetColor(Color.LightBlue);
    }

    if (bmiForAge >= 85 && bmiForAge < 95)
    {
        range.Style.Fill.BackgroundColor.SetColor(Color.Yellow);
    }

    if (bmiForAge >= 95)
    {
        range.Style.Fill.BackgroundColor.SetColor(Color.Red);
    }
}

double CalculateBmi(double e, double r)
{
    return Math.Round((e / ((r * r) / 10000)));

}

Double GetBmiForAge(Double a_dBMI, Double a_dAge, Double a_dSex)
{
    Double l_dPercentage = GetPercentage(a_dBMI, a_dAge, a_dSex, BMIForAge.DATA);
    if (l_dPercentage != -0.01)
    {
        return l_dPercentage;
    }

    return 0;
}

Double GetPercentage(Double a_dChecking, Double a_dAgainst, Double a_dSex, Double[] a_dData)
{
    for (int l_iIndex = 0; l_iIndex < a_dData.Length; l_iIndex++)
    {
        if (a_dSex == a_dData[l_iIndex])
        {
            if (a_dAgainst <= a_dData[l_iIndex + 1])
            {
                if (l_iIndex > 5)
                {
                    if (a_dAgainst > a_dData[l_iIndex - 4])
                    {
                        Double l_dPercentile = 0.0;
                        Double l_dL = a_dData[l_iIndex + 2];
                        Double l_dM = a_dData[l_iIndex + 3];
                        Double l_dS = a_dData[l_iIndex + 4];
                        Double l_dTemp = a_dChecking / l_dM;
                        Double l_dZ = (Math.Pow(l_dTemp, l_dL) - 1) / (l_dL * l_dS);
                        Double l_dZTimesHundred = l_dZ * 100;
                        if (l_dZTimesHundred < 0)
                        {
                            l_dZTimesHundred = Math.Ceiling(l_dZTimesHundred);
                            Int32 l_iZTimesHundred = Convert.ToInt32(l_dZTimesHundred);
                            l_iZTimesHundred *= -1;
                            if (l_iZTimesHundred <= 309)
                                l_dPercentile = 100 - (ZTable.DATA[l_iZTimesHundred] * 100);
                            else
                                l_dPercentile = 0.0;
                        }
                        else
                        {
                            l_dZTimesHundred = Math.Floor(l_dZTimesHundred);
                            Int32 l_iZTimesHundred = Convert.ToInt32(l_dZTimesHundred);
                            if (l_iZTimesHundred <= 309)
                                l_dPercentile = ZTable.DATA[l_iZTimesHundred] * 100;
                            else
                                l_dPercentile = 100.0;
                        }
                        int l_iPercentile = Convert.ToInt32(l_dPercentile * 100);
                        l_dPercentile = l_iPercentile / 100.0;
                        return l_dPercentile;
                    }
                    l_iIndex += 4;
                }
                else
                {
                    l_iIndex += 4;
                }
            }
            else
            {
                l_iIndex += 4;
            }
        }
        else
        {
            l_iIndex += 4;
        }
    }
    return -0.01;
}

package.Save();