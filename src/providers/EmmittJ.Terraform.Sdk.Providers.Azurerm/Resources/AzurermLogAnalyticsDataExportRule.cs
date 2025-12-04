using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermLogAnalyticsDataExportRule.
/// Nesting mode: single
/// </summary>
public class AzurermLogAnalyticsDataExportRuleTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_log_analytics_data_export_rule Terraform resource.
/// Manages a azurerm_log_analytics_data_export_rule resource.
/// </summary>
public partial class AzurermLogAnalyticsDataExportRule(string name) : TerraformResource("azurerm_log_analytics_data_export_rule", name)
{
    /// <summary>
    /// The destination_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationResourceId is required")]
    public required TerraformValue<string> DestinationResourceId
    {
        get => GetArgument<TerraformValue<string>>("destination_resource_id");
        set => SetArgument("destination_resource_id", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool>? Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

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
    /// The table_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableNames is required")]
    public required TerraformSet<string> TableNames
    {
        get => GetArgument<TerraformSet<string>>("table_names");
        set => SetArgument("table_names", value);
    }

    /// <summary>
    /// The workspace_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceResourceId is required")]
    public required TerraformValue<string> WorkspaceResourceId
    {
        get => GetArgument<TerraformValue<string>>("workspace_resource_id");
        set => SetArgument("workspace_resource_id", value);
    }

    /// <summary>
    /// The export_rule_id attribute.
    /// </summary>
    public TerraformValue<string> ExportRuleId
        => AsReference("export_rule_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLogAnalyticsDataExportRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLogAnalyticsDataExportRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
