using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class GroupOrganizationRoleAssignmentUpdateDto : GroupOrganizationRoleAssignmentCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
