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
        this.WithOutput("arn");
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
    /// The monitor_dimension attribute.
    /// </summary>
    public TerraformProperty<string>? MonitorDimension
    {
        get => GetProperty<TerraformProperty<string>>("monitor_dimension");
        set => this.WithProperty("monitor_dimension", value);
    }

    /// <summary>
    /// The monitor_specification attribute.
    /// </summary>
    public TerraformProperty<string>? MonitorSpecification
    {
        get => GetProperty<TerraformProperty<string>>("monitor_specification");
        set => this.WithProperty("monitor_specification", value);
    }

    /// <summary>
    /// The monitor_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitorType is required")]
    public required TerraformProperty<string> MonitorType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("monitor_type");
        set => this.WithProperty("monitor_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
