using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformLiteralProperty<string>? AuditComment
    {
        get => GetProperty<TerraformLiteralProperty<string>>("audit_comment");
        set => this.WithProperty("audit_comment", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KeyVaultCertificateId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_vault_certificate_id");
        set => this.WithProperty("key_vault_certificate_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The rulestack_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RulestackId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rulestack_id");
        set => this.WithProperty("rulestack_id", value);
    }

    /// <summary>
    /// The self_signed attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SelfSigned
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("self_signed");
        set => this.WithProperty("self_signed", value);
    }

}
