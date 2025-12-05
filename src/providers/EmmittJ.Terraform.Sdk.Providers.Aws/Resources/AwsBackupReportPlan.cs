using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for report_delivery_channel in AwsBackupReportPlan.
/// Nesting mode: list
/// </summary>
public class AwsBackupReportPlanReportDeliveryChannelBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "report_delivery_channel";

    /// <summary>
    /// The formats attribute.
    /// </summary>
    public TerraformSet<string>? Formats
    {
        get => GetArgument<TerraformSet<string>>("formats");
        set => SetArgument("formats", value);
    }

    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketName is required")]
    public required TerraformValue<string> S3BucketName
    {
        get => GetRequiredArgument<TerraformValue<string>>("s3_bucket_name");
        set => SetArgument("s3_bucket_name", value);
    }

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    public TerraformValue<string>? S3KeyPrefix
    {
        get => GetArgument<TerraformValue<string>>("s3_key_prefix");
        set => SetArgument("s3_key_prefix", value);
    }

}


/// <summary>
/// Block type for report_setting in AwsBackupReportPlan.
/// Nesting mode: list
/// </summary>
public class AwsBackupReportPlanReportSettingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "report_setting";

    /// <summary>
    /// The accounts attribute.
    /// </summary>
    public TerraformSet<string>? Accounts
    {
        get => GetArgument<TerraformSet<string>>("accounts");
        set => SetArgument("accounts", value);
    }

    /// <summary>
    /// The framework_arns attribute.
    /// </summary>
    public TerraformSet<string>? FrameworkArns
    {
        get => GetArgument<TerraformSet<string>>("framework_arns");
        set => SetArgument("framework_arns", value);
    }

    /// <summary>
    /// The number_of_frameworks attribute.
    /// </summary>
    public TerraformValue<double>? NumberOfFrameworks
    {
        get => GetArgument<TerraformValue<double>>("number_of_frameworks");
        set => SetArgument("number_of_frameworks", value);
    }

    /// <summary>
    /// The organization_units attribute.
    /// </summary>
    public TerraformSet<string>? OrganizationUnits
    {
        get => GetArgument<TerraformSet<string>>("organization_units");
        set => SetArgument("organization_units", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public TerraformSet<string>? Regions
    {
        get => GetArgument<TerraformSet<string>>("regions");
        set => SetArgument("regions", value);
    }

    /// <summary>
    /// The report_template attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReportTemplate is required")]
    public required TerraformValue<string> ReportTemplate
    {
        get => GetRequiredArgument<TerraformValue<string>>("report_template");
        set => SetArgument("report_template", value);
    }

}


/// <summary>
/// Represents a aws_backup_report_plan Terraform resource.
/// Manages a aws_backup_report_plan resource.
/// </summary>
public partial class AwsBackupReportPlan(string name) : TerraformResource("aws_backup_report_plan", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformValue<string> CreationTime
        => CreateReference("creation_time");

    /// <summary>
    /// The deployment_status attribute.
    /// </summary>
    public TerraformValue<string> DeploymentStatus
        => CreateReference("deployment_status");

    /// <summary>
    /// ReportDeliveryChannel block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReportDeliveryChannel is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReportDeliveryChannel block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReportDeliveryChannel block(s) allowed")]
    public required TerraformList<AwsBackupReportPlanReportDeliveryChannelBlock> ReportDeliveryChannel
    {
        get => GetRequiredArgument<TerraformList<AwsBackupReportPlanReportDeliveryChannelBlock>>("report_delivery_channel");
        set => SetArgument("report_delivery_channel", value);
    }

    /// <summary>
    /// ReportSetting block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReportSetting is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReportSetting block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReportSetting block(s) allowed")]
    public required TerraformList<AwsBackupReportPlanReportSettingBlock> ReportSetting
    {
        get => GetRequiredArgument<TerraformList<AwsBackupReportPlanReportSettingBlock>>("report_setting");
        set => SetArgument("report_setting", value);
    }

}
