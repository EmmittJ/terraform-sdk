using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBotServiceAzureBotTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_bot_service_azure_bot Terraform resource.
/// Manages a azurerm_bot_service_azure_bot resource.
/// </summary>
public partial class AzurermBotServiceAzureBot(string name) : TerraformResource("azurerm_bot_service_azure_bot", name)
{
    /// <summary>
    /// The cmk_key_vault_key_url attribute.
    /// </summary>
    public TerraformValue<string>? CmkKeyVaultKeyUrl
    {
        get => new TerraformReference<string>(this, "cmk_key_vault_key_url");
        set => SetArgument("cmk_key_vault_key_url", value);
    }

    /// <summary>
    /// The developer_app_insights_api_key attribute.
    /// </summary>
    public TerraformValue<string>? DeveloperAppInsightsApiKey
    {
        get => new TerraformReference<string>(this, "developer_app_insights_api_key");
        set => SetArgument("developer_app_insights_api_key", value);
    }

    /// <summary>
    /// The developer_app_insights_application_id attribute.
    /// </summary>
    public TerraformValue<string>? DeveloperAppInsightsApplicationId
    {
        get => new TerraformReference<string>(this, "developer_app_insights_application_id");
        set => SetArgument("developer_app_insights_application_id", value);
    }

    /// <summary>
    /// The developer_app_insights_key attribute.
    /// </summary>
    public TerraformValue<string>? DeveloperAppInsightsKey
    {
        get => new TerraformReference<string>(this, "developer_app_insights_key");
        set => SetArgument("developer_app_insights_key", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string>? Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
        set => SetArgument("endpoint", value);
    }

    /// <summary>
    /// The icon_url attribute.
    /// </summary>
    public TerraformValue<string>? IconUrl
    {
        get => new TerraformReference<string>(this, "icon_url");
        set => SetArgument("icon_url", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The local_authentication_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? LocalAuthenticationEnabled
    {
        get => new TerraformReference<bool>(this, "local_authentication_enabled");
        set => SetArgument("local_authentication_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The luis_app_ids attribute.
    /// </summary>
    public TerraformList<string>? LuisAppIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "luis_app_ids").ResolveNodes(ctx));
        set => SetArgument("luis_app_ids", value);
    }

    /// <summary>
    /// The luis_key attribute.
    /// </summary>
    public TerraformValue<string>? LuisKey
    {
        get => new TerraformReference<string>(this, "luis_key");
        set => SetArgument("luis_key", value);
    }

    /// <summary>
    /// The microsoft_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MicrosoftAppId is required")]
    public required TerraformValue<string> MicrosoftAppId
    {
        get => new TerraformReference<string>(this, "microsoft_app_id");
        set => SetArgument("microsoft_app_id", value);
    }

    /// <summary>
    /// The microsoft_app_msi_id attribute.
    /// </summary>
    public TerraformValue<string>? MicrosoftAppMsiId
    {
        get => new TerraformReference<string>(this, "microsoft_app_msi_id");
        set => SetArgument("microsoft_app_msi_id", value);
    }

    /// <summary>
    /// The microsoft_app_tenant_id attribute.
    /// </summary>
    public TerraformValue<string>? MicrosoftAppTenantId
    {
        get => new TerraformReference<string>(this, "microsoft_app_tenant_id");
        set => SetArgument("microsoft_app_tenant_id", value);
    }

    /// <summary>
    /// The microsoft_app_type attribute.
    /// </summary>
    public TerraformValue<string>? MicrosoftAppType
    {
        get => new TerraformReference<string>(this, "microsoft_app_type");
        set => SetArgument("microsoft_app_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    public required TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The streaming_endpoint_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? StreamingEndpointEnabled
    {
        get => new TerraformReference<bool>(this, "streaming_endpoint_enabled");
        set => SetArgument("streaming_endpoint_enabled", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermBotServiceAzureBotTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermBotServiceAzureBotTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
