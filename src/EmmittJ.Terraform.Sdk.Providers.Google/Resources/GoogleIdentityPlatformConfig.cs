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
    public List<string>? AuthorizedDomains
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("authorized_domains")?.Value;
        set => this.WithProperty("authorized_domains", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// Whether anonymous users will be auto-deleted after a period of 30 days
    /// </summary>
    public bool? AutodeleteAnonymousUsers
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("autodelete_anonymous_users")?.Value;
        set => this.WithProperty("autodelete_anonymous_users", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the Config resource
    /// </summary>
    public TerraformExpression Name => this["name"];

}
