using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_encryption_metadata in .
/// Nesting mode: list
/// </summary>
public class AwsCleanroomsCollaborationDataEncryptionMetadataBlock : TerraformBlock
{
    /// <summary>
    /// The allow_clear_text attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowClearText is required")]
    public required TerraformProperty<bool> AllowClearText
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("allow_clear_text");
        set => WithProperty("allow_clear_text", value);
    }

    /// <summary>
    /// The allow_duplicates attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowDuplicates is required")]
    public required TerraformProperty<bool> AllowDuplicates
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("allow_duplicates");
        set => WithProperty("allow_duplicates", value);
    }

    /// <summary>
    /// The allow_joins_on_columns_with_different_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowJoinsOnColumnsWithDifferentNames is required")]
    public required TerraformProperty<bool> AllowJoinsOnColumnsWithDifferentNames
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("allow_joins_on_columns_with_different_names");
        set => WithProperty("allow_joins_on_columns_with_different_names", value);
    }

    /// <summary>
    /// The preserve_nulls attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PreserveNulls is required")]
    public required TerraformProperty<bool> PreserveNulls
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("preserve_nulls");
        set => WithProperty("preserve_nulls", value);
    }

}

/// <summary>
/// Block type for member in .
/// Nesting mode: set
/// </summary>
public class AwsCleanroomsCollaborationMemberBlock : TerraformBlock
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    public required TerraformProperty<string> AccountId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("account_id");
        set => WithProperty("account_id", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("display_name");
        set => WithProperty("display_name", value);
    }

    /// <summary>
    /// The member_abilities attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemberAbilities is required")]
    public List<TerraformProperty<string>>? MemberAbilities
    {
        get => GetProperty<List<TerraformProperty<string>>>("member_abilities");
        set => WithProperty("member_abilities", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => WithProperty("status", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsCleanroomsCollaborationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_cleanrooms_collaboration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCleanroomsCollaboration : TerraformResource
{
    public AwsCleanroomsCollaboration(string name) : base("aws_cleanrooms_collaboration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("create_time");
        this.DeclareOutput("id");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The analytics_engine attribute.
    /// </summary>
    public TerraformProperty<string>? AnalyticsEngine
    {
        get => GetProperty<TerraformProperty<string>>("analytics_engine");
        set => this.WithProperty("analytics_engine", value);
    }

    /// <summary>
    /// The creator_display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreatorDisplayName is required")]
    public required TerraformProperty<string> CreatorDisplayName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("creator_display_name");
        set => this.WithProperty("creator_display_name", value);
    }

    /// <summary>
    /// The creator_member_abilities attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreatorMemberAbilities is required")]
    public List<TerraformProperty<string>>? CreatorMemberAbilities
    {
        get => GetProperty<List<TerraformProperty<string>>>("creator_member_abilities");
        set => this.WithProperty("creator_member_abilities", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformProperty<string> Description
    {
        get => GetRequiredProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The query_log_status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryLogStatus is required")]
    public required TerraformProperty<string> QueryLogStatus
    {
        get => GetRequiredProperty<TerraformProperty<string>>("query_log_status");
        set => this.WithProperty("query_log_status", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for data_encryption_metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataEncryptionMetadata block(s) allowed")]
    public List<AwsCleanroomsCollaborationDataEncryptionMetadataBlock>? DataEncryptionMetadata
    {
        get => GetProperty<List<AwsCleanroomsCollaborationDataEncryptionMetadataBlock>>("data_encryption_metadata");
        set => this.WithProperty("data_encryption_metadata", value);
    }

    /// <summary>
    /// Block for member.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCleanroomsCollaborationMemberBlock>? Member
    {
        get => GetProperty<HashSet<AwsCleanroomsCollaborationMemberBlock>>("member");
        set => this.WithProperty("member", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsCleanroomsCollaborationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsCleanroomsCollaborationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The update_time attribute.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
