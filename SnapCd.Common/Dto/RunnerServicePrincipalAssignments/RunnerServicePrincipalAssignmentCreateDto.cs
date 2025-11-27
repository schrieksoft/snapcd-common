namespace SnapCd.Common.Dto.RunnerServicePrincipalAssignments;

public class RunnerServicePrincipalAssignmentCreateDto
{
    public Guid ServicePrincipalId { get; set; }

    public Guid RunnerId { get; set; }
}
