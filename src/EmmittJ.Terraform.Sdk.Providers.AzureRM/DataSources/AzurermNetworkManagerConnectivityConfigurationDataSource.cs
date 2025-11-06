using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_network_manager_connectivity_configuration.
/// </summary>
public class AzurermNetworkManagerConnectivityConfigurationDataSource : TerraformDataSource
{
    public AzurermNetworkManagerConnectivityConfigurationDataSource(string name) : base("azurerm_network_manager_connectivity_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("applies_to_group");
        this.DeclareOutput("connectivity_topology");
        this.DeclareOutput("delete_existing_peering_enabled");
        this.DeclareOutput("description");
        this.DeclareOutput("global_mesh_enabled");
        this.DeclareOutput("hub");
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
    /// The network_manager_id attribute.
    /// </summary>
    public string? NetworkManagerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_manager_id")?.Value;
        set => this.WithProperty("network_manager_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The applies_to_group attribute.
    /// </summary>
    public TerraformExpression AppliesToGroup => this["applies_to_group"];

    /// <summary>
    /// The connectivity_topology attribute.
    /// </summary>
    public TerraformExpression ConnectivityTopology => this["connectivity_topology"];

    /// <summary>
    /// The delete_existing_peering_enabled attribute.
    /// </summary>
    public TerraformExpression DeleteExistingPeeringEnabled => this["delete_existing_peering_enabled"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The global_mesh_enabled attribute.
    /// </summary>
    public TerraformExpression GlobalMeshEnabled => this["global_mesh_enabled"];

    /// <summary>
    /// The hub attribute.
    /// </summary>
    public TerraformExpression Hub => this["hub"];

}
