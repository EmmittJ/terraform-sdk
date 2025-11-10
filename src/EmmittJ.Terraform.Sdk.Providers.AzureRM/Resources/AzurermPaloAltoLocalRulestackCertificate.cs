using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPaloAltoLocalRulestackCertificateTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_palo_alto_local_rulestack_certificate resource.
/// </summary>
public class AzurermPaloAltoLocalRulestackCertificate : TerraformResource
{
    public AzurermPaloAltoLocalRulestackCertificate(string name) : base("azurerm_palo_alto_local_rulestack_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The audit_comment attribute.
    /// </summary>
    public TerraformProperty<string>? AuditComment
    {
        get => GetProperty<TerraformProperty<string>>("audit_comment");
        set => this.WithProperty("audit_comment", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultCertificateId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_certificate_id");
        set => this.WithProperty("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The rulestack_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RulestackId is required")]
    public required TerraformProperty<string> RulestackId
    {
        get => GetProperty<TerraformProperty<string>>("rulestack_id");
        set => this.WithProperty("rulestack_id", value);
    }

    /// <summary>
    /// The self_signed attribute.
    /// </summary>
    public TerraformProperty<bool>? SelfSigned
    {
        get => GetProperty<TerraformProperty<bool>>("self_signed");
        set => this.WithProperty("self_signed", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPaloAltoLocalRulestackCertificateTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermPaloAltoLocalRulestackCertificateTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
