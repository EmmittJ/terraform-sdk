using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for kms_server_side_encryption in .
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruServiceIntegrationKmsServerSideEncryptionBlock : TerraformBlock
{
    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The opt_in_status attribute.
    /// </summary>
    public TerraformProperty<string>? OptInStatus
    {
        get => GetProperty<TerraformProperty<string>>("opt_in_status");
        set => WithProperty("opt_in_status", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for logs_anomaly_detection in .
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruServiceIntegrationLogsAnomalyDetectionBlock : TerraformBlock
{
    /// <summary>
    /// The opt_in_status attribute.
    /// </summary>
    public TerraformProperty<string>? OptInStatus
    {
        get => GetProperty<TerraformProperty<string>>("opt_in_status");
        set => WithProperty("opt_in_status", value);
    }

}

/// <summary>
/// Block type for ops_center in .
/// Nesting mode: list
/// </summary>
public class AwsDevopsguruServiceIntegrationOpsCenterBlock : TerraformBlock
{
    /// <summary>
    /// The opt_in_status attribute.
    /// </summary>
    public TerraformProperty<string>? OptInStatus
    {
        get => GetProperty<TerraformProperty<string>>("opt_in_status");
        set => WithProperty("opt_in_status", value);
    }

}

/// <summary>
/// Manages a aws_devopsguru_service_integration resource.
/// </summary>
public class AwsDevopsguruServiceIntegration : TerraformResource
{
    public AwsDevopsguruServiceIntegration(string name) : base("aws_devopsguru_service_integration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for kms_server_side_encryption.
    /// Nesting mode: list
    /// </summary>
    public List<AwsDevopsguruServiceIntegrationKmsServerSideEncryptionBlock>? KmsServerSideEncryption
    {
        get => GetProperty<List<AwsDevopsguruServiceIntegrationKmsServerSideEncryptionBlock>>("kms_server_side_encryption");
        set => this.WithProperty("kms_server_side_encryption", value);
    }

    /// <summary>
    /// Block for logs_anomaly_detection.
    /// Nesting mode: list
    /// </summary>
    public List<AwsDevopsguruServiceIntegrationLogsAnomalyDetectionBlock>? LogsAnomalyDetection
    {
        get => GetProperty<List<AwsDevopsguruServiceIntegrationLogsAnomalyDetectionBlock>>("logs_anomaly_detection");
        set => this.WithProperty("logs_anomaly_detection", value);
    }

    /// <summary>
    /// Block for ops_center.
    /// Nesting mode: list
    /// </summary>
    public List<AwsDevopsguruServiceIntegrationOpsCenterBlock>? OpsCenter
    {
        get => GetProperty<List<AwsDevopsguruServiceIntegrationOpsCenterBlock>>("ops_center");
        set => this.WithProperty("ops_center", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
