using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadServicePrincipalDelegatedPermissionGrant.
/// Nesting mode: single
/// </summary>
public class AzureadServicePrincipalDelegatedPermissionGrantTimeoutsBlock : TerraformBlock
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
/// Represents a azuread_service_principal_delegated_permission_grant Terraform resource.
/// Manages a azuread_service_principal_delegated_permission_grant resource.
/// </summary>
public partial class AzureadServicePrincipalDelegatedPermissionGrant(string name) : TerraformResource("azuread_service_principal_delegated_permission_grant", name)
{
    /// <summary>
    /// A set of claim values for delegated permission scopes which should be included in access tokens for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClaimValues is required")]
    public required TerraformSet<string> ClaimValues
    {
        get => GetRequiredArgument<TerraformSet<string>>("claim_values");
        set => SetArgument("claim_values", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The object ID of the service principal representing the resource to be accessed
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceServicePrincipalObjectId is required")]
    public required TerraformValue<string> ResourceServicePrincipalObjectId
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_service_principal_object_id");
        set => SetArgument("resource_service_principal_object_id", value);
    }

    /// <summary>
    /// The object ID of the service principal for which this delegated permission grant should be created
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalObjectId is required")]
    public required TerraformValue<string> ServicePrincipalObjectId
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_principal_object_id");
        set => SetArgument("service_principal_object_id", value);
    }

    /// <summary>
    /// The object ID of the user on behalf of whom the service principal is authorized to access the resource
    /// </summary>
    public TerraformValue<string>? UserObjectId
    {
        get => GetArgument<TerraformValue<string>>("user_object_id");
        set => SetArgument("user_object_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadServicePrincipalDelegatedPermissionGrantTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadServicePrincipalDelegatedPermissionGrantTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
