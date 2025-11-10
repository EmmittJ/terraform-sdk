using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for managed in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeManagedSslCertificateManagedBlock : TerraformBlock
{
    /// <summary>
    /// Domains for which a managed SSL certificate will be valid.  Currently,
    /// there can be up to 100 domains in this list.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domains is required")]
    public List<TerraformProperty<string>>? Domains
    {
        get => GetProperty<List<TerraformProperty<string>>>("domains");
        set => WithProperty("domains", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeManagedSslCertificateTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a google_compute_managed_ssl_certificate resource.
/// </summary>
public class GoogleComputeManagedSslCertificate : TerraformResource
{
    public GoogleComputeManagedSslCertificate(string name) : base("google_compute_managed_ssl_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("certificate_id");
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("expire_time");
        this.DeclareOutput("self_link");
        this.DeclareOutput("subject_alternative_names");
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    public TerraformProperty<string>? Name
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
    /// Enum field whose value is always &#39;MANAGED&#39; - used to signal to the API
    /// which type this is. Default value: &amp;quot;MANAGED&amp;quot; Possible values: [&amp;quot;MANAGED&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Block for managed.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Managed block(s) allowed")]
    public List<GoogleComputeManagedSslCertificateManagedBlock>? Managed
    {
        get => GetProperty<List<GoogleComputeManagedSslCertificateManagedBlock>>("managed");
        set => this.WithProperty("managed", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeManagedSslCertificateTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeManagedSslCertificateTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The unique identifier for the resource.
    /// </summary>
    public TerraformExpression CertificateId => this["certificate_id"];

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// Expire time of the certificate in RFC3339 text format.
    /// </summary>
    public TerraformExpression ExpireTime => this["expire_time"];

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// Domains associated with the certificate via Subject Alternative Name.
    /// </summary>
    public TerraformExpression SubjectAlternativeNames => this["subject_alternative_names"];

}
