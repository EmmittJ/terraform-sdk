using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadApplicationPreAuthorized.
/// Nesting mode: single
/// </summary>
public class AzureadApplicationPreAuthorizedTimeoutsBlock : TerraformBlock
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
/// Represents a azuread_application_pre_authorized Terraform resource.
/// Manages a azuread_application_pre_authorized resource.
/// </summary>
public partial class AzureadApplicationPreAuthorized(string name) : TerraformResource("azuread_application_pre_authorized", name)
{
    /// <summary>
    /// The resource ID of the application to which this pre-authorized application should be added
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformValue<string> ApplicationId
    {
        get => new TerraformReference<string>(this, "application_id");
        set => SetArgument("application_id", value);
    }

    /// <summary>
    /// The client ID of the pre-authorized application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizedClientId is required")]
    public required TerraformValue<string> AuthorizedClientId
    {
        get => new TerraformReference<string>(this, "authorized_client_id");
        set => SetArgument("authorized_client_id", value);
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
    /// The IDs of the permission scopes required by the pre-authorized application
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PermissionIds is required")]
    public required TerraformSet<string> PermissionIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "permission_ids").ResolveNodes(ctx));
        set => SetArgument("permission_ids", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadApplicationPreAuthorizedTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadApplicationPreAuthorizedTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
