using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_rds_cluster_activity_stream Terraform resource.
/// Manages a aws_rds_cluster_activity_stream resource.
/// </summary>
public partial class AwsRdsClusterActivityStream(string name) : TerraformResource("aws_rds_cluster_activity_stream", name)
{
    /// <summary>
    /// The engine_native_audit_fields_included attribute.
    /// </summary>
    public TerraformValue<bool>? EngineNativeAuditFieldsIncluded
    {
        get => new TerraformReference<bool>(this, "engine_native_audit_fields_included");
        set => SetArgument("engine_native_audit_fields_included", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyId is required")]
    public required TerraformValue<string> KmsKeyId
    {
        get => new TerraformReference<string>(this, "kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    public required TerraformValue<string> Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    public required TerraformValue<string> ResourceArn
    {
        get => new TerraformReference<string>(this, "resource_arn");
        set => SetArgument("resource_arn", value);
    }

    /// <summary>
    /// The kinesis_stream_name attribute.
    /// </summary>
    public TerraformValue<string> KinesisStreamName
    {
        get => new TerraformReference<string>(this, "kinesis_stream_name");
    }

}
