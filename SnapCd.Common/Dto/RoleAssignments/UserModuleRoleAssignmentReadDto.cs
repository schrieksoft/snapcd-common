using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class UserModuleRoleAssignmentReadDto : UserModuleRoleAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}