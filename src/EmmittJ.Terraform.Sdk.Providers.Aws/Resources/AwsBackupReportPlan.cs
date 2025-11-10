using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for report_delivery_channel in .
/// Nesting mode: list
/// </summary>
public class AwsBackupReportPlanReportDeliveryChannelBlock : TerraformBlock
{
    /// <summary>
    /// The formats attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Formats
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("formats");
        set => WithProperty("formats", value);
    }

    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketName is required")]
    public required TerraformProperty<string> S3BucketName
    {
        get => GetProperty<TerraformProperty<string>>("s3_bucket_name");
        set => WithProperty("s3_bucket_name", value);
    }

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? S3KeyPrefix
    {
        get => GetProperty<TerraformProperty<string>>("s3_key_prefix");
        set => WithProperty("s3_key_prefix", value);
    }

}

/// <summary>
/// Block type for report_setting in .
/// Nesting mode: list
/// </summary>
public class AwsBackupReportPlanReportSettingBlock : TerraformBlock
{
    /// <summary>
    /// The accounts attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Accounts
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("accounts");
        set => WithProperty("accounts", value);
    }

    /// <summary>
    /// The framework_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? FrameworkArns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("framework_arns");
        set => WithProperty("framework_arns", value);
    }

    /// <summary>
    /// The number_of_frameworks attribute.
    /// </summary>
    public TerraformProperty<double>? NumberOfFrameworks
    {
        get => GetProperty<TerraformProperty<double>>("number_of_frameworks");
        set => WithProperty("number_of_frameworks", value);
    }

    /// <summary>
    /// The organization_units attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? OrganizationUnits
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("organization_units");
        set => WithProperty("organization_units", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Regions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("regions");
        set => WithProperty("regions", value);
    }

    /// <summary>
    /// The report_template attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReportTemplate is required")]
    public required TerraformProperty<string> ReportTemplate
    {
        get => GetProperty<TerraformProperty<string>>("report_template");
        set => WithProperty("report_template", value);
    }

}

/// <summary>
/// Manages a aws_backup_report_plan resource.
/// </summary>
public class AwsBackupReportPlan : TerraformResource
{
    public AwsBackupReportPlan(string name) : base("aws_backup_report_plan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("creation_time");
        this.DeclareOutput("deployment_status");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
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
    /// Block for report_delivery_channel.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReportDeliveryChannel block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReportDeliveryChannel block(s) allowed")]
    public List<AwsBackupReportPlanReportDeliveryChannelBlock>? ReportDeliveryChannel
    {
        get => GetProperty<List<AwsBackupReportPlanReportDeliveryChannelBlock>>("report_delivery_channel");
        set => this.WithProperty("report_delivery_channel", value);
    }

    /// <summary>
    /// Block for report_setting.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReportSetting block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReportSetting block(s) allowed")]
    public List<AwsBackupReportPlanReportSettingBlock>? ReportSetting
    {
        get => GetProperty<List<AwsBackupReportPlanReportSettingBlock>>("report_setting");
        set => this.WithProperty("report_setting", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformExpression CreationTime => this["creation_time"];

    /// <summary>
    /// The deployment_status attribute.
    /// </summary>
    public TerraformExpression DeploymentStatus => this["deployment_status"];

}
