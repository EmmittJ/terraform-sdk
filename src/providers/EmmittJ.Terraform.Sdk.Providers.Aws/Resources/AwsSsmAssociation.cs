using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for output_location in .
/// Nesting mode: list
/// </summary>
public class AwsSsmAssociationOutputLocationBlock : ITerraformBlock
{
    /// <summary>
    /// The s3_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketName is required")]
    [TerraformPropertyName("s3_bucket_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> S3BucketName { get; set; }

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    [TerraformPropertyName("s3_key_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? S3KeyPrefix { get; set; }

    /// <summary>
    /// The s3_region attribute.
    /// </summary>
    [TerraformPropertyName("s3_region")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? S3Region { get; set; }

}

/// <summary>
/// Block type for targets in .
/// Nesting mode: list
/// </summary>
public class AwsSsmAssociationTargetsBlock : ITerraformBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Key { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<List<TerraformProperty<string>>>? Values { get; set; }

}

/// <summary>
/// Manages a aws_ssm_association resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSsmAssociation : TerraformResource
{
    public AwsSsmAssociation(string name) : base("aws_ssm_association", name)
    {
    }

    /// <summary>
    /// The apply_only_at_cron_interval attribute.
    /// </summary>
    [TerraformPropertyName("apply_only_at_cron_interval")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ApplyOnlyAtCronInterval { get; set; }

    /// <summary>
    /// The association_name attribute.
    /// </summary>
    [TerraformPropertyName("association_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AssociationName { get; set; }

    /// <summary>
    /// The automation_target_parameter_name attribute.
    /// </summary>
    [TerraformPropertyName("automation_target_parameter_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AutomationTargetParameterName { get; set; }

    /// <summary>
    /// The compliance_severity attribute.
    /// </summary>
    [TerraformPropertyName("compliance_severity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ComplianceSeverity { get; set; }

    /// <summary>
    /// The document_version attribute.
    /// </summary>
    [TerraformPropertyName("document_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DocumentVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "document_version");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The max_concurrency attribute.
    /// </summary>
    [TerraformPropertyName("max_concurrency")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MaxConcurrency { get; set; }

    /// <summary>
    /// The max_errors attribute.
    /// </summary>
    [TerraformPropertyName("max_errors")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MaxErrors { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Parameters { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "parameters");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    [TerraformPropertyName("schedule_expression")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ScheduleExpression { get; set; }

    /// <summary>
    /// The sync_compliance attribute.
    /// </summary>
    [TerraformPropertyName("sync_compliance")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SyncCompliance { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The wait_for_success_timeout_seconds attribute.
    /// </summary>
    [TerraformPropertyName("wait_for_success_timeout_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? WaitForSuccessTimeoutSeconds { get; set; }

    /// <summary>
    /// Block for output_location.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutputLocation block(s) allowed")]
    [TerraformPropertyName("output_location")]
    public TerraformList<TerraformBlock<AwsSsmAssociationOutputLocationBlock>>? OutputLocation { get; set; } = new();

    /// <summary>
    /// Block for targets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 Targets block(s) allowed")]
    [TerraformPropertyName("targets")]
    public TerraformList<TerraformBlock<AwsSsmAssociationTargetsBlock>>? Targets { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    [TerraformPropertyName("association_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AssociationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "association_id");

}
