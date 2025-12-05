using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermDevCenterProjectDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermDevCenterProjectDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_dev_center_project Terraform data source.
/// Retrieves information about a azurerm_dev_center_project.
/// </summary>
public partial class AzurermDevCenterProjectDataSource(string name) : TerraformDataSource("azurerm_dev_center_project", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// The dev_center_id attribute.
    /// </summary>
    public TerraformValue<string> DevCenterId
        => CreateReference("dev_center_id");

    /// <summary>
    /// The dev_center_uri attribute.
    /// </summary>
    public TerraformValue<string> DevCenterUri
        => CreateReference("dev_center_uri");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => CreateReference("identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The maximum_dev_boxes_per_user attribute.
    /// </summary>
    public TerraformValue<double> MaximumDevBoxesPerUser
        => CreateReference("maximum_dev_boxes_per_user");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDevCenterProjectDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDevCenterProjectDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
