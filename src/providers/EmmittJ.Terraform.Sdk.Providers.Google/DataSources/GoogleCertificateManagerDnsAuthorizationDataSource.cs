using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_certificate_manager_dns_authorization.
/// </summary>
public class GoogleCertificateManagerDnsAuthorizationDataSource : TerraformDataSource
{
    public GoogleCertificateManagerDnsAuthorizationDataSource(string name) : base("google_certificate_manager_dns_authorization", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("description");
        SetOutput("dns_resource_record");
        SetOutput("effective_labels");
        SetOutput("labels");
        SetOutput("terraform_labels");
        SetOutput("type");
        SetOutput("domain");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("project");
    }

    /// <summary>
    /// A domain which is being authorized. A DnsAuthorization resource covers a
    /// single domain and its wildcard, e.g. authorization for &amp;quot;example.com&amp;quot; can
    /// be used to issue certificates for &amp;quot;example.com&amp;quot; and &amp;quot;*.example.com&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    public required TerraformProperty<string> Domain
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain");
        set => SetProperty("domain", value);
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
    /// The Certificate Manager location. If not specified, &amp;quot;global&amp;quot; is used.
    /// </summary>
    public TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// Name of the resource; provided by the client when the resource is created.
    /// The name must be 1-64 characters long, and match the regular expression [a-zA-Z][a-zA-Z0-9_-]* which means the first character must be a letter,
    /// and all following characters must be a dash, underscore, letter or digit.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// A human-readable description of the resource.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The structure describing the DNS Resource Record that needs to be added
    /// to DNS configuration for the authorization to be usable by
    /// certificate.
    /// </summary>
    public TerraformExpression DnsResourceRecord => this["dns_resource_record"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Set of label tags associated with the DNS Authorization resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformExpression Labels => this["labels"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// type of DNS authorization. If unset during the resource creation, FIXED_RECORD will
    /// be used for global resources, and PER_PROJECT_RECORD will be used for other locations.
    /// 
    /// FIXED_RECORD DNS authorization uses DNS-01 validation method
    /// 
    /// PER_PROJECT_RECORD DNS authorization allows for independent management
    /// of Google-managed certificates with DNS authorization across multiple
    /// projects. Possible values: [&amp;quot;FIXED_RECORD&amp;quot;, &amp;quot;PER_PROJECT_RECORD&amp;quot;]
    /// </summary>
    public TerraformExpression Type => this["type"];

}
