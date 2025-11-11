using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_glue_dev_endpoint resource.
/// </summary>
public partial class AwsGlueDevEndpoint : TerraformResource
{
    public AwsGlueDevEndpoint(string name) : base("aws_glue_dev_endpoint", name)
    {
    }

    /// <summary>
    /// The arguments attribute.
    /// </summary>
    [TerraformProperty("arguments")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Arguments { get; set; }

    /// <summary>
    /// The extra_jars_s3_path attribute.
    /// </summary>
    [TerraformProperty("extra_jars_s3_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExtraJarsS3Path { get; set; }

    /// <summary>
    /// The extra_python_libs_s3_path attribute.
    /// </summary>
    [TerraformProperty("extra_python_libs_s3_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExtraPythonLibsS3Path { get; set; }

    /// <summary>
    /// The glue_version attribute.
    /// </summary>
    [TerraformProperty("glue_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GlueVersion { get; set; }

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
    /// The number_of_nodes attribute.
    /// </summary>
    [TerraformProperty("number_of_nodes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? NumberOfNodes { get; set; }

    /// <summary>
    /// The number_of_workers attribute.
    /// </summary>
    [TerraformProperty("number_of_workers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? NumberOfWorkers { get; set; }

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [TerraformProperty("public_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PublicKey { get; set; }

    /// <summary>
    /// The public_keys attribute.
    /// </summary>
    [TerraformProperty("public_keys")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? PublicKeys { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The security_configuration attribute.
    /// </summary>
    [TerraformProperty("security_configuration")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecurityConfiguration { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformProperty("subnet_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SubnetId { get; set; }

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
    /// The worker_type attribute.
    /// </summary>
    [TerraformProperty("worker_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WorkerType { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformProperty("availability_zone")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AvailabilityZone { get; }

    /// <summary>
    /// The failure_reason attribute.
    /// </summary>
    [TerraformProperty("failure_reason")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FailureReason { get; }

    /// <summary>
    /// The private_address attribute.
    /// </summary>
    [TerraformProperty("private_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrivateAddress { get; }

    /// <summary>
    /// The public_address attribute.
    /// </summary>
    [TerraformProperty("public_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PublicAddress { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [TerraformProperty("vpc_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VpcId { get; }

    /// <summary>
    /// The yarn_endpoint_address attribute.
    /// </summary>
    [TerraformProperty("yarn_endpoint_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> YarnEndpointAddress { get; }

    /// <summary>
    /// The zeppelin_remote_spark_interpreter_port attribute.
    /// </summary>
    [TerraformProperty("zeppelin_remote_spark_interpreter_port")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ZeppelinRemoteSparkInterpreterPort { get; }

}
