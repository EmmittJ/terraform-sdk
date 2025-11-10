using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeControlPlaneAccessTimeoutsBlock : ITerraformBlock
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
/// Manages a google_apigee_control_plane_access resource.
/// </summary>
public class GoogleApigeeControlPlaneAccess : TerraformResource
{
    public GoogleApigeeControlPlaneAccess(string name) : base("google_apigee_control_plane_access", name)
    {
    }

    /// <summary>
    /// Array of service accounts authorized to publish analytics data to the control plane, each specified using the following format: &#39;serviceAccount:service-account-name&#39;.
    /// 
    /// The &#39;service-account-name&#39; is formatted like an email address. For example: serviceAccount@my_project_id.iam.gserviceaccount.com
    /// 
    /// You might specify multiple service accounts, for example, if you have multiple environments and wish to assign a unique service account to each one.
    /// </summary>
    [TerraformPropertyName("analytics_publisher_identities")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? AnalyticsPublisherIdentities { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Name of the Apigee organization.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Array of service accounts to grant access to control plane resources (for the Synchronizer component), each specified using the following format: &#39;serviceAccount:service-account-name&#39;.
    /// 
    /// The &#39;service-account-name&#39; is formatted like an email address. For example: serviceAccount@my_project_id.iam.gserviceaccount.com
    /// 
    /// You might specify multiple service accounts, for example, if you have multiple environments and wish to assign a unique service account to each one.
    /// 
    /// The service accounts must have **Apigee Synchronizer Manager** role. See also [Create service accounts](https://cloud.google.com/apigee/docs/hybrid/v1.8/sa-about#create-the-service-accounts).
    /// </summary>
    [TerraformPropertyName("synchronizer_identities")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? SynchronizerIdentities { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleApigeeControlPlaneAccessTimeoutsBlock>? Timeouts { get; set; } = new();

}
