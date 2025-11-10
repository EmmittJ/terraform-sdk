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
        SetOutput("arn");
        SetOutput("id");
        SetOutput("tags_all");
        SetOutput("aggregation_period");
        SetOutput("monitor_name");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The aggregation_period attribute.
    /// </summary>
    public TerraformProperty<double> AggregationPeriod
    {
        get => GetRequiredOutput<TerraformProperty<double>>("aggregation_period");
        set => SetProperty("aggregation_period", value);
    }

    /// <summary>
    /// The monitor_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitorName is required")]
    public required TerraformProperty<string> MonitorName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("monitor_name");
        set => SetProperty("monitor_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
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
