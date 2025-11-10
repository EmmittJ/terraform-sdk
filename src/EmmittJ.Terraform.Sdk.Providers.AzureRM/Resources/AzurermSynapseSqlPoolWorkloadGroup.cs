using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSynapseSqlPoolWorkloadGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxResourcePercent is required")]
    public required TerraformProperty<double> MaxResourcePercent
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinResourcePercent is required")]
    public required TerraformProperty<double> MinResourcePercent
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlPoolId is required")]
    public required TerraformProperty<string> SqlPoolId
    {
        get => GetProperty<TerraformProperty<string>>("sql_pool_id");
        set => this.WithProperty("sql_pool_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSynapseSqlPoolWorkloadGroupTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSynapseSqlPoolWorkloadGroupTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
