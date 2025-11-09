using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_internetmonitor_monitor resource.
/// </summary>
public class AwsInternetmonitorMonitor : TerraformResource
{
    public AwsInternetmonitorMonitor(string name) : base("aws_internetmonitor_monitor", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The max_city_networks_to_monitor attribute.
    /// </summary>
    public TerraformProperty<double>? MaxCityNetworksToMonitor
    {
        get => GetProperty<TerraformProperty<double>>("max_city_networks_to_monitor");
        set => this.WithProperty("max_city_networks_to_monitor", value);
    }

    /// <summary>
    /// The monitor_name attribute.
    /// </summary>
    public TerraformProperty<string>? MonitorName
    {
        get => GetProperty<TerraformProperty<string>>("monitor_name");
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
    /// The resources attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Resources
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("resources");
        set => this.WithProperty("resources", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => this.WithProperty("status", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The traffic_percentage_to_monitor attribute.
    /// </summary>
    public TerraformProperty<double>? TrafficPercentageToMonitor
    {
        get => GetProperty<TerraformProperty<double>>("traffic_percentage_to_monitor");
        set => this.WithProperty("traffic_percentage_to_monitor", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
