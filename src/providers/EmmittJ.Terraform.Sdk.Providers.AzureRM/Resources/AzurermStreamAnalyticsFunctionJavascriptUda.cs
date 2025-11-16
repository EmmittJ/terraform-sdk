using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for input in .
/// Nesting mode: list
/// </summary>
public class AzurermStreamAnalyticsFunctionJavascriptUdaInputBlock : TerraformBlock
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
        get => new TerraformReference<bool>(this, "configuration_parameter");
        set => SetArgument("configuration_parameter", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for output in .
/// Nesting mode: list
/// </summary>
public class AzurermStreamAnalyticsFunctionJavascriptUdaOutputBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStreamAnalyticsFunctionJavascriptUdaTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_stream_analytics_function_javascript_uda Terraform resource.
/// Manages a azurerm_stream_analytics_function_javascript_uda resource.
/// </summary>
public partial class AzurermStreamAnalyticsFunctionJavascriptUda(string name) : TerraformResource("azurerm_stream_analytics_function_javascript_uda", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The script attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Script is required")]
    public required TerraformValue<string> Script
    {
        get => new TerraformReference<string>(this, "script");
        set => SetArgument("script", value);
    }

    /// <summary>
    /// The stream_analytics_job_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamAnalyticsJobId is required")]
    public required TerraformValue<string> StreamAnalyticsJobId
    {
        get => new TerraformReference<string>(this, "stream_analytics_job_id");
        set => SetArgument("stream_analytics_job_id", value);
    }

    /// <summary>
    /// Input block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Input is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Input block(s) required")]
    public required TerraformList<AzurermStreamAnalyticsFunctionJavascriptUdaInputBlock> Input
    {
        get => GetRequiredArgument<TerraformList<AzurermStreamAnalyticsFunctionJavascriptUdaInputBlock>>("input");
        set => SetArgument("input", value);
    }

    /// <summary>
    /// Output block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Output is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Output block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Output block(s) allowed")]
    public required TerraformList<AzurermStreamAnalyticsFunctionJavascriptUdaOutputBlock> Output
    {
        get => GetRequiredArgument<TerraformList<AzurermStreamAnalyticsFunctionJavascriptUdaOutputBlock>>("output");
        set => SetArgument("output", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStreamAnalyticsFunctionJavascriptUdaTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStreamAnalyticsFunctionJavascriptUdaTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
