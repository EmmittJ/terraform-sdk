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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The importance attribute.
    /// </summary>
    public TerraformProperty<string>? Importance
    {
        get => GetProperty<TerraformProperty<string>>("importance");
        set => this.WithProperty("importance", value);
    }

    /// <summary>
    /// The max_resource_percent attribute.
    /// </summary>
    public TerraformProperty<double>? MaxResourcePercent
    {
        get => GetProperty<TerraformProperty<double>>("max_resource_percent");
        set => this.WithProperty("max_resource_percent", value);
    }

    /// <summary>
    /// The max_resource_percent_per_request attribute.
    /// </summary>
    public TerraformProperty<double>? MaxResourcePercentPerRequest
    {
        get => GetProperty<TerraformProperty<double>>("max_resource_percent_per_request");
        set => this.WithProperty("max_resource_percent_per_request", value);
    }

    /// <summary>
    /// The min_resource_percent attribute.
    /// </summary>
    public TerraformProperty<double>? MinResourcePercent
    {
        get => GetProperty<TerraformProperty<double>>("min_resource_percent");
        set => this.WithProperty("min_resource_percent", value);
    }

    /// <summary>
    /// The min_resource_percent_per_request attribute.
    /// </summary>
    public TerraformProperty<double>? MinResourcePercentPerRequest
    {
        get => GetProperty<TerraformProperty<double>>("min_resource_percent_per_request");
        set => this.WithProperty("min_resource_percent_per_request", value);
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
    /// The query_execution_timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? QueryExecutionTimeoutInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("query_execution_timeout_in_seconds");
        set => this.WithProperty("query_execution_timeout_in_seconds", value);
    }

    /// <summary>
    /// The sql_pool_id attribute.
    /// </summary>
    public TerraformProperty<string>? SqlPoolId
    {
        get => GetProperty<TerraformProperty<string>>("sql_pool_id");
        set => this.WithProperty("sql_pool_id", value);
    }

}
