using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_network_manager_connectivity_configuration resource.
/// </summary>
public class AzurermNetworkManagerConnectivityConfiguration : TerraformResource
{
    public AzurermNetworkManagerConnectivityConfiguration(string name) : base("azurerm_network_manager_connectivity_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The connectivity_topology attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectivityTopology
    {
        get => GetProperty<TerraformProperty<string>>("connectivity_topology");
        set => this.WithProperty("connectivity_topology", value);
    }

    /// <summary>
    /// The delete_existing_peering_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DeleteExistingPeeringEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("delete_existing_peering_enabled");
        set => this.WithProperty("delete_existing_peering_enabled", value);
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
    /// The global_mesh_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? GlobalMeshEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("global_mesh_enabled");
        set => this.WithProperty("global_mesh_enabled", value);
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

}
