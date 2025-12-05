using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermApplicationInsightsDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermApplicationInsightsDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_application_insights Terraform data source.
/// Retrieves information about a azurerm_application_insights.
/// </summary>
public partial class AzurermApplicationInsightsDataSource(string name) : TerraformDataSource("azurerm_application_insights", name)
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
    /// The app_id attribute.
    /// </summary>
    public TerraformValue<string> AppId
        => CreateReference("app_id");

    /// <summary>
    /// The application_type attribute.
    /// </summary>
    public TerraformValue<string> ApplicationType
        => CreateReference("application_type");

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformValue<string> ConnectionString
        => CreateReference("connection_string");

    /// <summary>
    /// The instrumentation_key attribute.
    /// </summary>
    public TerraformValue<string> InstrumentationKey
        => CreateReference("instrumentation_key");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    public TerraformValue<double> RetentionInDays
        => CreateReference("retention_in_days");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformValue<string> WorkspaceId
        => CreateReference("workspace_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApplicationInsightsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApplicationInsightsDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
