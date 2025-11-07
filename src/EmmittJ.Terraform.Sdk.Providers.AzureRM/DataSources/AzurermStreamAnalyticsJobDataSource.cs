using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("compatibility_level");
        this.DeclareOutput("data_locale");
        this.DeclareOutput("events_late_arrival_max_delay_in_seconds");
        this.DeclareOutput("events_out_of_order_max_delay_in_seconds");
        this.DeclareOutput("events_out_of_order_policy");
        this.DeclareOutput("identity");
        this.DeclareOutput("job_id");
        this.DeclareOutput("last_output_time");
        this.DeclareOutput("location");
        this.DeclareOutput("output_error_policy");
        this.DeclareOutput("sku_name");
        this.DeclareOutput("start_mode");
        this.DeclareOutput("start_time");
        this.DeclareOutput("streaming_units");
        this.DeclareOutput("transformation_query");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
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
