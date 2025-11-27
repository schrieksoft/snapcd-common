using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class UserStackRoleAssignmentUpdateDto : UserStackRoleAssignmentCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
