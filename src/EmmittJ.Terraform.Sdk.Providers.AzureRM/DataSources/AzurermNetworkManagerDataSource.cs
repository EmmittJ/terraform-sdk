using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_network_manager.
/// </summary>
public class AzurermNetworkManagerDataSource : TerraformDataSource
{
    public AzurermNetworkManagerDataSource(string name) : base("azurerm_network_manager", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("cross_tenant_scopes");
        this.DeclareOutput("description");
        this.DeclareOutput("location");
        this.DeclareOutput("scope");
        this.DeclareOutput("scope_accesses");
        this.DeclareOutput("tags");
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cross_tenant_scopes attribute.
    /// </summary>
    public TerraformExpression CrossTenantScopes => this["cross_tenant_scopes"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformExpression Scope => this["scope"];

    /// <summary>
    /// The scope_accesses attribute.
    /// </summary>
    public TerraformExpression ScopeAccesses => this["scope_accesses"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
