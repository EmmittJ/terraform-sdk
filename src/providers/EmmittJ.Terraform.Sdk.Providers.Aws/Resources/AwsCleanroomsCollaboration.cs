using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_encryption_metadata in .
/// Nesting mode: list
/// </summary>
public partial class AwsCleanroomsCollaborationDataEncryptionMetadataBlock() : TerraformBlock("data_encryption_metadata")
{
    /// <summary>
    /// The allow_clear_text attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowClearText is required")]
    [TerraformProperty("allow_clear_text")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> AllowClearText { get; set; }

    /// <summary>
    /// The allow_duplicates attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowDuplicates is required")]
    [TerraformProperty("allow_duplicates")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> AllowDuplicates { get; set; }

    /// <summary>
    /// The allow_joins_on_columns_with_different_names attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowJoinsOnColumnsWithDifferentNames is required")]
    [TerraformProperty("allow_joins_on_columns_with_different_names")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> AllowJoinsOnColumnsWithDifferentNames { get; set; }

    /// <summary>
    /// The preserve_nulls attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PreserveNulls is required")]
    [TerraformProperty("preserve_nulls")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> PreserveNulls { get; set; }

}

/// <summary>
/// Block type for member in .
/// Nesting mode: set
/// </summary>
public partial class AwsCleanroomsCollaborationMemberBlock() : TerraformBlock("member")
{
    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    [TerraformProperty("account_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccountId { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The member_abilities attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MemberAbilities is required")]
    [TerraformProperty("member_abilities")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? MemberAbilities { get; set; }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsCleanroomsCollaborationTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_cleanrooms_collaboration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCleanroomsCollaboration : TerraformResource
{
    public AwsCleanroomsCollaboration(string name) : base("aws_cleanrooms_collaboration", name)
    {
    }

    /// <summary>
    /// The analytics_engine attribute.
    /// </summary>
    [TerraformProperty("analytics_engine")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AnalyticsEngine { get; set; }

    /// <summary>
    /// The creator_display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreatorDisplayName is required")]
    [TerraformProperty("creator_display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CreatorDisplayName { get; set; }

    /// <summary>
    /// The creator_member_abilities attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CreatorMemberAbilities is required")]
    [TerraformProperty("creator_member_abilities")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? CreatorMemberAbilities { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformProperty("description")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The query_log_status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryLogStatus is required")]
    [TerraformProperty("query_log_status")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> QueryLogStatus { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for data_encryption_metadata.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataEncryptionMetadata block(s) allowed")]
    [TerraformProperty("data_encryption_metadata")]
    public TerraformList<AwsCleanroomsCollaborationDataEncryptionMetadataBlock> DataEncryptionMetadata { get; set; } = new();

    /// <summary>
    /// Block for member.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("member")]
    public TerraformSet<AwsCleanroomsCollaborationMemberBlock> Member { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsCleanroomsCollaborationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The update_time attribute.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
