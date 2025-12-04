using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermStreamAnalyticsJobDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermStreamAnalyticsJobDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_stream_analytics_job Terraform data source.
/// Retrieves information about a azurerm_stream_analytics_job.
/// </summary>
public partial class AzurermStreamAnalyticsJobDataSource(string name) : TerraformDataSource("azurerm_stream_analytics_job", name)
{
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
    /// The compatibility_level attribute.
    /// </summary>
    public TerraformValue<string> CompatibilityLevel
        => AsReference("compatibility_level");

    /// <summary>
    /// The data_locale attribute.
    /// </summary>
    public TerraformValue<string> DataLocale
        => AsReference("data_locale");

    /// <summary>
    /// The events_late_arrival_max_delay_in_seconds attribute.
    /// </summary>
    public TerraformValue<double> EventsLateArrivalMaxDelayInSeconds
        => AsReference("events_late_arrival_max_delay_in_seconds");

    /// <summary>
    /// The events_out_of_order_max_delay_in_seconds attribute.
    /// </summary>
    public TerraformValue<double> EventsOutOfOrderMaxDelayInSeconds
        => AsReference("events_out_of_order_max_delay_in_seconds");

    /// <summary>
    /// The events_out_of_order_policy attribute.
    /// </summary>
    public TerraformValue<string> EventsOutOfOrderPolicy
        => AsReference("events_out_of_order_policy");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => AsReference("identity");

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    public TerraformValue<string> JobId
        => AsReference("job_id");

    /// <summary>
    /// The last_output_time attribute.
    /// </summary>
    public TerraformValue<string> LastOutputTime
        => AsReference("last_output_time");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The output_error_policy attribute.
    /// </summary>
    public TerraformValue<string> OutputErrorPolicy
        => AsReference("output_error_policy");

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformValue<string> SkuName
        => AsReference("sku_name");

    /// <summary>
    /// The start_mode attribute.
    /// </summary>
    public TerraformValue<string> StartMode
        => AsReference("start_mode");

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformValue<string> StartTime
        => AsReference("start_time");

    /// <summary>
    /// The streaming_units attribute.
    /// </summary>
    public TerraformValue<double> StreamingUnits
        => AsReference("streaming_units");

    /// <summary>
    /// The transformation_query attribute.
    /// </summary>
    public TerraformValue<string> TransformationQuery
        => AsReference("transformation_query");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStreamAnalyticsJobDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStreamAnalyticsJobDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
