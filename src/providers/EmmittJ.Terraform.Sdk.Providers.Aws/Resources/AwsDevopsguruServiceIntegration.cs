using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for kms_server_side_encryption in .
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruServiceIntegrationKmsServerSideEncryptionBlock
{
    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> KmsKeyId { get; set; } = default!;

    /// <summary>
    /// The opt_in_status attribute.
    /// </summary>
    [TerraformPropertyName("opt_in_status")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> OptInStatus { get; set; } = default!;

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Type { get; set; } = default!;

}

/// <summary>
/// Block type for logs_anomaly_detection in .
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruServiceIntegrationLogsAnomalyDetectionBlock
{
    /// <summary>
    /// The opt_in_status attribute.
    /// </summary>
    [TerraformPropertyName("opt_in_status")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> OptInStatus { get; set; } = default!;

}

/// <summary>
/// Block type for ops_center in .
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruServiceIntegrationOpsCenterBlock
{
    /// <summary>
    /// The opt_in_status attribute.
    /// </summary>
    [TerraformPropertyName("opt_in_status")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> OptInStatus { get; set; } = default!;

}

/// <summary>
/// Manages a aws_devopsguru_service_integration resource.
/// </summary>
public class AwsDevopsguruServiceIntegration : TerraformResource
{
    public AwsDevopsguruServiceIntegration(string name) : base("aws_devopsguru_service_integration", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for kms_server_side_encryption.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("kms_server_side_encryption")]
    public TerraformList<TerraformBlock<AwsDevopsguruServiceIntegrationKmsServerSideEncryptionBlock>>? KmsServerSideEncryption { get; set; }

    /// <summary>
    /// Block for logs_anomaly_detection.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("logs_anomaly_detection")]
    public TerraformList<TerraformBlock<AwsDevopsguruServiceIntegrationLogsAnomalyDetectionBlock>>? LogsAnomalyDetection { get; set; }

    /// <summary>
    /// Block for ops_center.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("ops_center")]
    public TerraformList<TerraformBlock<AwsDevopsguruServiceIntegrationOpsCenterBlock>>? OpsCenter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

}
