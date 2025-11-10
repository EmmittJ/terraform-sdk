using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for logs in .
/// Nesting mode: list
/// </summary>
public class AzurermElasticCloudElasticsearchDataSourceLogsBlock : TerraformBlock
{
    /// <summary>
    /// The filtering_tag attribute.
    /// </summary>
    public List<TerraformProperty<object>>? FilteringTag
    {
        get => GetProperty<List<TerraformProperty<object>>>("filtering_tag");
        set => WithProperty("filtering_tag", value);
    }

    /// <summary>
    /// The send_activity_logs attribute.
    /// </summary>
    public TerraformProperty<bool>? SendActivityLogs
    {
        get => GetProperty<TerraformProperty<bool>>("send_activity_logs");
        set => WithProperty("send_activity_logs", value);
    }

    /// <summary>
    /// The send_azuread_logs attribute.
    /// </summary>
    public TerraformProperty<bool>? SendAzureadLogs
    {
        get => GetProperty<TerraformProperty<bool>>("send_azuread_logs");
        set => WithProperty("send_azuread_logs", value);
    }

    /// <summary>
    /// The send_subscription_logs attribute.
    /// </summary>
    public TerraformProperty<bool>? SendSubscriptionLogs
    {
        get => GetProperty<TerraformProperty<bool>>("send_subscription_logs");
        set => WithProperty("send_subscription_logs", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermElasticCloudElasticsearchDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_elastic_cloud_elasticsearch.
/// </summary>
public class AzurermElasticCloudElasticsearchDataSource : TerraformDataSource
{
    public AzurermElasticCloudElasticsearchDataSource(string name) : base("azurerm_elastic_cloud_elasticsearch", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("elastic_cloud_deployment_id");
        this.WithOutput("elastic_cloud_email_address");
        this.WithOutput("elastic_cloud_sso_default_url");
        this.WithOutput("elastic_cloud_user_id");
        this.WithOutput("elasticsearch_service_url");
        this.WithOutput("kibana_service_url");
        this.WithOutput("kibana_sso_uri");
        this.WithOutput("location");
        this.WithOutput("monitoring_enabled");
        this.WithOutput("sku_name");
        this.WithOutput("tags");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for logs.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermElasticCloudElasticsearchDataSourceLogsBlock>? Logs
    {
        get => GetProperty<List<AzurermElasticCloudElasticsearchDataSourceLogsBlock>>("logs");
        set => this.WithProperty("logs", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermElasticCloudElasticsearchDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermElasticCloudElasticsearchDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The elastic_cloud_deployment_id attribute.
    /// </summary>
    public TerraformExpression ElasticCloudDeploymentId => this["elastic_cloud_deployment_id"];

    /// <summary>
    /// The elastic_cloud_email_address attribute.
    /// </summary>
    public TerraformExpression ElasticCloudEmailAddress => this["elastic_cloud_email_address"];

    /// <summary>
    /// The elastic_cloud_sso_default_url attribute.
    /// </summary>
    public TerraformExpression ElasticCloudSsoDefaultUrl => this["elastic_cloud_sso_default_url"];

    /// <summary>
    /// The elastic_cloud_user_id attribute.
    /// </summary>
    public TerraformExpression ElasticCloudUserId => this["elastic_cloud_user_id"];

    /// <summary>
    /// The elasticsearch_service_url attribute.
    /// </summary>
    public TerraformExpression ElasticsearchServiceUrl => this["elasticsearch_service_url"];

    /// <summary>
    /// The kibana_service_url attribute.
    /// </summary>
    public TerraformExpression KibanaServiceUrl => this["kibana_service_url"];

    /// <summary>
    /// The kibana_sso_uri attribute.
    /// </summary>
    public TerraformExpression KibanaSsoUri => this["kibana_sso_uri"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The monitoring_enabled attribute.
    /// </summary>
    public TerraformExpression MonitoringEnabled => this["monitoring_enabled"];

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformExpression SkuName => this["sku_name"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
