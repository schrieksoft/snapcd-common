using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RunnerNamespaceAssignments;

public class RunnerNamespaceAssignmentUpdateDto : RunnerNamespaceAssignmentCreateDto, IUpdateDto
{
    public Guid Id { get; set; }
}
