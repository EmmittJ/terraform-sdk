using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for output_target in AzurermMssqlJobStep.
/// Nesting mode: list
/// </summary>
public class AzurermMssqlJobStepOutputTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output_target";

    /// <summary>
    /// The job_credential_id attribute.
    /// </summary>
    public TerraformValue<string>? JobCredentialId
    {
        get => GetArgument<TerraformValue<string>>("job_credential_id");
        set => SetArgument("job_credential_id", value);
    }

    /// <summary>
    /// The mssql_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MssqlDatabaseId is required")]
    public required TerraformValue<string> MssqlDatabaseId
    {
        get => GetRequiredArgument<TerraformValue<string>>("mssql_database_id");
        set => SetArgument("mssql_database_id", value);
    }

    /// <summary>
    /// The schema_name attribute.
    /// </summary>
    public TerraformValue<string>? SchemaName
    {
        get => GetArgument<TerraformValue<string>>("schema_name");
        set => SetArgument("schema_name", value);
    }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    public required TerraformValue<string> TableName
    {
        get => GetRequiredArgument<TerraformValue<string>>("table_name");
        set => SetArgument("table_name", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermMssqlJobStep.
/// Nesting mode: single
/// </summary>
public class AzurermMssqlJobStepTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_mssql_job_step Terraform resource.
/// Manages a azurerm_mssql_job_step resource.
/// </summary>
public partial class AzurermMssqlJobStep(string name) : TerraformResource("azurerm_mssql_job_step", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The initial_retry_interval_seconds attribute.
    /// </summary>
    public TerraformValue<double>? InitialRetryIntervalSeconds
    {
        get => GetArgument<TerraformValue<double>>("initial_retry_interval_seconds");
        set => SetArgument("initial_retry_interval_seconds", value);
    }

    /// <summary>
    /// The job_credential_id attribute.
    /// </summary>
    public TerraformValue<string>? JobCredentialId
    {
        get => GetArgument<TerraformValue<string>>("job_credential_id");
        set => SetArgument("job_credential_id", value);
    }

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobId is required")]
    public required TerraformValue<string> JobId
    {
        get => GetRequiredArgument<TerraformValue<string>>("job_id");
        set => SetArgument("job_id", value);
    }

    /// <summary>
    /// The job_step_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobStepIndex is required")]
    public required TerraformValue<double> JobStepIndex
    {
        get => GetRequiredArgument<TerraformValue<double>>("job_step_index");
        set => SetArgument("job_step_index", value);
    }

    /// <summary>
    /// The job_target_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobTargetGroupId is required")]
    public required TerraformValue<string> JobTargetGroupId
    {
        get => GetRequiredArgument<TerraformValue<string>>("job_target_group_id");
        set => SetArgument("job_target_group_id", value);
    }

    /// <summary>
    /// The maximum_retry_interval_seconds attribute.
    /// </summary>
    public TerraformValue<double>? MaximumRetryIntervalSeconds
    {
        get => GetArgument<TerraformValue<double>>("maximum_retry_interval_seconds");
        set => SetArgument("maximum_retry_interval_seconds", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The retry_attempts attribute.
    /// </summary>
    public TerraformValue<double>? RetryAttempts
    {
        get => GetArgument<TerraformValue<double>>("retry_attempts");
        set => SetArgument("retry_attempts", value);
    }

    /// <summary>
    /// The retry_interval_backoff_multiplier attribute.
    /// </summary>
    public TerraformValue<double>? RetryIntervalBackoffMultiplier
    {
        get => GetArgument<TerraformValue<double>>("retry_interval_backoff_multiplier");
        set => SetArgument("retry_interval_backoff_multiplier", value);
    }

    /// <summary>
    /// The sql_script attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlScript is required")]
    public required TerraformValue<string> SqlScript
    {
        get => GetRequiredArgument<TerraformValue<string>>("sql_script");
        set => SetArgument("sql_script", value);
    }

    /// <summary>
    /// The timeout_seconds attribute.
    /// </summary>
    public TerraformValue<double>? TimeoutSeconds
    {
        get => GetArgument<TerraformValue<double>>("timeout_seconds");
        set => SetArgument("timeout_seconds", value);
    }

    /// <summary>
    /// OutputTarget block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputTarget block(s) allowed")]
    public TerraformList<AzurermMssqlJobStepOutputTargetBlock>? OutputTarget
    {
        get => GetArgument<TerraformList<AzurermMssqlJobStepOutputTargetBlock>>("output_target");
        set => SetArgument("output_target", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMssqlJobStepTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMssqlJobStepTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
