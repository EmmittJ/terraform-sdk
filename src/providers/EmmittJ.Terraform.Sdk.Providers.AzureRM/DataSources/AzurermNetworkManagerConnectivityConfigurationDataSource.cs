using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkManagerConnectivityConfigurationDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

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
        this.WithOutput("applies_to_group");
        this.WithOutput("connectivity_topology");
        this.WithOutput("delete_existing_peering_enabled");
        this.WithOutput("description");
        this.WithOutput("global_mesh_enabled");
        this.WithOutput("hub");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The network_manager_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkManagerId is required")]
    public required TerraformProperty<string> NetworkManagerId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("network_manager_id");
        set => this.WithProperty("network_manager_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetworkManagerConnectivityConfigurationDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermNetworkManagerConnectivityConfigurationDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
