using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class ServicePrincipalRunnerRoleAssignmentUpdateDto : ServicePrincipalRunnerRoleAssignmentCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
