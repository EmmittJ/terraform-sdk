using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_encryption_metadata in .
/// Nesting mode: list
/// </summary>
public class AwsCleanroomsCollaborationDataEncryptionMetadataBlock
{
    /// <summary>
    /// The allow_clear_text attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowClearText is required")]
    [TerraformPropertyName("allow_clear_text")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> AllowClearText { get; set; }

    /// <summary>
    /// The allow_duplicates attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowDuplicates is required")]
    [TerraformPropertyName("allow_duplicates")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> AllowDuplicates { get; set; }

    /// <summary>
    /// The allow_joins_on_columns_with_different_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowJoinsOnColumnsWithDifferentNames is required")]
    [TerraformPropertyName("allow_joins_on_columns_with_different_names")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> AllowJoinsOnColumnsWithDifferentNames { get; set; }

    /// <summary>
    /// The preserve_nulls attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PreserveNulls is required")]
    [TerraformPropertyName("preserve_nulls")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> PreserveNulls { get; set; }

}

/// <summary>
/// Block type for member in .
/// Nesting mode: set
/// </summary>
public class AwsCleanroomsCollaborationMemberBlock
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    [TerraformPropertyName("account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AccountId { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The member_abilities attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemberAbilities is required")]
    [TerraformPropertyName("member_abilities")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? MemberAbilities { get; set; }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsCleanroomsCollaborationTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_cleanrooms_collaboration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCleanroomsCollaboration : TerraformResource
{
    public AwsCleanroomsCollaboration(string name) : base("aws_cleanrooms_collaboration", name)
    {
    }

    /// <summary>
    /// The analytics_engine attribute.
    /// </summary>
    [TerraformPropertyName("analytics_engine")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AnalyticsEngine { get; set; }

    /// <summary>
    /// The creator_display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreatorDisplayName is required")]
    [TerraformPropertyName("creator_display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CreatorDisplayName { get; set; }

    /// <summary>
    /// The creator_member_abilities attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreatorMemberAbilities is required")]
    [TerraformPropertyName("creator_member_abilities")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? CreatorMemberAbilities { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformPropertyName("description")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The query_log_status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryLogStatus is required")]
    [TerraformPropertyName("query_log_status")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> QueryLogStatus { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for data_encryption_metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataEncryptionMetadata block(s) allowed")]
    [TerraformPropertyName("data_encryption_metadata")]
    public TerraformList<TerraformBlock<AwsCleanroomsCollaborationDataEncryptionMetadataBlock>>? DataEncryptionMetadata { get; set; }

    /// <summary>
    /// Block for member.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("member")]
    public TerraformSet<TerraformBlock<AwsCleanroomsCollaborationMemberBlock>>? Member { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsCleanroomsCollaborationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreateTime => new TerraformReference(this, "create_time");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The update_time attribute.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UpdateTime => new TerraformReference(this, "update_time");

}
