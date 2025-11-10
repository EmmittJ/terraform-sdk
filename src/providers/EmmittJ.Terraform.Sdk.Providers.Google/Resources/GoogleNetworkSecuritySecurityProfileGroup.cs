using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleNetworkSecuritySecurityProfileGroupTimeoutsBlock : TerraformBlock
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
/// Manages a google_network_security_security_profile_group resource.
/// </summary>
public class GoogleNetworkSecuritySecurityProfileGroup : TerraformResource
{
    public GoogleNetworkSecuritySecurityProfileGroup(string name) : base("google_network_security_security_profile_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("effective_labels");
        SetOutput("etag");
        SetOutput("terraform_labels");
        SetOutput("update_time");
        SetOutput("custom_intercept_profile");
        SetOutput("custom_mirroring_profile");
        SetOutput("description");
        SetOutput("id");
        SetOutput("labels");
        SetOutput("location");
        SetOutput("name");
        SetOutput("parent");
        SetOutput("threat_prevention_profile");
    }

    /// <summary>
    /// Reference to a SecurityProfile with the CustomIntercept configuration.
    /// </summary>
    public TerraformProperty<string> CustomInterceptProfile
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_intercept_profile");
        set => SetProperty("custom_intercept_profile", value);
    }

    /// <summary>
    /// Reference to a SecurityProfile with the custom mirroring configuration for the SecurityProfileGroup.
    /// </summary>
    public TerraformProperty<string> CustomMirroringProfile
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_mirroring_profile");
        set => SetProperty("custom_mirroring_profile", value);
    }

    /// <summary>
    /// An optional description of the profile. The Max length is 512 characters.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
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
    /// A map of key/value label pairs to assign to the resource.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Labels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("labels");
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The location of the security profile group.
    /// The default value is &#39;global&#39;.
    /// </summary>
    public TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name of the security profile group resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The name of the parent this security profile group belongs to.
    /// Format: organizations/{organization_id}.
    /// </summary>
    public TerraformProperty<string> Parent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent");
        set => SetProperty("parent", value);
    }

    /// <summary>
    /// Reference to a SecurityProfile with the threat prevention configuration for the SecurityProfileGroup.
    /// </summary>
    public TerraformProperty<string> ThreatPreventionProfile
    {
        get => GetRequiredOutput<TerraformProperty<string>>("threat_prevention_profile");
        set => SetProperty("threat_prevention_profile", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleNetworkSecuritySecurityProfileGroupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Time the security profile group was created in UTC.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// This checksum is computed by the server based on the value of other fields,
    /// and may be sent on update and delete requests to ensure the client has an up-to-date
    /// value before proceeding.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Time the security profile group was updated in UTC.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
