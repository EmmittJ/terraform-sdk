using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBatchJobTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_batch_job resource.
/// </summary>
public class AzurermBatchJob : TerraformResource
{
    public AzurermBatchJob(string name) : base("azurerm_batch_job", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("batch_pool_id");
        SetOutput("common_environment_properties");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("name");
        SetOutput("priority");
        SetOutput("task_retry_maximum");
    }

    /// <summary>
    /// The batch_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BatchPoolId is required")]
    public required TerraformProperty<string> BatchPoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("batch_pool_id");
        set => SetProperty("batch_pool_id", value);
    }

    /// <summary>
    /// The common_environment_properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> CommonEnvironmentProperties
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("common_environment_properties");
        set => SetProperty("common_environment_properties", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<double> Priority
    {
        get => GetRequiredOutput<TerraformProperty<double>>("priority");
        set => SetProperty("priority", value);
    }

    /// <summary>
    /// The task_retry_maximum attribute.
    /// </summary>
    public TerraformProperty<double> TaskRetryMaximum
    {
        get => GetRequiredOutput<TerraformProperty<double>>("task_retry_maximum");
        set => SetProperty("task_retry_maximum", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermBatchJobTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
