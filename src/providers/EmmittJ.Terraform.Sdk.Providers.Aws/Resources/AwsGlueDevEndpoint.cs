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
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Arguments { get; set; }

    /// <summary>
    /// The extra_jars_s3_path attribute.
    /// </summary>
    [TerraformPropertyName("extra_jars_s3_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExtraJarsS3Path { get; set; }

    /// <summary>
    /// The extra_python_libs_s3_path attribute.
    /// </summary>
    [TerraformPropertyName("extra_python_libs_s3_path")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExtraPythonLibsS3Path { get; set; }

    /// <summary>
    /// The glue_version attribute.
    /// </summary>
    [TerraformPropertyName("glue_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GlueVersion { get; set; }

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
    /// The number_of_nodes attribute.
    /// </summary>
    [TerraformPropertyName("number_of_nodes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? NumberOfNodes { get; set; }

    /// <summary>
    /// The number_of_workers attribute.
    /// </summary>
    [TerraformPropertyName("number_of_workers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? NumberOfWorkers { get; set; }

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [TerraformPropertyName("public_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PublicKey { get; set; }

    /// <summary>
    /// The public_keys attribute.
    /// </summary>
    [TerraformPropertyName("public_keys")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? PublicKeys { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The security_configuration attribute.
    /// </summary>
    [TerraformPropertyName("security_configuration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SecurityConfiguration { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SubnetId { get; set; }

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
    /// The worker_type attribute.
    /// </summary>
    [TerraformPropertyName("worker_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WorkerType { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AvailabilityZone => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone");

    /// <summary>
    /// The failure_reason attribute.
    /// </summary>
    [TerraformPropertyName("failure_reason")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FailureReason => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "failure_reason");

    /// <summary>
    /// The private_address attribute.
    /// </summary>
    [TerraformPropertyName("private_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_address");

    /// <summary>
    /// The public_address attribute.
    /// </summary>
    [TerraformPropertyName("public_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PublicAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "public_address");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformPropertyName("vpc_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VpcId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vpc_id");

    /// <summary>
    /// The yarn_endpoint_address attribute.
    /// </summary>
    [TerraformPropertyName("yarn_endpoint_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> YarnEndpointAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "yarn_endpoint_address");

    /// <summary>
    /// The zeppelin_remote_spark_interpreter_port attribute.
    /// </summary>
    [TerraformPropertyName("zeppelin_remote_spark_interpreter_port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> ZeppelinRemoteSparkInterpreterPort => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "zeppelin_remote_spark_interpreter_port");

}
