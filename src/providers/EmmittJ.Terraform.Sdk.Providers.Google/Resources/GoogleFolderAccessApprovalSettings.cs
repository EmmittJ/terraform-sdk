using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for enrolled_services in .
/// Nesting mode: set
/// </summary>
public class GoogleFolderAccessApprovalSettingsEnrolledServicesBlock : ITerraformBlock
{
    /// <summary>
    /// The product for which Access Approval will be enrolled. Allowed values are listed (case-sensitive):
    ///   * all
    ///   * App Engine
    ///   * BigQuery
    ///   * Cloud Bigtable
    ///   * Cloud Key Management Service
    ///   * Compute Engine
    ///   * Cloud Dataflow
    ///   * Cloud Identity and Access Management
    ///   * Cloud Pub/Sub
    ///   * Cloud Storage
    ///   * Persistent Disk
    /// 
    /// Note: These values are supported as input, but considered a legacy format:
    ///   * all
    ///   * appengine.googleapis.com
    ///   * bigquery.googleapis.com
    ///   * bigtable.googleapis.com
    ///   * cloudkms.googleapis.com
    ///   * compute.googleapis.com
    ///   * dataflow.googleapis.com
    ///   * iam.googleapis.com
    ///   * pubsub.googleapis.com
    ///   * storage.googleapis.com
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudProduct is required")]
    [TerraformPropertyName("cloud_product")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CloudProduct { get; set; }

    /// <summary>
    /// The enrollment level of the service. Default value: &amp;quot;BLOCK_ALL&amp;quot; Possible values: [&amp;quot;BLOCK_ALL&amp;quot;]
    /// </summary>
    [TerraformPropertyName("enrollment_level")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EnrollmentLevel { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleFolderAccessApprovalSettingsTimeoutsBlock : ITerraformBlock
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
/// Manages a google_folder_access_approval_settings resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleFolderAccessApprovalSettings : TerraformResource
{
    public GoogleFolderAccessApprovalSettings(string name) : base("google_folder_access_approval_settings", name)
    {
    }

    /// <summary>
    /// The asymmetric crypto key version to use for signing approval requests.
    /// Empty active_key_version indicates that a Google-managed key should be used for signing.
    /// This property will be ignored if set by an ancestor of the resource, and new non-empty values may not be set.
    /// </summary>
    [TerraformPropertyName("active_key_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ActiveKeyVersion { get; set; }

    /// <summary>
    /// ID of the folder of the access approval settings.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FolderId is required")]
    [TerraformPropertyName("folder_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FolderId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// A list of email addresses to which notifications relating to approval requests should be sent.
    /// Notifications relating to a resource will be sent to all emails in the settings of ancestor
    /// resources of that resource. A maximum of 50 email addresses are allowed.
    /// </summary>
    [TerraformPropertyName("notification_emails")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> NotificationEmails { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "notification_emails");

    /// <summary>
    /// Block for enrolled_services.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnrolledServices is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EnrolledServices block(s) required")]
    [TerraformPropertyName("enrolled_services")]
    public TerraformSet<TerraformBlock<GoogleFolderAccessApprovalSettingsEnrolledServicesBlock>>? EnrolledServices { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleFolderAccessApprovalSettingsTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// If the field is true, that indicates that an ancestor of this Folder has set active_key_version.
    /// </summary>
    [TerraformPropertyName("ancestor_has_active_key_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AncestorHasActiveKeyVersion => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "ancestor_has_active_key_version");

    /// <summary>
    /// If the field is true, that indicates that at least one service is enrolled for Access Approval in one or more ancestors of the Folder.
    /// </summary>
    [TerraformPropertyName("enrolled_ancestor")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnrolledAncestor => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enrolled_ancestor");

    /// <summary>
    /// If the field is true, that indicates that there is some configuration issue with the active_key_version
    /// configured on this Folder (e.g. it doesn&#39;t exist or the Access Approval service account doesn&#39;t have the
    /// correct permissions on it, etc.) This key version is not necessarily the effective key version at this level,
    /// as key versions are inherited top-down.
    /// </summary>
    [TerraformPropertyName("invalid_key_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> InvalidKeyVersion => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "invalid_key_version");

    /// <summary>
    /// The resource name of the settings. Format is &amp;quot;folders/{folder_id}/accessApprovalSettings&amp;quot;
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
