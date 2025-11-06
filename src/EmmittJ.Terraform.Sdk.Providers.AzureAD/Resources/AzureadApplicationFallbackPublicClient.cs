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
    public string? ApplicationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_id")?.Value;
        set => this.WithProperty("application_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Specifies explicitly whether the application is a public client. Appropriate for apps using token grant flows that don&#39;t use a redirect URI
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
