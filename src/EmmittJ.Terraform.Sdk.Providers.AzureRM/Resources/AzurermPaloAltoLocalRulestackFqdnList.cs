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
    /// The fully_qualified_domain_names attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? FullyQualifiedDomainNames
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("fully_qualified_domain_names");
        set => this.WithProperty("fully_qualified_domain_names", value);
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

}
