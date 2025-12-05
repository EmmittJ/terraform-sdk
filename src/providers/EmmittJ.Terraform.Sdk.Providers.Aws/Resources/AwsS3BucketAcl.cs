using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_control_policy in AwsS3BucketAcl.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketAclAccessControlPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_control_policy";

    /// <summary>
    /// Grant block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsS3BucketAclAccessControlPolicyBlockGrantBlock>? Grant
    {
        get => GetArgument<TerraformSet<AwsS3BucketAclAccessControlPolicyBlockGrantBlock>>("grant");
        set => SetArgument("grant", value);
    }

    /// <summary>
    /// Owner block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Owner is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Owner block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Owner block(s) allowed")]
    public required TerraformList<AwsS3BucketAclAccessControlPolicyBlockOwnerBlock> Owner
    {
        get => GetRequiredArgument<TerraformList<AwsS3BucketAclAccessControlPolicyBlockOwnerBlock>>("owner");
        set => SetArgument("owner", value);
    }

}

/// <summary>
/// Block type for grant in AwsS3BucketAclAccessControlPolicyBlock.
/// Nesting mode: set
/// </summary>
public class AwsS3BucketAclAccessControlPolicyBlockGrantBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grant";

    /// <summary>
    /// The permission attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permission is required")]
    public required TerraformValue<string> Permission
    {
        get => GetRequiredArgument<TerraformValue<string>>("permission");
        set => SetArgument("permission", value);
    }

    /// <summary>
    /// Grantee block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Grantee block(s) allowed")]
    public TerraformList<AwsS3BucketAclAccessControlPolicyBlockGrantBlockGranteeBlock>? Grantee
    {
        get => GetArgument<TerraformList<AwsS3BucketAclAccessControlPolicyBlockGrantBlockGranteeBlock>>("grantee");
        set => SetArgument("grantee", value);
    }

}

/// <summary>
/// Block type for grantee in AwsS3BucketAclAccessControlPolicyBlockGrantBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketAclAccessControlPolicyBlockGrantBlockGranteeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grantee";

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> DisplayName
        => CreateReference("display_name");

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    public TerraformValue<string>? EmailAddress
    {
        get => GetArgument<TerraformValue<string>>("email_address");
        set => SetArgument("email_address", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformValue<string>? Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for owner in AwsS3BucketAclAccessControlPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3BucketAclAccessControlPolicyBlockOwnerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "owner";

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name") ?? CreateReference("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetRequiredArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

}


/// <summary>
/// Represents a aws_s3_bucket_acl Terraform resource.
/// Manages a aws_s3_bucket_acl resource.
/// </summary>
public partial class AwsS3BucketAcl(string name) : TerraformResource("aws_s3_bucket_acl", name)
{
    /// <summary>
    /// The acl attribute.
    /// </summary>
    public TerraformValue<string>? Acl
    {
        get => GetArgument<TerraformValue<string>>("acl");
        set => SetArgument("acl", value);
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    public TerraformValue<string>? ExpectedBucketOwner
    {
        get => GetArgument<TerraformValue<string>>("expected_bucket_owner");
        set => SetArgument("expected_bucket_owner", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// AccessControlPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessControlPolicy block(s) allowed")]
    public TerraformList<AwsS3BucketAclAccessControlPolicyBlock>? AccessControlPolicy
    {
        get => GetArgument<TerraformList<AwsS3BucketAclAccessControlPolicyBlock>>("access_control_policy");
        set => SetArgument("access_control_policy", value);
    }

}
