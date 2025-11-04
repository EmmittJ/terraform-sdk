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
    public string? BatchPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("batch_pool_id")?.Value;
        set => this.WithProperty("batch_pool_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The common_environment_properties attribute.
    /// </summary>
    public Dictionary<string, string>? CommonEnvironmentProperties
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("common_environment_properties")?.Value;
        set => this.WithProperty("common_environment_properties", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public double? Priority
    {
        get => GetProperty<TerraformLiteralProperty<double>>("priority")?.Value;
        set => this.WithProperty("priority", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The task_retry_maximum attribute.
    /// </summary>
    public double? TaskRetryMaximum
    {
        get => GetProperty<TerraformLiteralProperty<double>>("task_retry_maximum")?.Value;
        set => this.WithProperty("task_retry_maximum", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

}
