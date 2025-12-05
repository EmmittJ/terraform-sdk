using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermPaloAltoLocalRulestackOutboundUntrustCertificateAssociation.
/// Nesting mode: single
/// </summary>
public class AzurermPaloAltoLocalRulestackOutboundUntrustCertificateAssociationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_palo_alto_local_rulestack_outbound_untrust_certificate_association Terraform resource.
/// Manages a azurerm_palo_alto_local_rulestack_outbound_untrust_certificate_association resource.
/// </summary>
public partial class AzurermPaloAltoLocalRulestackOutboundUntrustCertificateAssociation(string name) : TerraformResource("azurerm_palo_alto_local_rulestack_outbound_untrust_certificate_association", name)
{
    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateId is required")]
    public required TerraformValue<string> CertificateId
    {
        get => GetRequiredArgument<TerraformValue<string>>("certificate_id");
        set => SetArgument("certificate_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPaloAltoLocalRulestackOutboundUntrustCertificateAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPaloAltoLocalRulestackOutboundUntrustCertificateAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
