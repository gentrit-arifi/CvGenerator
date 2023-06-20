namespace CvGenerator.Controllers;

using CvGenerator.Helpers;
using Microsoft.Reporting.NETCore;
using System.Reflection;

public class RDCLReport
{
    public byte[] GenerateReport(string name, ReportType type, List<ReportDataSource> dataSources)
    {
        LocalReport localReport = new();

        foreach (var ds in dataSources)
            localReport.DataSources.Add(ds);

        var rs = Assembly.GetExecutingAssembly().GetManifestResourceStream($"CvGenerator.Reports.{name}");
        localReport.LoadReportDefinition(rs);

        string renderType = type switch
        {
            ReportType.PDF => "PDF",
            ReportType.Excel => "EXCELOPENXML",
            ReportType.Word => "WORDOPENXML",
            ReportType.IMAGE => "IMAGE",
            _ => "PDF",
        };
        string deviceInfo = "<DeviceInfo>" + "  <OutputFormat>PDF</OutputFormat>" + "  <PageWidth>13.48in</PageWidth>" + "  <PageHeight>8.53in</PageHeight>" + "  <MarginTop>0.0in</MarginTop>" + "  <MarginLeft>0.0in</MarginLeft>" + "  <MarginRight>0.0in</MarginRight>" + "  <MarginBottom>0.0in</MarginBottom>" + "</DeviceInfo>";
        deviceInfo = renderType == "IMAGE" ? "<DeviceInfo><OutputFormat>PNG</OutputFormat>" + "<DpiX> 150 </DpiX>" + "<DpiY> 150 </DpiY>" + " <PageWidth> 13.48in</PageWidth > " + " <PageHeight> 8.53in</PageHeight> " + " <MarginTop> 0.0in</MarginTop> " + " <MarginLeft> 0.0in</MarginLeft> " + " <MarginRight> 0.0in</MarginRight> " + " <MarginBottom> 0.0in</MarginBottom> " + " </DeviceInfo> " : deviceInfo;

        byte[] byteReport = localReport.Render(renderType, deviceInfo);

        return byteReport;
    }

    public byte[] GenerateReport(string name, List<ReportDataSource> dataSources, List<ReportParameter> parameters, ReportType type, ReportOrientation orientation)
    {
        LocalReport localReport = new();


        foreach (var ds in dataSources)
            localReport.DataSources.Add(ds);

        var rs = Assembly.GetExecutingAssembly().GetManifestResourceStream($"CvGenerator.Reports.{name}");
        localReport.LoadReportDefinition(rs);

        localReport.SetParameters(parameters);

        string renderType = type switch
        {
            ReportType.PDF => "PDF",
            ReportType.Excel => "EXCELOPENXML",
            ReportType.Word => "WORDOPENXML",
            _ => "PDF",
        };

        string deviceInfo = orientation switch
        {
            ReportOrientation.Portrait => "<DeviceInfo>" + "  <OutputFormat>PDF</OutputFormat>" + "  <PageWidth>8.27in</PageWidth>" + "  <PageHeight>11.69in</PageHeight>" + "  <MarginTop>0.0in</MarginTop>" + "  <MarginLeft>0.0in</MarginLeft>" + "  <MarginRight>0.0in</MarginRight>" + "  <MarginBottom>0.0in</MarginBottom>" + "</DeviceInfo>",
            ReportOrientation.Landscape => "<DeviceInfo>" + "  <OutputFormat>PDF</OutputFormat>" + "  <PageWidth>11.69in</PageWidth>" + "  <PageHeight>8.27in</PageHeight>" + "  <MarginTop>0.0in</MarginTop>" + "  <MarginLeft>0.0in</MarginLeft>" + "  <MarginRight>0.0in</MarginRight>" + "  <MarginBottom>0.0in</MarginBottom>" + "</DeviceInfo>",
            _ => "<DeviceInfo>" + "  <OutputFormat>PDF</OutputFormat>" + "  <PageWidth>11.69in</PageWidth>" + "  <PageHeight>8.27in</PageHeight>" + "  <MarginTop>0.0in</MarginTop>" + "  <MarginLeft>0.0in</MarginLeft>" + "  <MarginRight>0.0in</MarginRight>" + "  <MarginBottom>0.0in</MarginBottom>" + "</DeviceInfo>"
        };

        byte[] byteReport = localReport.Render(renderType, deviceInfo);

        return byteReport;
    }

    public byte[] GenerateReport(string name, ReportType type, List<ReportDataSource> dataSources, List<ReportParameter> parameters, string width, string height)
    {
        LocalReport localReport = new();

        foreach (var ds in dataSources)
            localReport.DataSources.Add(ds);

        var rs = Assembly.GetExecutingAssembly().GetManifestResourceStream($"CvGenerator.Reports.{name}");
        localReport.LoadReportDefinition(rs);

        localReport.SetParameters(parameters);

        string renderType = type switch
        {
            ReportType.PDF => "PDF",
            ReportType.Excel => "EXCELOPENXML",
            ReportType.Word => "WORDOPENXML",
            _ => "PDF",
        };

        string deviceInfo = $"<DeviceInfo><OutputFormat>{renderType}</OutputFormat><PageWidth>{width}</PageWidth><PageHeight>{height}</PageHeight><MarginTop>0.0in</MarginTop><MarginLeft>0.0in</MarginLeft><MarginRight>0.0in</MarginRight><MarginBottom>0.0in</MarginBottom></DeviceInfo>";

        byte[] byteReport = localReport.Render(renderType, deviceInfo);

        return byteReport;
    }
}
