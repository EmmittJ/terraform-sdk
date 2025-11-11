using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_glue_dev_endpoint resource.
/// </summary>
public class AwsGlueDevEndpoint : TerraformResource
{
    public AwsGlueDevEndpoint(string name) : base("aws_glue_dev_endpoint", name)
    {
    }

    /// <summary>
    /// The arguments attribute.
    /// </summary>
    [TerraformPropertyName("arguments")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Arguments { get; set; }

    /// <summary>
    /// The extra_jars_s3_path attribute.
    /// </summary>
    [TerraformPropertyName("extra_jars_s3_path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExtraJarsS3Path { get; set; }

    /// <summary>
    /// The extra_python_libs_s3_path attribute.
    /// </summary>
    [TerraformPropertyName("extra_python_libs_s3_path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExtraPythonLibsS3Path { get; set; }

    /// <summary>
    /// The glue_version attribute.
    /// </summary>
    [TerraformPropertyName("glue_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GlueVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The number_of_nodes attribute.
    /// </summary>
    [TerraformPropertyName("number_of_nodes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? NumberOfNodes { get; set; }

    /// <summary>
    /// The number_of_workers attribute.
    /// </summary>
    [TerraformPropertyName("number_of_workers")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? NumberOfWorkers { get; set; }

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [TerraformPropertyName("public_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PublicKey { get; set; }

    /// <summary>
    /// The public_keys attribute.
    /// </summary>
    [TerraformPropertyName("public_keys")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? PublicKeys { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The security_configuration attribute.
    /// </summary>
    [TerraformPropertyName("security_configuration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SecurityConfiguration { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SubnetId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The worker_type attribute.
    /// </summary>
    [TerraformPropertyName("worker_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? WorkerType { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AvailabilityZone => new TerraformReference(this, "availability_zone");

    /// <summary>
    /// The failure_reason attribute.
    /// </summary>
    [TerraformPropertyName("failure_reason")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> FailureReason => new TerraformReference(this, "failure_reason");

    /// <summary>
    /// The private_address attribute.
    /// </summary>
    [TerraformPropertyName("private_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrivateAddress => new TerraformReference(this, "private_address");

    /// <summary>
    /// The public_address attribute.
    /// </summary>
    [TerraformPropertyName("public_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PublicAddress => new TerraformReference(this, "public_address");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VpcId => new TerraformReference(this, "vpc_id");

    /// <summary>
    /// The yarn_endpoint_address attribute.
    /// </summary>
    [TerraformPropertyName("yarn_endpoint_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> YarnEndpointAddress => new TerraformReference(this, "yarn_endpoint_address");

    /// <summary>
    /// The zeppelin_remote_spark_interpreter_port attribute.
    /// </summary>
    [TerraformPropertyName("zeppelin_remote_spark_interpreter_port")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ZeppelinRemoteSparkInterpreterPort => new TerraformReference(this, "zeppelin_remote_spark_interpreter_port");

}
