using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    }

    /// <summary>
    /// The batch_pool_id attribute.
    /// </summary>
    public TerraformProperty<string>? BatchPoolId
    {
        get => GetProperty<TerraformProperty<string>>("batch_pool_id");
        set => this.WithProperty("batch_pool_id", value);
    }

    /// <summary>
    /// The common_environment_properties attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? CommonEnvironmentProperties
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("common_environment_properties");
        set => this.WithProperty("common_environment_properties", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformProperty<double>? Priority
    {
        get => GetProperty<TerraformProperty<double>>("priority");
        set => this.WithProperty("priority", value);
    }

    /// <summary>
    /// The task_retry_maximum attribute.
    /// </summary>
    public TerraformProperty<double>? TaskRetryMaximum
    {
        get => GetProperty<TerraformProperty<double>>("task_retry_maximum");
        set => this.WithProperty("task_retry_maximum", value);
    }

}
