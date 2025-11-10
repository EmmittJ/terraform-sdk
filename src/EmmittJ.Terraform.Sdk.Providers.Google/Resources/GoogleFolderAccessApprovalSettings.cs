using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for enrolled_services in .
/// Nesting mode: set
/// </summary>
public class GoogleFolderAccessApprovalSettingsEnrolledServicesBlock : TerraformBlock
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
    public required TerraformProperty<string> CloudProduct
    {
        get => GetProperty<TerraformProperty<string>>("cloud_product");
        set => WithProperty("cloud_product", value);
    }

    /// <summary>
    /// The enrollment level of the service. Default value: &amp;quot;BLOCK_ALL&amp;quot; Possible values: [&amp;quot;BLOCK_ALL&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? EnrollmentLevel
    {
        get => GetProperty<TerraformProperty<string>>("enrollment_level");
        set => WithProperty("enrollment_level", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleFolderAccessApprovalSettingsTimeoutsBlock : TerraformBlock
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
/// Manages a google_folder_access_approval_settings resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleFolderAccessApprovalSettings : TerraformResource
{
    public GoogleFolderAccessApprovalSettings(string name) : base("google_folder_access_approval_settings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("ancestor_has_active_key_version");
        this.DeclareOutput("enrolled_ancestor");
        this.DeclareOutput("invalid_key_version");
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The asymmetric crypto key version to use for signing approval requests.
    /// Empty active_key_version indicates that a Google-managed key should be used for signing.
    /// This property will be ignored if set by an ancestor of the resource, and new non-empty values may not be set.
    /// </summary>
    public TerraformProperty<string>? ActiveKeyVersion
    {
        get => GetProperty<TerraformProperty<string>>("active_key_version");
        set => this.WithProperty("active_key_version", value);
    }

    /// <summary>
    /// ID of the folder of the access approval settings.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FolderId is required")]
    public required TerraformProperty<string> FolderId
    {
        get => GetProperty<TerraformProperty<string>>("folder_id");
        set => this.WithProperty("folder_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// A list of email addresses to which notifications relating to approval requests should be sent.
    /// Notifications relating to a resource will be sent to all emails in the settings of ancestor
    /// resources of that resource. A maximum of 50 email addresses are allowed.
    /// </summary>
    public HashSet<TerraformProperty<string>>? NotificationEmails
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("notification_emails");
        set => this.WithProperty("notification_emails", value);
    }

    /// <summary>
    /// Block for enrolled_services.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EnrolledServices block(s) required")]
    public HashSet<GoogleFolderAccessApprovalSettingsEnrolledServicesBlock>? EnrolledServices
    {
        get => GetProperty<HashSet<GoogleFolderAccessApprovalSettingsEnrolledServicesBlock>>("enrolled_services");
        set => this.WithProperty("enrolled_services", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleFolderAccessApprovalSettingsTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleFolderAccessApprovalSettingsTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// If the field is true, that indicates that an ancestor of this Folder has set active_key_version.
    /// </summary>
    public TerraformExpression AncestorHasActiveKeyVersion => this["ancestor_has_active_key_version"];

    /// <summary>
    /// If the field is true, that indicates that at least one service is enrolled for Access Approval in one or more ancestors of the Folder.
    /// </summary>
    public TerraformExpression EnrolledAncestor => this["enrolled_ancestor"];

    /// <summary>
    /// If the field is true, that indicates that there is some configuration issue with the active_key_version
    /// configured on this Folder (e.g. it doesn&#39;t exist or the Access Approval service account doesn&#39;t have the
    /// correct permissions on it, etc.) This key version is not necessarily the effective key version at this level,
    /// as key versions are inherited top-down.
    /// </summary>
    public TerraformExpression InvalidKeyVersion => this["invalid_key_version"];

    /// <summary>
    /// The resource name of the settings. Format is &amp;quot;folders/{folder_id}/accessApprovalSettings&amp;quot;
    /// </summary>
    public TerraformExpression Name => this["name"];

}
