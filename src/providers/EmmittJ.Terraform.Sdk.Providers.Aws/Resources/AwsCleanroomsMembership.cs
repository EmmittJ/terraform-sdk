using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for default_result_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCleanroomsMembershipDefaultResultConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RoleArn { get; set; }

}

/// <summary>
/// Block type for payment_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCleanroomsMembershipPaymentConfigurationBlock : ITerraformBlock
{
}

/// <summary>
/// Manages a aws_cleanrooms_membership resource.
/// </summary>
public class AwsCleanroomsMembership : TerraformResource
{
    public AwsCleanroomsMembership(string name) : base("aws_cleanrooms_membership", name)
    {
    }

    /// <summary>
    /// The collaboration_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CollaborationId is required")]
    [TerraformPropertyName("collaboration_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CollaborationId { get; set; }

    /// <summary>
    /// The query_log_status attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueryLogStatus is required")]
    [TerraformPropertyName("query_log_status")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> QueryLogStatus { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for default_result_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("default_result_configuration")]
    public TerraformList<TerraformBlock<AwsCleanroomsMembershipDefaultResultConfigurationBlock>>? DefaultResultConfiguration { get; set; } = new();

    /// <summary>
    /// Block for payment_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("payment_configuration")]
    public TerraformList<TerraformBlock<AwsCleanroomsMembershipPaymentConfigurationBlock>>? PaymentConfiguration { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The collaboration_arn attribute.
    /// </summary>
    [TerraformPropertyName("collaboration_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CollaborationArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "collaboration_arn");

    /// <summary>
    /// The collaboration_creator_account_id attribute.
    /// </summary>
    [TerraformPropertyName("collaboration_creator_account_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CollaborationCreatorAccountId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "collaboration_creator_account_id");

    /// <summary>
    /// The collaboration_creator_display_name attribute.
    /// </summary>
    [TerraformPropertyName("collaboration_creator_display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CollaborationCreatorDisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "collaboration_creator_display_name");

    /// <summary>
    /// The collaboration_name attribute.
    /// </summary>
    [TerraformPropertyName("collaboration_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CollaborationName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "collaboration_name");

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The member_abilities attribute.
    /// </summary>
    [TerraformPropertyName("member_abilities")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> MemberAbilities => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "member_abilities");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The update_time attribute.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
