using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for three_tier_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The app_resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppResourceGroupName is required")]
    public required TerraformProperty<string> AppResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("app_resource_group_name");
        set => WithProperty("app_resource_group_name", value);
    }

    /// <summary>
    /// The high_availability_type attribute.
    /// </summary>
    public TerraformProperty<string>? HighAvailabilityType
    {
        get => GetProperty<TerraformProperty<string>>("high_availability_type");
        set => WithProperty("high_availability_type", value);
    }

    /// <summary>
    /// The secondary_ip_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SecondaryIpEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("secondary_ip_enabled");
        set => WithProperty("secondary_ip_enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_workloads_sap_three_tier_virtual_instance resource.
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstance : TerraformResource
{
    public AzurermWorkloadsSapThreeTierVirtualInstance(string name) : base("azurerm_workloads_sap_three_tier_virtual_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The app_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppLocation is required")]
    public required TerraformProperty<string> AppLocation
    {
        get => GetProperty<TerraformProperty<string>>("app_location");
        set => this.WithProperty("app_location", value);
    }

    /// <summary>
    /// The environment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    public required TerraformProperty<string> Environment
    {
        get => GetProperty<TerraformProperty<string>>("environment");
        set => this.WithProperty("environment", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("managed_resource_group_name");
        set => this.WithProperty("managed_resource_group_name", value);
    }

    /// <summary>
    /// The managed_resources_network_access_type attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedResourcesNetworkAccessType
    {
        get => GetProperty<TerraformProperty<string>>("managed_resources_network_access_type");
        set => this.WithProperty("managed_resources_network_access_type", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sap_fqdn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SapFqdn is required")]
    public required TerraformProperty<string> SapFqdn
    {
        get => GetProperty<TerraformProperty<string>>("sap_fqdn");
        set => this.WithProperty("sap_fqdn", value);
    }

    /// <summary>
    /// The sap_product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SapProduct is required")]
    public required TerraformProperty<string> SapProduct
    {
        get => GetProperty<TerraformProperty<string>>("sap_product");
        set => this.WithProperty("sap_product", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermWorkloadsSapThreeTierVirtualInstanceIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermWorkloadsSapThreeTierVirtualInstanceIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for three_tier_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ThreeTierConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThreeTierConfiguration block(s) allowed")]
    public List<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlock>? ThreeTierConfiguration
    {
        get => GetProperty<List<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlock>>("three_tier_configuration");
        set => this.WithProperty("three_tier_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermWorkloadsSapThreeTierVirtualInstanceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermWorkloadsSapThreeTierVirtualInstanceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
