namespace SnapCd.Common.Dto.RoleAssignments;

public class ServicePrincipalRunnerRoleAssignmentCreateDto
{
    public Guid ServicePrincipalId { get; set; }

    public Guid RunnerId { get; set; }

    public RunnerRole RoleName { get; set; }
}
