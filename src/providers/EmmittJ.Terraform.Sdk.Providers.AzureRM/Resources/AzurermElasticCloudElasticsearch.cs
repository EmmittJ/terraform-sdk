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
/// Block type for logs in .
/// Nesting mode: list
/// </summary>
public class AzurermElasticCloudElasticsearchLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logs";

    /// <summary>
    /// The send_activity_logs attribute.
    /// </summary>
    [TerraformArgument("send_activity_logs")]
    public TerraformValue<bool>? SendActivityLogs
    {
        get => new TerraformReference<bool>(this, "send_activity_logs");
        set => SetArgument("send_activity_logs", value);
    }

    /// <summary>
    /// The send_azuread_logs attribute.
    /// </summary>
    [TerraformArgument("send_azuread_logs")]
    public TerraformValue<bool>? SendAzureadLogs
    {
        get => new TerraformReference<bool>(this, "send_azuread_logs");
        set => SetArgument("send_azuread_logs", value);
    }

    /// <summary>
    /// The send_subscription_logs attribute.
    /// </summary>
    [TerraformArgument("send_subscription_logs")]
    public TerraformValue<bool>? SendSubscriptionLogs
    {
        get => new TerraformReference<bool>(this, "send_subscription_logs");
        set => SetArgument("send_subscription_logs", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermElasticCloudElasticsearchTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_elastic_cloud_elasticsearch resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermElasticCloudElasticsearch : TerraformResource
{
    public AzurermElasticCloudElasticsearch(string name) : base("azurerm_elastic_cloud_elasticsearch", name)
    {
    }

    /// <summary>
    /// The elastic_cloud_email_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ElasticCloudEmailAddress is required")]
    [TerraformArgument("elastic_cloud_email_address")]
    public required TerraformValue<string> ElasticCloudEmailAddress
    {
        get => new TerraformReference<string>(this, "elastic_cloud_email_address");
        set => SetArgument("elastic_cloud_email_address", value);
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
    /// The monitoring_enabled attribute.
    /// </summary>
    [TerraformArgument("monitoring_enabled")]
    public TerraformValue<bool>? MonitoringEnabled
    {
        get => new TerraformReference<bool>(this, "monitoring_enabled");
        set => SetArgument("monitoring_enabled", value);
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
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformArgument("sku_name")]
    public required TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
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
    /// Block for logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logs block(s) allowed")]
    [TerraformArgument("logs")]
    public TerraformList<AzurermElasticCloudElasticsearchLogsBlock> Logs { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermElasticCloudElasticsearchTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The elastic_cloud_deployment_id attribute.
    /// </summary>
    [TerraformArgument("elastic_cloud_deployment_id")]
    public TerraformValue<string> ElasticCloudDeploymentId
    {
        get => new TerraformReference<string>(this, "elastic_cloud_deployment_id");
    }

    /// <summary>
    /// The elastic_cloud_sso_default_url attribute.
    /// </summary>
    [TerraformArgument("elastic_cloud_sso_default_url")]
    public TerraformValue<string> ElasticCloudSsoDefaultUrl
    {
        get => new TerraformReference<string>(this, "elastic_cloud_sso_default_url");
    }

    /// <summary>
    /// The elastic_cloud_user_id attribute.
    /// </summary>
    [TerraformArgument("elastic_cloud_user_id")]
    public TerraformValue<string> ElasticCloudUserId
    {
        get => new TerraformReference<string>(this, "elastic_cloud_user_id");
    }

    /// <summary>
    /// The elasticsearch_service_url attribute.
    /// </summary>
    [TerraformArgument("elasticsearch_service_url")]
    public TerraformValue<string> ElasticsearchServiceUrl
    {
        get => new TerraformReference<string>(this, "elasticsearch_service_url");
    }

    /// <summary>
    /// The kibana_service_url attribute.
    /// </summary>
    [TerraformArgument("kibana_service_url")]
    public TerraformValue<string> KibanaServiceUrl
    {
        get => new TerraformReference<string>(this, "kibana_service_url");
    }

    /// <summary>
    /// The kibana_sso_uri attribute.
    /// </summary>
    [TerraformArgument("kibana_sso_uri")]
    public TerraformValue<string> KibanaSsoUri
    {
        get => new TerraformReference<string>(this, "kibana_sso_uri");
    }

}
