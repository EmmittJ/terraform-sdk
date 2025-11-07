using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Manages a azuread_application_fallback_public_client resource.
/// </summary>
public class AzureadApplicationFallbackPublicClient : TerraformResource
{
    public AzureadApplicationFallbackPublicClient(string name) : base("azuread_application_fallback_public_client", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The resource ID of the application to which the fallback public client setting should be applied
    /// </summary>
    public TerraformLiteralProperty<string>? ApplicationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_id");
        set => this.WithProperty("application_id", value);
    }

    /// <summary>
    /// Specifies explicitly whether the application is a public client. Appropriate for apps using token grant flows that don&#39;t use a redirect URI
    /// </summary>
    public TerraformLiteralProperty<bool>? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

}
