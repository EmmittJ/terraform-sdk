using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_networkmonitor_monitor resource.
/// </summary>
public class AwsNetworkmonitorMonitor : TerraformResource
{
    public AwsNetworkmonitorMonitor(string name) : base("aws_networkmonitor_monitor", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("id");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The aggregation_period attribute.
    /// </summary>
    public double? AggregationPeriod
    {
        get => GetProperty<TerraformLiteralProperty<double>>("aggregation_period")?.Value;
        set => this.WithProperty("aggregation_period", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The monitor_name attribute.
    /// </summary>
    public string? MonitorName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("monitor_name")?.Value;
        set => this.WithProperty("monitor_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
