using SnapCd.Common.Dto.NamespaceInputs.Base;

namespace SnapCd.Common.Dto.NamespaceInputs;

public class NamespaceInputFromSecretCreateDto : NamespaceInputCreateDto
{
    public Guid SecretId { get; set; }

    public InputType Type { get; set; }
}
