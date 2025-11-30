using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermStreamAnalyticsJobSchedule.
/// Nesting mode: single
/// </summary>
public class AzurermStreamAnalyticsJobScheduleTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_stream_analytics_job_schedule Terraform resource.
/// Manages a azurerm_stream_analytics_job_schedule resource.
/// </summary>
public partial class AzurermStreamAnalyticsJobSchedule(string name) : TerraformResource("azurerm_stream_analytics_job_schedule", name)
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
    /// The start_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StartMode is required")]
    public required TerraformValue<string> StartMode
    {
        get => new TerraformReference<string>(this, "start_mode");
        set => SetArgument("start_mode", value);
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformValue<string> StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
        set => SetArgument("start_time", value);
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
    /// The last_output_time attribute.
    /// </summary>
    public TerraformValue<string> LastOutputTime
    {
        get => new TerraformReference<string>(this, "last_output_time");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStreamAnalyticsJobScheduleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStreamAnalyticsJobScheduleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
