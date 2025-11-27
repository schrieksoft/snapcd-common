using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class ServicePrincipalRunnerRoleAssignmentDto : ServicePrincipalRunnerRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}