using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ce_anomaly_monitor resource.
/// </summary>
public class AwsCeAnomalyMonitor : TerraformResource
{
    public AwsCeAnomalyMonitor(string name) : base("aws_ce_anomaly_monitor", name)
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
    /// The monitor_dimension attribute.
    /// </summary>
    public string? MonitorDimension
    {
        get => GetProperty<TerraformLiteralProperty<string>>("monitor_dimension")?.Value;
        set => this.WithProperty("monitor_dimension", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The monitor_specification attribute.
    /// </summary>
    public string? MonitorSpecification
    {
        get => GetProperty<TerraformLiteralProperty<string>>("monitor_specification")?.Value;
        set => this.WithProperty("monitor_specification", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The monitor_type attribute.
    /// </summary>
    public string? MonitorType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("monitor_type")?.Value;
        set => this.WithProperty("monitor_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
