using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_app_service_plan.
/// </summary>
[Obsolete("This data source is deprecated.")]
public class AzurermAppServicePlanDataSource : TerraformDataSource
{
    public AzurermAppServicePlanDataSource(string name) : base("azurerm_app_service_plan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("app_service_environment_id");
        this.DeclareOutput("is_xenon");
        this.DeclareOutput("kind");
        this.DeclareOutput("location");
        this.DeclareOutput("maximum_elastic_worker_count");
        this.DeclareOutput("maximum_number_of_workers");
        this.DeclareOutput("per_site_scaling");
        this.DeclareOutput("reserved");
        this.DeclareOutput("sku");
        this.DeclareOutput("tags");
        this.DeclareOutput("zone_redundant");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The app_service_environment_id attribute.
    /// </summary>
    public TerraformExpression AppServiceEnvironmentId => this["app_service_environment_id"];

    /// <summary>
    /// The is_xenon attribute.
    /// </summary>
    public TerraformExpression IsXenon => this["is_xenon"];

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformExpression Kind => this["kind"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The maximum_elastic_worker_count attribute.
    /// </summary>
    public TerraformExpression MaximumElasticWorkerCount => this["maximum_elastic_worker_count"];

    /// <summary>
    /// The maximum_number_of_workers attribute.
    /// </summary>
    public TerraformExpression MaximumNumberOfWorkers => this["maximum_number_of_workers"];

    /// <summary>
    /// The per_site_scaling attribute.
    /// </summary>
    public TerraformExpression PerSiteScaling => this["per_site_scaling"];

    /// <summary>
    /// The reserved attribute.
    /// </summary>
    public TerraformExpression Reserved => this["reserved"];

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformExpression Sku => this["sku"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformExpression ZoneRedundant => this["zone_redundant"];

}
