using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_backup_report_plan.
/// </summary>
public partial class AwsBackupReportPlanDataSource : TerraformDataSource
{
    public AwsBackupReportPlanDataSource(string name) : base("aws_backup_report_plan", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    [TerraformProperty("creation_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreationTime { get; }

    /// <summary>
    /// The deployment_status attribute.
    /// </summary>
    [TerraformProperty("deployment_status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DeploymentStatus { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The report_delivery_channel attribute.
    /// </summary>
    [TerraformProperty("report_delivery_channel")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ReportDeliveryChannel { get; }

    /// <summary>
    /// The report_setting attribute.
    /// </summary>
    [TerraformProperty("report_setting")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ReportSetting { get; }

}
