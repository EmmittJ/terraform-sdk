using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for member_definition in AwsSagemakerWorkteam.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerWorkteamMemberDefinitionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "member_definition";

    /// <summary>
    /// CognitoMemberDefinition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CognitoMemberDefinition block(s) allowed")]
    public TerraformList<AwsSagemakerWorkteamMemberDefinitionBlockCognitoMemberDefinitionBlock>? CognitoMemberDefinition
    {
        get => GetArgument<TerraformList<AwsSagemakerWorkteamMemberDefinitionBlockCognitoMemberDefinitionBlock>>("cognito_member_definition");
        set => SetArgument("cognito_member_definition", value);
    }

    /// <summary>
    /// OidcMemberDefinition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OidcMemberDefinition block(s) allowed")]
    public TerraformList<AwsSagemakerWorkteamMemberDefinitionBlockOidcMemberDefinitionBlock>? OidcMemberDefinition
    {
        get => GetArgument<TerraformList<AwsSagemakerWorkteamMemberDefinitionBlockOidcMemberDefinitionBlock>>("oidc_member_definition");
        set => SetArgument("oidc_member_definition", value);
    }

}

/// <summary>
/// Block type for cognito_member_definition in AwsSagemakerWorkteamMemberDefinitionBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerWorkteamMemberDefinitionBlockCognitoMemberDefinitionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cognito_member_definition";

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The user_group attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserGroup is required")]
    public required TerraformValue<string> UserGroup
    {
        get => new TerraformReference<string>(this, "user_group");
        set => SetArgument("user_group", value);
    }

    /// <summary>
    /// The user_pool attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPool is required")]
    public required TerraformValue<string> UserPool
    {
        get => new TerraformReference<string>(this, "user_pool");
        set => SetArgument("user_pool", value);
    }

}

/// <summary>
/// Block type for oidc_member_definition in AwsSagemakerWorkteamMemberDefinitionBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerWorkteamMemberDefinitionBlockOidcMemberDefinitionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oidc_member_definition";

    /// <summary>
    /// The groups attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Groups is required")]
    public required TerraformSet<string> Groups
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "groups").ResolveNodes(ctx));
        set => SetArgument("groups", value);
    }

}


/// <summary>
/// Block type for notification_configuration in AwsSagemakerWorkteam.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerWorkteamNotificationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "notification_configuration";

    /// <summary>
    /// The notification_topic_arn attribute.
    /// </summary>
    public TerraformValue<string>? NotificationTopicArn
    {
        get => new TerraformReference<string>(this, "notification_topic_arn");
        set => SetArgument("notification_topic_arn", value);
    }

}


/// <summary>
/// Block type for worker_access_configuration in AwsSagemakerWorkteam.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerWorkteamWorkerAccessConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "worker_access_configuration";

    /// <summary>
    /// S3Presign block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Presign block(s) allowed")]
    public TerraformList<AwsSagemakerWorkteamWorkerAccessConfigurationBlockS3PresignBlock>? S3Presign
    {
        get => GetArgument<TerraformList<AwsSagemakerWorkteamWorkerAccessConfigurationBlockS3PresignBlock>>("s3_presign");
        set => SetArgument("s3_presign", value);
    }

}

/// <summary>
/// Block type for s3_presign in AwsSagemakerWorkteamWorkerAccessConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerWorkteamWorkerAccessConfigurationBlockS3PresignBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_presign";

    /// <summary>
    /// IamPolicyConstraints block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IamPolicyConstraints block(s) allowed")]
    public TerraformList<AwsSagemakerWorkteamWorkerAccessConfigurationBlockS3PresignBlockIamPolicyConstraintsBlock>? IamPolicyConstraints
    {
        get => GetArgument<TerraformList<AwsSagemakerWorkteamWorkerAccessConfigurationBlockS3PresignBlockIamPolicyConstraintsBlock>>("iam_policy_constraints");
        set => SetArgument("iam_policy_constraints", value);
    }

}

/// <summary>
/// Block type for iam_policy_constraints in AwsSagemakerWorkteamWorkerAccessConfigurationBlockS3PresignBlock.
/// Nesting mode: list
/// </summary>
public class AwsSagemakerWorkteamWorkerAccessConfigurationBlockS3PresignBlockIamPolicyConstraintsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "iam_policy_constraints";

    /// <summary>
    /// The source_ip attribute.
    /// </summary>
    public TerraformValue<string> SourceIp
    {
        get => new TerraformReference<string>(this, "source_ip");
        set => SetArgument("source_ip", value);
    }

    /// <summary>
    /// The vpc_source_ip attribute.
    /// </summary>
    public TerraformValue<string> VpcSourceIp
    {
        get => new TerraformReference<string>(this, "vpc_source_ip");
        set => SetArgument("vpc_source_ip", value);
    }

}


/// <summary>
/// Represents a aws_sagemaker_workteam Terraform resource.
/// Manages a aws_sagemaker_workteam resource.
/// </summary>
public partial class AwsSagemakerWorkteam(string name) : TerraformResource("aws_sagemaker_workteam", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The workforce_name attribute.
    /// </summary>
    public TerraformValue<string>? WorkforceName
    {
        get => new TerraformReference<string>(this, "workforce_name");
        set => SetArgument("workforce_name", value);
    }

    /// <summary>
    /// The workteam_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkteamName is required")]
    public required TerraformValue<string> WorkteamName
    {
        get => new TerraformReference<string>(this, "workteam_name");
        set => SetArgument("workteam_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The subdomain attribute.
    /// </summary>
    public TerraformValue<string> Subdomain
    {
        get => new TerraformReference<string>(this, "subdomain");
    }

    /// <summary>
    /// MemberDefinition block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemberDefinition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MemberDefinition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 MemberDefinition block(s) allowed")]
    public required TerraformList<AwsSagemakerWorkteamMemberDefinitionBlock> MemberDefinition
    {
        get => GetRequiredArgument<TerraformList<AwsSagemakerWorkteamMemberDefinitionBlock>>("member_definition");
        set => SetArgument("member_definition", value);
    }

    /// <summary>
    /// NotificationConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NotificationConfiguration block(s) allowed")]
    public TerraformList<AwsSagemakerWorkteamNotificationConfigurationBlock>? NotificationConfiguration
    {
        get => GetArgument<TerraformList<AwsSagemakerWorkteamNotificationConfigurationBlock>>("notification_configuration");
        set => SetArgument("notification_configuration", value);
    }

    /// <summary>
    /// WorkerAccessConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkerAccessConfiguration block(s) allowed")]
    public TerraformList<AwsSagemakerWorkteamWorkerAccessConfigurationBlock>? WorkerAccessConfiguration
    {
        get => GetArgument<TerraformList<AwsSagemakerWorkteamWorkerAccessConfigurationBlock>>("worker_access_configuration");
        set => SetArgument("worker_access_configuration", value);
    }

}
