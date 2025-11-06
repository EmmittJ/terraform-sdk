using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_clouddomains_registration resource.
/// </summary>
public class GoogleClouddomainsRegistration : TerraformResource
{
    public GoogleClouddomainsRegistration(string name) : base("google_clouddomains_registration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("expire_time");
        this.DeclareOutput("issues");
        this.DeclareOutput("name");
        this.DeclareOutput("register_failure_reason");
        this.DeclareOutput("state");
        this.DeclareOutput("supported_privacy");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// The list of contact notices that the caller acknowledges. Possible value is PUBLIC_CONTACT_DATA_ACKNOWLEDGEMENT
    /// </summary>
    public List<string>? ContactNotices
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("contact_notices")?.Value;
        set => this.WithProperty("contact_notices", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// Required. The domain name. Unicode domain names must be expressed in Punycode format.
    /// </summary>
    public string? DomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name")?.Value;
        set => this.WithProperty("domain_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The list of domain notices that you acknowledge. Possible value is HSTS_PRELOADED
    /// </summary>
    public List<string>? DomainNotices
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("domain_notices")?.Value;
        set => this.WithProperty("domain_notices", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Set of labels associated with the Registration.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, string>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels")?.Value;
        set => this.WithProperty("labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Output only. Time at which the automation was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Output only. Time at which the automation was updated.
    /// </summary>
    public TerraformExpression ExpireTime => this["expire_time"];

    /// <summary>
    /// Output only. The set of issues with the Registration that require attention.
    /// </summary>
    public TerraformExpression Issues => this["issues"];

    /// <summary>
    /// Output only. Name of the Registration resource, in the format projects/*/locations/*/registrations/&amp;lt;domain_name&amp;gt;.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. The reason the domain registration failed. Only set for domains in REGISTRATION_FAILED state.
    /// </summary>
    public TerraformExpression RegisterFailureReason => this["register_failure_reason"];

    /// <summary>
    /// Output only. The current state of the Registration.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Output only. Set of options for the contactSettings.privacy field that this Registration supports.
    /// </summary>
    public TerraformExpression SupportedPrivacy => this["supported_privacy"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
