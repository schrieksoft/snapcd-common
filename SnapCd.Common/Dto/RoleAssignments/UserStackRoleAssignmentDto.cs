using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class UserStackRoleAssignmentDto : UserStackRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}