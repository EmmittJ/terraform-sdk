using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for s3_config in AwsDatasyncLocationS3.
/// Nesting mode: list
/// </summary>
public class AwsDatasyncLocationS3S3ConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_config";

    /// <summary>
    /// The bucket_access_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketAccessRoleArn is required")]
    public required TerraformValue<string> BucketAccessRoleArn
    {
        get => new TerraformReference<string>(this, "bucket_access_role_arn");
        set => SetArgument("bucket_access_role_arn", value);
    }

}


/// <summary>
/// Represents a aws_datasync_location_s3 Terraform resource.
/// Manages a aws_datasync_location_s3 resource.
/// </summary>
public partial class AwsDatasyncLocationS3(string name) : TerraformResource("aws_datasync_location_s3", name)
{
    /// <summary>
    /// The agent_arns attribute.
    /// </summary>
    public TerraformSet<string>? AgentArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "agent_arns").ResolveNodes(ctx));
        set => SetArgument("agent_arns", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The s3_bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3BucketArn is required")]
    public required TerraformValue<string> S3BucketArn
    {
        get => new TerraformReference<string>(this, "s3_bucket_arn");
        set => SetArgument("s3_bucket_arn", value);
    }

    /// <summary>
    /// The s3_storage_class attribute.
    /// </summary>
    public TerraformValue<string> S3StorageClass
    {
        get => new TerraformReference<string>(this, "s3_storage_class");
        set => SetArgument("s3_storage_class", value);
    }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Subdirectory is required")]
    public required TerraformValue<string> Subdirectory
    {
        get => new TerraformReference<string>(this, "subdirectory");
        set => SetArgument("subdirectory", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformValue<string> Uri
    {
        get => new TerraformReference<string>(this, "uri");
    }

    /// <summary>
    /// S3Config block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Config is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3Config block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Config block(s) allowed")]
    public required TerraformList<AwsDatasyncLocationS3S3ConfigBlock> S3Config
    {
        get => GetRequiredArgument<TerraformList<AwsDatasyncLocationS3S3ConfigBlock>>("s3_config");
        set => SetArgument("s3_config", value);
    }

}
