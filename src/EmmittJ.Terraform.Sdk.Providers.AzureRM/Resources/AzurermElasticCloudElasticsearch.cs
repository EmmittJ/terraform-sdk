using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_elastic_cloud_elasticsearch resource.
/// </summary>
public class AzurermElasticCloudElasticsearch : TerraformResource
{
    public AzurermElasticCloudElasticsearch(string name) : base("azurerm_elastic_cloud_elasticsearch", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("elastic_cloud_deployment_id");
        this.DeclareOutput("elastic_cloud_sso_default_url");
        this.DeclareOutput("elastic_cloud_user_id");
        this.DeclareOutput("elasticsearch_service_url");
        this.DeclareOutput("kibana_service_url");
        this.DeclareOutput("kibana_sso_uri");
    }

    /// <summary>
    /// The elastic_cloud_email_address attribute.
    /// </summary>
    public TerraformProperty<string>? ElasticCloudEmailAddress
    {
        get => GetProperty<TerraformProperty<string>>("elastic_cloud_email_address");
        set => this.WithProperty("elastic_cloud_email_address", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The monitoring_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? MonitoringEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("monitoring_enabled");
        set => this.WithProperty("monitoring_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformProperty<string>? SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
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
