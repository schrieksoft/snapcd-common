using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class ServicePrincipalOrganizationRoleAssignmentReadDto : ServicePrincipalOrganizationRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}