using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class UserStackRoleAssignmentReadDto : UserStackRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}