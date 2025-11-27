using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RoleAssignments;

public class RoleAssignmentUpdateDto : RoleAssignmentCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
