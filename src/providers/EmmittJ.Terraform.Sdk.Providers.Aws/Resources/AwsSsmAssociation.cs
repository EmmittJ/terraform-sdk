using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for output_location in AwsSsmAssociation.
/// Nesting mode: list
/// </summary>
public class AwsSsmAssociationOutputLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output_location";

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

    /// <summary>
    /// The s3_region attribute.
    /// </summary>
    public TerraformValue<string>? S3Region
    {
        get => new TerraformReference<string>(this, "s3_region");
        set => SetArgument("s3_region", value);
    }

}


/// <summary>
/// Block type for targets in AwsSsmAssociation.
/// Nesting mode: list
/// </summary>
public class AwsSsmAssociationTargetsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "targets";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Represents a aws_ssm_association Terraform resource.
/// Manages a aws_ssm_association resource.
/// </summary>
public partial class AwsSsmAssociation(string name) : TerraformResource("aws_ssm_association", name)
{
    /// <summary>
    /// The apply_only_at_cron_interval attribute.
    /// </summary>
    public TerraformValue<bool>? ApplyOnlyAtCronInterval
    {
        get => new TerraformReference<bool>(this, "apply_only_at_cron_interval");
        set => SetArgument("apply_only_at_cron_interval", value);
    }

    /// <summary>
    /// The association_name attribute.
    /// </summary>
    public TerraformValue<string>? AssociationName
    {
        get => new TerraformReference<string>(this, "association_name");
        set => SetArgument("association_name", value);
    }

    /// <summary>
    /// The automation_target_parameter_name attribute.
    /// </summary>
    public TerraformValue<string>? AutomationTargetParameterName
    {
        get => new TerraformReference<string>(this, "automation_target_parameter_name");
        set => SetArgument("automation_target_parameter_name", value);
    }

    /// <summary>
    /// The compliance_severity attribute.
    /// </summary>
    public TerraformValue<string>? ComplianceSeverity
    {
        get => new TerraformReference<string>(this, "compliance_severity");
        set => SetArgument("compliance_severity", value);
    }

    /// <summary>
    /// The document_version attribute.
    /// </summary>
    public TerraformValue<string> DocumentVersion
    {
        get => new TerraformReference<string>(this, "document_version");
        set => SetArgument("document_version", value);
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
    /// The max_concurrency attribute.
    /// </summary>
    public TerraformValue<string>? MaxConcurrency
    {
        get => new TerraformReference<string>(this, "max_concurrency");
        set => SetArgument("max_concurrency", value);
    }

    /// <summary>
    /// The max_errors attribute.
    /// </summary>
    public TerraformValue<string>? MaxErrors
    {
        get => new TerraformReference<string>(this, "max_errors");
        set => SetArgument("max_errors", value);
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
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string> Parameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameters").ResolveNodes(ctx));
        set => SetArgument("parameters", value);
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
    /// The schedule_expression attribute.
    /// </summary>
    public TerraformValue<string>? ScheduleExpression
    {
        get => new TerraformReference<string>(this, "schedule_expression");
        set => SetArgument("schedule_expression", value);
    }

    /// <summary>
    /// The sync_compliance attribute.
    /// </summary>
    public TerraformValue<string>? SyncCompliance
    {
        get => new TerraformReference<string>(this, "sync_compliance");
        set => SetArgument("sync_compliance", value);
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
    /// The wait_for_success_timeout_seconds attribute.
    /// </summary>
    public TerraformValue<double>? WaitForSuccessTimeoutSeconds
    {
        get => new TerraformReference<double>(this, "wait_for_success_timeout_seconds");
        set => SetArgument("wait_for_success_timeout_seconds", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    public TerraformValue<string> AssociationId
    {
        get => new TerraformReference<string>(this, "association_id");
    }

    /// <summary>
    /// OutputLocation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputLocation block(s) allowed")]
    public TerraformList<AwsSsmAssociationOutputLocationBlock>? OutputLocation
    {
        get => GetArgument<TerraformList<AwsSsmAssociationOutputLocationBlock>>("output_location");
        set => SetArgument("output_location", value);
    }

    /// <summary>
    /// Targets block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 Targets block(s) allowed")]
    public TerraformList<AwsSsmAssociationTargetsBlock>? Targets
    {
        get => GetArgument<TerraformList<AwsSsmAssociationTargetsBlock>>("targets");
        set => SetArgument("targets", value);
    }

}
