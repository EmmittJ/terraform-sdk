using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleIapBrandTimeoutsBlock : TerraformBlock
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
/// Manages a google_iap_brand resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class GoogleIapBrand : TerraformResource
{
    public GoogleIapBrand(string name) : base("google_iap_brand", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("name");
        SetOutput("org_internal_only");
        SetOutput("application_title");
        SetOutput("id");
        SetOutput("project");
        SetOutput("support_email");
    }

    /// <summary>
    /// Application name displayed on OAuth consent screen.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationTitle is required")]
    public required TerraformProperty<string> ApplicationTitle
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_title");
        set => SetProperty("application_title", value);
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Support email displayed on the OAuth consent screen. Can be either a
    /// user or group email. When a user email is specified, the caller must
    /// be the user with the associated email address. When a group email is
    /// specified, the caller can be either a user or a service account which
    /// is an owner of the specified group in Cloud Identity.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SupportEmail is required")]
    public required TerraformProperty<string> SupportEmail
    {
        get => GetRequiredOutput<TerraformProperty<string>>("support_email");
        set => SetProperty("support_email", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleIapBrandTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. Identifier of the brand, in the format &#39;projects/{project_number}/brands/{brand_id}&#39;
    /// NOTE: The name can also be expressed as &#39;projects/{project_id}/brands/{brand_id}&#39;, e.g. when importing.
    /// NOTE: The brand identification corresponds to the project number as only one
    /// brand can be created per project.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Whether the brand is only intended for usage inside the GSuite organization only.
    /// </summary>
    public TerraformExpression OrgInternalOnly => this["org_internal_only"];

}
