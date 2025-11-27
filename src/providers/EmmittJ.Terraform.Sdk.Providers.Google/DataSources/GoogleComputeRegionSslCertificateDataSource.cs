using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_region_ssl_certificate Terraform data source.
/// Retrieves information about a google_compute_region_ssl_certificate.
/// </summary>
public partial class GoogleComputeRegionSslCertificateDataSource(string name) : TerraformDataSource("google_compute_region_ssl_certificate", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The Region in which the created regional ssl certificate should reside.
    /// If it is not provided, the provider region is used.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The certificate in PEM format.
    /// The certificate chain must be no greater than 5 certs long.
    /// The chain must include at least one intermediate cert.
    /// </summary>
    public TerraformValue<string> Certificate
    {
        get => new TerraformReference<string>(this, "certificate");
    }

    /// <summary>
    /// The unique identifier for the resource.
    /// </summary>
    public TerraformValue<double> CertificateId
    {
        get => new TerraformReference<double>(this, "certificate_id");
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
    {
        get => new TerraformReference<string>(this, "creation_timestamp");
    }

    /// <summary>
    /// An optional description of this resource.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// Expire time of the certificate in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> ExpireTime
    {
        get => new TerraformReference<string>(this, "expire_time");
    }

    /// <summary>
    /// Creates a unique name beginning with the specified prefix. Conflicts with name.
    /// </summary>
    public TerraformValue<string> NamePrefix
    {
        get => new TerraformReference<string>(this, "name_prefix");
    }

    /// <summary>
    /// The write-only private key in PEM format.
    /// </summary>
    public TerraformValue<string> PrivateKey
    {
        get => new TerraformReference<string>(this, "private_key");
    }

    /// <summary>
    /// The self_link attribute.
    /// </summary>
    public TerraformValue<string> SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
    }

}
