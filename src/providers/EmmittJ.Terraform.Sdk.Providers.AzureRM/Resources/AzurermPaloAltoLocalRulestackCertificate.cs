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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("audit_comment");
        SetOutput("description");
        SetOutput("id");
        SetOutput("key_vault_certificate_id");
        SetOutput("name");
        SetOutput("rulestack_id");
        SetOutput("self_signed");
    }

    /// <summary>
    /// The audit_comment attribute.
    /// </summary>
    public TerraformProperty<string> AuditComment
    {
        get => GetRequiredOutput<TerraformProperty<string>>("audit_comment");
        set => SetProperty("audit_comment", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string> KeyVaultCertificateId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_vault_certificate_id");
        set => SetProperty("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The rulestack_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RulestackId is required")]
    public required TerraformProperty<string> RulestackId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("rulestack_id");
        set => SetProperty("rulestack_id", value);
    }

    /// <summary>
    /// The self_signed attribute.
    /// </summary>
    public TerraformProperty<bool> SelfSigned
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("self_signed");
        set => SetProperty("self_signed", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPaloAltoLocalRulestackCertificateTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
