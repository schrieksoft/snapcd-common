using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class ServicePrincipalNamespaceRoleAssignmentUpdateDto : ServicePrincipalNamespaceRoleAssignmentCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
