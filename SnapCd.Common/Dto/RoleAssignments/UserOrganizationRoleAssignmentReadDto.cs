using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class UserOrganizationRoleAssignmentReadDto : UserOrganizationRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}