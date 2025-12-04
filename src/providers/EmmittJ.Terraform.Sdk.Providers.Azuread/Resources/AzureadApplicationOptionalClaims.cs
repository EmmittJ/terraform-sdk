using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for access_token in AzureadApplicationOptionalClaims.
/// Nesting mode: list
/// </summary>
public class AzureadApplicationOptionalClaimsAccessTokenBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_token";

    /// <summary>
    /// List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim
    /// </summary>
    public TerraformList<string>? AdditionalProperties
    {
        get => GetArgument<TerraformList<string>>("additional_properties");
        set => SetArgument("additional_properties", value);
    }

    /// <summary>
    /// Whether the claim specified by the client is necessary to ensure a smooth authorization experience
    /// </summary>
    public TerraformValue<bool>? Essential
    {
        get => GetArgument<TerraformValue<bool>>("essential");
        set => SetArgument("essential", value);
    }

    /// <summary>
    /// The name of the optional claim
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The source of the claim. If `source` is absent, the claim is a predefined optional claim. If `source` is `user`, the value of `name` is the extension property from the user object
    /// </summary>
    public TerraformValue<string>? Source
    {
        get => GetArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

}


/// <summary>
/// Block type for id_token in AzureadApplicationOptionalClaims.
/// Nesting mode: list
/// </summary>
public class AzureadApplicationOptionalClaimsIdTokenBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "id_token";

    /// <summary>
    /// List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim
    /// </summary>
    public TerraformList<string>? AdditionalProperties
    {
        get => GetArgument<TerraformList<string>>("additional_properties");
        set => SetArgument("additional_properties", value);
    }

    /// <summary>
    /// Whether the claim specified by the client is necessary to ensure a smooth authorization experience
    /// </summary>
    public TerraformValue<bool>? Essential
    {
        get => GetArgument<TerraformValue<bool>>("essential");
        set => SetArgument("essential", value);
    }

    /// <summary>
    /// The name of the optional claim
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The source of the claim. If `source` is absent, the claim is a predefined optional claim. If `source` is `user`, the value of `name` is the extension property from the user object
    /// </summary>
    public TerraformValue<string>? Source
    {
        get => GetArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

}


/// <summary>
/// Block type for saml2_token in AzureadApplicationOptionalClaims.
/// Nesting mode: list
/// </summary>
public class AzureadApplicationOptionalClaimsSaml2TokenBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "saml2_token";

    /// <summary>
    /// List of additional properties of the claim. If a property exists in this list, it modifies the behaviour of the optional claim
    /// </summary>
    public TerraformList<string>? AdditionalProperties
    {
        get => GetArgument<TerraformList<string>>("additional_properties");
        set => SetArgument("additional_properties", value);
    }

    /// <summary>
    /// Whether the claim specified by the client is necessary to ensure a smooth authorization experience
    /// </summary>
    public TerraformValue<bool>? Essential
    {
        get => GetArgument<TerraformValue<bool>>("essential");
        set => SetArgument("essential", value);
    }

    /// <summary>
    /// The name of the optional claim
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The source of the claim. If `source` is absent, the claim is a predefined optional claim. If `source` is `user`, the value of `name` is the extension property from the user object
    /// </summary>
    public TerraformValue<string>? Source
    {
        get => GetArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

}


/// <summary>
/// Block type for timeouts in AzureadApplicationOptionalClaims.
/// Nesting mode: single
/// </summary>
public class AzureadApplicationOptionalClaimsTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azuread_application_optional_claims Terraform resource.
/// Manages a azuread_application_optional_claims resource.
/// </summary>
public partial class AzureadApplicationOptionalClaims(string name) : TerraformResource("azuread_application_optional_claims", name)
{
    /// <summary>
    /// The resource ID of the application to which these optional claims belong
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformValue<string> ApplicationId
    {
        get => GetArgument<TerraformValue<string>>("application_id");
        set => SetArgument("application_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// AccessToken block (nesting mode: list).
    /// </summary>
    public TerraformList<AzureadApplicationOptionalClaimsAccessTokenBlock>? AccessToken
    {
        get => GetArgument<TerraformList<AzureadApplicationOptionalClaimsAccessTokenBlock>>("access_token");
        set => SetArgument("access_token", value);
    }

    /// <summary>
    /// IdToken block (nesting mode: list).
    /// </summary>
    public TerraformList<AzureadApplicationOptionalClaimsIdTokenBlock>? IdToken
    {
        get => GetArgument<TerraformList<AzureadApplicationOptionalClaimsIdTokenBlock>>("id_token");
        set => SetArgument("id_token", value);
    }

    /// <summary>
    /// Saml2Token block (nesting mode: list).
    /// </summary>
    public TerraformList<AzureadApplicationOptionalClaimsSaml2TokenBlock>? Saml2Token
    {
        get => GetArgument<TerraformList<AzureadApplicationOptionalClaimsSaml2TokenBlock>>("saml2_token");
        set => SetArgument("saml2_token", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadApplicationOptionalClaimsTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadApplicationOptionalClaimsTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
