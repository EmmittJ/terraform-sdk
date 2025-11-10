using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadApplicationIdentifierUriTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Manages a azuread_application_identifier_uri resource.
/// </summary>
public class AzureadApplicationIdentifierUri : TerraformResource
{
    public AzureadApplicationIdentifierUri(string name) : base("azuread_application_identifier_uri", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("application_id");
        SetOutput("id");
        SetOutput("identifier_uri");
    }

    /// <summary>
    /// The resource ID of the application to which the identifier URI should be added
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformProperty<string> ApplicationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_id");
        set => SetProperty("application_id", value);
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
    /// The user-defined URI or URI-like string that uniquely identifies an application within its Azure AD tenant, or within a verified custom domain if the application is multi-tenant
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentifierUri is required")]
    public required TerraformProperty<string> IdentifierUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identifier_uri");
        set => SetProperty("identifier_uri", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadApplicationIdentifierUriTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
