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
    public string? ConnectivityTopology
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connectivity_topology")?.Value;
        set => this.WithProperty("connectivity_topology", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The delete_existing_peering_enabled attribute.
    /// </summary>
    public bool? DeleteExistingPeeringEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("delete_existing_peering_enabled")?.Value;
        set => this.WithProperty("delete_existing_peering_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The global_mesh_enabled attribute.
    /// </summary>
    public bool? GlobalMeshEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("global_mesh_enabled")?.Value;
        set => this.WithProperty("global_mesh_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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

}
