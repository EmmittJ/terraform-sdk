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
        SetOutput("arn");
        SetOutput("id");
        SetOutput("monitor_dimension");
        SetOutput("monitor_specification");
        SetOutput("monitor_type");
        SetOutput("name");
        SetOutput("tags");
        SetOutput("tags_all");
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
    /// The monitor_dimension attribute.
    /// </summary>
    public TerraformProperty<string> MonitorDimension
    {
        get => GetRequiredOutput<TerraformProperty<string>>("monitor_dimension");
        set => SetProperty("monitor_dimension", value);
    }

    /// <summary>
    /// The monitor_specification attribute.
    /// </summary>
    public TerraformProperty<string> MonitorSpecification
    {
        get => GetRequiredOutput<TerraformProperty<string>>("monitor_specification");
        set => SetProperty("monitor_specification", value);
    }

    /// <summary>
    /// The monitor_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitorType is required")]
    public required TerraformProperty<string> MonitorType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("monitor_type");
        set => SetProperty("monitor_type", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
