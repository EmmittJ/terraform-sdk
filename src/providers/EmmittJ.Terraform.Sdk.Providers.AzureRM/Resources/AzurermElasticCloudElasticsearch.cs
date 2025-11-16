using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<bool>? SendActivityLogs
    {
        get => new TerraformReference<bool>(this, "send_activity_logs");
        set => SetArgument("send_activity_logs", value);
    }

    /// <summary>
    /// The send_azuread_logs attribute.
    /// </summary>
    public TerraformValue<bool>? SendAzureadLogs
    {
        get => new TerraformReference<bool>(this, "send_azuread_logs");
        set => SetArgument("send_azuread_logs", value);
    }

    /// <summary>
    /// The send_subscription_logs attribute.
    /// </summary>
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
/// Represents a azurerm_elastic_cloud_elasticsearch Terraform resource.
/// Manages a azurerm_elastic_cloud_elasticsearch resource.
/// </summary>
public partial class AzurermElasticCloudElasticsearch(string name) : TerraformResource("azurerm_elastic_cloud_elasticsearch", name)
{
    /// <summary>
    /// The elastic_cloud_email_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ElasticCloudEmailAddress is required")]
    public required TerraformValue<string> ElasticCloudEmailAddress
    {
        get => new TerraformReference<string>(this, "elastic_cloud_email_address");
        set => SetArgument("elastic_cloud_email_address", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The monitoring_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? MonitoringEnabled
    {
        get => new TerraformReference<bool>(this, "monitoring_enabled");
        set => SetArgument("monitoring_enabled", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
        set => SetArgument("sku_name", value);
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
    /// The elastic_cloud_deployment_id attribute.
    /// </summary>
    public TerraformValue<string> ElasticCloudDeploymentId
    {
        get => new TerraformReference<string>(this, "elastic_cloud_deployment_id");
    }

    /// <summary>
    /// The elastic_cloud_sso_default_url attribute.
    /// </summary>
    public TerraformValue<string> ElasticCloudSsoDefaultUrl
    {
        get => new TerraformReference<string>(this, "elastic_cloud_sso_default_url");
    }

    /// <summary>
    /// The elastic_cloud_user_id attribute.
    /// </summary>
    public TerraformValue<string> ElasticCloudUserId
    {
        get => new TerraformReference<string>(this, "elastic_cloud_user_id");
    }

    /// <summary>
    /// The elasticsearch_service_url attribute.
    /// </summary>
    public TerraformValue<string> ElasticsearchServiceUrl
    {
        get => new TerraformReference<string>(this, "elasticsearch_service_url");
    }

    /// <summary>
    /// The kibana_service_url attribute.
    /// </summary>
    public TerraformValue<string> KibanaServiceUrl
    {
        get => new TerraformReference<string>(this, "kibana_service_url");
    }

    /// <summary>
    /// The kibana_sso_uri attribute.
    /// </summary>
    public TerraformValue<string> KibanaSsoUri
    {
        get => new TerraformReference<string>(this, "kibana_sso_uri");
    }

    /// <summary>
    /// Logs block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logs block(s) allowed")]
    public TerraformList<AzurermElasticCloudElasticsearchLogsBlock>? Logs
    {
        get => GetArgument<TerraformList<AzurermElasticCloudElasticsearchLogsBlock>>("logs");
        set => SetArgument("logs", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermElasticCloudElasticsearchTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermElasticCloudElasticsearchTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
