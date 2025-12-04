using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for input in AzurermStreamAnalyticsFunctionJavascriptUdf.
/// Nesting mode: list
/// </summary>
public class AzurermStreamAnalyticsFunctionJavascriptUdfInputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "input";

    /// <summary>
    /// The configuration_parameter attribute.
    /// </summary>
    public TerraformValue<bool>? ConfigurationParameter
    {
        get => GetArgument<TerraformValue<bool>>("configuration_parameter");
        set => SetArgument("configuration_parameter", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for output in AzurermStreamAnalyticsFunctionJavascriptUdf.
/// Nesting mode: list
/// </summary>
public class AzurermStreamAnalyticsFunctionJavascriptUdfOutputBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermStreamAnalyticsFunctionJavascriptUdf.
/// Nesting mode: single
/// </summary>
public class AzurermStreamAnalyticsFunctionJavascriptUdfTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_stream_analytics_function_javascript_udf Terraform resource.
/// Manages a azurerm_stream_analytics_function_javascript_udf resource.
/// </summary>
public partial class AzurermStreamAnalyticsFunctionJavascriptUdf(string name) : TerraformResource("azurerm_stream_analytics_function_javascript_udf", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The script attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Script is required")]
    public required TerraformValue<string> Script
    {
        get => GetArgument<TerraformValue<string>>("script");
        set => SetArgument("script", value);
    }

    /// <summary>
    /// The stream_analytics_job_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamAnalyticsJobName is required")]
    public required TerraformValue<string> StreamAnalyticsJobName
    {
        get => GetArgument<TerraformValue<string>>("stream_analytics_job_name");
        set => SetArgument("stream_analytics_job_name", value);
    }

    /// <summary>
    /// Input block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Input is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Input block(s) required")]
    public required TerraformList<AzurermStreamAnalyticsFunctionJavascriptUdfInputBlock> Input
    {
        get => GetRequiredArgument<TerraformList<AzurermStreamAnalyticsFunctionJavascriptUdfInputBlock>>("input");
        set => SetArgument("input", value);
    }

    /// <summary>
    /// Output block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Output is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Output block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Output block(s) allowed")]
    public required TerraformList<AzurermStreamAnalyticsFunctionJavascriptUdfOutputBlock> Output
    {
        get => GetRequiredArgument<TerraformList<AzurermStreamAnalyticsFunctionJavascriptUdfOutputBlock>>("output");
        set => SetArgument("output", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStreamAnalyticsFunctionJavascriptUdfTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStreamAnalyticsFunctionJavascriptUdfTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
