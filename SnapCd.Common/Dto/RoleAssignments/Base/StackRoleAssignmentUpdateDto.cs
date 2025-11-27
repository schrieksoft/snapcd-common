using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments.Base;

public class StackRoleAssignmentUpdateDto : StackRoleAssignmentCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
