using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class ServicePrincipalNamespaceRoleAssignmentDto : ServicePrincipalNamespaceRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}