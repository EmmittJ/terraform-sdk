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
    public TerraformProperty<string>? Email
    {
        get => GetProperty<TerraformProperty<string>>("email");
        set => this.WithProperty("email", value);
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
    /// The id of the Web Resource to add this owner to, in the form &amp;quot;webResource/&amp;lt;web-resource-id&amp;gt;&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? WebResourceId
    {
        get => GetProperty<TerraformProperty<string>>("web_resource_id");
        set => this.WithProperty("web_resource_id", value);
    }

}
