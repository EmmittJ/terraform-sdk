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
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The managed_instance_id attribute.
    /// </summary>
    public string? ManagedInstanceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("managed_instance_id")?.Value;
        set => this.WithProperty("managed_instance_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The timezone_id attribute.
    /// </summary>
    public string? TimezoneId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("timezone_id")?.Value;
        set => this.WithProperty("timezone_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
