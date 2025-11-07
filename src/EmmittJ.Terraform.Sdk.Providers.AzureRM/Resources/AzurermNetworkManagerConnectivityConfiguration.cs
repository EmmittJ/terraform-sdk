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
    public TerraformLiteralProperty<string>? ConnectivityTopology
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connectivity_topology");
        set => this.WithProperty("connectivity_topology", value);
    }

    /// <summary>
    /// The delete_existing_peering_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DeleteExistingPeeringEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("delete_existing_peering_enabled");
        set => this.WithProperty("delete_existing_peering_enabled", value);
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
    /// The global_mesh_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? GlobalMeshEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("global_mesh_enabled");
        set => this.WithProperty("global_mesh_enabled", value);
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
    /// The network_manager_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NetworkManagerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_manager_id");
        set => this.WithProperty("network_manager_id", value);
    }

}
