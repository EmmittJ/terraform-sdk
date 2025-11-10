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
        set => SetProperty("allow_clear_text", value);
    }

    /// <summary>
    /// The allow_duplicates attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowDuplicates is required")]
    public required TerraformProperty<bool> AllowDuplicates
    {
        set => SetProperty("allow_duplicates", value);
    }

    /// <summary>
    /// The allow_joins_on_columns_with_different_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowJoinsOnColumnsWithDifferentNames is required")]
    public required TerraformProperty<bool> AllowJoinsOnColumnsWithDifferentNames
    {
        set => SetProperty("allow_joins_on_columns_with_different_names", value);
    }

    /// <summary>
    /// The preserve_nulls attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PreserveNulls is required")]
    public required TerraformProperty<bool> PreserveNulls
    {
        set => SetProperty("preserve_nulls", value);
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
        set => SetProperty("account_id", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The member_abilities attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemberAbilities is required")]
    public List<TerraformProperty<string>>? MemberAbilities
    {
        set => SetProperty("member_abilities", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        set => SetProperty("status", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("arn");
        SetOutput("create_time");
        SetOutput("id");
        SetOutput("update_time");
        SetOutput("analytics_engine");
        SetOutput("creator_display_name");
        SetOutput("creator_member_abilities");
        SetOutput("description");
        SetOutput("name");
        SetOutput("query_log_status");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The analytics_engine attribute.
    /// </summary>
    public TerraformProperty<string> AnalyticsEngine
    {
        get => GetRequiredOutput<TerraformProperty<string>>("analytics_engine");
        set => SetProperty("analytics_engine", value);
    }

    /// <summary>
    /// The creator_display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreatorDisplayName is required")]
    public required TerraformProperty<string> CreatorDisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("creator_display_name");
        set => SetProperty("creator_display_name", value);
    }

    /// <summary>
    /// The creator_member_abilities attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreatorMemberAbilities is required")]
    public List<TerraformProperty<string>> CreatorMemberAbilities
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("creator_member_abilities");
        set => SetProperty("creator_member_abilities", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The query_log_status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryLogStatus is required")]
    public required TerraformProperty<string> QueryLogStatus
    {
        get => GetRequiredOutput<TerraformProperty<string>>("query_log_status");
        set => SetProperty("query_log_status", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for data_encryption_metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataEncryptionMetadata block(s) allowed")]
    public List<AwsCleanroomsCollaborationDataEncryptionMetadataBlock>? DataEncryptionMetadata
    {
        set => SetProperty("data_encryption_metadata", value);
    }

    /// <summary>
    /// Block for member.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCleanroomsCollaborationMemberBlock>? Member
    {
        set => SetProperty("member", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsCleanroomsCollaborationTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
