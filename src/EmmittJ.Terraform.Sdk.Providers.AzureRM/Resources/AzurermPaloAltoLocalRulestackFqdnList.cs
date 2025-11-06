using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_palo_alto_local_rulestack_fqdn_list resource.
/// </summary>
public class AzurermPaloAltoLocalRulestackFqdnList : TerraformResource
{
    public AzurermPaloAltoLocalRulestackFqdnList(string name) : base("azurerm_palo_alto_local_rulestack_fqdn_list", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The audit_comment attribute.
    /// </summary>
    public string? AuditComment
    {
        get => GetProperty<TerraformLiteralProperty<string>>("audit_comment")?.Value;
        set => this.WithProperty("audit_comment", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The fully_qualified_domain_names attribute.
    /// </summary>
    public List<string>? FullyQualifiedDomainNames
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("fully_qualified_domain_names")?.Value;
        set => this.WithProperty("fully_qualified_domain_names", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The rulestack_id attribute.
    /// </summary>
    public string? RulestackId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rulestack_id")?.Value;
        set => this.WithProperty("rulestack_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
