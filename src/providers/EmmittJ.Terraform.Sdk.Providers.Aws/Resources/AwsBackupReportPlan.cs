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
        set => SetProperty("formats", value);
    }

    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketName is required")]
    public required TerraformProperty<string> S3BucketName
    {
        set => SetProperty("s3_bucket_name", value);
    }

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? S3KeyPrefix
    {
        set => SetProperty("s3_key_prefix", value);
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
        set => SetProperty("accounts", value);
    }

    /// <summary>
    /// The framework_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? FrameworkArns
    {
        set => SetProperty("framework_arns", value);
    }

    /// <summary>
    /// The number_of_frameworks attribute.
    /// </summary>
    public TerraformProperty<double>? NumberOfFrameworks
    {
        set => SetProperty("number_of_frameworks", value);
    }

    /// <summary>
    /// The organization_units attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? OrganizationUnits
    {
        set => SetProperty("organization_units", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Regions
    {
        set => SetProperty("regions", value);
    }

    /// <summary>
    /// The report_template attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReportTemplate is required")]
    public required TerraformProperty<string> ReportTemplate
    {
        set => SetProperty("report_template", value);
    }

}

/// <summary>
/// Manages a aws_backup_report_plan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsBackupReportPlan : TerraformResource
{
    public AwsBackupReportPlan(string name) : base("aws_backup_report_plan", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("creation_time");
        SetOutput("deployment_status");
        SetOutput("description");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
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
    /// Block for report_delivery_channel.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReportDeliveryChannel is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReportDeliveryChannel block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReportDeliveryChannel block(s) allowed")]
    public List<AwsBackupReportPlanReportDeliveryChannelBlock>? ReportDeliveryChannel
    {
        set => SetProperty("report_delivery_channel", value);
    }

    /// <summary>
    /// Block for report_setting.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReportSetting is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReportSetting block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReportSetting block(s) allowed")]
    public List<AwsBackupReportPlanReportSettingBlock>? ReportSetting
    {
        set => SetProperty("report_setting", value);
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
