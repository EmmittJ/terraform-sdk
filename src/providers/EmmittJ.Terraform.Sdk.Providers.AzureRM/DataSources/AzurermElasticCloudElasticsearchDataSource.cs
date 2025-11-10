using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for logs in .
/// Nesting mode: list
/// </summary>
public class AzurermElasticCloudElasticsearchDataSourceLogsBlock : ITerraformBlock
{
    /// <summary>
    /// The filtering_tag attribute.
    /// </summary>
    [TerraformPropertyName("filtering_tag")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> FilteringTag => new TerraformReferenceProperty<List<TerraformProperty<object>>>("", "filtering_tag");

    /// <summary>
    /// The send_activity_logs attribute.
    /// </summary>
    [TerraformPropertyName("send_activity_logs")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> SendActivityLogs => new TerraformReferenceProperty<TerraformProperty<bool>>("", "send_activity_logs");

    /// <summary>
    /// The send_azuread_logs attribute.
    /// </summary>
    [TerraformPropertyName("send_azuread_logs")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> SendAzureadLogs => new TerraformReferenceProperty<TerraformProperty<bool>>("", "send_azuread_logs");

    /// <summary>
    /// The send_subscription_logs attribute.
    /// </summary>
    [TerraformPropertyName("send_subscription_logs")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> SendSubscriptionLogs => new TerraformReferenceProperty<TerraformProperty<bool>>("", "send_subscription_logs");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermElasticCloudElasticsearchDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for logs.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("logs")]
    public TerraformList<TerraformBlock<AzurermElasticCloudElasticsearchDataSourceLogsBlock>>? Logs { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermElasticCloudElasticsearchDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The elastic_cloud_deployment_id attribute.
    /// </summary>
    [TerraformPropertyName("elastic_cloud_deployment_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ElasticCloudDeploymentId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "elastic_cloud_deployment_id");

    /// <summary>
    /// The elastic_cloud_email_address attribute.
    /// </summary>
    [TerraformPropertyName("elastic_cloud_email_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ElasticCloudEmailAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "elastic_cloud_email_address");

    /// <summary>
    /// The elastic_cloud_sso_default_url attribute.
    /// </summary>
    [TerraformPropertyName("elastic_cloud_sso_default_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ElasticCloudSsoDefaultUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "elastic_cloud_sso_default_url");

    /// <summary>
    /// The elastic_cloud_user_id attribute.
    /// </summary>
    [TerraformPropertyName("elastic_cloud_user_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ElasticCloudUserId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "elastic_cloud_user_id");

    /// <summary>
    /// The elasticsearch_service_url attribute.
    /// </summary>
    [TerraformPropertyName("elasticsearch_service_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ElasticsearchServiceUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "elasticsearch_service_url");

    /// <summary>
    /// The kibana_service_url attribute.
    /// </summary>
    [TerraformPropertyName("kibana_service_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KibanaServiceUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kibana_service_url");

    /// <summary>
    /// The kibana_sso_uri attribute.
    /// </summary>
    [TerraformPropertyName("kibana_sso_uri")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KibanaSsoUri => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kibana_sso_uri");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The monitoring_enabled attribute.
    /// </summary>
    [TerraformPropertyName("monitoring_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> MonitoringEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "monitoring_enabled");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformPropertyName("sku_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SkuName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sku_name");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

}
