using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermExtendedLocationCustomLocationDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermExtendedLocationCustomLocationDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_extended_location_custom_location Terraform data source.
/// Retrieves information about a azurerm_extended_location_custom_location.
/// </summary>
public partial class AzurermExtendedLocationCustomLocationDataSource(string name) : TerraformDataSource("azurerm_extended_location_custom_location", name)
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
    /// The authentication attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Authentication
        => AsReference("authentication");

    /// <summary>
    /// The cluster_extension_ids attribute.
    /// </summary>
    public TerraformList<string> ClusterExtensionIds
        => AsReference("cluster_extension_ids");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// The host_resource_id attribute.
    /// </summary>
    public TerraformValue<string> HostResourceId
        => AsReference("host_resource_id");

    /// <summary>
    /// The host_type attribute.
    /// </summary>
    public TerraformValue<string> HostType
        => AsReference("host_type");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    public TerraformValue<string> NamespaceAttribute
        => AsReference("namespace");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermExtendedLocationCustomLocationDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermExtendedLocationCustomLocationDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
