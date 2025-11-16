using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    public required TerraformSet<string> IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for three_tier_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "three_tier_configuration";

    /// <summary>
    /// The app_resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppResourceGroupName is required")]
    public required TerraformValue<string> AppResourceGroupName
    {
        get => new TerraformReference<string>(this, "app_resource_group_name");
        set => SetArgument("app_resource_group_name", value);
    }

    /// <summary>
    /// The high_availability_type attribute.
    /// </summary>
    public TerraformValue<string>? HighAvailabilityType
    {
        get => new TerraformReference<string>(this, "high_availability_type");
        set => SetArgument("high_availability_type", value);
    }

    /// <summary>
    /// The secondary_ip_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SecondaryIpEnabled
    {
        get => new TerraformReference<bool>(this, "secondary_ip_enabled");
        set => SetArgument("secondary_ip_enabled", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermWorkloadsSapThreeTierVirtualInstanceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_workloads_sap_three_tier_virtual_instance Terraform resource.
/// Manages a azurerm_workloads_sap_three_tier_virtual_instance resource.
/// </summary>
public partial class AzurermWorkloadsSapThreeTierVirtualInstance(string name) : TerraformResource("azurerm_workloads_sap_three_tier_virtual_instance", name)
{
    /// <summary>
    /// The app_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppLocation is required")]
    public required TerraformValue<string> AppLocation
    {
        get => new TerraformReference<string>(this, "app_location");
        set => SetArgument("app_location", value);
    }

    /// <summary>
    /// The environment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    public required TerraformValue<string> Environment
    {
        get => new TerraformReference<string>(this, "environment");
        set => SetArgument("environment", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    public TerraformValue<string>? ManagedResourceGroupName
    {
        get => new TerraformReference<string>(this, "managed_resource_group_name");
        set => SetArgument("managed_resource_group_name", value);
    }

    /// <summary>
    /// The managed_resources_network_access_type attribute.
    /// </summary>
    public TerraformValue<string>? ManagedResourcesNetworkAccessType
    {
        get => new TerraformReference<string>(this, "managed_resources_network_access_type");
        set => SetArgument("managed_resources_network_access_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sap_fqdn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SapFqdn is required")]
    public required TerraformValue<string> SapFqdn
    {
        get => new TerraformReference<string>(this, "sap_fqdn");
        set => SetArgument("sap_fqdn", value);
    }

    /// <summary>
    /// The sap_product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SapProduct is required")]
    public required TerraformValue<string> SapProduct
    {
        get => new TerraformReference<string>(this, "sap_product");
        set => SetArgument("sap_product", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// ThreeTierConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ThreeTierConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ThreeTierConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThreeTierConfiguration block(s) allowed")]
    public required TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlock> ThreeTierConfiguration
    {
        get => GetRequiredArgument<TerraformList<AzurermWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationBlock>>("three_tier_configuration");
        set => SetArgument("three_tier_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermWorkloadsSapThreeTierVirtualInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermWorkloadsSapThreeTierVirtualInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
