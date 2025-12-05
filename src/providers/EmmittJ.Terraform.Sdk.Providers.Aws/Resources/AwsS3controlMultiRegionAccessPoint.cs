using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for details in AwsS3controlMultiRegionAccessPoint.
/// Nesting mode: list
/// </summary>
public class AwsS3controlMultiRegionAccessPointDetailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "details";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// PublicAccessBlock block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublicAccessBlock block(s) allowed")]
    public TerraformList<AwsS3controlMultiRegionAccessPointDetailsBlockPublicAccessBlockBlock>? PublicAccessBlock
    {
        get => GetArgument<TerraformList<AwsS3controlMultiRegionAccessPointDetailsBlockPublicAccessBlockBlock>>("public_access_block");
        set => SetArgument("public_access_block", value);
    }

    /// <summary>
    /// Region block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Region block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 Region block(s) allowed")]
    public required TerraformSet<AwsS3controlMultiRegionAccessPointDetailsBlockRegionBlock> Region
    {
        get => GetRequiredArgument<TerraformSet<AwsS3controlMultiRegionAccessPointDetailsBlockRegionBlock>>("region");
        set => SetArgument("region", value);
    }

}

/// <summary>
/// Block type for public_access_block in AwsS3controlMultiRegionAccessPointDetailsBlock.
/// Nesting mode: list
/// </summary>
public class AwsS3controlMultiRegionAccessPointDetailsBlockPublicAccessBlockBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "public_access_block";

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
/// Block type for region in AwsS3controlMultiRegionAccessPointDetailsBlock.
/// Nesting mode: set
/// </summary>
public class AwsS3controlMultiRegionAccessPointDetailsBlockRegionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "region";

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
    /// The bucket_account_id attribute.
    /// </summary>
    public TerraformValue<string> BucketAccountId
    {
        get => GetArgument<TerraformValue<string>>("bucket_account_id") ?? CreateReference("bucket_account_id");
        set => SetArgument("bucket_account_id", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformValue<string> Region
        => CreateReference("region");

}


/// <summary>
/// Block type for timeouts in AwsS3controlMultiRegionAccessPoint.
/// Nesting mode: single
/// </summary>
public class AwsS3controlMultiRegionAccessPointTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_s3control_multi_region_access_point Terraform resource.
/// Manages a aws_s3control_multi_region_access_point resource.
/// </summary>
public partial class AwsS3controlMultiRegionAccessPoint(string name) : TerraformResource("aws_s3control_multi_region_access_point", name)
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformValue<string> AccountId
    {
        get => GetArgument<TerraformValue<string>>("account_id") ?? CreateReference("account_id");
        set => SetArgument("account_id", value);
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
    /// The alias attribute.
    /// </summary>
    public TerraformValue<string> Alias
        => CreateReference("alias");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformValue<string> DomainName
        => CreateReference("domain_name");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => CreateReference("status");

    /// <summary>
    /// Details block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Details is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Details block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Details block(s) allowed")]
    public required TerraformList<AwsS3controlMultiRegionAccessPointDetailsBlock> Details
    {
        get => GetRequiredArgument<TerraformList<AwsS3controlMultiRegionAccessPointDetailsBlock>>("details");
        set => SetArgument("details", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsS3controlMultiRegionAccessPointTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsS3controlMultiRegionAccessPointTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
