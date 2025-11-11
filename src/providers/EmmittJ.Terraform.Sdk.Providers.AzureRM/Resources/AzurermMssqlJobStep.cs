using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for output_target in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMssqlJobStepOutputTargetBlock : TerraformBlockBase
{
    /// <summary>
    /// The job_credential_id attribute.
    /// </summary>
    [TerraformProperty("job_credential_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? JobCredentialId { get; set; }

    /// <summary>
    /// The mssql_database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MssqlDatabaseId is required")]
    [TerraformProperty("mssql_database_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MssqlDatabaseId { get; set; }

    /// <summary>
    /// The schema_name attribute.
    /// </summary>
    [TerraformProperty("schema_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SchemaName { get; set; }

    /// <summary>
    /// The table_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableName is required")]
    [TerraformProperty("table_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TableName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMssqlJobStepTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_mssql_job_step resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermMssqlJobStep : TerraformResource
{
    public AzurermMssqlJobStep(string name) : base("azurerm_mssql_job_step", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The initial_retry_interval_seconds attribute.
    /// </summary>
    [TerraformProperty("initial_retry_interval_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? InitialRetryIntervalSeconds { get; set; }

    /// <summary>
    /// The job_credential_id attribute.
    /// </summary>
    [TerraformProperty("job_credential_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? JobCredentialId { get; set; }

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobId is required")]
    [TerraformProperty("job_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> JobId { get; set; }

    /// <summary>
    /// The job_step_index attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobStepIndex is required")]
    [TerraformProperty("job_step_index")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> JobStepIndex { get; set; }

    /// <summary>
    /// The job_target_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JobTargetGroupId is required")]
    [TerraformProperty("job_target_group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> JobTargetGroupId { get; set; }

    /// <summary>
    /// The maximum_retry_interval_seconds attribute.
    /// </summary>
    [TerraformProperty("maximum_retry_interval_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaximumRetryIntervalSeconds { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The retry_attempts attribute.
    /// </summary>
    [TerraformProperty("retry_attempts")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RetryAttempts { get; set; }

    /// <summary>
    /// The retry_interval_backoff_multiplier attribute.
    /// </summary>
    [TerraformProperty("retry_interval_backoff_multiplier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RetryIntervalBackoffMultiplier { get; set; }

    /// <summary>
    /// The sql_script attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlScript is required")]
    [TerraformProperty("sql_script")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SqlScript { get; set; }

    /// <summary>
    /// The timeout_seconds attribute.
    /// </summary>
    [TerraformProperty("timeout_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TimeoutSeconds { get; set; }

    /// <summary>
    /// Block for output_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputTarget block(s) allowed")]
    [TerraformProperty("output_target")]
    public partial TerraformList<TerraformBlock<AzurermMssqlJobStepOutputTargetBlock>>? OutputTarget { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermMssqlJobStepTimeoutsBlock>? Timeouts { get; set; }

}
