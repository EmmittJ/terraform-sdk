using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for report_delivery_channel in .
/// Nesting mode: list
/// </summary>
public partial class AwsBackupReportPlanReportDeliveryChannelBlock : TerraformBlockBase
{
    /// <summary>
    /// The formats attribute.
    /// </summary>
    [TerraformProperty("formats")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Formats { get; set; }

    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketName is required")]
    [TerraformProperty("s3_bucket_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> S3BucketName { get; set; }

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    [TerraformProperty("s3_key_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? S3KeyPrefix { get; set; }

}

/// <summary>
/// Block type for report_setting in .
/// Nesting mode: list
/// </summary>
public partial class AwsBackupReportPlanReportSettingBlock : TerraformBlockBase
{
    /// <summary>
    /// The accounts attribute.
    /// </summary>
    [TerraformProperty("accounts")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Accounts { get; set; }

    /// <summary>
    /// The framework_arns attribute.
    /// </summary>
    [TerraformProperty("framework_arns")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? FrameworkArns { get; set; }

    /// <summary>
    /// The number_of_frameworks attribute.
    /// </summary>
    [TerraformProperty("number_of_frameworks")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? NumberOfFrameworks { get; set; }

    /// <summary>
    /// The organization_units attribute.
    /// </summary>
    [TerraformProperty("organization_units")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? OrganizationUnits { get; set; }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    [TerraformProperty("regions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Regions { get; set; }

    /// <summary>
    /// The report_template attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReportTemplate is required")]
    [TerraformProperty("report_template")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ReportTemplate { get; set; }

}

/// <summary>
/// Manages a aws_backup_report_plan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsBackupReportPlan : TerraformResource
{
    public AwsBackupReportPlan(string name) : base("aws_backup_report_plan", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for report_delivery_channel.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReportDeliveryChannel is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReportDeliveryChannel block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReportDeliveryChannel block(s) allowed")]
    [TerraformProperty("report_delivery_channel")]
    public partial TerraformList<TerraformBlock<AwsBackupReportPlanReportDeliveryChannelBlock>>? ReportDeliveryChannel { get; set; }

    /// <summary>
    /// Block for report_setting.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReportSetting is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReportSetting block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReportSetting block(s) allowed")]
    [TerraformProperty("report_setting")]
    public partial TerraformList<TerraformBlock<AwsBackupReportPlanReportSettingBlock>>? ReportSetting { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    [TerraformProperty("creation_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTime { get; }

    /// <summary>
    /// The deployment_status attribute.
    /// </summary>
    [TerraformProperty("deployment_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DeploymentStatus { get; }

}
