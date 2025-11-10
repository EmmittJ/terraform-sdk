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
        get => GetRequiredProperty<TerraformProperty<string>>("s3_bucket_name");
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

    /// <summary>
    /// The s3_region attribute.
    /// </summary>
    public TerraformProperty<string>? S3Region
    {
        get => GetProperty<TerraformProperty<string>>("s3_region");
        set => WithProperty("s3_region", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("key");
        set => WithProperty("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public List<TerraformProperty<string>>? Values
    {
        get => GetProperty<List<TerraformProperty<string>>>("values");
        set => WithProperty("values", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("association_id");
    }

    /// <summary>
    /// The apply_only_at_cron_interval attribute.
    /// </summary>
    public TerraformProperty<bool>? ApplyOnlyAtCronInterval
    {
        get => GetProperty<TerraformProperty<bool>>("apply_only_at_cron_interval");
        set => this.WithProperty("apply_only_at_cron_interval", value);
    }

    /// <summary>
    /// The association_name attribute.
    /// </summary>
    public TerraformProperty<string>? AssociationName
    {
        get => GetProperty<TerraformProperty<string>>("association_name");
        set => this.WithProperty("association_name", value);
    }

    /// <summary>
    /// The automation_target_parameter_name attribute.
    /// </summary>
    public TerraformProperty<string>? AutomationTargetParameterName
    {
        get => GetProperty<TerraformProperty<string>>("automation_target_parameter_name");
        set => this.WithProperty("automation_target_parameter_name", value);
    }

    /// <summary>
    /// The compliance_severity attribute.
    /// </summary>
    public TerraformProperty<string>? ComplianceSeverity
    {
        get => GetProperty<TerraformProperty<string>>("compliance_severity");
        set => this.WithProperty("compliance_severity", value);
    }

    /// <summary>
    /// The document_version attribute.
    /// </summary>
    public TerraformProperty<string>? DocumentVersion
    {
        get => GetProperty<TerraformProperty<string>>("document_version");
        set => this.WithProperty("document_version", value);
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
    /// The max_concurrency attribute.
    /// </summary>
    public TerraformProperty<string>? MaxConcurrency
    {
        get => GetProperty<TerraformProperty<string>>("max_concurrency");
        set => this.WithProperty("max_concurrency", value);
    }

    /// <summary>
    /// The max_errors attribute.
    /// </summary>
    public TerraformProperty<string>? MaxErrors
    {
        get => GetProperty<TerraformProperty<string>>("max_errors");
        set => this.WithProperty("max_errors", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => this.WithProperty("parameters", value);
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
    /// The schedule_expression attribute.
    /// </summary>
    public TerraformProperty<string>? ScheduleExpression
    {
        get => GetProperty<TerraformProperty<string>>("schedule_expression");
        set => this.WithProperty("schedule_expression", value);
    }

    /// <summary>
    /// The sync_compliance attribute.
    /// </summary>
    public TerraformProperty<string>? SyncCompliance
    {
        get => GetProperty<TerraformProperty<string>>("sync_compliance");
        set => this.WithProperty("sync_compliance", value);
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
    /// The wait_for_success_timeout_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? WaitForSuccessTimeoutSeconds
    {
        get => GetProperty<TerraformProperty<double>>("wait_for_success_timeout_seconds");
        set => this.WithProperty("wait_for_success_timeout_seconds", value);
    }

    /// <summary>
    /// Block for output_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputLocation block(s) allowed")]
    public List<AwsSsmAssociationOutputLocationBlock>? OutputLocation
    {
        get => GetProperty<List<AwsSsmAssociationOutputLocationBlock>>("output_location");
        set => this.WithProperty("output_location", value);
    }

    /// <summary>
    /// Block for targets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 Targets block(s) allowed")]
    public List<AwsSsmAssociationTargetsBlock>? Targets
    {
        get => GetProperty<List<AwsSsmAssociationTargetsBlock>>("targets");
        set => this.WithProperty("targets", value);
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
