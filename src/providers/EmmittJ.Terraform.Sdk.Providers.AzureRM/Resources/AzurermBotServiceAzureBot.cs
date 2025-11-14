using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_bot_service_azure_bot resource.
/// </summary>
public class AzurermBotServiceAzureBot : TerraformResource
{
    public AzurermBotServiceAzureBot(string name) : base("azurerm_bot_service_azure_bot", name)
    {
    }

    /// <summary>
    /// The cmk_key_vault_key_url attribute.
    /// </summary>
    [TerraformArgument("cmk_key_vault_key_url")]
    public TerraformValue<string>? CmkKeyVaultKeyUrl
    {
        get => new TerraformReference<string>(this, "cmk_key_vault_key_url");
        set => SetArgument("cmk_key_vault_key_url", value);
    }

    /// <summary>
    /// The developer_app_insights_api_key attribute.
    /// </summary>
    [TerraformArgument("developer_app_insights_api_key")]
    public TerraformValue<string>? DeveloperAppInsightsApiKey
    {
        get => new TerraformReference<string>(this, "developer_app_insights_api_key");
        set => SetArgument("developer_app_insights_api_key", value);
    }

    /// <summary>
    /// The developer_app_insights_application_id attribute.
    /// </summary>
    [TerraformArgument("developer_app_insights_application_id")]
    public TerraformValue<string>? DeveloperAppInsightsApplicationId
    {
        get => new TerraformReference<string>(this, "developer_app_insights_application_id");
        set => SetArgument("developer_app_insights_application_id", value);
    }

    /// <summary>
    /// The developer_app_insights_key attribute.
    /// </summary>
    [TerraformArgument("developer_app_insights_key")]
    public TerraformValue<string>? DeveloperAppInsightsKey
    {
        get => new TerraformReference<string>(this, "developer_app_insights_key");
        set => SetArgument("developer_app_insights_key", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformArgument("display_name")]
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformArgument("endpoint")]
    public TerraformValue<string>? Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
        set => SetArgument("endpoint", value);
    }

    /// <summary>
    /// The icon_url attribute.
    /// </summary>
    [TerraformArgument("icon_url")]
    public TerraformValue<string>? IconUrl
    {
        get => new TerraformReference<string>(this, "icon_url");
        set => SetArgument("icon_url", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The local_authentication_enabled attribute.
    /// </summary>
    [TerraformArgument("local_authentication_enabled")]
    public TerraformValue<bool>? LocalAuthenticationEnabled
    {
        get => new TerraformReference<bool>(this, "local_authentication_enabled");
        set => SetArgument("local_authentication_enabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The luis_app_ids attribute.
    /// </summary>
    [TerraformArgument("luis_app_ids")]
    public TerraformList<string>? LuisAppIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "luis_app_ids").ResolveNodes(ctx));
        set => SetArgument("luis_app_ids", value);
    }

    /// <summary>
    /// The luis_key attribute.
    /// </summary>
    [TerraformArgument("luis_key")]
    public TerraformValue<string>? LuisKey
    {
        get => new TerraformReference<string>(this, "luis_key");
        set => SetArgument("luis_key", value);
    }

    /// <summary>
    /// The microsoft_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MicrosoftAppId is required")]
    [TerraformArgument("microsoft_app_id")]
    public required TerraformValue<string> MicrosoftAppId
    {
        get => new TerraformReference<string>(this, "microsoft_app_id");
        set => SetArgument("microsoft_app_id", value);
    }

    /// <summary>
    /// The microsoft_app_msi_id attribute.
    /// </summary>
    [TerraformArgument("microsoft_app_msi_id")]
    public TerraformValue<string>? MicrosoftAppMsiId
    {
        get => new TerraformReference<string>(this, "microsoft_app_msi_id");
        set => SetArgument("microsoft_app_msi_id", value);
    }

    /// <summary>
    /// The microsoft_app_tenant_id attribute.
    /// </summary>
    [TerraformArgument("microsoft_app_tenant_id")]
    public TerraformValue<string>? MicrosoftAppTenantId
    {
        get => new TerraformReference<string>(this, "microsoft_app_tenant_id");
        set => SetArgument("microsoft_app_tenant_id", value);
    }

    /// <summary>
    /// The microsoft_app_type attribute.
    /// </summary>
    [TerraformArgument("microsoft_app_type")]
    public TerraformValue<string>? MicrosoftAppType
    {
        get => new TerraformReference<string>(this, "microsoft_app_type");
        set => SetArgument("microsoft_app_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformArgument("public_network_access_enabled")]
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [TerraformArgument("sku")]
    public required TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The streaming_endpoint_enabled attribute.
    /// </summary>
    [TerraformArgument("streaming_endpoint_enabled")]
    public TerraformValue<bool>? StreamingEndpointEnabled
    {
        get => new TerraformReference<bool>(this, "streaming_endpoint_enabled");
        set => SetArgument("streaming_endpoint_enabled", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermBotServiceAzureBotTimeoutsBlock Timeouts { get; set; } = new();

}
