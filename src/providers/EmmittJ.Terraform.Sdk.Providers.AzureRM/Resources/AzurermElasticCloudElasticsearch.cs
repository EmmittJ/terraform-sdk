using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for logs in .
/// Nesting mode: list
/// </summary>
public class AzurermElasticCloudElasticsearchLogsBlock
{
    /// <summary>
    /// The send_activity_logs attribute.
    /// </summary>
    [TerraformPropertyName("send_activity_logs")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SendActivityLogs { get; set; }

    /// <summary>
    /// The send_azuread_logs attribute.
    /// </summary>
    [TerraformPropertyName("send_azuread_logs")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SendAzureadLogs { get; set; }

    /// <summary>
    /// The send_subscription_logs attribute.
    /// </summary>
    [TerraformPropertyName("send_subscription_logs")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SendSubscriptionLogs { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermElasticCloudElasticsearchTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

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
    [TerraformPropertyName("elastic_cloud_email_address")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ElasticCloudEmailAddress { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The monitoring_enabled attribute.
    /// </summary>
    [TerraformPropertyName("monitoring_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? MonitoringEnabled { get; set; }

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
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    [TerraformPropertyName("sku_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SkuName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logs block(s) allowed")]
    [TerraformPropertyName("logs")]
    public TerraformList<TerraformBlock<AzurermElasticCloudElasticsearchLogsBlock>>? Logs { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermElasticCloudElasticsearchTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The elastic_cloud_deployment_id attribute.
    /// </summary>
    [TerraformPropertyName("elastic_cloud_deployment_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ElasticCloudDeploymentId => new TerraformReference(this, "elastic_cloud_deployment_id");

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

}
