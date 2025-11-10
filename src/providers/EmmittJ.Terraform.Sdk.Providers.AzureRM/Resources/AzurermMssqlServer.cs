using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for azuread_administrator in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlServerAzureadAdministratorBlock : TerraformBlock
{
    /// <summary>
    /// The azuread_authentication_only attribute.
    /// </summary>
    public TerraformProperty<bool>? AzureadAuthenticationOnly
    {
        set => SetProperty("azuread_authentication_only", value);
    }

    /// <summary>
    /// The login_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoginUsername is required")]
    public required TerraformProperty<string> LoginUsername
    {
        set => SetProperty("login_username", value);
    }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectId is required")]
    public required TerraformProperty<string> ObjectId
    {
        set => SetProperty("object_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlServerIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlServerTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_mssql_server resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMssqlServer : TerraformResource
{
    public AzurermMssqlServer(string name) : base("azurerm_mssql_server", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("fully_qualified_domain_name");
        SetOutput("restorable_dropped_database_ids");
        SetOutput("administrator_login");
        SetOutput("administrator_login_password");
        SetOutput("administrator_login_password_wo");
        SetOutput("administrator_login_password_wo_version");
        SetOutput("connection_policy");
        SetOutput("express_vulnerability_assessment_enabled");
        SetOutput("id");
        SetOutput("location");
        SetOutput("minimum_tls_version");
        SetOutput("name");
        SetOutput("outbound_network_restriction_enabled");
        SetOutput("primary_user_assigned_identity_id");
        SetOutput("public_network_access_enabled");
        SetOutput("resource_group_name");
        SetOutput("tags");
        SetOutput("transparent_data_encryption_key_vault_key_id");
        SetOutput("version");
    }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    public TerraformProperty<string> AdministratorLogin
    {
        get => GetRequiredOutput<TerraformProperty<string>>("administrator_login");
        set => SetProperty("administrator_login", value);
    }

    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    public TerraformProperty<string> AdministratorLoginPassword
    {
        get => GetRequiredOutput<TerraformProperty<string>>("administrator_login_password");
        set => SetProperty("administrator_login_password", value);
    }

    /// <summary>
    /// The administrator_login_password_wo attribute.
    /// </summary>
    public TerraformProperty<string> AdministratorLoginPasswordWo
    {
        get => GetRequiredOutput<TerraformProperty<string>>("administrator_login_password_wo");
        set => SetProperty("administrator_login_password_wo", value);
    }

    /// <summary>
    /// The administrator_login_password_wo_version attribute.
    /// </summary>
    public TerraformProperty<double> AdministratorLoginPasswordWoVersion
    {
        get => GetRequiredOutput<TerraformProperty<double>>("administrator_login_password_wo_version");
        set => SetProperty("administrator_login_password_wo_version", value);
    }

    /// <summary>
    /// The connection_policy attribute.
    /// </summary>
    public TerraformProperty<string> ConnectionPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connection_policy");
        set => SetProperty("connection_policy", value);
    }

    /// <summary>
    /// The express_vulnerability_assessment_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ExpressVulnerabilityAssessmentEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("express_vulnerability_assessment_enabled");
        set => SetProperty("express_vulnerability_assessment_enabled", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    public TerraformProperty<string> MinimumTlsVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("minimum_tls_version");
        set => SetProperty("minimum_tls_version", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The outbound_network_restriction_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> OutboundNetworkRestrictionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("outbound_network_restriction_enabled");
        set => SetProperty("outbound_network_restriction_enabled", value);
    }

    /// <summary>
    /// The primary_user_assigned_identity_id attribute.
    /// </summary>
    public TerraformProperty<string> PrimaryUserAssignedIdentityId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("primary_user_assigned_identity_id");
        set => SetProperty("primary_user_assigned_identity_id", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PublicNetworkAccessEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("public_network_access_enabled");
        set => SetProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The transparent_data_encryption_key_vault_key_id attribute.
    /// </summary>
    public TerraformProperty<string> TransparentDataEncryptionKeyVaultKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("transparent_data_encryption_key_vault_key_id");
        set => SetProperty("transparent_data_encryption_key_vault_key_id", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version");
        set => SetProperty("version", value);
    }

    /// <summary>
    /// Block for azuread_administrator.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureadAdministrator block(s) allowed")]
    public List<AzurermMssqlServerAzureadAdministratorBlock>? AzureadAdministrator
    {
        set => SetProperty("azuread_administrator", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermMssqlServerIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMssqlServerTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The fully_qualified_domain_name attribute.
    /// </summary>
    public TerraformExpression FullyQualifiedDomainName => this["fully_qualified_domain_name"];

    /// <summary>
    /// The restorable_dropped_database_ids attribute.
    /// </summary>
    public TerraformExpression RestorableDroppedDatabaseIds => this["restorable_dropped_database_ids"];

}
