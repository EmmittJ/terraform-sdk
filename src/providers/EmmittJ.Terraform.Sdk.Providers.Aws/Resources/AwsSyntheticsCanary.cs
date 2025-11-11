using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for artifact_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsSyntheticsCanaryArtifactConfigBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for run_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsSyntheticsCanaryRunConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The active_tracing attribute.
    /// </summary>
    [TerraformProperty("active_tracing")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ActiveTracing { get; set; }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    [TerraformProperty("environment_variables")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? EnvironmentVariables { get; set; }

    /// <summary>
    /// The ephemeral_storage attribute.
    /// </summary>
    [TerraformProperty("ephemeral_storage")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> EphemeralStorage { get; set; }

    /// <summary>
    /// The memory_in_mb attribute.
    /// </summary>
    [TerraformProperty("memory_in_mb")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MemoryInMb { get; set; }

    /// <summary>
    /// The timeout_in_seconds attribute.
    /// </summary>
    [TerraformProperty("timeout_in_seconds")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> TimeoutInSeconds { get; set; }

}

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public partial class AwsSyntheticsCanaryScheduleBlock : TerraformBlockBase
{
    /// <summary>
    /// The duration_in_seconds attribute.
    /// </summary>
    [TerraformProperty("duration_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DurationInSeconds { get; set; }

    /// <summary>
    /// The expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    [TerraformProperty("expression")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Expression { get; set; }

}

/// <summary>
/// Block type for vpc_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsSyntheticsCanaryVpcConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The ipv6_allowed_for_dual_stack attribute.
    /// </summary>
    [TerraformProperty("ipv6_allowed_for_dual_stack")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Ipv6AllowedForDualStack { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformProperty("subnet_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SubnetIds { get; set; }


}

/// <summary>
/// Manages a aws_synthetics_canary resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSyntheticsCanary : TerraformResource
{
    public AwsSyntheticsCanary(string name) : base("aws_synthetics_canary", name)
    {
    }

    /// <summary>
    /// The artifact_s3_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArtifactS3Location is required")]
    [TerraformProperty("artifact_s3_location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ArtifactS3Location { get; set; }

    /// <summary>
    /// The delete_lambda attribute.
    /// </summary>
    [TerraformProperty("delete_lambda")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeleteLambda { get; set; }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    [TerraformProperty("execution_role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ExecutionRoleArn { get; set; }

    /// <summary>
    /// The failure_retention_period attribute.
    /// </summary>
    [TerraformProperty("failure_retention_period")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? FailureRetentionPeriod { get; set; }

    /// <summary>
    /// The handler attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Handler is required")]
    [TerraformProperty("handler")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Handler { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The runtime_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuntimeVersion is required")]
    [TerraformProperty("runtime_version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RuntimeVersion { get; set; }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [TerraformProperty("s3_bucket")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? S3Bucket { get; set; }

    /// <summary>
    /// The s3_key attribute.
    /// </summary>
    [TerraformProperty("s3_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? S3Key { get; set; }

    /// <summary>
    /// The s3_version attribute.
    /// </summary>
    [TerraformProperty("s3_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? S3Version { get; set; }

    /// <summary>
    /// The start_canary attribute.
    /// </summary>
    [TerraformProperty("start_canary")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? StartCanary { get; set; }

    /// <summary>
    /// The success_retention_period attribute.
    /// </summary>
    [TerraformProperty("success_retention_period")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? SuccessRetentionPeriod { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The zip_file attribute.
    /// </summary>
    [TerraformProperty("zip_file")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ZipFile { get; set; }

    /// <summary>
    /// Block for artifact_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ArtifactConfig block(s) allowed")]
    [TerraformProperty("artifact_config")]
    public partial TerraformList<TerraformBlock<AwsSyntheticsCanaryArtifactConfigBlock>>? ArtifactConfig { get; set; }

    /// <summary>
    /// Block for run_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RunConfig block(s) allowed")]
    [TerraformProperty("run_config")]
    public partial TerraformList<TerraformBlock<AwsSyntheticsCanaryRunConfigBlock>>? RunConfig { get; set; }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Schedule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Schedule block(s) allowed")]
    [TerraformProperty("schedule")]
    public partial TerraformList<TerraformBlock<AwsSyntheticsCanaryScheduleBlock>>? Schedule { get; set; }

    /// <summary>
    /// Block for vpc_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfig block(s) allowed")]
    [TerraformProperty("vpc_config")]
    public partial TerraformList<TerraformBlock<AwsSyntheticsCanaryVpcConfigBlock>>? VpcConfig { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The engine_arn attribute.
    /// </summary>
    [TerraformProperty("engine_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> EngineArn { get; }

    /// <summary>
    /// The source_location_arn attribute.
    /// </summary>
    [TerraformProperty("source_location_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SourceLocationArn { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The timeline attribute.
    /// </summary>
    [TerraformProperty("timeline")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Timeline { get; }

}
