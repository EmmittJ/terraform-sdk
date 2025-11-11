using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for logs in .
/// Nesting mode: list
/// </summary>
public class AzurermElasticCloudElasticsearchDataSourceLogsBlock
{




}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermElasticCloudElasticsearchDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for logs.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("logs")]
    public TerraformList<TerraformBlock<AzurermElasticCloudElasticsearchDataSourceLogsBlock>>? Logs { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermElasticCloudElasticsearchDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The elastic_cloud_deployment_id attribute.
    /// </summary>
    [TerraformPropertyName("elastic_cloud_deployment_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ElasticCloudDeploymentId => new TerraformReference(this, "elastic_cloud_deployment_id");

    /// <summary>
    /// The elastic_cloud_email_address attribute.
    /// </summary>
    [TerraformPropertyName("elastic_cloud_email_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ElasticCloudEmailAddress => new TerraformReference(this, "elastic_cloud_email_address");

    /// <summary>
    /// The elastic_cloud_sso_default_url attribute.
    /// </summary>
    [TerraformPropertyName("elastic_cloud_sso_default_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ElasticCloudSsoDefaultUrl => new TerraformReference(this, "elastic_cloud_sso_default_url");

    /// <summary>
    /// The elastic_cloud_user_id attribute.
    /// </summary>
    [TerraformPropertyName("elastic_cloud_user_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ElasticCloudUserId => new TerraformReference(this, "elastic_cloud_user_id");

    /// <summary>
    /// The elasticsearch_service_url attribute.
    /// </summary>
    [TerraformPropertyName("elasticsearch_service_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ElasticsearchServiceUrl => new TerraformReference(this, "elasticsearch_service_url");

    /// <summary>
    /// The kibana_service_url attribute.
    /// </summary>
    [TerraformPropertyName("kibana_service_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KibanaServiceUrl => new TerraformReference(this, "kibana_service_url");

    /// <summary>
    /// The kibana_sso_uri attribute.
    /// </summary>
    [TerraformPropertyName("kibana_sso_uri")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KibanaSsoUri => new TerraformReference(this, "kibana_sso_uri");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The monitoring_enabled attribute.
    /// </summary>
    [TerraformPropertyName("monitoring_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> MonitoringEnabled => new TerraformReference(this, "monitoring_enabled");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformPropertyName("sku_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SkuName => new TerraformReference(this, "sku_name");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

}
