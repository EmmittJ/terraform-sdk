using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for versioning_configuration in AwsS3BucketVersioning.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketVersioningVersioningConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "versioning_configuration";

    /// <summary>
    /// The mfa_delete attribute.
    /// </summary>
    public TerraformValue<string> MfaDelete
    {
        get => new TerraformReference<string>(this, "mfa_delete");
        set => SetArgument("mfa_delete", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Status is required")]
    public required TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

}


/// <summary>
/// Represents a aws_s3_bucket_versioning Terraform resource.
/// Manages a aws_s3_bucket_versioning resource.
/// </summary>
public partial class AwsS3BucketVersioning(string name) : TerraformResource("aws_s3_bucket_versioning", name)
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    public TerraformValue<string>? ExpectedBucketOwner
    {
        get => new TerraformReference<string>(this, "expected_bucket_owner");
        set => SetArgument("expected_bucket_owner", value);
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
    /// The mfa attribute.
    /// </summary>
    public TerraformValue<string>? Mfa
    {
        get => new TerraformReference<string>(this, "mfa");
        set => SetArgument("mfa", value);
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
    /// VersioningConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VersioningConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VersioningConfiguration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VersioningConfiguration block(s) allowed")]
    public required TerraformList<AwsS3BucketVersioningVersioningConfigurationBlock> VersioningConfiguration
    {
        get => GetRequiredArgument<TerraformList<AwsS3BucketVersioningVersioningConfigurationBlock>>("versioning_configuration");
        set => SetArgument("versioning_configuration", value);
    }

}
