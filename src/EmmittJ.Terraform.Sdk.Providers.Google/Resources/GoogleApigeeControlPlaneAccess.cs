using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeControlPlaneAccessTimeoutsBlock : TerraformBlock
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
/// Manages a google_apigee_control_plane_access resource.
/// </summary>
public class GoogleApigeeControlPlaneAccess : TerraformResource
{
    public GoogleApigeeControlPlaneAccess(string name) : base("google_apigee_control_plane_access", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// Array of service accounts authorized to publish analytics data to the control plane, each specified using the following format: &#39;serviceAccount:service-account-name&#39;.
    /// 
    /// The &#39;service-account-name&#39; is formatted like an email address. For example: serviceAccount@my_project_id.iam.gserviceaccount.com
    /// 
    /// You might specify multiple service accounts, for example, if you have multiple environments and wish to assign a unique service account to each one.
    /// </summary>
    public List<TerraformProperty<string>>? AnalyticsPublisherIdentities
    {
        get => GetProperty<List<TerraformProperty<string>>>("analytics_publisher_identities");
        set => this.WithProperty("analytics_publisher_identities", value);
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
    /// Name of the Apigee organization.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Array of service accounts to grant access to control plane resources (for the Synchronizer component), each specified using the following format: &#39;serviceAccount:service-account-name&#39;.
    /// 
    /// The &#39;service-account-name&#39; is formatted like an email address. For example: serviceAccount@my_project_id.iam.gserviceaccount.com
    /// 
    /// You might specify multiple service accounts, for example, if you have multiple environments and wish to assign a unique service account to each one.
    /// 
    /// The service accounts must have **Apigee Synchronizer Manager** role. See also [Create service accounts](https://cloud.google.com/apigee/docs/hybrid/v1.8/sa-about#create-the-service-accounts).
    /// </summary>
    public List<TerraformProperty<string>>? SynchronizerIdentities
    {
        get => GetProperty<List<TerraformProperty<string>>>("synchronizer_identities");
        set => this.WithProperty("synchronizer_identities", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApigeeControlPlaneAccessTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleApigeeControlPlaneAccessTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
