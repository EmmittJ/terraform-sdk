using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for logs in .
/// Nesting mode: list
/// </summary>
public partial class AzurermElasticCloudElasticsearchDataSourceLogsBlock() : TerraformBlock("logs")
{




}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermElasticCloudElasticsearchDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_elastic_cloud_elasticsearch.
/// </summary>
public partial class AzurermElasticCloudElasticsearchDataSource : TerraformDataSource
{
    public AzurermElasticCloudElasticsearchDataSource(string name) : base("azurerm_elastic_cloud_elasticsearch", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for logs.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("logs")]
    public TerraformList<AzurermElasticCloudElasticsearchDataSourceLogsBlock> Logs { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermElasticCloudElasticsearchDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The elastic_cloud_deployment_id attribute.
    /// </summary>
    [TerraformProperty("elastic_cloud_deployment_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ElasticCloudDeploymentId { get; }

    /// <summary>
    /// The elastic_cloud_email_address attribute.
    /// </summary>
    [TerraformProperty("elastic_cloud_email_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ElasticCloudEmailAddress { get; }

    /// <summary>
    /// The elastic_cloud_sso_default_url attribute.
    /// </summary>
    [TerraformProperty("elastic_cloud_sso_default_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ElasticCloudSsoDefaultUrl { get; }

    /// <summary>
    /// The elastic_cloud_user_id attribute.
    /// </summary>
    [TerraformProperty("elastic_cloud_user_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ElasticCloudUserId { get; }

    /// <summary>
    /// The elasticsearch_service_url attribute.
    /// </summary>
    [TerraformProperty("elasticsearch_service_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ElasticsearchServiceUrl { get; }

    /// <summary>
    /// The kibana_service_url attribute.
    /// </summary>
    [TerraformProperty("kibana_service_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KibanaServiceUrl { get; }

    /// <summary>
    /// The kibana_sso_uri attribute.
    /// </summary>
    [TerraformProperty("kibana_sso_uri")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KibanaSsoUri { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The monitoring_enabled attribute.
    /// </summary>
    [TerraformProperty("monitoring_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> MonitoringEnabled { get; }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformProperty("sku_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SkuName { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

}
