using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for kms_key_details in AwsCodegurureviewerRepositoryAssociation.
/// Nesting mode: list
/// </summary>
public class AwsCodegurureviewerRepositoryAssociationKmsKeyDetailsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "kms_key_details";

    /// <summary>
    /// The encryption_option attribute.
    /// </summary>
    public TerraformValue<string>? EncryptionOption
    {
        get => GetArgument<TerraformValue<string>>("encryption_option");
        set => SetArgument("encryption_option", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

}


/// <summary>
/// Block type for repository in AwsCodegurureviewerRepositoryAssociation.
/// Nesting mode: list
/// </summary>
public class AwsCodegurureviewerRepositoryAssociationRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "repository";

    /// <summary>
    /// Bitbucket block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Bitbucket block(s) allowed")]
    public TerraformList<AwsCodegurureviewerRepositoryAssociationRepositoryBlockBitbucketBlock>? Bitbucket
    {
        get => GetArgument<TerraformList<AwsCodegurureviewerRepositoryAssociationRepositoryBlockBitbucketBlock>>("bitbucket");
        set => SetArgument("bitbucket", value);
    }

    /// <summary>
    /// Codecommit block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Codecommit block(s) allowed")]
    public TerraformList<AwsCodegurureviewerRepositoryAssociationRepositoryBlockCodecommitBlock>? Codecommit
    {
        get => GetArgument<TerraformList<AwsCodegurureviewerRepositoryAssociationRepositoryBlockCodecommitBlock>>("codecommit");
        set => SetArgument("codecommit", value);
    }

    /// <summary>
    /// GithubEnterpriseServer block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubEnterpriseServer block(s) allowed")]
    public TerraformList<AwsCodegurureviewerRepositoryAssociationRepositoryBlockGithubEnterpriseServerBlock>? GithubEnterpriseServer
    {
        get => GetArgument<TerraformList<AwsCodegurureviewerRepositoryAssociationRepositoryBlockGithubEnterpriseServerBlock>>("github_enterprise_server");
        set => SetArgument("github_enterprise_server", value);
    }

    /// <summary>
    /// S3Bucket block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Bucket block(s) allowed")]
    public TerraformList<AwsCodegurureviewerRepositoryAssociationRepositoryBlockS3BucketBlock>? S3Bucket
    {
        get => GetArgument<TerraformList<AwsCodegurureviewerRepositoryAssociationRepositoryBlockS3BucketBlock>>("s3_bucket");
        set => SetArgument("s3_bucket", value);
    }

}

/// <summary>
/// Block type for bitbucket in AwsCodegurureviewerRepositoryAssociationRepositoryBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodegurureviewerRepositoryAssociationRepositoryBlockBitbucketBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bitbucket";

    /// <summary>
    /// The connection_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionArn is required")]
    public required TerraformValue<string> ConnectionArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("connection_arn");
        set => SetArgument("connection_arn", value);
    }

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
    /// The owner attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Owner is required")]
    public required TerraformValue<string> Owner
    {
        get => GetRequiredArgument<TerraformValue<string>>("owner");
        set => SetArgument("owner", value);
    }

}

/// <summary>
/// Block type for codecommit in AwsCodegurureviewerRepositoryAssociationRepositoryBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodegurureviewerRepositoryAssociationRepositoryBlockCodecommitBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "codecommit";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}

/// <summary>
/// Block type for github_enterprise_server in AwsCodegurureviewerRepositoryAssociationRepositoryBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodegurureviewerRepositoryAssociationRepositoryBlockGithubEnterpriseServerBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "github_enterprise_server";

    /// <summary>
    /// The connection_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionArn is required")]
    public required TerraformValue<string> ConnectionArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("connection_arn");
        set => SetArgument("connection_arn", value);
    }

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
    /// The owner attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Owner is required")]
    public required TerraformValue<string> Owner
    {
        get => GetRequiredArgument<TerraformValue<string>>("owner");
        set => SetArgument("owner", value);
    }

}

/// <summary>
/// Block type for s3_bucket in AwsCodegurureviewerRepositoryAssociationRepositoryBlock.
/// Nesting mode: list
/// </summary>
public class AwsCodegurureviewerRepositoryAssociationRepositoryBlockS3BucketBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_bucket";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsCodegurureviewerRepositoryAssociation.
/// Nesting mode: single
/// </summary>
public class AwsCodegurureviewerRepositoryAssociationTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_codegurureviewer_repository_association Terraform resource.
/// Manages a aws_codegurureviewer_repository_association resource.
/// </summary>
public partial class AwsCodegurureviewerRepositoryAssociation(string name) : TerraformResource("aws_codegurureviewer_repository_association", name)
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
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    public TerraformValue<string> AssociationId
        => AsReference("association_id");

    /// <summary>
    /// The connection_arn attribute.
    /// </summary>
    public TerraformValue<string> ConnectionArn
        => AsReference("connection_arn");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The owner attribute.
    /// </summary>
    public TerraformValue<string> Owner
        => AsReference("owner");

    /// <summary>
    /// The provider_type attribute.
    /// </summary>
    public TerraformValue<string> ProviderType
        => AsReference("provider_type");

    /// <summary>
    /// The s3_repository_details attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> S3RepositoryDetails
        => AsReference("s3_repository_details");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The state_reason attribute.
    /// </summary>
    public TerraformValue<string> StateReason
        => AsReference("state_reason");

    /// <summary>
    /// KmsKeyDetails block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KmsKeyDetails block(s) allowed")]
    public TerraformList<AwsCodegurureviewerRepositoryAssociationKmsKeyDetailsBlock>? KmsKeyDetails
    {
        get => GetArgument<TerraformList<AwsCodegurureviewerRepositoryAssociationKmsKeyDetailsBlock>>("kms_key_details");
        set => SetArgument("kms_key_details", value);
    }

    /// <summary>
    /// Repository block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Repository is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Repository block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Repository block(s) allowed")]
    public required TerraformList<AwsCodegurureviewerRepositoryAssociationRepositoryBlock> Repository
    {
        get => GetRequiredArgument<TerraformList<AwsCodegurureviewerRepositoryAssociationRepositoryBlock>>("repository");
        set => SetArgument("repository", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsCodegurureviewerRepositoryAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsCodegurureviewerRepositoryAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
