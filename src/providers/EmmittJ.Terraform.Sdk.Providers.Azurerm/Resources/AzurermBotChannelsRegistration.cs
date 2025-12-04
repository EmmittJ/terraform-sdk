using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermBotChannelsRegistration.
/// Nesting mode: single
/// </summary>
public class AzurermBotChannelsRegistrationTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_bot_channels_registration Terraform resource.
/// Manages a azurerm_bot_channels_registration resource.
/// </summary>
public partial class AzurermBotChannelsRegistration(string name) : TerraformResource("azurerm_bot_channels_registration", name)
{
    /// <summary>
    /// The cmk_key_vault_url attribute.
    /// </summary>
    public TerraformValue<string>? CmkKeyVaultUrl
    {
        get => GetArgument<TerraformValue<string>>("cmk_key_vault_url");
        set => SetArgument("cmk_key_vault_url", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

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
    /// The icon_url attribute.
    /// </summary>
    public TerraformValue<string>? IconUrl
    {
        get => GetArgument<TerraformValue<string>>("icon_url");
        set => SetArgument("icon_url", value);
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
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => GetArgument<TerraformValue<bool>>("public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
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
    /// The streaming_endpoint_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? StreamingEndpointEnabled
    {
        get => GetArgument<TerraformValue<bool>>("streaming_endpoint_enabled");
        set => SetArgument("streaming_endpoint_enabled", value);
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
    public AzurermBotChannelsRegistrationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermBotChannelsRegistrationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
