using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class ServicePrincipalModuleRoleAssignmentReadDto : ServicePrincipalModuleRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}