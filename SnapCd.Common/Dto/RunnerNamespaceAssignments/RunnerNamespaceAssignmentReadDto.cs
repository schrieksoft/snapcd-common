using SnapCd.Common.Interfaces;

namespace SnapCd.Common.Dto.RunnerNamespaceAssignments;

public class RunnerNamespaceAssignmentReadDto : RunnerNamespaceAssignmentCreateDto, IDto
{
    public Guid Id { get; set; }
}