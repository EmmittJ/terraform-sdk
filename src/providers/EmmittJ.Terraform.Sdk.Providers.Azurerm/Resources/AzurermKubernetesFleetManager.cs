using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for hub_profile in AzurermKubernetesFleetManager.
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AzurermKubernetesFleetManagerHubProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hub_profile";

    /// <summary>
    /// The dns_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DnsPrefix is required")]
    public required TerraformValue<string> DnsPrefix
    {
        get => GetArgument<TerraformValue<string>>("dns_prefix");
        set => SetArgument("dns_prefix", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string> Fqdn
        => AsReference("fqdn");

    /// <summary>
    /// The kubernetes_version attribute.
    /// </summary>
    public TerraformValue<string> KubernetesVersion
        => AsReference("kubernetes_version");

}


/// <summary>
/// Block type for timeouts in AzurermKubernetesFleetManager.
/// Nesting mode: single
/// </summary>
public class AzurermKubernetesFleetManagerTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_kubernetes_fleet_manager Terraform resource.
/// Manages a azurerm_kubernetes_fleet_manager resource.
/// </summary>
public partial class AzurermKubernetesFleetManager(string name) : TerraformResource("azurerm_kubernetes_fleet_manager", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// HubProfile block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HubProfile block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public TerraformList<AzurermKubernetesFleetManagerHubProfileBlock>? HubProfile
    {
        get => GetArgument<TerraformList<AzurermKubernetesFleetManagerHubProfileBlock>>("hub_profile");
        set => SetArgument("hub_profile", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKubernetesFleetManagerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKubernetesFleetManagerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
