using ResumeInBlazor.Models.Interfaces;

namespace ResumeInBlazor.Components;

public static class PrintBreakCss
{
    private const string ClassName = "print-break-before";

    public static string Combine(string baseClass, IPrintBreakable? item) =>
        item?.PageBreakBefore == true ? $"{baseClass} {ClassName}" : baseClass;
}
