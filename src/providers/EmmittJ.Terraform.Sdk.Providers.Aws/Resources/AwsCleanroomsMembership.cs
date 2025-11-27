using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for default_result_configuration in AwsCleanroomsMembership.
/// Nesting mode: list
/// </summary>
public class AwsCleanroomsMembershipDefaultResultConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_result_configuration";

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// OutputConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCleanroomsMembershipDefaultResultConfigurationBlockOutputConfigurationBlock>? OutputConfiguration
    {
        get => GetArgument<TerraformList<AwsCleanroomsMembershipDefaultResultConfigurationBlockOutputConfigurationBlock>>("output_configuration");
        set => SetArgument("output_configuration", value);
    }

}

/// <summary>
/// Block type for output_configuration in AwsCleanroomsMembershipDefaultResultConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsCleanroomsMembershipDefaultResultConfigurationBlockOutputConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "output_configuration";

    /// <summary>
    /// S3 block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCleanroomsMembershipDefaultResultConfigurationBlockOutputConfigurationBlockS3Block>? S3
    {
        get => GetArgument<TerraformList<AwsCleanroomsMembershipDefaultResultConfigurationBlockOutputConfigurationBlockS3Block>>("s3");
        set => SetArgument("s3", value);
    }

}

/// <summary>
/// Block type for s3 in AwsCleanroomsMembershipDefaultResultConfigurationBlockOutputConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsCleanroomsMembershipDefaultResultConfigurationBlockOutputConfigurationBlockS3Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3";

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
    /// The key_prefix attribute.
    /// </summary>
    public TerraformValue<string>? KeyPrefix
    {
        get => new TerraformReference<string>(this, "key_prefix");
        set => SetArgument("key_prefix", value);
    }

    /// <summary>
    /// The result_format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResultFormat is required")]
    public required TerraformValue<string> ResultFormat
    {
        get => new TerraformReference<string>(this, "result_format");
        set => SetArgument("result_format", value);
    }

}


/// <summary>
/// Block type for payment_configuration in AwsCleanroomsMembership.
/// Nesting mode: list
/// </summary>
public class AwsCleanroomsMembershipPaymentConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "payment_configuration";

    /// <summary>
    /// QueryCompute block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCleanroomsMembershipPaymentConfigurationBlockQueryComputeBlock>? QueryCompute
    {
        get => GetArgument<TerraformList<AwsCleanroomsMembershipPaymentConfigurationBlockQueryComputeBlock>>("query_compute");
        set => SetArgument("query_compute", value);
    }

}

/// <summary>
/// Block type for query_compute in AwsCleanroomsMembershipPaymentConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsCleanroomsMembershipPaymentConfigurationBlockQueryComputeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "query_compute";

    /// <summary>
    /// The is_responsible attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IsResponsible is required")]
    public required TerraformValue<bool> IsResponsible
    {
        get => new TerraformReference<bool>(this, "is_responsible");
        set => SetArgument("is_responsible", value);
    }

}


/// <summary>
/// Represents a aws_cleanrooms_membership Terraform resource.
/// Manages a aws_cleanrooms_membership resource.
/// </summary>
public partial class AwsCleanroomsMembership(string name) : TerraformResource("aws_cleanrooms_membership", name)
{
    /// <summary>
    /// The collaboration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollaborationId is required")]
    public required TerraformValue<string> CollaborationId
    {
        get => new TerraformReference<string>(this, "collaboration_id");
        set => SetArgument("collaboration_id", value);
    }

    /// <summary>
    /// The query_log_status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryLogStatus is required")]
    public required TerraformValue<string> QueryLogStatus
    {
        get => new TerraformReference<string>(this, "query_log_status");
        set => SetArgument("query_log_status", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The collaboration_arn attribute.
    /// </summary>
    public TerraformValue<string> CollaborationArn
    {
        get => new TerraformReference<string>(this, "collaboration_arn");
    }

    /// <summary>
    /// The collaboration_creator_account_id attribute.
    /// </summary>
    public TerraformValue<string> CollaborationCreatorAccountId
    {
        get => new TerraformReference<string>(this, "collaboration_creator_account_id");
    }

    /// <summary>
    /// The collaboration_creator_display_name attribute.
    /// </summary>
    public TerraformValue<string> CollaborationCreatorDisplayName
    {
        get => new TerraformReference<string>(this, "collaboration_creator_display_name");
    }

    /// <summary>
    /// The collaboration_name attribute.
    /// </summary>
    public TerraformValue<string> CollaborationName
    {
        get => new TerraformReference<string>(this, "collaboration_name");
    }

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The member_abilities attribute.
    /// </summary>
    public TerraformList<string> MemberAbilities
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "member_abilities").ResolveNodes(ctx));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
    }

    /// <summary>
    /// The update_time attribute.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// DefaultResultConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCleanroomsMembershipDefaultResultConfigurationBlock>? DefaultResultConfiguration
    {
        get => GetArgument<TerraformList<AwsCleanroomsMembershipDefaultResultConfigurationBlock>>("default_result_configuration");
        set => SetArgument("default_result_configuration", value);
    }

    /// <summary>
    /// PaymentConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCleanroomsMembershipPaymentConfigurationBlock>? PaymentConfiguration
    {
        get => GetArgument<TerraformList<AwsCleanroomsMembershipPaymentConfigurationBlock>>("payment_configuration");
        set => SetArgument("payment_configuration", value);
    }

}
