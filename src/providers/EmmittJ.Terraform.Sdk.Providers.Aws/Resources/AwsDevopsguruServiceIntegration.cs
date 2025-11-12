using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for kms_server_side_encryption in .
/// Nesting mode: list
/// </summary>
public partial class AwsDevopsguruServiceIntegrationKmsServerSideEncryptionBlock() : TerraformBlock("kms_server_side_encryption")
{
    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KmsKeyId { get; set; }

    /// <summary>
    /// The opt_in_status attribute.
    /// </summary>
    [TerraformProperty("opt_in_status")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> OptInStatus { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for logs_anomaly_detection in .
/// Nesting mode: list
/// </summary>
public partial class AwsDevopsguruServiceIntegrationLogsAnomalyDetectionBlock() : TerraformBlock("logs_anomaly_detection")
{
    /// <summary>
    /// The opt_in_status attribute.
    /// </summary>
    [TerraformProperty("opt_in_status")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> OptInStatus { get; set; }

}

/// <summary>
/// Block type for ops_center in .
/// Nesting mode: list
/// </summary>
public partial class AwsDevopsguruServiceIntegrationOpsCenterBlock() : TerraformBlock("ops_center")
{
    /// <summary>
    /// The opt_in_status attribute.
    /// </summary>
    [TerraformProperty("opt_in_status")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> OptInStatus { get; set; }

}

/// <summary>
/// Manages a aws_devopsguru_service_integration resource.
/// </summary>
public partial class AwsDevopsguruServiceIntegration : TerraformResource
{
    public AwsDevopsguruServiceIntegration(string name) : base("aws_devopsguru_service_integration", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for kms_server_side_encryption.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("kms_server_side_encryption")]
    public TerraformList<AwsDevopsguruServiceIntegrationKmsServerSideEncryptionBlock> KmsServerSideEncryption { get; set; } = new();

    /// <summary>
    /// Block for logs_anomaly_detection.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("logs_anomaly_detection")]
    public TerraformList<AwsDevopsguruServiceIntegrationLogsAnomalyDetectionBlock> LogsAnomalyDetection { get; set; } = new();

    /// <summary>
    /// Block for ops_center.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("ops_center")]
    public TerraformList<AwsDevopsguruServiceIntegrationOpsCenterBlock> OpsCenter { get; set; } = new();

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

}
