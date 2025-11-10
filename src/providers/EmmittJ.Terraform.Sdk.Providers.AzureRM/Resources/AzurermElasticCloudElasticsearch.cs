using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for logs in .
/// Nesting mode: list
/// </summary>
public class AzurermElasticCloudElasticsearchLogsBlock : TerraformBlock
{
    /// <summary>
    /// The send_activity_logs attribute.
    /// </summary>
    public TerraformProperty<bool>? SendActivityLogs
    {
        set => SetProperty("send_activity_logs", value);
    }

    /// <summary>
    /// The send_azuread_logs attribute.
    /// </summary>
    public TerraformProperty<bool>? SendAzureadLogs
    {
        set => SetProperty("send_azuread_logs", value);
    }

    /// <summary>
    /// The send_subscription_logs attribute.
    /// </summary>
    public TerraformProperty<bool>? SendSubscriptionLogs
    {
        set => SetProperty("send_subscription_logs", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermElasticCloudElasticsearchTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("elastic_cloud_deployment_id");
        SetOutput("elastic_cloud_sso_default_url");
        SetOutput("elastic_cloud_user_id");
        SetOutput("elasticsearch_service_url");
        SetOutput("kibana_service_url");
        SetOutput("kibana_sso_uri");
        SetOutput("elastic_cloud_email_address");
        SetOutput("id");
        SetOutput("location");
        SetOutput("monitoring_enabled");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("sku_name");
        SetOutput("tags");
    }

    /// <summary>
    /// The elastic_cloud_email_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ElasticCloudEmailAddress is required")]
    public required TerraformProperty<string> ElasticCloudEmailAddress
    {
        get => GetRequiredOutput<TerraformProperty<string>>("elastic_cloud_email_address");
        set => SetProperty("elastic_cloud_email_address", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The monitoring_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> MonitoringEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("monitoring_enabled");
        set => SetProperty("monitoring_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformProperty<string> SkuName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku_name");
        set => SetProperty("sku_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for logs.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logs block(s) allowed")]
    public List<AzurermElasticCloudElasticsearchLogsBlock>? Logs
    {
        set => SetProperty("logs", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermElasticCloudElasticsearchTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The elastic_cloud_deployment_id attribute.
    /// </summary>
    public TerraformExpression ElasticCloudDeploymentId => this["elastic_cloud_deployment_id"];

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

}
