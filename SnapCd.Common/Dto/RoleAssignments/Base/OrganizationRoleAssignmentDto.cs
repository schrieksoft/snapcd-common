using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments.Base;

public class OrganizationRoleAssignmentDto : OrganizationRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}