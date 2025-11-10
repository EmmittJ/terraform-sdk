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
        SetOutput("id");
        SetOutput("importance");
        SetOutput("max_resource_percent");
        SetOutput("max_resource_percent_per_request");
        SetOutput("min_resource_percent");
        SetOutput("min_resource_percent_per_request");
        SetOutput("name");
        SetOutput("query_execution_timeout_in_seconds");
        SetOutput("sql_pool_id");
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
    /// The importance attribute.
    /// </summary>
    public TerraformProperty<string> Importance
    {
        get => GetRequiredOutput<TerraformProperty<string>>("importance");
        set => SetProperty("importance", value);
    }

    /// <summary>
    /// The max_resource_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxResourcePercent is required")]
    public required TerraformProperty<double> MaxResourcePercent
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_resource_percent");
        set => SetProperty("max_resource_percent", value);
    }

    /// <summary>
    /// The max_resource_percent_per_request attribute.
    /// </summary>
    public TerraformProperty<double> MaxResourcePercentPerRequest
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_resource_percent_per_request");
        set => SetProperty("max_resource_percent_per_request", value);
    }

    /// <summary>
    /// The min_resource_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinResourcePercent is required")]
    public required TerraformProperty<double> MinResourcePercent
    {
        get => GetRequiredOutput<TerraformProperty<double>>("min_resource_percent");
        set => SetProperty("min_resource_percent", value);
    }

    /// <summary>
    /// The min_resource_percent_per_request attribute.
    /// </summary>
    public TerraformProperty<double> MinResourcePercentPerRequest
    {
        get => GetRequiredOutput<TerraformProperty<double>>("min_resource_percent_per_request");
        set => SetProperty("min_resource_percent_per_request", value);
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
    /// The query_execution_timeout_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double> QueryExecutionTimeoutInSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("query_execution_timeout_in_seconds");
        set => SetProperty("query_execution_timeout_in_seconds", value);
    }

    /// <summary>
    /// The sql_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlPoolId is required")]
    public required TerraformProperty<string> SqlPoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sql_pool_id");
        set => SetProperty("sql_pool_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSynapseSqlPoolWorkloadGroupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
