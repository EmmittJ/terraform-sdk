using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsLbTrustStoreRevocation.
/// Nesting mode: single
/// </summary>
public class AwsLbTrustStoreRevocationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

}


/// <summary>
/// Represents a aws_lb_trust_store_revocation Terraform resource.
/// Manages a aws_lb_trust_store_revocation resource.
/// </summary>
public partial class AwsLbTrustStoreRevocation(string name) : TerraformResource("aws_lb_trust_store_revocation", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The revocations_s3_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RevocationsS3Bucket is required")]
    public required TerraformValue<string> RevocationsS3Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("revocations_s3_bucket");
        set => SetArgument("revocations_s3_bucket", value);
    }

    /// <summary>
    /// The revocations_s3_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RevocationsS3Key is required")]
    public required TerraformValue<string> RevocationsS3Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("revocations_s3_key");
        set => SetArgument("revocations_s3_key", value);
    }

    /// <summary>
    /// The revocations_s3_object_version attribute.
    /// </summary>
    public TerraformValue<string>? RevocationsS3ObjectVersion
    {
        get => GetArgument<TerraformValue<string>>("revocations_s3_object_version");
        set => SetArgument("revocations_s3_object_version", value);
    }

    /// <summary>
    /// The trust_store_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustStoreArn is required")]
    public required TerraformValue<string> TrustStoreArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("trust_store_arn");
        set => SetArgument("trust_store_arn", value);
    }

    /// <summary>
    /// The revocation_id attribute.
    /// </summary>
    public TerraformValue<double> RevocationId
        => AsReference("revocation_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsLbTrustStoreRevocationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsLbTrustStoreRevocationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
