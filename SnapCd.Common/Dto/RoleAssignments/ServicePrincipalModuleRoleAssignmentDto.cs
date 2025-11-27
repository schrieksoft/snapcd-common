using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class ServicePrincipalModuleRoleAssignmentDto : ServicePrincipalModuleRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}