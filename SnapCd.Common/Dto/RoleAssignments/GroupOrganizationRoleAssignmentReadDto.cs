using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class GroupOrganizationRoleAssignmentReadDto : GroupOrganizationRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}