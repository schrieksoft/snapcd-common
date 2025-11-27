using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class GroupStackRoleAssignmentUpdateDto : GroupStackRoleAssignmentCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
