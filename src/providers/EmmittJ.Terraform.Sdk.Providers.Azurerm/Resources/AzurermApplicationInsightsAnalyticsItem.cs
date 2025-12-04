using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermApplicationInsightsAnalyticsItem.
/// Nesting mode: single
/// </summary>
public class AzurermApplicationInsightsAnalyticsItemTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_application_insights_analytics_item Terraform resource.
/// Manages a azurerm_application_insights_analytics_item resource.
/// </summary>
public partial class AzurermApplicationInsightsAnalyticsItem(string name) : TerraformResource("azurerm_application_insights_analytics_item", name)
{
    /// <summary>
    /// The application_insights_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationInsightsId is required")]
    public required TerraformValue<string> ApplicationInsightsId
    {
        get => GetArgument<TerraformValue<string>>("application_insights_id");
        set => SetArgument("application_insights_id", value);
    }

    /// <summary>
    /// The content attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    public required TerraformValue<string> Content
    {
        get => GetArgument<TerraformValue<string>>("content");
        set => SetArgument("content", value);
    }

    /// <summary>
    /// The function_alias attribute.
    /// </summary>
    public TerraformValue<string>? FunctionAlias
    {
        get => GetArgument<TerraformValue<string>>("function_alias");
        set => SetArgument("function_alias", value);
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
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformValue<string> Scope
    {
        get => GetArgument<TerraformValue<string>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The time_created attribute.
    /// </summary>
    public TerraformValue<string> TimeCreated
        => AsReference("time_created");

    /// <summary>
    /// The time_modified attribute.
    /// </summary>
    public TerraformValue<string> TimeModified
        => AsReference("time_modified");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
        => AsReference("version");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApplicationInsightsAnalyticsItemTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApplicationInsightsAnalyticsItemTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
