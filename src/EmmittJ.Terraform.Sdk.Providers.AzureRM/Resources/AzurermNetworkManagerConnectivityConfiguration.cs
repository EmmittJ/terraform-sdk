using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for applies_to_group in .
/// Nesting mode: list
/// </summary>
public class AzurermNetworkManagerConnectivityConfigurationAppliesToGroupBlock : TerraformBlock
{
    /// <summary>
    /// The global_mesh_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? GlobalMeshEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("global_mesh_enabled");
        set => WithProperty("global_mesh_enabled", value);
    }

    /// <summary>
    /// The group_connectivity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupConnectivity is required")]
    public required TerraformProperty<string> GroupConnectivity
    {
        get => GetProperty<TerraformProperty<string>>("group_connectivity");
        set => WithProperty("group_connectivity", value);
    }

    /// <summary>
    /// The network_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkGroupId is required")]
    public required TerraformProperty<string> NetworkGroupId
    {
        get => GetProperty<TerraformProperty<string>>("network_group_id");
        set => WithProperty("network_group_id", value);
    }

    /// <summary>
    /// The use_hub_gateway attribute.
    /// </summary>
    public TerraformProperty<bool>? UseHubGateway
    {
        get => GetProperty<TerraformProperty<bool>>("use_hub_gateway");
        set => WithProperty("use_hub_gateway", value);
    }

}

/// <summary>
/// Block type for hub in .
/// Nesting mode: list
/// </summary>
public class AzurermNetworkManagerConnectivityConfigurationHubBlock : TerraformBlock
{
    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceId is required")]
    public required TerraformProperty<string> ResourceId
    {
        get => GetProperty<TerraformProperty<string>>("resource_id");
        set => WithProperty("resource_id", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    public required TerraformProperty<string> ResourceType
    {
        get => GetProperty<TerraformProperty<string>>("resource_type");
        set => WithProperty("resource_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkManagerConnectivityConfigurationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_network_manager_connectivity_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectivityTopology is required")]
    public required TerraformProperty<string> ConnectivityTopology
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The network_manager_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkManagerId is required")]
    public required TerraformProperty<string> NetworkManagerId
    {
        get => GetProperty<TerraformProperty<string>>("network_manager_id");
        set => this.WithProperty("network_manager_id", value);
    }

    /// <summary>
    /// Block for applies_to_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AppliesToGroup block(s) required")]
    public List<AzurermNetworkManagerConnectivityConfigurationAppliesToGroupBlock>? AppliesToGroup
    {
        get => GetProperty<List<AzurermNetworkManagerConnectivityConfigurationAppliesToGroupBlock>>("applies_to_group");
        set => this.WithProperty("applies_to_group", value);
    }

    /// <summary>
    /// Block for hub.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Hub block(s) allowed")]
    public List<AzurermNetworkManagerConnectivityConfigurationHubBlock>? Hub
    {
        get => GetProperty<List<AzurermNetworkManagerConnectivityConfigurationHubBlock>>("hub");
        set => this.WithProperty("hub", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetworkManagerConnectivityConfigurationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermNetworkManagerConnectivityConfigurationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
