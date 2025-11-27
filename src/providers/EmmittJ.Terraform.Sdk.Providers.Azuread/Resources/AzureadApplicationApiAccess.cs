using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadApplicationApiAccess.
/// Nesting mode: single
/// </summary>
public class AzureadApplicationApiAccessTimeoutsBlock : TerraformBlock
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
/// Represents a azuread_application_api_access Terraform resource.
/// Manages a azuread_application_api_access resource.
/// </summary>
public partial class AzureadApplicationApiAccess(string name) : TerraformResource("azuread_application_api_access", name)
{
    /// <summary>
    /// The client ID of the API to which access is being granted
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiClientId is required")]
    public required TerraformValue<string> ApiClientId
    {
        get => new TerraformReference<string>(this, "api_client_id");
        set => SetArgument("api_client_id", value);
    }

    /// <summary>
    /// The resource ID of the application to which this API access is granted
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
    /// A set of role IDs to be granted to the application, as published by the API
    /// </summary>
    public TerraformSet<string>? RoleIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "role_ids").ResolveNodes(ctx));
        set => SetArgument("role_ids", value);
    }

    /// <summary>
    /// A set of scope IDs to be granted to the application, as published by the API
    /// </summary>
    public TerraformSet<string>? ScopeIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "scope_ids").ResolveNodes(ctx));
        set => SetArgument("scope_ids", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadApplicationApiAccessTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadApplicationApiAccessTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
