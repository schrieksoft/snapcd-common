using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class GroupStackRoleAssignmentReadDto : GroupStackRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}