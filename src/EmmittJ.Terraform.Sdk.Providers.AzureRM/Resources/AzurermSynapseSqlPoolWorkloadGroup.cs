using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_synapse_sql_pool_workload_group resource.
/// </summary>
public class AzurermSynapseSqlPoolWorkloadGroup : TerraformResource
{
    public AzurermSynapseSqlPoolWorkloadGroup(string name) : base("azurerm_synapse_sql_pool_workload_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The importance attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Importance
    {
        get => GetProperty<TerraformLiteralProperty<string>>("importance");
        set => this.WithProperty("importance", value);
    }

    /// <summary>
    /// The max_resource_percent attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxResourcePercent
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_resource_percent");
        set => this.WithProperty("max_resource_percent", value);
    }

    /// <summary>
    /// The max_resource_percent_per_request attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxResourcePercentPerRequest
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_resource_percent_per_request");
        set => this.WithProperty("max_resource_percent_per_request", value);
    }

    /// <summary>
    /// The min_resource_percent attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MinResourcePercent
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_resource_percent");
        set => this.WithProperty("min_resource_percent", value);
    }

    /// <summary>
    /// The min_resource_percent_per_request attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MinResourcePercentPerRequest
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_resource_percent_per_request");
        set => this.WithProperty("min_resource_percent_per_request", value);
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
    /// The query_execution_timeout_in_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? QueryExecutionTimeoutInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("query_execution_timeout_in_seconds");
        set => this.WithProperty("query_execution_timeout_in_seconds", value);
    }

    /// <summary>
    /// The sql_pool_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SqlPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sql_pool_id");
        set => this.WithProperty("sql_pool_id", value);
    }

}
