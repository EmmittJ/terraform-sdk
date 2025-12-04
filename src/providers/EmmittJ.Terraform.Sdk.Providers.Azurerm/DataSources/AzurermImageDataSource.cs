using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermImageDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermImageDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_image Terraform data source.
/// Retrieves information about a azurerm_image.
/// </summary>
public partial class AzurermImageDataSource(string name) : TerraformDataSource("azurerm_image", name)
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
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The name_regex attribute.
    /// </summary>
    public TerraformValue<string>? NameRegex
    {
        get => GetArgument<TerraformValue<string>>("name_regex");
        set => SetArgument("name_regex", value);
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
    /// The sort_descending attribute.
    /// </summary>
    public TerraformValue<bool>? SortDescending
    {
        get => GetArgument<TerraformValue<bool>>("sort_descending");
        set => SetArgument("sort_descending", value);
    }

    /// <summary>
    /// The data_disk attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DataDisk
        => AsReference("data_disk");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The os_disk attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> OsDisk
        => AsReference("os_disk");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The zone_resilient attribute.
    /// </summary>
    public TerraformValue<bool> ZoneResilient
        => AsReference("zone_resilient");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermImageDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermImageDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
