using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_mssql_job_step resource.
/// </summary>
public class AzurermMssqlJobStep : TerraformResource
{
    public AzurermMssqlJobStep(string name) : base("azurerm_mssql_job_step", name)
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
    /// The initial_retry_interval_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? InitialRetryIntervalSeconds
    {
        get => GetProperty<TerraformProperty<double>>("initial_retry_interval_seconds");
        set => this.WithProperty("initial_retry_interval_seconds", value);
    }

    /// <summary>
    /// The job_credential_id attribute.
    /// </summary>
    public TerraformProperty<string>? JobCredentialId
    {
        get => GetProperty<TerraformProperty<string>>("job_credential_id");
        set => this.WithProperty("job_credential_id", value);
    }

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    public TerraformProperty<string>? JobId
    {
        get => GetProperty<TerraformProperty<string>>("job_id");
        set => this.WithProperty("job_id", value);
    }

    /// <summary>
    /// The job_step_index attribute.
    /// </summary>
    public TerraformProperty<double>? JobStepIndex
    {
        get => GetProperty<TerraformProperty<double>>("job_step_index");
        set => this.WithProperty("job_step_index", value);
    }

    /// <summary>
    /// The job_target_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? JobTargetGroupId
    {
        get => GetProperty<TerraformProperty<string>>("job_target_group_id");
        set => this.WithProperty("job_target_group_id", value);
    }

    /// <summary>
    /// The maximum_retry_interval_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumRetryIntervalSeconds
    {
        get => GetProperty<TerraformProperty<double>>("maximum_retry_interval_seconds");
        set => this.WithProperty("maximum_retry_interval_seconds", value);
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
    /// The retry_attempts attribute.
    /// </summary>
    public TerraformProperty<double>? RetryAttempts
    {
        get => GetProperty<TerraformProperty<double>>("retry_attempts");
        set => this.WithProperty("retry_attempts", value);
    }

    /// <summary>
    /// The retry_interval_backoff_multiplier attribute.
    /// </summary>
    public TerraformProperty<double>? RetryIntervalBackoffMultiplier
    {
        get => GetProperty<TerraformProperty<double>>("retry_interval_backoff_multiplier");
        set => this.WithProperty("retry_interval_backoff_multiplier", value);
    }

    /// <summary>
    /// The sql_script attribute.
    /// </summary>
    public TerraformProperty<string>? SqlScript
    {
        get => GetProperty<TerraformProperty<string>>("sql_script");
        set => this.WithProperty("sql_script", value);
    }

    /// <summary>
    /// The timeout_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? TimeoutSeconds
    {
        get => GetProperty<TerraformProperty<double>>("timeout_seconds");
        set => this.WithProperty("timeout_seconds", value);
    }

}
