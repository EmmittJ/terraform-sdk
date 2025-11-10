using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSiteVerificationOwnerTimeoutsBlock : TerraformBlock
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

}

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
        SetOutput("email");
        SetOutput("id");
        SetOutput("web_resource_id");
    }

    /// <summary>
    /// The email address of the owner.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformProperty<string> Email
    {
        get => GetRequiredOutput<TerraformProperty<string>>("email");
        set => SetProperty("email", value);
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
    /// The id of the Web Resource to add this owner to, in the form &amp;quot;webResource/&amp;lt;web-resource-id&amp;gt;&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebResourceId is required")]
    public required TerraformProperty<string> WebResourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("web_resource_id");
        set => SetProperty("web_resource_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleSiteVerificationOwnerTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
