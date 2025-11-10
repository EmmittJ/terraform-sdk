using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for enrolled_services in .
/// Nesting mode: set
/// </summary>
public class GoogleOrganizationAccessApprovalSettingsEnrolledServicesBlock : TerraformBlock
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
    public required TerraformProperty<string> CloudProduct
    {
        set => SetProperty("cloud_product", value);
    }

    /// <summary>
    /// The enrollment level of the service. Default value: &amp;quot;BLOCK_ALL&amp;quot; Possible values: [&amp;quot;BLOCK_ALL&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? EnrollmentLevel
    {
        set => SetProperty("enrollment_level", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleOrganizationAccessApprovalSettingsTimeoutsBlock : TerraformBlock
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
/// Manages a google_organization_access_approval_settings resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleOrganizationAccessApprovalSettings : TerraformResource
{
    public GoogleOrganizationAccessApprovalSettings(string name) : base("google_organization_access_approval_settings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("ancestor_has_active_key_version");
        SetOutput("enrolled_ancestor");
        SetOutput("invalid_key_version");
        SetOutput("name");
        SetOutput("active_key_version");
        SetOutput("id");
        SetOutput("notification_emails");
        SetOutput("organization_id");
    }

    /// <summary>
    /// The asymmetric crypto key version to use for signing approval requests.
    /// Empty active_key_version indicates that a Google-managed key should be used for signing.
    /// </summary>
    public TerraformProperty<string> ActiveKeyVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("active_key_version");
        set => SetProperty("active_key_version", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// A list of email addresses to which notifications relating to approval requests should be sent.
    /// Notifications relating to a resource will be sent to all emails in the settings of ancestor
    /// resources of that resource. A maximum of 50 email addresses are allowed.
    /// </summary>
    public HashSet<TerraformProperty<string>> NotificationEmails
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("notification_emails");
        set => SetProperty("notification_emails", value);
    }

    /// <summary>
    /// ID of the organization of the access approval settings.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrganizationId is required")]
    public required TerraformProperty<string> OrganizationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("organization_id");
        set => SetProperty("organization_id", value);
    }

    /// <summary>
    /// Block for enrolled_services.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnrolledServices is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EnrolledServices block(s) required")]
    public HashSet<GoogleOrganizationAccessApprovalSettingsEnrolledServicesBlock>? EnrolledServices
    {
        set => SetProperty("enrolled_services", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleOrganizationAccessApprovalSettingsTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// This field will always be unset for the organization since organizations do not have ancestors.
    /// </summary>
    public TerraformExpression AncestorHasActiveKeyVersion => this["ancestor_has_active_key_version"];

    /// <summary>
    /// This field will always be unset for the organization since organizations do not have ancestors.
    /// </summary>
    public TerraformExpression EnrolledAncestor => this["enrolled_ancestor"];

    /// <summary>
    /// If the field is true, that indicates that there is some configuration issue with the active_key_version
    /// configured on this Organization (e.g. it doesn&#39;t exist or the Access Approval service account doesn&#39;t have the
    /// correct permissions on it, etc.).
    /// </summary>
    public TerraformExpression InvalidKeyVersion => this["invalid_key_version"];

    /// <summary>
    /// The resource name of the settings. Format is &amp;quot;organizations/{organization_id}/accessApprovalSettings&amp;quot;
    /// </summary>
    public TerraformExpression Name => this["name"];

}
