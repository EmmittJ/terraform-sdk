using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_stream_analytics_job.
/// </summary>
public class AzurermStreamAnalyticsJobDataSource : TerraformDataSource
{
    public AzurermStreamAnalyticsJobDataSource(string name) : base("azurerm_stream_analytics_job", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermStreamAnalyticsJobDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The compatibility_level attribute.
    /// </summary>
    [TerraformArgument("compatibility_level")]
    public TerraformValue<string> CompatibilityLevel
    {
        get => new TerraformReference<string>(this, "compatibility_level");
    }

    /// <summary>
    /// The data_locale attribute.
    /// </summary>
    [TerraformArgument("data_locale")]
    public TerraformValue<string> DataLocale
    {
        get => new TerraformReference<string>(this, "data_locale");
    }

    /// <summary>
    /// The events_late_arrival_max_delay_in_seconds attribute.
    /// </summary>
    [TerraformArgument("events_late_arrival_max_delay_in_seconds")]
    public TerraformValue<double> EventsLateArrivalMaxDelayInSeconds
    {
        get => new TerraformReference<double>(this, "events_late_arrival_max_delay_in_seconds");
    }

    /// <summary>
    /// The events_out_of_order_max_delay_in_seconds attribute.
    /// </summary>
    [TerraformArgument("events_out_of_order_max_delay_in_seconds")]
    public TerraformValue<double> EventsOutOfOrderMaxDelayInSeconds
    {
        get => new TerraformReference<double>(this, "events_out_of_order_max_delay_in_seconds");
    }

    /// <summary>
    /// The events_out_of_order_policy attribute.
    /// </summary>
    [TerraformArgument("events_out_of_order_policy")]
    public TerraformValue<string> EventsOutOfOrderPolicy
    {
        get => new TerraformReference<string>(this, "events_out_of_order_policy");
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformArgument("identity")]
    public TerraformList<object> Identity
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    [TerraformArgument("job_id")]
    public TerraformValue<string> JobId
    {
        get => new TerraformReference<string>(this, "job_id");
    }

    /// <summary>
    /// The last_output_time attribute.
    /// </summary>
    [TerraformArgument("last_output_time")]
    public TerraformValue<string> LastOutputTime
    {
        get => new TerraformReference<string>(this, "last_output_time");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The output_error_policy attribute.
    /// </summary>
    [TerraformArgument("output_error_policy")]
    public TerraformValue<string> OutputErrorPolicy
    {
        get => new TerraformReference<string>(this, "output_error_policy");
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [TerraformArgument("sku_name")]
    public TerraformValue<string> SkuName
    {
        get => new TerraformReference<string>(this, "sku_name");
    }

    /// <summary>
    /// The start_mode attribute.
    /// </summary>
    [TerraformArgument("start_mode")]
    public TerraformValue<string> StartMode
    {
        get => new TerraformReference<string>(this, "start_mode");
    }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformArgument("start_time")]
    public TerraformValue<string> StartTime
    {
        get => new TerraformReference<string>(this, "start_time");
    }

    /// <summary>
    /// The streaming_units attribute.
    /// </summary>
    [TerraformArgument("streaming_units")]
    public TerraformValue<double> StreamingUnits
    {
        get => new TerraformReference<double>(this, "streaming_units");
    }

    /// <summary>
    /// The transformation_query attribute.
    /// </summary>
    [TerraformArgument("transformation_query")]
    public TerraformValue<string> TransformationQuery
    {
        get => new TerraformReference<string>(this, "transformation_query");
    }

}
