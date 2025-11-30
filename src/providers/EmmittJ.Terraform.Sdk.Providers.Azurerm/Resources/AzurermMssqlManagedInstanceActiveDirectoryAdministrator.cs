using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermMssqlManagedInstanceActiveDirectoryAdministrator.
/// Nesting mode: single
/// </summary>
public class AzurermMssqlManagedInstanceActiveDirectoryAdministratorTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_mssql_managed_instance_active_directory_administrator Terraform resource.
/// Manages a azurerm_mssql_managed_instance_active_directory_administrator resource.
/// </summary>
public partial class AzurermMssqlManagedInstanceActiveDirectoryAdministrator(string name) : TerraformResource("azurerm_mssql_managed_instance_active_directory_administrator", name)
{
    /// <summary>
    /// The azuread_authentication_only attribute.
    /// </summary>
    public TerraformValue<bool>? AzureadAuthenticationOnly
    {
        get => new TerraformReference<bool>(this, "azuread_authentication_only");
        set => SetArgument("azuread_authentication_only", value);
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
    /// The login_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoginUsername is required")]
    public required TerraformValue<string> LoginUsername
    {
        get => new TerraformReference<string>(this, "login_username");
        set => SetArgument("login_username", value);
    }

    /// <summary>
    /// The managed_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedInstanceId is required")]
    public required TerraformValue<string> ManagedInstanceId
    {
        get => new TerraformReference<string>(this, "managed_instance_id");
        set => SetArgument("managed_instance_id", value);
    }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectId is required")]
    public required TerraformValue<string> ObjectId
    {
        get => new TerraformReference<string>(this, "object_id");
        set => SetArgument("object_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    public required TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
        set => SetArgument("tenant_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMssqlManagedInstanceActiveDirectoryAdministratorTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMssqlManagedInstanceActiveDirectoryAdministratorTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
