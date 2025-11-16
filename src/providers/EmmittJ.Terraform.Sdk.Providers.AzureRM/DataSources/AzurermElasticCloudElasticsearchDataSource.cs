using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for logs in .
/// Nesting mode: list
/// </summary>
public class AzurermElasticCloudElasticsearchDataSourceLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logs";

    /// <summary>
    /// The filtering_tag attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> FilteringTag
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "filtering_tag").ResolveNodes(ctx));
    }

    /// <summary>
    /// The send_activity_logs attribute.
    /// </summary>
    public TerraformValue<bool> SendActivityLogs
    {
        get => new TerraformReference<bool>(this, "send_activity_logs");
    }

    /// <summary>
    /// The send_azuread_logs attribute.
    /// </summary>
    public TerraformValue<bool> SendAzureadLogs
    {
        get => new TerraformReference<bool>(this, "send_azuread_logs");
    }

    /// <summary>
    /// The send_subscription_logs attribute.
    /// </summary>
    public TerraformValue<bool> SendSubscriptionLogs
    {
        get => new TerraformReference<bool>(this, "send_subscription_logs");
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermElasticCloudElasticsearchDataSourceTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_elastic_cloud_elasticsearch Terraform data source.
/// Retrieves information about a azurerm_elastic_cloud_elasticsearch.
/// </summary>
public partial class AzurermElasticCloudElasticsearchDataSource(string name) : TerraformDataSource("azurerm_elastic_cloud_elasticsearch", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The elastic_cloud_deployment_id attribute.
    /// </summary>
    public TerraformValue<string> ElasticCloudDeploymentId
    {
        get => new TerraformReference<string>(this, "elastic_cloud_deployment_id");
    }

    /// <summary>
    /// The elastic_cloud_email_address attribute.
    /// </summary>
    public TerraformValue<string> ElasticCloudEmailAddress
    {
        get => new TerraformReference<string>(this, "elastic_cloud_email_address");
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
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The monitoring_enabled attribute.
    /// </summary>
    public TerraformValue<bool> MonitoringEnabled
    {
        get => new TerraformReference<bool>(this, "monitoring_enabled");
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// Logs block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermElasticCloudElasticsearchDataSourceLogsBlock>? Logs
    {
        get => GetArgument<TerraformList<AzurermElasticCloudElasticsearchDataSourceLogsBlock>>("logs");
        set => SetArgument("logs", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermElasticCloudElasticsearchDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermElasticCloudElasticsearchDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
