using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_network_manager_scope_connection resource.
/// </summary>
public class AzurermNetworkManagerScopeConnection : TerraformResource
{
    public AzurermNetworkManagerScopeConnection(string name) : base("azurerm_network_manager_scope_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("connection_state");
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The network_manager_id attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkManagerId
    {
        get => GetProperty<TerraformProperty<string>>("network_manager_id");
        set => this.WithProperty("network_manager_id", value);
    }

    /// <summary>
    /// The target_scope_id attribute.
    /// </summary>
    public TerraformProperty<string>? TargetScopeId
    {
        get => GetProperty<TerraformProperty<string>>("target_scope_id");
        set => this.WithProperty("target_scope_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => this.WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The connection_state attribute.
    /// </summary>
    public TerraformExpression ConnectionState => this["connection_state"];

}
