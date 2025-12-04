using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermStreamAnalyticsOutputFunction.
/// Nesting mode: single
/// </summary>
public class AzurermStreamAnalyticsOutputFunctionTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_stream_analytics_output_function Terraform resource.
/// Manages a azurerm_stream_analytics_output_function resource.
/// </summary>
public partial class AzurermStreamAnalyticsOutputFunction(string name) : TerraformResource("azurerm_stream_analytics_output_function", name)
{
    /// <summary>
    /// The api_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiKey is required")]
    public required TerraformValue<string> ApiKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("api_key");
        set => SetArgument("api_key", value);
    }

    /// <summary>
    /// The batch_max_count attribute.
    /// </summary>
    public TerraformValue<double>? BatchMaxCount
    {
        get => GetArgument<TerraformValue<double>>("batch_max_count");
        set => SetArgument("batch_max_count", value);
    }

    /// <summary>
    /// The batch_max_in_bytes attribute.
    /// </summary>
    public TerraformValue<double>? BatchMaxInBytes
    {
        get => GetArgument<TerraformValue<double>>("batch_max_in_bytes");
        set => SetArgument("batch_max_in_bytes", value);
    }

    /// <summary>
    /// The function_app attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionApp is required")]
    public required TerraformValue<string> FunctionApp
    {
        get => GetRequiredArgument<TerraformValue<string>>("function_app");
        set => SetArgument("function_app", value);
    }

    /// <summary>
    /// The function_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionName is required")]
    public required TerraformValue<string> FunctionName
    {
        get => GetRequiredArgument<TerraformValue<string>>("function_name");
        set => SetArgument("function_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The stream_analytics_job_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamAnalyticsJobName is required")]
    public required TerraformValue<string> StreamAnalyticsJobName
    {
        get => GetRequiredArgument<TerraformValue<string>>("stream_analytics_job_name");
        set => SetArgument("stream_analytics_job_name", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStreamAnalyticsOutputFunctionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStreamAnalyticsOutputFunctionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
