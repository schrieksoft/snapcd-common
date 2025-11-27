using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class UserOrganizationRoleAssignmentDto : UserOrganizationRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}