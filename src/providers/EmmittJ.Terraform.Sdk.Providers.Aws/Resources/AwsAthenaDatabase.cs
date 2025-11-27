using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for acl_configuration in AwsAthenaDatabase.
/// Nesting mode: list
/// </summary>
public class AwsAthenaDatabaseAclConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "acl_configuration";

    /// <summary>
    /// The s3_acl_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3AclOption is required")]
    public required TerraformValue<string> S3AclOption
    {
        get => new TerraformReference<string>(this, "s3_acl_option");
        set => SetArgument("s3_acl_option", value);
    }

}


/// <summary>
/// Block type for encryption_configuration in AwsAthenaDatabase.
/// Nesting mode: list
/// </summary>
public class AwsAthenaDatabaseEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_configuration";

    /// <summary>
    /// The encryption_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EncryptionOption is required")]
    public required TerraformValue<string> EncryptionOption
    {
        get => new TerraformReference<string>(this, "encryption_option");
        set => SetArgument("encryption_option", value);
    }

    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    public TerraformValue<string>? KmsKey
    {
        get => new TerraformReference<string>(this, "kms_key");
        set => SetArgument("kms_key", value);
    }

}


/// <summary>
/// Represents a aws_athena_database Terraform resource.
/// Manages a aws_athena_database resource.
/// </summary>
public partial class AwsAthenaDatabase(string name) : TerraformResource("aws_athena_database", name)
{
    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public TerraformValue<string>? Bucket
    {
        get => new TerraformReference<string>(this, "bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The comment attribute.
    /// </summary>
    public TerraformValue<string>? Comment
    {
        get => new TerraformReference<string>(this, "comment");
        set => SetArgument("comment", value);
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
    /// The force_destroy attribute.
    /// </summary>
    public TerraformValue<bool>? ForceDestroy
    {
        get => new TerraformReference<bool>(this, "force_destroy");
        set => SetArgument("force_destroy", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    public TerraformMap<string>? Properties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "properties").ResolveNodes(ctx));
        set => SetArgument("properties", value);
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
    /// The workgroup attribute.
    /// </summary>
    public TerraformValue<string>? Workgroup
    {
        get => new TerraformReference<string>(this, "workgroup");
        set => SetArgument("workgroup", value);
    }

    /// <summary>
    /// AclConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AclConfiguration block(s) allowed")]
    public TerraformList<AwsAthenaDatabaseAclConfigurationBlock>? AclConfiguration
    {
        get => GetArgument<TerraformList<AwsAthenaDatabaseAclConfigurationBlock>>("acl_configuration");
        set => SetArgument("acl_configuration", value);
    }

    /// <summary>
    /// EncryptionConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    public TerraformList<AwsAthenaDatabaseEncryptionConfigurationBlock>? EncryptionConfiguration
    {
        get => GetArgument<TerraformList<AwsAthenaDatabaseEncryptionConfigurationBlock>>("encryption_configuration");
        set => SetArgument("encryption_configuration", value);
    }

}
