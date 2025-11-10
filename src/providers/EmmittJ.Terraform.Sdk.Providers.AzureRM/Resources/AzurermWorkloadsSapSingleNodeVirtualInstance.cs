using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapSingleNodeVirtualInstanceIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for single_server_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The app_resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppResourceGroupName is required")]
    public required TerraformProperty<string> AppResourceGroupName
    {
        set => SetProperty("app_resource_group_name", value);
    }

    /// <summary>
    /// The database_type attribute.
    /// </summary>
    public TerraformProperty<string>? DatabaseType
    {
        set => SetProperty("database_type", value);
    }

    /// <summary>
    /// The secondary_ip_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SecondaryIpEnabled
    {
        set => SetProperty("secondary_ip_enabled", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        set => SetProperty("subnet_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermWorkloadsSapSingleNodeVirtualInstanceTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_workloads_sap_single_node_virtual_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermWorkloadsSapSingleNodeVirtualInstance : TerraformResource
{
    public AzurermWorkloadsSapSingleNodeVirtualInstance(string name) : base("azurerm_workloads_sap_single_node_virtual_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("app_location");
        SetOutput("environment");
        SetOutput("id");
        SetOutput("location");
        SetOutput("managed_resource_group_name");
        SetOutput("managed_resources_network_access_type");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("sap_fqdn");
        SetOutput("sap_product");
        SetOutput("tags");
    }

    /// <summary>
    /// The app_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppLocation is required")]
    public required TerraformProperty<string> AppLocation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("app_location");
        set => SetProperty("app_location", value);
    }

    /// <summary>
    /// The environment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    public required TerraformProperty<string> Environment
    {
        get => GetRequiredOutput<TerraformProperty<string>>("environment");
        set => SetProperty("environment", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string> ManagedResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("managed_resource_group_name");
        set => SetProperty("managed_resource_group_name", value);
    }

    /// <summary>
    /// The managed_resources_network_access_type attribute.
    /// </summary>
    public TerraformProperty<string> ManagedResourcesNetworkAccessType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("managed_resources_network_access_type");
        set => SetProperty("managed_resources_network_access_type", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sap_fqdn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SapFqdn is required")]
    public required TerraformProperty<string> SapFqdn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sap_fqdn");
        set => SetProperty("sap_fqdn", value);
    }

    /// <summary>
    /// The sap_product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SapProduct is required")]
    public required TerraformProperty<string> SapProduct
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sap_product");
        set => SetProperty("sap_product", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermWorkloadsSapSingleNodeVirtualInstanceIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for single_server_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SingleServerConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SingleServerConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SingleServerConfiguration block(s) allowed")]
    public List<AzurermWorkloadsSapSingleNodeVirtualInstanceSingleServerConfigurationBlock>? SingleServerConfiguration
    {
        set => SetProperty("single_server_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermWorkloadsSapSingleNodeVirtualInstanceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
