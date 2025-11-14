using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for azuread_administrator in .
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
    [TerraformArgument("azuread_authentication_only")]
    public TerraformValue<bool> AzureadAuthenticationOnly
    {
        get => new TerraformReference<bool>(this, "azuread_authentication_only");
        set => SetArgument("azuread_authentication_only", value);
    }

    /// <summary>
    /// The login_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoginUsername is required")]
    [TerraformArgument("login_username")]
    public required TerraformValue<string> LoginUsername
    {
        get => new TerraformReference<string>(this, "login_username");
        set => SetArgument("login_username", value);
    }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectId is required")]
    [TerraformArgument("object_id")]
    public required TerraformValue<string> ObjectId
    {
        get => new TerraformReference<string>(this, "object_id");
        set => SetArgument("object_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformArgument("tenant_id")]
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
        set => SetArgument("tenant_id", value);
    }

}

/// <summary>
/// Block type for identity in .
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
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_mssql_server resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMssqlServer : TerraformResource
{
    public AzurermMssqlServer(string name) : base("azurerm_mssql_server", name)
    {
    }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    [TerraformArgument("administrator_login")]
    public TerraformValue<string> AdministratorLogin
    {
        get => new TerraformReference<string>(this, "administrator_login");
        set => SetArgument("administrator_login", value);
    }

    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    [TerraformArgument("administrator_login_password")]
    public TerraformValue<string>? AdministratorLoginPassword
    {
        get => new TerraformReference<string>(this, "administrator_login_password");
        set => SetArgument("administrator_login_password", value);
    }

    /// <summary>
    /// The administrator_login_password_wo attribute.
    /// </summary>
    [TerraformArgument("administrator_login_password_wo")]
    public TerraformValue<string>? AdministratorLoginPasswordWo
    {
        get => new TerraformReference<string>(this, "administrator_login_password_wo");
        set => SetArgument("administrator_login_password_wo", value);
    }

    /// <summary>
    /// The administrator_login_password_wo_version attribute.
    /// </summary>
    [TerraformArgument("administrator_login_password_wo_version")]
    public TerraformValue<double>? AdministratorLoginPasswordWoVersion
    {
        get => new TerraformReference<double>(this, "administrator_login_password_wo_version");
        set => SetArgument("administrator_login_password_wo_version", value);
    }

    /// <summary>
    /// The connection_policy attribute.
    /// </summary>
    [TerraformArgument("connection_policy")]
    public TerraformValue<string>? ConnectionPolicy
    {
        get => new TerraformReference<string>(this, "connection_policy");
        set => SetArgument("connection_policy", value);
    }

    /// <summary>
    /// The express_vulnerability_assessment_enabled attribute.
    /// </summary>
    [TerraformArgument("express_vulnerability_assessment_enabled")]
    public TerraformValue<bool>? ExpressVulnerabilityAssessmentEnabled
    {
        get => new TerraformReference<bool>(this, "express_vulnerability_assessment_enabled");
        set => SetArgument("express_vulnerability_assessment_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    [TerraformArgument("minimum_tls_version")]
    public TerraformValue<string>? MinimumTlsVersion
    {
        get => new TerraformReference<string>(this, "minimum_tls_version");
        set => SetArgument("minimum_tls_version", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The outbound_network_restriction_enabled attribute.
    /// </summary>
    [TerraformArgument("outbound_network_restriction_enabled")]
    public TerraformValue<bool>? OutboundNetworkRestrictionEnabled
    {
        get => new TerraformReference<bool>(this, "outbound_network_restriction_enabled");
        set => SetArgument("outbound_network_restriction_enabled", value);
    }

    /// <summary>
    /// The primary_user_assigned_identity_id attribute.
    /// </summary>
    [TerraformArgument("primary_user_assigned_identity_id")]
    public TerraformValue<string> PrimaryUserAssignedIdentityId
    {
        get => new TerraformReference<string>(this, "primary_user_assigned_identity_id");
        set => SetArgument("primary_user_assigned_identity_id", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformArgument("public_network_access_enabled")]
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The transparent_data_encryption_key_vault_key_id attribute.
    /// </summary>
    [TerraformArgument("transparent_data_encryption_key_vault_key_id")]
    public TerraformValue<string>? TransparentDataEncryptionKeyVaultKeyId
    {
        get => new TerraformReference<string>(this, "transparent_data_encryption_key_vault_key_id");
        set => SetArgument("transparent_data_encryption_key_vault_key_id", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformArgument("version")]
    public required TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// Block for azuread_administrator.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureadAdministrator block(s) allowed")]
    [TerraformArgument("azuread_administrator")]
    public TerraformList<AzurermMssqlServerAzureadAdministratorBlock> AzureadAdministrator { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermMssqlServerIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMssqlServerTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The fully_qualified_domain_name attribute.
    /// </summary>
    [TerraformArgument("fully_qualified_domain_name")]
    public TerraformValue<string> FullyQualifiedDomainName
    {
        get => new TerraformReference<string>(this, "fully_qualified_domain_name");
    }

    /// <summary>
    /// The restorable_dropped_database_ids attribute.
    /// </summary>
    [TerraformArgument("restorable_dropped_database_ids")]
    public TerraformList<string> RestorableDroppedDatabaseIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "restorable_dropped_database_ids").ResolveNodes(ctx));
    }

}
