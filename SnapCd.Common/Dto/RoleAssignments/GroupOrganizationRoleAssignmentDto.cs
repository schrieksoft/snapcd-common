using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class GroupOrganizationRoleAssignmentDto : GroupOrganizationRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}