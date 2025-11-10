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
        set => SetProperty("global_mesh_enabled", value);
    }

    /// <summary>
    /// The group_connectivity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupConnectivity is required")]
    public required TerraformProperty<string> GroupConnectivity
    {
        set => SetProperty("group_connectivity", value);
    }

    /// <summary>
    /// The network_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkGroupId is required")]
    public required TerraformProperty<string> NetworkGroupId
    {
        set => SetProperty("network_group_id", value);
    }

    /// <summary>
    /// The use_hub_gateway attribute.
    /// </summary>
    public TerraformProperty<bool>? UseHubGateway
    {
        set => SetProperty("use_hub_gateway", value);
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
        set => SetProperty("resource_id", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceType is required")]
    public required TerraformProperty<string> ResourceType
    {
        set => SetProperty("resource_type", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("connectivity_topology");
        SetOutput("delete_existing_peering_enabled");
        SetOutput("description");
        SetOutput("global_mesh_enabled");
        SetOutput("id");
        SetOutput("name");
        SetOutput("network_manager_id");
    }

    /// <summary>
    /// The connectivity_topology attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectivityTopology is required")]
    public required TerraformProperty<string> ConnectivityTopology
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connectivity_topology");
        set => SetProperty("connectivity_topology", value);
    }

    /// <summary>
    /// The delete_existing_peering_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> DeleteExistingPeeringEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("delete_existing_peering_enabled");
        set => SetProperty("delete_existing_peering_enabled", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The global_mesh_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> GlobalMeshEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("global_mesh_enabled");
        set => SetProperty("global_mesh_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The network_manager_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkManagerId is required")]
    public required TerraformProperty<string> NetworkManagerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_manager_id");
        set => SetProperty("network_manager_id", value);
    }

    /// <summary>
    /// Block for applies_to_group.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppliesToGroup is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AppliesToGroup block(s) required")]
    public List<AzurermNetworkManagerConnectivityConfigurationAppliesToGroupBlock>? AppliesToGroup
    {
        set => SetProperty("applies_to_group", value);
    }

    /// <summary>
    /// Block for hub.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Hub block(s) allowed")]
    public List<AzurermNetworkManagerConnectivityConfigurationHubBlock>? Hub
    {
        set => SetProperty("hub", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetworkManagerConnectivityConfigurationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
