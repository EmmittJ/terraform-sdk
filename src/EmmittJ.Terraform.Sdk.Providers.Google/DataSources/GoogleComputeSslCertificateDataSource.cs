using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_ssl_certificate.
/// </summary>
public class GoogleComputeSslCertificateDataSource : TerraformDataSource
{
    public GoogleComputeSslCertificateDataSource(string name) : base("google_compute_ssl_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("certificate");
        this.DeclareOutput("certificate_id");
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("description");
        this.DeclareOutput("expire_time");
        this.DeclareOutput("name_prefix");
        this.DeclareOutput("private_key");
        this.DeclareOutput("self_link");
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
    /// Name of the resource. Provided by the client when the resource is
    /// created. The name must be 1-63 characters long, and comply with
    /// RFC1035. Specifically, the name must be 1-63 characters long and match
    /// the regular expression &#39;[a-z]([-a-z0-9]*[a-z0-9])?&#39; which means the
    /// first character must be a lowercase letter, and all following
    /// characters must be a dash, lowercase letter, or digit, except the last
    /// character, which cannot be a dash.
    /// 
    /// These are in the same namespace as the managed SSL certificates.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The certificate in PEM format.
    /// The certificate chain must be no greater than 5 certs long.
    /// The chain must include at least one intermediate cert.
    /// </summary>
    public TerraformExpression Certificate => this["certificate"];

    /// <summary>
    /// The unique identifier for the resource.
    /// </summary>
    public TerraformExpression CertificateId => this["certificate_id"];

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// Expire time of the certificate in RFC3339 text format.
    /// </summary>
    public TerraformExpression ExpireTime => this["expire_time"];

    /// <summary>
    /// Creates a unique name beginning with the specified prefix. Conflicts with name.
    /// </summary>
    public TerraformExpression NamePrefix => this["name_prefix"];

    /// <summary>
    /// The write-only private key in PEM format.
    /// </summary>
    public TerraformExpression PrivateKey => this["private_key"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

}
