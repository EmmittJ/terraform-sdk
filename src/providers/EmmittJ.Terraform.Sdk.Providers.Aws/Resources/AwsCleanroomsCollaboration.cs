using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_encryption_metadata in AwsCleanroomsCollaboration.
/// Nesting mode: list
/// </summary>
public class AwsCleanroomsCollaborationDataEncryptionMetadataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_encryption_metadata";

    /// <summary>
    /// The allow_clear_text attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowClearText is required")]
    public required TerraformValue<bool> AllowClearText
    {
        get => new TerraformReference<bool>(this, "allow_clear_text");
        set => SetArgument("allow_clear_text", value);
    }

    /// <summary>
    /// The allow_duplicates attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowDuplicates is required")]
    public required TerraformValue<bool> AllowDuplicates
    {
        get => new TerraformReference<bool>(this, "allow_duplicates");
        set => SetArgument("allow_duplicates", value);
    }

    /// <summary>
    /// The allow_joins_on_columns_with_different_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowJoinsOnColumnsWithDifferentNames is required")]
    public required TerraformValue<bool> AllowJoinsOnColumnsWithDifferentNames
    {
        get => new TerraformReference<bool>(this, "allow_joins_on_columns_with_different_names");
        set => SetArgument("allow_joins_on_columns_with_different_names", value);
    }

    /// <summary>
    /// The preserve_nulls attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PreserveNulls is required")]
    public required TerraformValue<bool> PreserveNulls
    {
        get => new TerraformReference<bool>(this, "preserve_nulls");
        set => SetArgument("preserve_nulls", value);
    }

}


/// <summary>
/// Block type for member in AwsCleanroomsCollaboration.
/// Nesting mode: set
/// </summary>
public class AwsCleanroomsCollaborationMemberBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "member";

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    public required TerraformValue<string> AccountId
    {
        get => new TerraformReference<string>(this, "account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The member_abilities attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemberAbilities is required")]
    public TerraformList<string>? MemberAbilities
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "member_abilities").ResolveNodes(ctx));
        set => SetArgument("member_abilities", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

}


/// <summary>
/// Block type for timeouts in AwsCleanroomsCollaboration.
/// Nesting mode: single
/// </summary>
public class AwsCleanroomsCollaborationTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_cleanrooms_collaboration Terraform resource.
/// Manages a aws_cleanrooms_collaboration resource.
/// </summary>
public partial class AwsCleanroomsCollaboration(string name) : TerraformResource("aws_cleanrooms_collaboration", name)
{
    /// <summary>
    /// The analytics_engine attribute.
    /// </summary>
    public TerraformValue<string>? AnalyticsEngine
    {
        get => new TerraformReference<string>(this, "analytics_engine");
        set => SetArgument("analytics_engine", value);
    }

    /// <summary>
    /// The creator_display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreatorDisplayName is required")]
    public required TerraformValue<string> CreatorDisplayName
    {
        get => new TerraformReference<string>(this, "creator_display_name");
        set => SetArgument("creator_display_name", value);
    }

    /// <summary>
    /// The creator_member_abilities attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreatorMemberAbilities is required")]
    public TerraformList<string>? CreatorMemberAbilities
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "creator_member_abilities").ResolveNodes(ctx));
        set => SetArgument("creator_member_abilities", value);
    }

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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The update_time attribute.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// DataEncryptionMetadata block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataEncryptionMetadata block(s) allowed")]
    public TerraformList<AwsCleanroomsCollaborationDataEncryptionMetadataBlock>? DataEncryptionMetadata
    {
        get => GetArgument<TerraformList<AwsCleanroomsCollaborationDataEncryptionMetadataBlock>>("data_encryption_metadata");
        set => SetArgument("data_encryption_metadata", value);
    }

    /// <summary>
    /// Member block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCleanroomsCollaborationMemberBlock>? Member
    {
        get => GetArgument<TerraformSet<AwsCleanroomsCollaborationMemberBlock>>("member");
        set => SetArgument("member", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsCleanroomsCollaborationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsCleanroomsCollaborationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
