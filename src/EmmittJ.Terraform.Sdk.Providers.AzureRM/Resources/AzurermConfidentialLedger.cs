using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_confidential_ledger resource.
/// </summary>
public class AzurermConfidentialLedger : TerraformResource
{
    public AzurermConfidentialLedger(string name) : base("azurerm_confidential_ledger", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("identity_service_endpoint");
        this.DeclareOutput("ledger_endpoint");
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
    /// The ledger_type attribute.
    /// </summary>
    public TerraformProperty<string>? LedgerType
    {
        get => GetProperty<TerraformProperty<string>>("ledger_type");
        set => this.WithProperty("ledger_type", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The identity_service_endpoint attribute.
    /// </summary>
    public TerraformExpression IdentityServiceEndpoint => this["identity_service_endpoint"];

    /// <summary>
    /// The ledger_endpoint attribute.
    /// </summary>
    public TerraformExpression LedgerEndpoint => this["ledger_endpoint"];

}
