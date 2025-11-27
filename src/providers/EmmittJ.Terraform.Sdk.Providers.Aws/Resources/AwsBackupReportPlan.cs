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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "formats").ResolveNodes(ctx));
        set => SetArgument("formats", value);
    }

    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketName is required")]
    public required TerraformValue<string> S3BucketName
    {
        get => new TerraformReference<string>(this, "s3_bucket_name");
        set => SetArgument("s3_bucket_name", value);
    }

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    public TerraformValue<string>? S3KeyPrefix
    {
        get => new TerraformReference<string>(this, "s3_key_prefix");
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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "accounts").ResolveNodes(ctx));
        set => SetArgument("accounts", value);
    }

    /// <summary>
    /// The framework_arns attribute.
    /// </summary>
    public TerraformSet<string>? FrameworkArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "framework_arns").ResolveNodes(ctx));
        set => SetArgument("framework_arns", value);
    }

    /// <summary>
    /// The number_of_frameworks attribute.
    /// </summary>
    public TerraformValue<double>? NumberOfFrameworks
    {
        get => new TerraformReference<double>(this, "number_of_frameworks");
        set => SetArgument("number_of_frameworks", value);
    }

    /// <summary>
    /// The organization_units attribute.
    /// </summary>
    public TerraformSet<string>? OrganizationUnits
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "organization_units").ResolveNodes(ctx));
        set => SetArgument("organization_units", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public TerraformSet<string>? Regions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "regions").ResolveNodes(ctx));
        set => SetArgument("regions", value);
    }

    /// <summary>
    /// The report_template attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReportTemplate is required")]
    public required TerraformValue<string> ReportTemplate
    {
        get => new TerraformReference<string>(this, "report_template");
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
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformValue<string> CreationTime
    {
        get => new TerraformReference<string>(this, "creation_time");
    }

    /// <summary>
    /// The deployment_status attribute.
    /// </summary>
    public TerraformValue<string> DeploymentStatus
    {
        get => new TerraformReference<string>(this, "deployment_status");
    }

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
