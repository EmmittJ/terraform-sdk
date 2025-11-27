using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for kms_server_side_encryption in AwsDevopsguruServiceIntegration.
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruServiceIntegrationKmsServerSideEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kms_server_side_encryption";

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The opt_in_status attribute.
    /// </summary>
    public TerraformValue<string> OptInStatus
    {
        get => new TerraformReference<string>(this, "opt_in_status");
        set => SetArgument("opt_in_status", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for logs_anomaly_detection in AwsDevopsguruServiceIntegration.
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruServiceIntegrationLogsAnomalyDetectionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logs_anomaly_detection";

    /// <summary>
    /// The opt_in_status attribute.
    /// </summary>
    public TerraformValue<string> OptInStatus
    {
        get => new TerraformReference<string>(this, "opt_in_status");
        set => SetArgument("opt_in_status", value);
    }

}


/// <summary>
/// Block type for ops_center in AwsDevopsguruServiceIntegration.
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruServiceIntegrationOpsCenterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ops_center";

    /// <summary>
    /// The opt_in_status attribute.
    /// </summary>
    public TerraformValue<string> OptInStatus
    {
        get => new TerraformReference<string>(this, "opt_in_status");
        set => SetArgument("opt_in_status", value);
    }

}


/// <summary>
/// Represents a aws_devopsguru_service_integration Terraform resource.
/// Manages a aws_devopsguru_service_integration resource.
/// </summary>
public partial class AwsDevopsguruServiceIntegration(string name) : TerraformResource("aws_devopsguru_service_integration", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// KmsServerSideEncryption block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsDevopsguruServiceIntegrationKmsServerSideEncryptionBlock>? KmsServerSideEncryption
    {
        get => GetArgument<TerraformList<AwsDevopsguruServiceIntegrationKmsServerSideEncryptionBlock>>("kms_server_side_encryption");
        set => SetArgument("kms_server_side_encryption", value);
    }

    /// <summary>
    /// LogsAnomalyDetection block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsDevopsguruServiceIntegrationLogsAnomalyDetectionBlock>? LogsAnomalyDetection
    {
        get => GetArgument<TerraformList<AwsDevopsguruServiceIntegrationLogsAnomalyDetectionBlock>>("logs_anomaly_detection");
        set => SetArgument("logs_anomaly_detection", value);
    }

    /// <summary>
    /// OpsCenter block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsDevopsguruServiceIntegrationOpsCenterBlock>? OpsCenter
    {
        get => GetArgument<TerraformList<AwsDevopsguruServiceIntegrationOpsCenterBlock>>("ops_center");
        set => SetArgument("ops_center", value);
    }

}
