using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class UserOrganizationRoleAssignmentUpdateDto : UserOrganizationRoleAssignmentCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
