using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_site_verification_owner resource.
/// </summary>
public class GoogleSiteVerificationOwner : TerraformResource
{
    public GoogleSiteVerificationOwner(string name) : base("google_site_verification_owner", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The email address of the owner.
    /// </summary>
    public string? Email
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email")?.Value;
        set => this.WithProperty("email", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The id of the Web Resource to add this owner to, in the form &amp;quot;webResource/&amp;lt;web-resource-id&amp;gt;&amp;quot;.
    /// </summary>
    public string? WebResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("web_resource_id")?.Value;
        set => this.WithProperty("web_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
