using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for report_delivery_channel in .
/// Nesting mode: list
/// </summary>
public class AwsBackupReportPlanReportDeliveryChannelBlock
{
    /// <summary>
    /// The formats attribute.
    /// </summary>
    [TerraformPropertyName("formats")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Formats { get; set; }

    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketName is required")]
    [TerraformPropertyName("s3_bucket_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> S3BucketName { get; set; }

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    [TerraformPropertyName("s3_key_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? S3KeyPrefix { get; set; }

}

/// <summary>
/// Block type for report_setting in .
/// Nesting mode: list
/// </summary>
public class AwsBackupReportPlanReportSettingBlock
{
    /// <summary>
    /// The accounts attribute.
    /// </summary>
    [TerraformPropertyName("accounts")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Accounts { get; set; }

    /// <summary>
    /// The framework_arns attribute.
    /// </summary>
    [TerraformPropertyName("framework_arns")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? FrameworkArns { get; set; }

    /// <summary>
    /// The number_of_frameworks attribute.
    /// </summary>
    [TerraformPropertyName("number_of_frameworks")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? NumberOfFrameworks { get; set; }

    /// <summary>
    /// The organization_units attribute.
    /// </summary>
    [TerraformPropertyName("organization_units")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? OrganizationUnits { get; set; }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    [TerraformPropertyName("regions")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Regions { get; set; }

    /// <summary>
    /// The report_template attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReportTemplate is required")]
    [TerraformPropertyName("report_template")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ReportTemplate { get; set; }

}

/// <summary>
/// Manages a aws_backup_report_plan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsBackupReportPlan : TerraformResource
{
    public AwsBackupReportPlan(string name) : base("aws_backup_report_plan", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for report_delivery_channel.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReportDeliveryChannel is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReportDeliveryChannel block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReportDeliveryChannel block(s) allowed")]
    [TerraformPropertyName("report_delivery_channel")]
    public TerraformList<TerraformBlock<AwsBackupReportPlanReportDeliveryChannelBlock>>? ReportDeliveryChannel { get; set; }

    /// <summary>
    /// Block for report_setting.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReportSetting is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReportSetting block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReportSetting block(s) allowed")]
    [TerraformPropertyName("report_setting")]
    public TerraformList<TerraformBlock<AwsBackupReportPlanReportSettingBlock>>? ReportSetting { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    [TerraformPropertyName("creation_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationTime => new TerraformReference(this, "creation_time");

    /// <summary>
    /// The deployment_status attribute.
    /// </summary>
    [TerraformPropertyName("deployment_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeploymentStatus => new TerraformReference(this, "deployment_status");

}
