using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for logs in .
/// Nesting mode: list
/// </summary>
public partial class AzurermElasticCloudElasticsearchLogsBlock : TerraformBlockBase
{
    /// <summary>
    /// The send_activity_logs attribute.
    /// </summary>
    [TerraformProperty("send_activity_logs")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SendActivityLogs { get; set; }

    /// <summary>
    /// The send_azuread_logs attribute.
    /// </summary>
    [TerraformProperty("send_azuread_logs")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SendAzureadLogs { get; set; }

    /// <summary>
    /// The send_subscription_logs attribute.
    /// </summary>
    [TerraformProperty("send_subscription_logs")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SendSubscriptionLogs { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermElasticCloudElasticsearchTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_elastic_cloud_elasticsearch resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermElasticCloudElasticsearch : TerraformResource
{
    public AzurermElasticCloudElasticsearch(string name) : base("azurerm_elastic_cloud_elasticsearch", name)
    {
    }

    /// <summary>
    /// The elastic_cloud_email_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ElasticCloudEmailAddress is required")]
    [TerraformProperty("elastic_cloud_email_address")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ElasticCloudEmailAddress { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The monitoring_enabled attribute.
    /// </summary>
    [TerraformProperty("monitoring_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? MonitoringEnabled { get; set; }

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
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformProperty("sku_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SkuName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logs block(s) allowed")]
    [TerraformProperty("logs")]
    public partial TerraformList<TerraformBlock<AzurermElasticCloudElasticsearchLogsBlock>>? Logs { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermElasticCloudElasticsearchTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The elastic_cloud_deployment_id attribute.
    /// </summary>
    [TerraformProperty("elastic_cloud_deployment_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ElasticCloudDeploymentId { get; }

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

}
