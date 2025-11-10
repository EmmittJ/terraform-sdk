using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsOrganizationsAccountTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_organizations_account resource.
/// </summary>
public class AwsOrganizationsAccount : TerraformResource
{
    public AwsOrganizationsAccount(string name) : base("aws_organizations_account", name)
    {
    }

    /// <summary>
    /// The close_on_deletion attribute.
    /// </summary>
    [TerraformPropertyName("close_on_deletion")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CloseOnDeletion { get; set; }

    /// <summary>
    /// The create_govcloud attribute.
    /// </summary>
    [TerraformPropertyName("create_govcloud")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CreateGovcloud { get; set; }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    [TerraformPropertyName("email")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Email { get; set; }

    /// <summary>
    /// The iam_user_access_to_billing attribute.
    /// </summary>
    [TerraformPropertyName("iam_user_access_to_billing")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IamUserAccessToBilling { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    [TerraformPropertyName("parent_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ParentId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "parent_id");

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [TerraformPropertyName("role_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RoleName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsOrganizationsAccountTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The govcloud_id attribute.
    /// </summary>
    [TerraformPropertyName("govcloud_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GovcloudId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "govcloud_id");

    /// <summary>
    /// The joined_method attribute.
    /// </summary>
    [TerraformPropertyName("joined_method")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> JoinedMethod => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "joined_method");

    /// <summary>
    /// The joined_timestamp attribute.
    /// </summary>
    [TerraformPropertyName("joined_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> JoinedTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "joined_timestamp");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

}
