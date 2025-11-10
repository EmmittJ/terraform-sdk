using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for artifact_config in .
/// Nesting mode: list
/// </summary>
public class AwsSyntheticsCanaryArtifactConfigBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for run_config in .
/// Nesting mode: list
/// </summary>
public class AwsSyntheticsCanaryRunConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The active_tracing attribute.
    /// </summary>
    [TerraformPropertyName("active_tracing")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ActiveTracing { get; set; }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    [TerraformPropertyName("environment_variables")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? EnvironmentVariables { get; set; }

    /// <summary>
    /// The ephemeral_storage attribute.
    /// </summary>
    [TerraformPropertyName("ephemeral_storage")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> EphemeralStorage { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "ephemeral_storage");

    /// <summary>
    /// The memory_in_mb attribute.
    /// </summary>
    [TerraformPropertyName("memory_in_mb")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MemoryInMb { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "memory_in_mb");

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("timeout_in_seconds")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> TimeoutInSeconds { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "timeout_in_seconds");

}

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public class AwsSyntheticsCanaryScheduleBlock : ITerraformBlock
{
    /// <summary>
    /// The duration_in_seconds attribute.
    /// </summary>
    [TerraformPropertyName("duration_in_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DurationInSeconds { get; set; }

    /// <summary>
    /// The expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    [TerraformPropertyName("expression")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Expression { get; set; }

}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public class AwsSyntheticsCanaryVpcConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The ipv6_allowed_for_dual_stack attribute.
    /// </summary>
    [TerraformPropertyName("ipv6_allowed_for_dual_stack")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Ipv6AllowedForDualStack { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SubnetIds { get; set; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcId => new TerraformReferenceProperty<TerraformProperty<string>>("", "vpc_id");

}

/// <summary>
/// Manages a aws_synthetics_canary resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSyntheticsCanary : TerraformResource
{
    public AwsSyntheticsCanary(string name) : base("aws_synthetics_canary", name)
    {
    }

    /// <summary>
    /// The artifact_s3_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArtifactS3Location is required")]
    [TerraformPropertyName("artifact_s3_location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ArtifactS3Location { get; set; }

    /// <summary>
    /// The delete_lambda attribute.
    /// </summary>
    [TerraformPropertyName("delete_lambda")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeleteLambda { get; set; }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    [TerraformPropertyName("execution_role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ExecutionRoleArn { get; set; }

    /// <summary>
    /// The failure_retention_period attribute.
    /// </summary>
    [TerraformPropertyName("failure_retention_period")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? FailureRetentionPeriod { get; set; }

    /// <summary>
    /// The handler attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Handler is required")]
    [TerraformPropertyName("handler")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Handler { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The runtime_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeVersion is required")]
    [TerraformPropertyName("runtime_version")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RuntimeVersion { get; set; }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [TerraformPropertyName("s3_bucket")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? S3Bucket { get; set; }

    /// <summary>
    /// The s3_key attribute.
    /// </summary>
    [TerraformPropertyName("s3_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? S3Key { get; set; }

    /// <summary>
    /// The s3_version attribute.
    /// </summary>
    [TerraformPropertyName("s3_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? S3Version { get; set; }

    /// <summary>
    /// The start_canary attribute.
    /// </summary>
    [TerraformPropertyName("start_canary")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? StartCanary { get; set; }

    /// <summary>
    /// The success_retention_period attribute.
    /// </summary>
    [TerraformPropertyName("success_retention_period")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? SuccessRetentionPeriod { get; set; }

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
    /// The zip_file attribute.
    /// </summary>
    [TerraformPropertyName("zip_file")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ZipFile { get; set; }

    /// <summary>
    /// Block for artifact_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ArtifactConfig block(s) allowed")]
    [TerraformPropertyName("artifact_config")]
    public TerraformList<TerraformBlock<AwsSyntheticsCanaryArtifactConfigBlock>>? ArtifactConfig { get; set; } = new();

    /// <summary>
    /// Block for run_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RunConfig block(s) allowed")]
    [TerraformPropertyName("run_config")]
    public TerraformList<TerraformBlock<AwsSyntheticsCanaryRunConfigBlock>>? RunConfig { get; set; } = new();

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schedule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    [TerraformPropertyName("schedule")]
    public TerraformList<TerraformBlock<AwsSyntheticsCanaryScheduleBlock>>? Schedule { get; set; } = new();

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    [TerraformPropertyName("vpc_config")]
    public TerraformList<TerraformBlock<AwsSyntheticsCanaryVpcConfigBlock>>? VpcConfig { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The engine_arn attribute.
    /// </summary>
    [TerraformPropertyName("engine_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EngineArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "engine_arn");

    /// <summary>
    /// The source_location_arn attribute.
    /// </summary>
    [TerraformPropertyName("source_location_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceLocationArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_location_arn");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The timeline attribute.
    /// </summary>
    [TerraformPropertyName("timeline")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Timeline => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "timeline");

}
