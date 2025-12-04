using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments.Base;

public class StackRoleAssignmentDto : StackRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}