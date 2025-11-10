using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for kms_server_side_encryption in .
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruServiceIntegrationKmsServerSideEncryptionBlock : ITerraformBlock
{
    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> KmsKeyId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "kms_key_id");

    /// <summary>
    /// The opt_in_status attribute.
    /// </summary>
    [TerraformPropertyName("opt_in_status")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OptInStatus { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "opt_in_status");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Type { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "type");

}

/// <summary>
/// Block type for logs_anomaly_detection in .
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruServiceIntegrationLogsAnomalyDetectionBlock : ITerraformBlock
{
    /// <summary>
    /// The opt_in_status attribute.
    /// </summary>
    [TerraformPropertyName("opt_in_status")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OptInStatus { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "opt_in_status");

}

/// <summary>
/// Block type for ops_center in .
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruServiceIntegrationOpsCenterBlock : ITerraformBlock
{
    /// <summary>
    /// The opt_in_status attribute.
    /// </summary>
    [TerraformPropertyName("opt_in_status")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> OptInStatus { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "opt_in_status");

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for kms_server_side_encryption.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("kms_server_side_encryption")]
    public TerraformList<TerraformBlock<AwsDevopsguruServiceIntegrationKmsServerSideEncryptionBlock>>? KmsServerSideEncryption { get; set; } = new();

    /// <summary>
    /// Block for logs_anomaly_detection.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("logs_anomaly_detection")]
    public TerraformList<TerraformBlock<AwsDevopsguruServiceIntegrationLogsAnomalyDetectionBlock>>? LogsAnomalyDetection { get; set; } = new();

    /// <summary>
    /// Block for ops_center.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("ops_center")]
    public TerraformList<TerraformBlock<AwsDevopsguruServiceIntegrationOpsCenterBlock>>? OpsCenter { get; set; } = new();

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

}
