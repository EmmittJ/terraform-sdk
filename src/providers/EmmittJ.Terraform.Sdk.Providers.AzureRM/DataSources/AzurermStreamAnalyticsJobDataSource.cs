using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStreamAnalyticsJobDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_stream_analytics_job.
/// </summary>
public class AzurermStreamAnalyticsJobDataSource : TerraformDataSource
{
    public AzurermStreamAnalyticsJobDataSource(string name) : base("azurerm_stream_analytics_job", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("compatibility_level");
        SetOutput("data_locale");
        SetOutput("events_late_arrival_max_delay_in_seconds");
        SetOutput("events_out_of_order_max_delay_in_seconds");
        SetOutput("events_out_of_order_policy");
        SetOutput("identity");
        SetOutput("job_id");
        SetOutput("last_output_time");
        SetOutput("location");
        SetOutput("output_error_policy");
        SetOutput("sku_name");
        SetOutput("start_mode");
        SetOutput("start_time");
        SetOutput("streaming_units");
        SetOutput("transformation_query");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStreamAnalyticsJobDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The compatibility_level attribute.
    /// </summary>
    public TerraformExpression CompatibilityLevel => this["compatibility_level"];

    /// <summary>
    /// The data_locale attribute.
    /// </summary>
    public TerraformExpression DataLocale => this["data_locale"];

    /// <summary>
    /// The events_late_arrival_max_delay_in_seconds attribute.
    /// </summary>
    public TerraformExpression EventsLateArrivalMaxDelayInSeconds => this["events_late_arrival_max_delay_in_seconds"];

    /// <summary>
    /// The events_out_of_order_max_delay_in_seconds attribute.
    /// </summary>
    public TerraformExpression EventsOutOfOrderMaxDelayInSeconds => this["events_out_of_order_max_delay_in_seconds"];

    /// <summary>
    /// The events_out_of_order_policy attribute.
    /// </summary>
    public TerraformExpression EventsOutOfOrderPolicy => this["events_out_of_order_policy"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    public TerraformExpression JobId => this["job_id"];

    /// <summary>
    /// The last_output_time attribute.
    /// </summary>
    public TerraformExpression LastOutputTime => this["last_output_time"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The output_error_policy attribute.
    /// </summary>
    public TerraformExpression OutputErrorPolicy => this["output_error_policy"];

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformExpression SkuName => this["sku_name"];

    /// <summary>
    /// The start_mode attribute.
    /// </summary>
    public TerraformExpression StartMode => this["start_mode"];

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    public TerraformExpression StartTime => this["start_time"];

    /// <summary>
    /// The streaming_units attribute.
    /// </summary>
    public TerraformExpression StreamingUnits => this["streaming_units"];

    /// <summary>
    /// The transformation_query attribute.
    /// </summary>
    public TerraformExpression TransformationQuery => this["transformation_query"];

}
