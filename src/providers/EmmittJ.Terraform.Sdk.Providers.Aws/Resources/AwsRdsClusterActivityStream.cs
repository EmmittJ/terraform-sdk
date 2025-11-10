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
        SetOutput("kinesis_stream_name");
        SetOutput("engine_native_audit_fields_included");
        SetOutput("id");
        SetOutput("kms_key_id");
        SetOutput("mode");
        SetOutput("region");
        SetOutput("resource_arn");
    }

    /// <summary>
    /// The engine_native_audit_fields_included attribute.
    /// </summary>
    public TerraformProperty<bool> EngineNativeAuditFieldsIncluded
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("engine_native_audit_fields_included");
        set => SetProperty("engine_native_audit_fields_included", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyId is required")]
    public required TerraformProperty<string> KmsKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_id");
        set => SetProperty("kms_key_id", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformProperty<string> Mode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("mode");
        set => SetProperty("mode", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    public required TerraformProperty<string> ResourceArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_arn");
        set => SetProperty("resource_arn", value);
    }

    /// <summary>
    /// The kinesis_stream_name attribute.
    /// </summary>
    public TerraformExpression KinesisStreamName => this["kinesis_stream_name"];

}
