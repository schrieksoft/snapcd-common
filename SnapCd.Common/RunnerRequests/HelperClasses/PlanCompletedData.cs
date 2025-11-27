namespace SnapCd.Common.RunnerRequests.HelperClasses;

/// <summary>
/// Data returned when a Plan operation completes successfully.
/// Contains all resource and output change statistics.
/// </summary>
public class PlanCompletedData
{
    // Resource counts
    public int TotalCountAfter { get; set; }
    public int TotalCountBefore { get; set; }
    public int TotalChangedCount { get; set; }
    public int TotalUnchangedCount { get; set; }
    public int CreateCount { get; set; }
    public int ModifyCount { get; set; }
    public int DestroyCount { get; set; }
    public int RecreateCount { get; set; }

    // Resource change details (JSON)
    public required string Unchanged { get; set; }
    public required string Create { get; set; }
    public required string Modify { get; set; }
    public required string Destroy { get; set; }
    public required string Recreate { get; set; }

    // Output counts
    public int OutputsTotalCount { get; set; }
    public int OutputsTotalChangedCount { get; set; }
    public int OutputsTotalUnchangedCount { get; set; }
    public int OutputsCreateCount { get; set; }
    public int OutputsModifyCount { get; set; }
    public int OutputsDestroyCount { get; set; }
    public int OutputsRecreateCount { get; set; }

    // Output change details (JSON)
    public required string OutputsUnchanged { get; set; }
    public required string OutputsCreate { get; set; }
    public required string OutputsModify { get; set; }
    public required string OutputsDestroy { get; set; }
    public required string OutputsRecreate { get; set; }
}
