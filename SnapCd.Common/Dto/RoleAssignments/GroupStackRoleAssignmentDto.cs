using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class GroupStackRoleAssignmentDto : GroupStackRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}