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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The max_city_networks_to_monitor attribute.
    /// </summary>
    public double? MaxCityNetworksToMonitor
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_city_networks_to_monitor")?.Value;
        set => this.WithProperty("max_city_networks_to_monitor", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resources attribute.
    /// </summary>
    public HashSet<string>? Resources
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("resources")?.Value;
        set => this.WithProperty("resources", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public string? Status
    {
        get => GetProperty<TerraformLiteralProperty<string>>("status")?.Value;
        set => this.WithProperty("status", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The traffic_percentage_to_monitor attribute.
    /// </summary>
    public double? TrafficPercentageToMonitor
    {
        get => GetProperty<TerraformLiteralProperty<double>>("traffic_percentage_to_monitor")?.Value;
        set => this.WithProperty("traffic_percentage_to_monitor", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
