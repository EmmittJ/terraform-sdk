using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_rds_cluster_activity_stream resource.
/// </summary>
public class AwsRdsClusterActivityStream : TerraformResource
{
    public AwsRdsClusterActivityStream(string name) : base("aws_rds_cluster_activity_stream", name)
    {
    }

    /// <summary>
    /// The engine_native_audit_fields_included attribute.
    /// </summary>
    [TerraformPropertyName("engine_native_audit_fields_included")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? EngineNativeAuditFieldsIncluded { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyId is required")]
    [TerraformPropertyName("kms_key_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KmsKeyId { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformPropertyName("mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Mode { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    [TerraformPropertyName("resource_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceArn { get; set; }

    /// <summary>
    /// The kinesis_stream_name attribute.
    /// </summary>
    [TerraformPropertyName("kinesis_stream_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> KinesisStreamName => new TerraformReference(this, "kinesis_stream_name");

}
