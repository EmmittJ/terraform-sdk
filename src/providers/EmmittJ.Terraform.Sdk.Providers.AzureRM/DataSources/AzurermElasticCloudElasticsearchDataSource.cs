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
public class AzurermElasticCloudElasticsearchDataSourceLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logs";





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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_elastic_cloud_elasticsearch.
/// </summary>
public class AzurermElasticCloudElasticsearchDataSource : TerraformDataSource
{
    public AzurermElasticCloudElasticsearchDataSource(string name) : base("azurerm_elastic_cloud_elasticsearch", name)
    {
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
    /// Block for logs.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("logs")]
    public TerraformList<AzurermElasticCloudElasticsearchDataSourceLogsBlock> Logs { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermElasticCloudElasticsearchDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The elastic_cloud_deployment_id attribute.
    /// </summary>
    [TerraformArgument("elastic_cloud_deployment_id")]
    public TerraformValue<string> ElasticCloudDeploymentId
    {
        get => new TerraformReference<string>(this, "elastic_cloud_deployment_id");
    }

    /// <summary>
    /// The elastic_cloud_email_address attribute.
    /// </summary>
    [TerraformArgument("elastic_cloud_email_address")]
    public TerraformValue<string> ElasticCloudEmailAddress
    {
        get => new TerraformReference<string>(this, "elastic_cloud_email_address");
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

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The monitoring_enabled attribute.
    /// </summary>
    [TerraformArgument("monitoring_enabled")]
    public TerraformValue<bool> MonitoringEnabled
    {
        get => new TerraformReference<bool>(this, "monitoring_enabled");
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformArgument("sku_name")]
    public TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

}
