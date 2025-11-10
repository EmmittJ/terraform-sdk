using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadApplicationFallbackPublicClientTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformProperty<string> ApplicationId
    {
        get => GetProperty<TerraformProperty<string>>("application_id");
        set => this.WithProperty("application_id", value);
    }

    /// <summary>
    /// Specifies explicitly whether the application is a public client. Appropriate for apps using token grant flows that don&#39;t use a redirect URI
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadApplicationFallbackPublicClientTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzureadApplicationFallbackPublicClientTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
