using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attributes in .
/// Nesting mode: list
/// </summary>
public partial class GoogleApigeeDeveloperAttributesBlock : TerraformBlockBase
{
    /// <summary>
    /// Key of the attribute
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// Value of the attribute
    /// </summary>
    [TerraformProperty("value")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleApigeeDeveloperTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_apigee_developer resource.
/// </summary>
public partial class GoogleApigeeDeveloper : TerraformResource
{
    public GoogleApigeeDeveloper(string name) : base("google_apigee_developer", name)
    {
    }

    /// <summary>
    /// Email address of the developer. This value is used to uniquely identify the developer in Apigee hybrid. Note that the email address has to be in lowercase only..
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    [TerraformProperty("email")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Email { get; set; }

    /// <summary>
    /// First name of the developer.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirstName is required")]
    [TerraformProperty("first_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> FirstName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Last name of the developer.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LastName is required")]
    [TerraformProperty("last_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LastName { get; set; }

    /// <summary>
    /// The Apigee Organization associated with the Apigee instance,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformProperty("org_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> OrgId { get; set; }

    /// <summary>
    /// User name of the developer. Not used by Apigee hybrid.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    [TerraformProperty("user_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> UserName { get; set; }

    /// <summary>
    /// Block for attributes.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("attributes")]
    public TerraformList<TerraformBlock<GoogleApigeeDeveloperAttributesBlock>>? Attributes { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleApigeeDeveloperTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Time at which the developer was created in milliseconds since epoch.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// Time at which the developer was last modified in milliseconds since epoch.
    /// </summary>
    [TerraformProperty("last_modified_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastModifiedAt { get; }

    /// <summary>
    /// Name of the Apigee organization in which the developer resides.
    /// </summary>
    [TerraformProperty("organizatio_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OrganizatioName { get; }

    /// <summary>
    /// Status of the developer. Valid values are active and inactive.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

}
