using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for azuread_administrator in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMssqlServerAzureadAdministratorBlock : TerraformBlockBase
{
    /// <summary>
    /// The azuread_authentication_only attribute.
    /// </summary>
    [TerraformProperty("azuread_authentication_only")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> AzureadAuthenticationOnly { get; set; }

    /// <summary>
    /// The login_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoginUsername is required")]
    [TerraformProperty("login_username")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LoginUsername { get; set; }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectId is required")]
    [TerraformProperty("object_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ObjectId { get; set; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformProperty("tenant_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TenantId { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMssqlServerIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMssqlServerTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_mssql_server resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermMssqlServer : TerraformResource
{
    public AzurermMssqlServer(string name) : base("azurerm_mssql_server", name)
    {
    }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    [TerraformProperty("administrator_login")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AdministratorLogin { get; set; }

    /// <summary>
    /// The administrator_login_password attribute.
    /// </summary>
    [TerraformProperty("administrator_login_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AdministratorLoginPassword { get; set; }

    /// <summary>
    /// The administrator_login_password_wo attribute.
    /// </summary>
    [TerraformProperty("administrator_login_password_wo")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AdministratorLoginPasswordWo { get; set; }

    /// <summary>
    /// The administrator_login_password_wo_version attribute.
    /// </summary>
    [TerraformProperty("administrator_login_password_wo_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? AdministratorLoginPasswordWoVersion { get; set; }

    /// <summary>
    /// The connection_policy attribute.
    /// </summary>
    [TerraformProperty("connection_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ConnectionPolicy { get; set; }

    /// <summary>
    /// The express_vulnerability_assessment_enabled attribute.
    /// </summary>
    [TerraformProperty("express_vulnerability_assessment_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ExpressVulnerabilityAssessmentEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The minimum_tls_version attribute.
    /// </summary>
    [TerraformProperty("minimum_tls_version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MinimumTlsVersion { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The outbound_network_restriction_enabled attribute.
    /// </summary>
    [TerraformProperty("outbound_network_restriction_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? OutboundNetworkRestrictionEnabled { get; set; }

    /// <summary>
    /// The primary_user_assigned_identity_id attribute.
    /// </summary>
    [TerraformProperty("primary_user_assigned_identity_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PrimaryUserAssignedIdentityId { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The transparent_data_encryption_key_vault_key_id attribute.
    /// </summary>
    [TerraformProperty("transparent_data_encryption_key_vault_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TransparentDataEncryptionKeyVaultKeyId { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformProperty("version")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Version { get; set; }

    /// <summary>
    /// Block for azuread_administrator.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureadAdministrator block(s) allowed")]
    [TerraformProperty("azuread_administrator")]
    public partial TerraformList<TerraformBlock<AzurermMssqlServerAzureadAdministratorBlock>>? AzureadAdministrator { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public partial TerraformList<TerraformBlock<AzurermMssqlServerIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermMssqlServerTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The fully_qualified_domain_name attribute.
    /// </summary>
    [TerraformProperty("fully_qualified_domain_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FullyQualifiedDomainName { get; }

    /// <summary>
    /// The restorable_dropped_database_ids attribute.
    /// </summary>
    [TerraformProperty("restorable_dropped_database_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> RestorableDroppedDatabaseIds { get; }

}
