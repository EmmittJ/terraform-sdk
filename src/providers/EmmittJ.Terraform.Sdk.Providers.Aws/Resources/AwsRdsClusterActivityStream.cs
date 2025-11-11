using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_rds_cluster_activity_stream resource.
/// </summary>
public partial class AwsRdsClusterActivityStream : TerraformResource
{
    public AwsRdsClusterActivityStream(string name) : base("aws_rds_cluster_activity_stream", name)
    {
    }

    /// <summary>
    /// The engine_native_audit_fields_included attribute.
    /// </summary>
    [TerraformProperty("engine_native_audit_fields_included")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EngineNativeAuditFieldsIncluded { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyId is required")]
    [TerraformProperty("kms_key_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KmsKeyId { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformProperty("mode")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Mode { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    [TerraformProperty("resource_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceArn { get; set; }

    /// <summary>
    /// The kinesis_stream_name attribute.
    /// </summary>
    [TerraformProperty("kinesis_stream_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> KinesisStreamName { get; }

}
