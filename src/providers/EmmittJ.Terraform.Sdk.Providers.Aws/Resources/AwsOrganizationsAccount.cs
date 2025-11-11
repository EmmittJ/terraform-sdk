using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsOrganizationsAccountTimeoutsBlock : TerraformBlockBase
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
/// Manages a aws_organizations_account resource.
/// </summary>
public partial class AwsOrganizationsAccount : TerraformResource
{
    public AwsOrganizationsAccount(string name) : base("aws_organizations_account", name)
    {
    }

    /// <summary>
    /// The close_on_deletion attribute.
    /// </summary>
    [TerraformProperty("close_on_deletion")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CloseOnDeletion { get; set; }

    /// <summary>
    /// The create_govcloud attribute.
    /// </summary>
    [TerraformProperty("create_govcloud")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? CreateGovcloud { get; set; }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    [TerraformProperty("email")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Email { get; set; }

    /// <summary>
    /// The iam_user_access_to_billing attribute.
    /// </summary>
    [TerraformProperty("iam_user_access_to_billing")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IamUserAccessToBilling { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    [TerraformProperty("parent_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ParentId { get; set; }

    /// <summary>
    /// The role_name attribute.
    /// </summary>
    [TerraformProperty("role_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RoleName { get; set; }

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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsOrganizationsAccountTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The govcloud_id attribute.
    /// </summary>
    [TerraformProperty("govcloud_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GovcloudId { get; }

    /// <summary>
    /// The joined_method attribute.
    /// </summary>
    [TerraformProperty("joined_method")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> JoinedMethod { get; }

    /// <summary>
    /// The joined_timestamp attribute.
    /// </summary>
    [TerraformProperty("joined_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> JoinedTimestamp { get; }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

}
