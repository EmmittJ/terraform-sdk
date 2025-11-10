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
        this.WithOutput("arn");
        this.WithOutput("id");
        this.WithOutput("tags_all");
    }

    /// <summary>
    /// The aggregation_period attribute.
    /// </summary>
    public TerraformProperty<double>? AggregationPeriod
    {
        get => GetProperty<TerraformProperty<double>>("aggregation_period");
        set => this.WithProperty("aggregation_period", value);
    }

    /// <summary>
    /// The monitor_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitorName is required")]
    public required TerraformProperty<string> MonitorName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("monitor_name");
        set => this.WithProperty("monitor_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
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
