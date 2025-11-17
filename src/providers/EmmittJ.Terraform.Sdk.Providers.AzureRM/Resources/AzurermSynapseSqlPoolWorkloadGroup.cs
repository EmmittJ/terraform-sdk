using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSynapseSqlPoolWorkloadGroup.
/// Nesting mode: single
/// </summary>
public class AzurermSynapseSqlPoolWorkloadGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_synapse_sql_pool_workload_group Terraform resource.
/// Manages a azurerm_synapse_sql_pool_workload_group resource.
/// </summary>
public partial class AzurermSynapseSqlPoolWorkloadGroup(string name) : TerraformResource("azurerm_synapse_sql_pool_workload_group", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The importance attribute.
    /// </summary>
    public TerraformValue<string>? Importance
    {
        get => new TerraformReference<string>(this, "importance");
        set => SetArgument("importance", value);
    }

    /// <summary>
    /// The max_resource_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxResourcePercent is required")]
    public required TerraformValue<double> MaxResourcePercent
    {
        get => new TerraformReference<double>(this, "max_resource_percent");
        set => SetArgument("max_resource_percent", value);
    }

    /// <summary>
    /// The max_resource_percent_per_request attribute.
    /// </summary>
    public TerraformValue<double>? MaxResourcePercentPerRequest
    {
        get => new TerraformReference<double>(this, "max_resource_percent_per_request");
        set => SetArgument("max_resource_percent_per_request", value);
    }

    /// <summary>
    /// The min_resource_percent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinResourcePercent is required")]
    public required TerraformValue<double> MinResourcePercent
    {
        get => new TerraformReference<double>(this, "min_resource_percent");
        set => SetArgument("min_resource_percent", value);
    }

    /// <summary>
    /// The min_resource_percent_per_request attribute.
    /// </summary>
    public TerraformValue<double>? MinResourcePercentPerRequest
    {
        get => new TerraformReference<double>(this, "min_resource_percent_per_request");
        set => SetArgument("min_resource_percent_per_request", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The query_execution_timeout_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? QueryExecutionTimeoutInSeconds
    {
        get => new TerraformReference<double>(this, "query_execution_timeout_in_seconds");
        set => SetArgument("query_execution_timeout_in_seconds", value);
    }

    /// <summary>
    /// The sql_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlPoolId is required")]
    public required TerraformValue<string> SqlPoolId
    {
        get => new TerraformReference<string>(this, "sql_pool_id");
        set => SetArgument("sql_pool_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSynapseSqlPoolWorkloadGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSynapseSqlPoolWorkloadGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
