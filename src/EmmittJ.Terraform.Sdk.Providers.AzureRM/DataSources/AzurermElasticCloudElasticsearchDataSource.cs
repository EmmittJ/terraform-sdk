using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("elastic_cloud_deployment_id");
        this.DeclareOutput("elastic_cloud_email_address");
        this.DeclareOutput("elastic_cloud_sso_default_url");
        this.DeclareOutput("elastic_cloud_user_id");
        this.DeclareOutput("elasticsearch_service_url");
        this.DeclareOutput("kibana_service_url");
        this.DeclareOutput("kibana_sso_uri");
        this.DeclareOutput("location");
        this.DeclareOutput("monitoring_enabled");
        this.DeclareOutput("sku_name");
        this.DeclareOutput("tags");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
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
