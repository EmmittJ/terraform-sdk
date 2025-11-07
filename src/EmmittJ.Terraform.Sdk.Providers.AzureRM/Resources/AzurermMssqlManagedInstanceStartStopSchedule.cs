using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_mssql_managed_instance_start_stop_schedule resource.
/// </summary>
public class AzurermMssqlManagedInstanceStartStopSchedule : TerraformResource
{
    public AzurermMssqlManagedInstanceStartStopSchedule(string name) : base("azurerm_mssql_managed_instance_start_stop_schedule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("next_execution_time");
        this.DeclareOutput("next_run_action");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The managed_instance_id attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedInstanceId
    {
        get => GetProperty<TerraformProperty<string>>("managed_instance_id");
        set => this.WithProperty("managed_instance_id", value);
    }

    /// <summary>
    /// The timezone_id attribute.
    /// </summary>
    public TerraformProperty<string>? TimezoneId
    {
        get => GetProperty<TerraformProperty<string>>("timezone_id");
        set => this.WithProperty("timezone_id", value);
    }

    /// <summary>
    /// The next_execution_time attribute.
    /// </summary>
    public TerraformExpression NextExecutionTime => this["next_execution_time"];

    /// <summary>
    /// The next_run_action attribute.
    /// </summary>
    public TerraformExpression NextRunAction => this["next_run_action"];

}
