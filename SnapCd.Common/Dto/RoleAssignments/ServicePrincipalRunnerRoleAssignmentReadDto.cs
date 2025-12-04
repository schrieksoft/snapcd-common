using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class ServicePrincipalRunnerRoleAssignmentReadDto : ServicePrincipalRunnerRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}