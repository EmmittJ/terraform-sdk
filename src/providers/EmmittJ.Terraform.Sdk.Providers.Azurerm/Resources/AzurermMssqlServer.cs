using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for azuread_administrator in AzurermMssqlServer.
/// Nesting mode: list
/// </summary>
public class AzurermMssqlServerAzureadAdministratorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azuread_administrator";

    /// <summary>
    /// The azuread_authentication_only attribute.
    /// </summary>
    public TerraformValue<bool>? AzureadAuthenticationOnly
    {
        get => GetArgument<TerraformValue<bool>>("azuread_authentication_only");
        set => SetArgument("azuread_authentication_only", value);
    }

    /// <summary>
    /// The login_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoginUsername is required")]
    public required TerraformValue<string> LoginUsername
    {
        get => GetArgument<TerraformValue<string>>("login_username");
        set => SetArgument("login_username", value);
    }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectId is required")]
    public required TerraformValue<string> ObjectId
    {
        get => GetArgument<TerraformValue<string>>("object_id");
        set => SetArgument("object_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string>? TenantId
    {
        get => GetArgument<TerraformValue<string>>("tenant_id");
        set => SetArgument("tenant_id", value);
    }

}


/// <summary>
/// Block type for identity in AzurermMssqlServer.
/// Nesting mode: list
/// </summary>
public class AzurermMssqlServerIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public TerraformSet<string>? IdentityIds
    {
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => AsReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermMssqlServer.
/// Nesting mode: single
/// </summary>
public class AzurermMssqlServerTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_mssql_server Terraform resource.
/// Manages a azurerm_mssql_server resource.
/// </summary>
public partial class AzurermMssqlServer(string name) : TerraformResource("azurerm_mssql_server", name)
{
    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    public TerraformValue<string>? AdministratorLogin
    {
        get => GetArgument<TerraformValue<string>>("administrator_login");
        set => SetArgument("administrator_login", value);
    }

    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    public TerraformValue<string>? AdministratorLoginPassword
    {
        get => GetArgument<TerraformValue<string>>("administrator_login_password");
        set => SetArgument("administrator_login_password", value);
    }

    /// <summary>
    /// The administrator_login_password_wo attribute.
    /// </summary>
    public TerraformValue<string>? AdministratorLoginPasswordWo
    {
        get => GetArgument<TerraformValue<string>>("administrator_login_password_wo");
        set => SetArgument("administrator_login_password_wo", value);
    }

    /// <summary>
    /// The administrator_login_password_wo_version attribute.
    /// </summary>
    public TerraformValue<double>? AdministratorLoginPasswordWoVersion
    {
        get => GetArgument<TerraformValue<double>>("administrator_login_password_wo_version");
        set => SetArgument("administrator_login_password_wo_version", value);
    }

    /// <summary>
    /// The connection_policy attribute.
    /// </summary>
    public TerraformValue<string>? ConnectionPolicy
    {
        get => GetArgument<TerraformValue<string>>("connection_policy");
        set => SetArgument("connection_policy", value);
    }

    /// <summary>
    /// The express_vulnerability_assessment_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ExpressVulnerabilityAssessmentEnabled
    {
        get => GetArgument<TerraformValue<bool>>("express_vulnerability_assessment_enabled");
        set => SetArgument("express_vulnerability_assessment_enabled", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    public TerraformValue<string>? MinimumTlsVersion
    {
        get => GetArgument<TerraformValue<string>>("minimum_tls_version");
        set => SetArgument("minimum_tls_version", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The outbound_network_restriction_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? OutboundNetworkRestrictionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("outbound_network_restriction_enabled");
        set => SetArgument("outbound_network_restriction_enabled", value);
    }

    /// <summary>
    /// The primary_user_assigned_identity_id attribute.
    /// </summary>
    public TerraformValue<string>? PrimaryUserAssignedIdentityId
    {
        get => GetArgument<TerraformValue<string>>("primary_user_assigned_identity_id");
        set => SetArgument("primary_user_assigned_identity_id", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => GetArgument<TerraformValue<bool>>("public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The transparent_data_encryption_key_vault_key_id attribute.
    /// </summary>
    public TerraformValue<string>? TransparentDataEncryptionKeyVaultKeyId
    {
        get => GetArgument<TerraformValue<string>>("transparent_data_encryption_key_vault_key_id");
        set => SetArgument("transparent_data_encryption_key_vault_key_id", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => GetArgument<TerraformValue<string>>("version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The fully_qualified_domain_name attribute.
    /// </summary>
    public TerraformValue<string> FullyQualifiedDomainName
        => AsReference("fully_qualified_domain_name");

    /// <summary>
    /// The restorable_dropped_database_ids attribute.
    /// </summary>
    public TerraformList<string> RestorableDroppedDatabaseIds
        => AsReference("restorable_dropped_database_ids");

    /// <summary>
    /// AzureadAdministrator block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureadAdministrator block(s) allowed")]
    public TerraformList<AzurermMssqlServerAzureadAdministratorBlock>? AzureadAdministrator
    {
        get => GetArgument<TerraformList<AzurermMssqlServerAzureadAdministratorBlock>>("azuread_administrator");
        set => SetArgument("azuread_administrator", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermMssqlServerIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermMssqlServerIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMssqlServerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMssqlServerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
