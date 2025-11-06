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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The importance attribute.
    /// </summary>
    public string? Importance
    {
        get => GetProperty<TerraformLiteralProperty<string>>("importance")?.Value;
        set => this.WithProperty("importance", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The max_resource_percent attribute.
    /// </summary>
    public double? MaxResourcePercent
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_resource_percent")?.Value;
        set => this.WithProperty("max_resource_percent", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The max_resource_percent_per_request attribute.
    /// </summary>
    public double? MaxResourcePercentPerRequest
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_resource_percent_per_request")?.Value;
        set => this.WithProperty("max_resource_percent_per_request", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The min_resource_percent attribute.
    /// </summary>
    public double? MinResourcePercent
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_resource_percent")?.Value;
        set => this.WithProperty("min_resource_percent", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The min_resource_percent_per_request attribute.
    /// </summary>
    public double? MinResourcePercentPerRequest
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_resource_percent_per_request")?.Value;
        set => this.WithProperty("min_resource_percent_per_request", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The query_execution_timeout_in_seconds attribute.
    /// </summary>
    public double? QueryExecutionTimeoutInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("query_execution_timeout_in_seconds")?.Value;
        set => this.WithProperty("query_execution_timeout_in_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The sql_pool_id attribute.
    /// </summary>
    public string? SqlPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sql_pool_id")?.Value;
        set => this.WithProperty("sql_pool_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
