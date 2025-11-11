using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for enrolled_services in .
/// Nesting mode: set
/// </summary>
public partial class GoogleProjectAccessApprovalSettingsEnrolledServicesBlock : TerraformBlockBase
{
    /// <summary>
    /// The product for which Access Approval will be enrolled. Allowed values are listed (case-sensitive):
    ///   all
    ///   appengine.googleapis.com
    ///   bigquery.googleapis.com
    ///   bigtable.googleapis.com
    ///   cloudkms.googleapis.com
    ///   compute.googleapis.com
    ///   dataflow.googleapis.com
    ///   iam.googleapis.com
    ///   pubsub.googleapis.com
    ///   storage.googleapis.com
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudProduct is required")]
    [TerraformProperty("cloud_product")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CloudProduct { get; set; }

    /// <summary>
    /// The enrollment level of the service. Default value: &amp;quot;BLOCK_ALL&amp;quot; Possible values: [&amp;quot;BLOCK_ALL&amp;quot;]
    /// </summary>
    [TerraformProperty("enrollment_level")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EnrollmentLevel { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleProjectAccessApprovalSettingsTimeoutsBlock : TerraformBlockBase
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
/// Manages a google_project_access_approval_settings resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleProjectAccessApprovalSettings : TerraformResource
{
    public GoogleProjectAccessApprovalSettings(string name) : base("google_project_access_approval_settings", name)
    {
    }

    /// <summary>
    /// The asymmetric crypto key version to use for signing approval requests.
    /// Empty active_key_version indicates that a Google-managed key should be used for signing.
    /// This property will be ignored if set by an ancestor of the resource, and new non-empty values may not be set.
    /// </summary>
    [TerraformProperty("active_key_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ActiveKeyVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// A list of email addresses to which notifications relating to approval requests should be sent.
    /// Notifications relating to a resource will be sent to all emails in the settings of ancestor
    /// resources of that resource. A maximum of 50 email addresses are allowed.
    /// </summary>
    [TerraformProperty("notification_emails")]
    // Optional+Computed - source generator will implement get/set
    public TerraformSet<string> NotificationEmails { get; set; }

    /// <summary>
    /// Project id.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// ID of the project of the access approval settings.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    [TerraformProperty("project_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ProjectId { get; set; }

    /// <summary>
    /// Block for enrolled_services.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnrolledServices is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EnrolledServices block(s) required")]
    [TerraformProperty("enrolled_services")]
    public TerraformSet<TerraformBlock<GoogleProjectAccessApprovalSettingsEnrolledServicesBlock>>? EnrolledServices { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleProjectAccessApprovalSettingsTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// If the field is true, that indicates that an ancestor of this Project has set active_key_version.
    /// </summary>
    [TerraformProperty("ancestor_has_active_key_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> AncestorHasActiveKeyVersion { get; }

    /// <summary>
    /// If the field is true, that indicates that at least one service is enrolled for Access Approval in one or more ancestors of the Project.
    /// </summary>
    [TerraformProperty("enrolled_ancestor")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnrolledAncestor { get; }

    /// <summary>
    /// If the field is true, that indicates that there is some configuration issue with the active_key_version
    /// configured on this Project (e.g. it doesn&#39;t exist or the Access Approval service account doesn&#39;t have the
    /// correct permissions on it, etc.) This key version is not necessarily the effective key version at this level,
    /// as key versions are inherited top-down.
    /// </summary>
    [TerraformProperty("invalid_key_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> InvalidKeyVersion { get; }

    /// <summary>
    /// The resource name of the settings. Format is &amp;quot;projects/{project_id}/accessApprovalSettings&amp;quot;
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

}
