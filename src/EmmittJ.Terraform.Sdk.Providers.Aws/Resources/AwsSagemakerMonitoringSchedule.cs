using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for monitoring_schedule_config in .
/// Nesting mode: list
/// </summary>
public class AwsSagemakerMonitoringScheduleMonitoringScheduleConfigBlock : TerraformBlock
{
    /// <summary>
    /// The monitoring_job_definition_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitoringJobDefinitionName is required")]
    public required TerraformProperty<string> MonitoringJobDefinitionName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("monitoring_job_definition_name");
        set => WithProperty("monitoring_job_definition_name", value);
    }

    /// <summary>
    /// The monitoring_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MonitoringType is required")]
    public required TerraformProperty<string> MonitoringType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("monitoring_type");
        set => WithProperty("monitoring_type", value);
    }

}

/// <summary>
/// Manages a aws_sagemaker_monitoring_schedule resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSagemakerMonitoringSchedule : TerraformResource
{
    public AwsSagemakerMonitoringSchedule(string name) : base("aws_sagemaker_monitoring_schedule", name)
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for monitoring_schedule_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MonitoringScheduleConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MonitoringScheduleConfig block(s) allowed")]
    public List<AwsSagemakerMonitoringScheduleMonitoringScheduleConfigBlock>? MonitoringScheduleConfig
    {
        get => GetProperty<List<AwsSagemakerMonitoringScheduleMonitoringScheduleConfigBlock>>("monitoring_schedule_config");
        set => this.WithProperty("monitoring_schedule_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
