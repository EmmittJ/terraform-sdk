using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("etag");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Reference to a SecurityProfile with the CustomIntercept configuration.
    /// </summary>
    public TerraformLiteralProperty<string>? CustomInterceptProfile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_intercept_profile");
        set => this.WithProperty("custom_intercept_profile", value);
    }

    /// <summary>
    /// Reference to a SecurityProfile with the custom mirroring configuration for the SecurityProfileGroup.
    /// </summary>
    public TerraformLiteralProperty<string>? CustomMirroringProfile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_mirroring_profile");
        set => this.WithProperty("custom_mirroring_profile", value);
    }

    /// <summary>
    /// An optional description of the profile. The Max length is 512 characters.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// A map of key/value label pairs to assign to the resource.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The location of the security profile group.
    /// The default value is &#39;global&#39;.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name of the security profile group resource.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The name of the parent this security profile group belongs to.
    /// Format: organizations/{organization_id}.
    /// </summary>
    public TerraformLiteralProperty<string>? Parent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// Reference to a SecurityProfile with the threat prevention configuration for the SecurityProfileGroup.
    /// </summary>
    public TerraformLiteralProperty<string>? ThreatPreventionProfile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("threat_prevention_profile");
        set => this.WithProperty("threat_prevention_profile", value);
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
