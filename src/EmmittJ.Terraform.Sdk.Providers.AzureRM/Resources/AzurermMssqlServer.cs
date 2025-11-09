using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_mssql_server resource.
/// </summary>
public class AzurermMssqlServer : TerraformResource
{
    public AzurermMssqlServer(string name) : base("azurerm_mssql_server", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("fully_qualified_domain_name");
        this.DeclareOutput("restorable_dropped_database_ids");
    }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    public TerraformProperty<string>? AdministratorLogin
    {
        get => GetProperty<TerraformProperty<string>>("administrator_login");
        set => this.WithProperty("administrator_login", value);
    }

    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    public TerraformProperty<string>? AdministratorLoginPassword
    {
        get => GetProperty<TerraformProperty<string>>("administrator_login_password");
        set => this.WithProperty("administrator_login_password", value);
    }

    /// <summary>
    /// The administrator_login_password_wo attribute.
    /// </summary>
    public TerraformProperty<string>? AdministratorLoginPasswordWo
    {
        get => GetProperty<TerraformProperty<string>>("administrator_login_password_wo");
        set => this.WithProperty("administrator_login_password_wo", value);
    }

    /// <summary>
    /// The administrator_login_password_wo_version attribute.
    /// </summary>
    public TerraformProperty<double>? AdministratorLoginPasswordWoVersion
    {
        get => GetProperty<TerraformProperty<double>>("administrator_login_password_wo_version");
        set => this.WithProperty("administrator_login_password_wo_version", value);
    }

    /// <summary>
    /// The connection_policy attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionPolicy
    {
        get => GetProperty<TerraformProperty<string>>("connection_policy");
        set => this.WithProperty("connection_policy", value);
    }

    /// <summary>
    /// The express_vulnerability_assessment_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ExpressVulnerabilityAssessmentEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("express_vulnerability_assessment_enabled");
        set => this.WithProperty("express_vulnerability_assessment_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    public TerraformProperty<string>? MinimumTlsVersion
    {
        get => GetProperty<TerraformProperty<string>>("minimum_tls_version");
        set => this.WithProperty("minimum_tls_version", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The outbound_network_restriction_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? OutboundNetworkRestrictionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("outbound_network_restriction_enabled");
        set => this.WithProperty("outbound_network_restriction_enabled", value);
    }

    /// <summary>
    /// The primary_user_assigned_identity_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrimaryUserAssignedIdentityId
    {
        get => GetProperty<TerraformProperty<string>>("primary_user_assigned_identity_id");
        set => this.WithProperty("primary_user_assigned_identity_id", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The transparent_data_encryption_key_vault_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? TransparentDataEncryptionKeyVaultKeyId
    {
        get => GetProperty<TerraformProperty<string>>("transparent_data_encryption_key_vault_key_id");
        set => this.WithProperty("transparent_data_encryption_key_vault_key_id", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
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
