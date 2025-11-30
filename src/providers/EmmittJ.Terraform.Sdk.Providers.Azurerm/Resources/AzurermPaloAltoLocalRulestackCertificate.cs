using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermPaloAltoLocalRulestackCertificate.
/// Nesting mode: single
/// </summary>
public class AzurermPaloAltoLocalRulestackCertificateTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_palo_alto_local_rulestack_certificate Terraform resource.
/// Manages a azurerm_palo_alto_local_rulestack_certificate resource.
/// </summary>
public partial class AzurermPaloAltoLocalRulestackCertificate(string name) : TerraformResource("azurerm_palo_alto_local_rulestack_certificate", name)
{
    /// <summary>
    /// The audit_comment attribute.
    /// </summary>
    public TerraformValue<string>? AuditComment
    {
        get => new TerraformReference<string>(this, "audit_comment");
        set => SetArgument("audit_comment", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    public TerraformValue<string>? KeyVaultCertificateId
    {
        get => new TerraformReference<string>(this, "key_vault_certificate_id");
        set => SetArgument("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The rulestack_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RulestackId is required")]
    public required TerraformValue<string> RulestackId
    {
        get => new TerraformReference<string>(this, "rulestack_id");
        set => SetArgument("rulestack_id", value);
    }

    /// <summary>
    /// The self_signed attribute.
    /// </summary>
    public TerraformValue<bool>? SelfSigned
    {
        get => new TerraformReference<bool>(this, "self_signed");
        set => SetArgument("self_signed", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPaloAltoLocalRulestackCertificateTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPaloAltoLocalRulestackCertificateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
