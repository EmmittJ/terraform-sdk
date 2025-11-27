using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadApplicationRedirectUris.
/// Nesting mode: single
/// </summary>
public class AzureadApplicationRedirectUrisTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azuread_application_redirect_uris Terraform resource.
/// Manages a azuread_application_redirect_uris resource.
/// </summary>
public partial class AzureadApplicationRedirectUris(string name) : TerraformResource("azuread_application_redirect_uris", name)
{
    /// <summary>
    /// The resource ID of the application to which these redirect URIs belong
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformValue<string> ApplicationId
    {
        get => new TerraformReference<string>(this, "application_id");
        set => SetArgument("application_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// A set of redirect URIs
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RedirectUris is required")]
    public required TerraformSet<string> RedirectUris
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "redirect_uris").ResolveNodes(ctx));
        set => SetArgument("redirect_uris", value);
    }

    /// <summary>
    /// The type of redirect URIs to assign to the application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadApplicationRedirectUrisTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadApplicationRedirectUrisTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
