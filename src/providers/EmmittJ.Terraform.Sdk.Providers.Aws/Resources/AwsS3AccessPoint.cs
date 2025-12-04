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
        get => GetArgument<TerraformValue<bool>>("block_public_acls");
        set => SetArgument("block_public_acls", value);
    }

    /// <summary>
    /// The block_public_policy attribute.
    /// </summary>
    public TerraformValue<bool>? BlockPublicPolicy
    {
        get => GetArgument<TerraformValue<bool>>("block_public_policy");
        set => SetArgument("block_public_policy", value);
    }

    /// <summary>
    /// The ignore_public_acls attribute.
    /// </summary>
    public TerraformValue<bool>? IgnorePublicAcls
    {
        get => GetArgument<TerraformValue<bool>>("ignore_public_acls");
        set => SetArgument("ignore_public_acls", value);
    }

    /// <summary>
    /// The restrict_public_buckets attribute.
    /// </summary>
    public TerraformValue<bool>? RestrictPublicBuckets
    {
        get => GetArgument<TerraformValue<bool>>("restrict_public_buckets");
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
        get => GetArgument<TerraformValue<string>>("vpc_id");
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
    public TerraformValue<string>? AccountId
    {
        get => GetArgument<TerraformValue<string>>("account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformValue<string> Bucket
    {
        get => GetArgument<TerraformValue<string>>("bucket");
        set => SetArgument("bucket", value);
    }

    /// <summary>
    /// The bucket_account_id attribute.
    /// </summary>
    public TerraformValue<string>? BucketAccountId
    {
        get => GetArgument<TerraformValue<string>>("bucket_account_id");
        set => SetArgument("bucket_account_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformValue<string>? Policy
    {
        get => GetArgument<TerraformValue<string>>("policy");
        set => SetArgument("policy", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    public TerraformValue<string> Alias
        => AsReference("alias");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformValue<string> DomainName
        => AsReference("domain_name");

    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    public TerraformMap<string> Endpoints
        => AsReference("endpoints");

    /// <summary>
    /// The has_public_access_policy attribute.
    /// </summary>
    public TerraformValue<bool> HasPublicAccessPolicy
        => AsReference("has_public_access_policy");

    /// <summary>
    /// The network_origin attribute.
    /// </summary>
    public TerraformValue<string> NetworkOrigin
        => AsReference("network_origin");

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
