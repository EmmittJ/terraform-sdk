using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_privateca_certificate resource.
/// </summary>
public class GooglePrivatecaCertificate : TerraformResource
{
    public GooglePrivatecaCertificate(string name) : base("google_privateca_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("certificate_description");
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("issuer_certificate_authority");
        this.DeclareOutput("pem_certificate");
        this.DeclareOutput("pem_certificate_chain");
        this.DeclareOutput("revocation_details");
        this.DeclareOutput("terraform_labels");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The Certificate Authority ID that should issue the certificate. For example, to issue a Certificate from
    /// a Certificate Authority with resource name &#39;projects/my-project/locations/us-central1/caPools/my-pool/certificateAuthorities/my-ca&#39;,
    /// argument &#39;pool&#39; should be set to &#39;projects/my-project/locations/us-central1/caPools/my-pool&#39;, argument &#39;certificate_authority&#39;
    /// should be set to &#39;my-ca&#39;.
    /// </summary>
    public TerraformProperty<string>? CertificateAuthority
    {
        get => GetProperty<TerraformProperty<string>>("certificate_authority");
        set => this.WithProperty("certificate_authority", value);
    }

    /// <summary>
    /// The resource name for a CertificateTemplate used to issue this certificate,
    /// in the format &#39;projects/*/locations/*/certificateTemplates/*&#39;. If this is specified,
    /// the caller must have the necessary permission to use this template. If this is
    /// omitted, no template will be used. This template must be in the same location
    /// as the Certificate.
    /// </summary>
    public TerraformProperty<string>? CertificateTemplate
    {
        get => GetProperty<TerraformProperty<string>>("certificate_template");
        set => this.WithProperty("certificate_template", value);
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
    /// Labels with user-defined metadata to apply to this resource.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMapProperty<string>? Labels
    {
        get => GetProperty<TerraformMapProperty<string>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The desired lifetime of the CA certificate. Used to create the &amp;quot;notBeforeTime&amp;quot; and
    /// &amp;quot;notAfterTime&amp;quot; fields inside an X.509 certificate. A duration in seconds with up to nine
    /// fractional digits, terminated by &#39;s&#39;. Example: &amp;quot;3.5s&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Lifetime
    {
        get => GetProperty<TerraformProperty<string>>("lifetime");
        set => this.WithProperty("lifetime", value);
    }

    /// <summary>
    /// Location of the Certificate. A full list of valid locations can be found by
    /// running &#39;gcloud privateca locations list&#39;.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name for this Certificate.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Immutable. A pem-encoded X.509 certificate signing request (CSR).
    /// </summary>
    public TerraformProperty<string>? PemCsr
    {
        get => GetProperty<TerraformProperty<string>>("pem_csr");
        set => this.WithProperty("pem_csr", value);
    }

    /// <summary>
    /// The name of the CaPool this Certificate belongs to.
    /// </summary>
    public TerraformProperty<string>? Pool
    {
        get => GetProperty<TerraformProperty<string>>("pool");
        set => this.WithProperty("pool", value);
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
    /// Output only. Details regarding the revocation of this Certificate. This Certificate is considered revoked if and only if this field is present.
    /// </summary>
    public TerraformExpression CertificateDescription => this["certificate_description"];

    /// <summary>
    /// The time that this resource was created on the server.
    /// This is in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// The resource name of the issuing CertificateAuthority in the format &#39;projects/*/locations/*/caPools/*/certificateAuthorities/*&#39;.
    /// </summary>
    public TerraformExpression IssuerCertificateAuthority => this["issuer_certificate_authority"];

    /// <summary>
    /// Output only. The pem-encoded, signed X.509 certificate.
    /// </summary>
    public TerraformExpression PemCertificate => this["pem_certificate"];

    /// <summary>
    /// The chain that may be used to verify the X.509 certificate. Expected to be in issuer-to-root order according to RFC 5246.
    /// </summary>
    public TerraformExpression PemCertificateChain => this["pem_certificate_chain"];

    /// <summary>
    /// Output only. Details regarding the revocation of this Certificate. This Certificate is
    /// considered revoked if and only if this field is present.
    /// </summary>
    public TerraformExpression RevocationDetails => this["revocation_details"];

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

    /// <summary>
    /// Output only. The time at which this CertificateAuthority was updated.
    /// This is in RFC3339 text format.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
