using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_identity_platform_config resource.
/// </summary>
public class GoogleIdentityPlatformConfig : TerraformResource
{
    public GoogleIdentityPlatformConfig(string name) : base("google_identity_platform_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// List of domains authorized for OAuth redirects.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? AuthorizedDomains
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("authorized_domains");
        set => this.WithProperty("authorized_domains", value);
    }

    /// <summary>
    /// Whether anonymous users will be auto-deleted after a period of 30 days
    /// </summary>
    public TerraformLiteralProperty<bool>? AutodeleteAnonymousUsers
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("autodelete_anonymous_users");
        set => this.WithProperty("autodelete_anonymous_users", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The name of the Config resource
    /// </summary>
    public TerraformExpression Name => this["name"];

}
