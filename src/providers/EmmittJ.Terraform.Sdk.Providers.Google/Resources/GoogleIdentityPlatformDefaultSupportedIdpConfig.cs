using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleIdentityPlatformDefaultSupportedIdpConfigTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_identity_platform_default_supported_idp_config resource.
/// </summary>
public class GoogleIdentityPlatformDefaultSupportedIdpConfig : TerraformResource
{
    public GoogleIdentityPlatformDefaultSupportedIdpConfig(string name) : base("google_identity_platform_default_supported_idp_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("name");
        SetOutput("client_id");
        SetOutput("client_secret");
        SetOutput("enabled");
        SetOutput("id");
        SetOutput("idp_id");
        SetOutput("project");
    }

    /// <summary>
    /// OAuth client ID
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformProperty<string> ClientId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_id");
        set => SetProperty("client_id", value);
    }

    /// <summary>
    /// OAuth client secret
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientSecret is required")]
    public required TerraformProperty<string> ClientSecret
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_secret");
        set => SetProperty("client_secret", value);
    }

    /// <summary>
    /// If this IDP allows the user to sign in
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// ID of the IDP. Possible values include:
    /// 
    /// * &#39;apple.com&#39;
    /// 
    /// * &#39;facebook.com&#39;
    /// 
    /// * &#39;gc.apple.com&#39;
    /// 
    /// * &#39;github.com&#39;
    /// 
    /// * &#39;google.com&#39;
    /// 
    /// * &#39;linkedin.com&#39;
    /// 
    /// * &#39;microsoft.com&#39;
    /// 
    /// * &#39;playgames.google.com&#39;
    /// 
    /// * &#39;twitter.com&#39;
    /// 
    /// * &#39;yahoo.com&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdpId is required")]
    public required TerraformProperty<string> IdpId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("idp_id");
        set => SetProperty("idp_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleIdentityPlatformDefaultSupportedIdpConfigTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The name of the DefaultSupportedIdpConfig resource
    /// </summary>
    public TerraformExpression Name => this["name"];

}
