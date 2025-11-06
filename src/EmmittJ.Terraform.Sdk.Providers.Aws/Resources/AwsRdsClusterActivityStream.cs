using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_rds_cluster_activity_stream resource.
/// </summary>
public class AwsRdsClusterActivityStream : TerraformResource
{
    public AwsRdsClusterActivityStream(string name) : base("aws_rds_cluster_activity_stream", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("kinesis_stream_name");
    }

    /// <summary>
    /// The engine_native_audit_fields_included attribute.
    /// </summary>
    public bool? EngineNativeAuditFieldsIncluded
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("engine_native_audit_fields_included")?.Value;
        set => this.WithProperty("engine_native_audit_fields_included", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public string? KmsKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kms_key_id")?.Value;
        set => this.WithProperty("kms_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public string? Mode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("mode")?.Value;
        set => this.WithProperty("mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public string? ResourceArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_arn")?.Value;
        set => this.WithProperty("resource_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kinesis_stream_name attribute.
    /// </summary>
    public TerraformExpression KinesisStreamName => this["kinesis_stream_name"];

}
