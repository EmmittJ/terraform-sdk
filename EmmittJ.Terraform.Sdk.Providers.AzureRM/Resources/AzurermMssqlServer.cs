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
    public string? AdministratorLogin
    {
        get => GetProperty<TerraformLiteralProperty<string>>("administrator_login")?.Value;
        set => this.WithProperty("administrator_login", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    public string? AdministratorLoginPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("administrator_login_password")?.Value;
        set => this.WithProperty("administrator_login_password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The administrator_login_password_wo attribute.
    /// </summary>
    public string? AdministratorLoginPasswordWo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("administrator_login_password_wo")?.Value;
        set => this.WithProperty("administrator_login_password_wo", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The administrator_login_password_wo_version attribute.
    /// </summary>
    public double? AdministratorLoginPasswordWoVersion
    {
        get => GetProperty<TerraformLiteralProperty<double>>("administrator_login_password_wo_version")?.Value;
        set => this.WithProperty("administrator_login_password_wo_version", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The connection_policy attribute.
    /// </summary>
    public string? ConnectionPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_policy")?.Value;
        set => this.WithProperty("connection_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The express_vulnerability_assessment_enabled attribute.
    /// </summary>
    public bool? ExpressVulnerabilityAssessmentEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("express_vulnerability_assessment_enabled")?.Value;
        set => this.WithProperty("express_vulnerability_assessment_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    public string? MinimumTlsVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("minimum_tls_version")?.Value;
        set => this.WithProperty("minimum_tls_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The outbound_network_restriction_enabled attribute.
    /// </summary>
    public bool? OutboundNetworkRestrictionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("outbound_network_restriction_enabled")?.Value;
        set => this.WithProperty("outbound_network_restriction_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The primary_user_assigned_identity_id attribute.
    /// </summary>
    public string? PrimaryUserAssignedIdentityId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("primary_user_assigned_identity_id")?.Value;
        set => this.WithProperty("primary_user_assigned_identity_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public bool? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_network_access_enabled")?.Value;
        set => this.WithProperty("public_network_access_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The transparent_data_encryption_key_vault_key_id attribute.
    /// </summary>
    public string? TransparentDataEncryptionKeyVaultKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transparent_data_encryption_key_vault_key_id")?.Value;
        set => this.WithProperty("transparent_data_encryption_key_vault_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public string? Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version")?.Value;
        set => this.WithProperty("version", value == null ? null : new TerraformLiteralProperty<string>(value));
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
