using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_certificate_manager_certificates Terraform data source.
/// Retrieves information about a google_certificate_manager_certificates.
/// </summary>
public partial class GoogleCertificateManagerCertificatesDataSource(string name) : TerraformDataSource("google_certificate_manager_certificates", name)
{
    /// <summary>
    /// The filter attribute.
    /// </summary>
    public TerraformValue<string>? Filter
    {
        get => new TerraformReference<string>(this, "filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The certificates attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Certificates
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "certificates").ResolveNodes(ctx));
    }

}
