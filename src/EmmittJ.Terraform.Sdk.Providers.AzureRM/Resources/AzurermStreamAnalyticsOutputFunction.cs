using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStreamAnalyticsOutputFunctionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_stream_analytics_output_function resource.
/// </summary>
public class AzurermStreamAnalyticsOutputFunction : TerraformResource
{
    public AzurermStreamAnalyticsOutputFunction(string name) : base("azurerm_stream_analytics_output_function", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiKey is required")]
    public required TerraformProperty<string> ApiKey
    {
        get => GetProperty<TerraformProperty<string>>("api_key");
        set => this.WithProperty("api_key", value);
    }

    /// <summary>
    /// The batch_max_count attribute.
    /// </summary>
    public TerraformProperty<double>? BatchMaxCount
    {
        get => GetProperty<TerraformProperty<double>>("batch_max_count");
        set => this.WithProperty("batch_max_count", value);
    }

    /// <summary>
    /// The batch_max_in_bytes attribute.
    /// </summary>
    public TerraformProperty<double>? BatchMaxInBytes
    {
        get => GetProperty<TerraformProperty<double>>("batch_max_in_bytes");
        set => this.WithProperty("batch_max_in_bytes", value);
    }

    /// <summary>
    /// The function_app attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionApp is required")]
    public required TerraformProperty<string> FunctionApp
    {
        get => GetProperty<TerraformProperty<string>>("function_app");
        set => this.WithProperty("function_app", value);
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    public required TerraformProperty<string> FunctionName
    {
        get => GetProperty<TerraformProperty<string>>("function_name");
        set => this.WithProperty("function_name", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The stream_analytics_job_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamAnalyticsJobName is required")]
    public required TerraformProperty<string> StreamAnalyticsJobName
    {
        get => GetProperty<TerraformProperty<string>>("stream_analytics_job_name");
        set => this.WithProperty("stream_analytics_job_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStreamAnalyticsOutputFunctionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermStreamAnalyticsOutputFunctionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
