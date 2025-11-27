using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments.Base;

public class RunnerRoleAssignmentUpdateDto : RunnerRoleAssignmentCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
