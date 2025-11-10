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
        set => SetProperty("additional_properties", value);
    }

    /// <summary>
    /// Whether the claim specified by the client is necessary to ensure a smooth authorization experience
    /// </summary>
    public TerraformProperty<bool>? Essential
    {
        set => SetProperty("essential", value);
    }

    /// <summary>
    /// The name of the optional claim
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The source of the claim. If `source` is absent, the claim is a predefined optional claim. If `source` is `user`, the value of `name` is the extension property from the user object
    /// </summary>
    public TerraformProperty<string>? Source
    {
        set => SetProperty("source", value);
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
        set => SetProperty("additional_properties", value);
    }

    /// <summary>
    /// Whether the claim specified by the client is necessary to ensure a smooth authorization experience
    /// </summary>
    public TerraformProperty<bool>? Essential
    {
        set => SetProperty("essential", value);
    }

    /// <summary>
    /// The name of the optional claim
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The source of the claim. If `source` is absent, the claim is a predefined optional claim. If `source` is `user`, the value of `name` is the extension property from the user object
    /// </summary>
    public TerraformProperty<string>? Source
    {
        set => SetProperty("source", value);
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
        set => SetProperty("additional_properties", value);
    }

    /// <summary>
    /// Whether the claim specified by the client is necessary to ensure a smooth authorization experience
    /// </summary>
    public TerraformProperty<bool>? Essential
    {
        set => SetProperty("essential", value);
    }

    /// <summary>
    /// The name of the optional claim
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The source of the claim. If `source` is absent, the claim is a predefined optional claim. If `source` is `user`, the value of `name` is the extension property from the user object
    /// </summary>
    public TerraformProperty<string>? Source
    {
        set => SetProperty("source", value);
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("application_id");
        SetOutput("id");
    }

    /// <summary>
    /// The resource ID of the application to which these optional claims belong
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
    /// Block for access_token.
    /// Nesting mode: list
    /// </summary>
    public List<AzureadApplicationOptionalClaimsAccessTokenBlock>? AccessToken
    {
        set => SetProperty("access_token", value);
    }

    /// <summary>
    /// Block for id_token.
    /// Nesting mode: list
    /// </summary>
    public List<AzureadApplicationOptionalClaimsIdTokenBlock>? IdToken
    {
        set => SetProperty("id_token", value);
    }

    /// <summary>
    /// Block for saml2_token.
    /// Nesting mode: list
    /// </summary>
    public List<AzureadApplicationOptionalClaimsSaml2TokenBlock>? Saml2Token
    {
        set => SetProperty("saml2_token", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadApplicationOptionalClaimsTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
