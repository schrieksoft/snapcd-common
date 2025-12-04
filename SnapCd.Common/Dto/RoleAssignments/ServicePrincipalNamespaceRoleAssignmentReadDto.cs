using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class ServicePrincipalNamespaceRoleAssignmentReadDto : ServicePrincipalNamespaceRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}