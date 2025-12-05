using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermResourcesDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermResourcesDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_resources Terraform data source.
/// Retrieves information about a azurerm_resources.
/// </summary>
public partial class AzurermResourcesDataSource(string name) : TerraformDataSource("azurerm_resources", name)
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
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? CreateReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The required_tags attribute.
    /// </summary>
    public TerraformMap<string>? RequiredTags
    {
        get => GetArgument<TerraformMap<string>>("required_tags");
        set => SetArgument("required_tags", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name") ?? CreateReference("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type") ?? CreateReference("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The resources attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Resources
        => CreateReference("resources");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermResourcesDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermResourcesDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
