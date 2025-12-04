using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermBotWebApp.
/// Nesting mode: single
/// </summary>
public class AzurermBotWebAppTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_bot_web_app Terraform resource.
/// Manages a azurerm_bot_web_app resource.
/// </summary>
public partial class AzurermBotWebApp(string name) : TerraformResource("azurerm_bot_web_app", name)
{
    /// <summary>
    /// The developer_app_insights_api_key attribute.
    /// </summary>
    public TerraformValue<string>? DeveloperAppInsightsApiKey
    {
        get => GetArgument<TerraformValue<string>>("developer_app_insights_api_key");
        set => SetArgument("developer_app_insights_api_key", value);
    }

    /// <summary>
    /// The developer_app_insights_application_id attribute.
    /// </summary>
    public TerraformValue<string>? DeveloperAppInsightsApplicationId
    {
        get => GetArgument<TerraformValue<string>>("developer_app_insights_application_id");
        set => SetArgument("developer_app_insights_application_id", value);
    }

    /// <summary>
    /// The developer_app_insights_key attribute.
    /// </summary>
    public TerraformValue<string>? DeveloperAppInsightsKey
    {
        get => GetArgument<TerraformValue<string>>("developer_app_insights_key");
        set => SetArgument("developer_app_insights_key", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string>? Endpoint
    {
        get => GetArgument<TerraformValue<string>>("endpoint");
        set => SetArgument("endpoint", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The luis_app_ids attribute.
    /// </summary>
    public TerraformList<string>? LuisAppIds
    {
        get => GetArgument<TerraformList<string>>("luis_app_ids");
        set => SetArgument("luis_app_ids", value);
    }

    /// <summary>
    /// The luis_key attribute.
    /// </summary>
    public TerraformValue<string>? LuisKey
    {
        get => GetArgument<TerraformValue<string>>("luis_key");
        set => SetArgument("luis_key", value);
    }

    /// <summary>
    /// The microsoft_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MicrosoftAppId is required")]
    public required TerraformValue<string> MicrosoftAppId
    {
        get => GetArgument<TerraformValue<string>>("microsoft_app_id");
        set => SetArgument("microsoft_app_id", value);
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
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformValue<string> Sku
    {
        get => GetArgument<TerraformValue<string>>("sku");
        set => SetArgument("sku", value);
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermBotWebAppTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermBotWebAppTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
