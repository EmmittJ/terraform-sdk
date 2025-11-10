using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for output_location in .
/// Nesting mode: list
/// </summary>
public class AwsSsmAssociationOutputLocationBlock : TerraformBlock
{
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

    /// <summary>
    /// The s3_region attribute.
    /// </summary>
    public TerraformProperty<string>? S3Region
    {
        set => SetProperty("s3_region", value);
    }

}

/// <summary>
/// Block type for targets in .
/// Nesting mode: list
/// </summary>
public class AwsSsmAssociationTargetsBlock : TerraformBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        set => SetProperty("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public List<TerraformProperty<string>>? Values
    {
        set => SetProperty("values", value);
    }

}

/// <summary>
/// Manages a aws_ssm_association resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSsmAssociation : TerraformResource
{
    public AwsSsmAssociation(string name) : base("aws_ssm_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("association_id");
        SetOutput("apply_only_at_cron_interval");
        SetOutput("association_name");
        SetOutput("automation_target_parameter_name");
        SetOutput("compliance_severity");
        SetOutput("document_version");
        SetOutput("id");
        SetOutput("max_concurrency");
        SetOutput("max_errors");
        SetOutput("name");
        SetOutput("parameters");
        SetOutput("region");
        SetOutput("schedule_expression");
        SetOutput("sync_compliance");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("wait_for_success_timeout_seconds");
    }

    /// <summary>
    /// The apply_only_at_cron_interval attribute.
    /// </summary>
    public TerraformProperty<bool> ApplyOnlyAtCronInterval
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("apply_only_at_cron_interval");
        set => SetProperty("apply_only_at_cron_interval", value);
    }

    /// <summary>
    /// The association_name attribute.
    /// </summary>
    public TerraformProperty<string> AssociationName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("association_name");
        set => SetProperty("association_name", value);
    }

    /// <summary>
    /// The automation_target_parameter_name attribute.
    /// </summary>
    public TerraformProperty<string> AutomationTargetParameterName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("automation_target_parameter_name");
        set => SetProperty("automation_target_parameter_name", value);
    }

    /// <summary>
    /// The compliance_severity attribute.
    /// </summary>
    public TerraformProperty<string> ComplianceSeverity
    {
        get => GetRequiredOutput<TerraformProperty<string>>("compliance_severity");
        set => SetProperty("compliance_severity", value);
    }

    /// <summary>
    /// The document_version attribute.
    /// </summary>
    public TerraformProperty<string> DocumentVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("document_version");
        set => SetProperty("document_version", value);
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
    /// The max_concurrency attribute.
    /// </summary>
    public TerraformProperty<string> MaxConcurrency
    {
        get => GetRequiredOutput<TerraformProperty<string>>("max_concurrency");
        set => SetProperty("max_concurrency", value);
    }

    /// <summary>
    /// The max_errors attribute.
    /// </summary>
    public TerraformProperty<string> MaxErrors
    {
        get => GetRequiredOutput<TerraformProperty<string>>("max_errors");
        set => SetProperty("max_errors", value);
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
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Parameters
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => SetProperty("parameters", value);
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
    /// The schedule_expression attribute.
    /// </summary>
    public TerraformProperty<string> ScheduleExpression
    {
        get => GetRequiredOutput<TerraformProperty<string>>("schedule_expression");
        set => SetProperty("schedule_expression", value);
    }

    /// <summary>
    /// The sync_compliance attribute.
    /// </summary>
    public TerraformProperty<string> SyncCompliance
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sync_compliance");
        set => SetProperty("sync_compliance", value);
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
    /// The wait_for_success_timeout_seconds attribute.
    /// </summary>
    public TerraformProperty<double> WaitForSuccessTimeoutSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("wait_for_success_timeout_seconds");
        set => SetProperty("wait_for_success_timeout_seconds", value);
    }

    /// <summary>
    /// Block for output_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputLocation block(s) allowed")]
    public List<AwsSsmAssociationOutputLocationBlock>? OutputLocation
    {
        set => SetProperty("output_location", value);
    }

    /// <summary>
    /// Block for targets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 Targets block(s) allowed")]
    public List<AwsSsmAssociationTargetsBlock>? Targets
    {
        set => SetProperty("targets", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    public TerraformExpression AssociationId => this["association_id"];

}
