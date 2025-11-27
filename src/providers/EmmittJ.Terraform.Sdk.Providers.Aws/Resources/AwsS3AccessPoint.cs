using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for public_access_block_configuration in AwsS3AccessPoint.
/// Nesting mode: list
/// </summary>
public class AwsS3AccessPointPublicAccessBlockConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "public_access_block_configuration";

    /// <summary>
    /// The block_public_acls attribute.
    /// </summary>
    public TerraformValue<bool>? BlockPublicAcls
    {
        get => new TerraformReference<bool>(this, "block_public_acls");
        set => SetArgument("block_public_acls", value);
    }

    /// <summary>
    /// The block_public_policy attribute.
    /// </summary>
    public TerraformValue<bool>? BlockPublicPolicy
    {
        get => new TerraformReference<bool>(this, "block_public_policy");
        set => SetArgument("block_public_policy", value);
    }

    /// <summary>
    /// The ignore_public_acls attribute.
    /// </summary>
    public TerraformValue<bool>? IgnorePublicAcls
    {
        get => new TerraformReference<bool>(this, "ignore_public_acls");
        set => SetArgument("ignore_public_acls", value);
    }

    /// <summary>
    /// The restrict_public_buckets attribute.
    /// </summary>
    public TerraformValue<bool>? RestrictPublicBuckets
    {
        get => new TerraformReference<bool>(this, "restrict_public_buckets");
        set => SetArgument("restrict_public_buckets", value);
    }

}


/// <summary>
/// Block type for vpc_configuration in AwsS3AccessPoint.
/// Nesting mode: list
/// </summary>
public class AwsS3AccessPointVpcConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vpc_configuration";

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    public required TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
        set => SetArgument("vpc_id", value);
    }

}


/// <summary>
/// Represents a aws_s3_access_point Terraform resource.
/// Manages a aws_s3_access_point resource.
/// </summary>
public partial class AwsS3AccessPoint(string name) : TerraformResource("aws_s3_access_point", name)
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformValue<string> AccountId
    {
        get => new TerraformReference<string>(this, "account_id");
        set => SetArgument("account_id", value);
    }

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
    /// The bucket_account_id attribute.
    /// </summary>
    public TerraformValue<string> BucketAccountId
    {
        get => new TerraformReference<string>(this, "bucket_account_id");
        set => SetArgument("bucket_account_id", value);
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
    /// The policy attribute.
    /// </summary>
    public TerraformValue<string> Policy
    {
        get => new TerraformReference<string>(this, "policy");
        set => SetArgument("policy", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    public TerraformValue<string> Alias
    {
        get => new TerraformReference<string>(this, "alias");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformValue<string> DomainName
    {
        get => new TerraformReference<string>(this, "domain_name");
    }

    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    public TerraformMap<string> Endpoints
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "endpoints").ResolveNodes(ctx));
    }

    /// <summary>
    /// The has_public_access_policy attribute.
    /// </summary>
    public TerraformValue<bool> HasPublicAccessPolicy
    {
        get => new TerraformReference<bool>(this, "has_public_access_policy");
    }

    /// <summary>
    /// The network_origin attribute.
    /// </summary>
    public TerraformValue<string> NetworkOrigin
    {
        get => new TerraformReference<string>(this, "network_origin");
    }

    /// <summary>
    /// PublicAccessBlockConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublicAccessBlockConfiguration block(s) allowed")]
    public TerraformList<AwsS3AccessPointPublicAccessBlockConfigurationBlock>? PublicAccessBlockConfiguration
    {
        get => GetArgument<TerraformList<AwsS3AccessPointPublicAccessBlockConfigurationBlock>>("public_access_block_configuration");
        set => SetArgument("public_access_block_configuration", value);
    }

    /// <summary>
    /// VpcConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfiguration block(s) allowed")]
    public TerraformList<AwsS3AccessPointVpcConfigurationBlock>? VpcConfiguration
    {
        get => GetArgument<TerraformList<AwsS3AccessPointVpcConfigurationBlock>>("vpc_configuration");
        set => SetArgument("vpc_configuration", value);
    }

}
