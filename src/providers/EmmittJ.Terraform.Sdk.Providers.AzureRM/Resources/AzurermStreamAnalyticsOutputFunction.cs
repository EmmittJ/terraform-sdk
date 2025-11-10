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
        SetOutput("api_key");
        SetOutput("batch_max_count");
        SetOutput("batch_max_in_bytes");
        SetOutput("function_app");
        SetOutput("function_name");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("stream_analytics_job_name");
    }

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiKey is required")]
    public required TerraformProperty<string> ApiKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_key");
        set => SetProperty("api_key", value);
    }

    /// <summary>
    /// The batch_max_count attribute.
    /// </summary>
    public TerraformProperty<double> BatchMaxCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("batch_max_count");
        set => SetProperty("batch_max_count", value);
    }

    /// <summary>
    /// The batch_max_in_bytes attribute.
    /// </summary>
    public TerraformProperty<double> BatchMaxInBytes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("batch_max_in_bytes");
        set => SetProperty("batch_max_in_bytes", value);
    }

    /// <summary>
    /// The function_app attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionApp is required")]
    public required TerraformProperty<string> FunctionApp
    {
        get => GetRequiredOutput<TerraformProperty<string>>("function_app");
        set => SetProperty("function_app", value);
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    public required TerraformProperty<string> FunctionName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("function_name");
        set => SetProperty("function_name", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The stream_analytics_job_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamAnalyticsJobName is required")]
    public required TerraformProperty<string> StreamAnalyticsJobName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("stream_analytics_job_name");
        set => SetProperty("stream_analytics_job_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStreamAnalyticsOutputFunctionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
