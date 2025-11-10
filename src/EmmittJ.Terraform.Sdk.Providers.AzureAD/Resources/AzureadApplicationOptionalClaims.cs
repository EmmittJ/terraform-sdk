using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for access_token in .
/// Nesting mode: list
/// </summary>
public class AzureadApplicationOptionalClaimsAccessTokenBlock : TerraformBlock
{
    /// <summary>
    /// List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim
    /// </summary>
    public List<TerraformProperty<string>>? AdditionalProperties
    {
        get => GetProperty<List<TerraformProperty<string>>>("additional_properties");
        set => WithProperty("additional_properties", value);
    }

    /// <summary>
    /// Whether the claim specified by the client is necessary to ensure a smooth authorization experience
    /// </summary>
    public TerraformProperty<bool>? Essential
    {
        get => GetProperty<TerraformProperty<bool>>("essential");
        set => WithProperty("essential", value);
    }

    /// <summary>
    /// The name of the optional claim
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The source of the claim. If `source` is absent, the claim is a predefined optional claim. If `source` is `user`, the value of `name` is the extension property from the user object
    /// </summary>
    public TerraformProperty<string>? Source
    {
        get => GetProperty<TerraformProperty<string>>("source");
        set => WithProperty("source", value);
    }

}

/// <summary>
/// Block type for id_token in .
/// Nesting mode: list
/// </summary>
public class AzureadApplicationOptionalClaimsIdTokenBlock : TerraformBlock
{
    /// <summary>
    /// List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim
    /// </summary>
    public List<TerraformProperty<string>>? AdditionalProperties
    {
        get => GetProperty<List<TerraformProperty<string>>>("additional_properties");
        set => WithProperty("additional_properties", value);
    }

    /// <summary>
    /// Whether the claim specified by the client is necessary to ensure a smooth authorization experience
    /// </summary>
    public TerraformProperty<bool>? Essential
    {
        get => GetProperty<TerraformProperty<bool>>("essential");
        set => WithProperty("essential", value);
    }

    /// <summary>
    /// The name of the optional claim
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The source of the claim. If `source` is absent, the claim is a predefined optional claim. If `source` is `user`, the value of `name` is the extension property from the user object
    /// </summary>
    public TerraformProperty<string>? Source
    {
        get => GetProperty<TerraformProperty<string>>("source");
        set => WithProperty("source", value);
    }

}

/// <summary>
/// Block type for saml2_token in .
/// Nesting mode: list
/// </summary>
public class AzureadApplicationOptionalClaimsSaml2TokenBlock : TerraformBlock
{
    /// <summary>
    /// List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim
    /// </summary>
    public List<TerraformProperty<string>>? AdditionalProperties
    {
        get => GetProperty<List<TerraformProperty<string>>>("additional_properties");
        set => WithProperty("additional_properties", value);
    }

    /// <summary>
    /// Whether the claim specified by the client is necessary to ensure a smooth authorization experience
    /// </summary>
    public TerraformProperty<bool>? Essential
    {
        get => GetProperty<TerraformProperty<bool>>("essential");
        set => WithProperty("essential", value);
    }

    /// <summary>
    /// The name of the optional claim
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The source of the claim. If `source` is absent, the claim is a predefined optional claim. If `source` is `user`, the value of `name` is the extension property from the user object
    /// </summary>
    public TerraformProperty<string>? Source
    {
        get => GetProperty<TerraformProperty<string>>("source");
        set => WithProperty("source", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadApplicationOptionalClaimsTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azuread_application_optional_claims resource.
/// </summary>
public class AzureadApplicationOptionalClaims : TerraformResource
{
    public AzureadApplicationOptionalClaims(string name) : base("azuread_application_optional_claims", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The resource ID of the application to which these optional claims belong
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
    /// Block for access_token.
    /// Nesting mode: list
    /// </summary>
    public List<AzureadApplicationOptionalClaimsAccessTokenBlock>? AccessToken
    {
        get => GetProperty<List<AzureadApplicationOptionalClaimsAccessTokenBlock>>("access_token");
        set => this.WithProperty("access_token", value);
    }

    /// <summary>
    /// Block for id_token.
    /// Nesting mode: list
    /// </summary>
    public List<AzureadApplicationOptionalClaimsIdTokenBlock>? IdToken
    {
        get => GetProperty<List<AzureadApplicationOptionalClaimsIdTokenBlock>>("id_token");
        set => this.WithProperty("id_token", value);
    }

    /// <summary>
    /// Block for saml2_token.
    /// Nesting mode: list
    /// </summary>
    public List<AzureadApplicationOptionalClaimsSaml2TokenBlock>? Saml2Token
    {
        get => GetProperty<List<AzureadApplicationOptionalClaimsSaml2TokenBlock>>("saml2_token");
        set => this.WithProperty("saml2_token", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadApplicationOptionalClaimsTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzureadApplicationOptionalClaimsTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
