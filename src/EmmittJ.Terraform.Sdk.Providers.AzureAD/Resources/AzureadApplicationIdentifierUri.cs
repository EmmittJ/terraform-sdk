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
    }

    /// <summary>
    /// The resource ID of the application to which the identifier URI should be added
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformProperty<string> ApplicationId
    {
        get => GetProperty<TerraformProperty<string>>("application_id");
        set => this.WithProperty("application_id", value);
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
    /// The user-defined URI or URI-like string that uniquely identifies an application within its Azure AD tenant, or within a verified custom domain if the application is multi-tenant
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentifierUri is required")]
    public required TerraformProperty<string> IdentifierUri
    {
        get => GetProperty<TerraformProperty<string>>("identifier_uri");
        set => this.WithProperty("identifier_uri", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadApplicationIdentifierUriTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzureadApplicationIdentifierUriTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
