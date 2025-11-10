using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for azuread_based_service_principal in .
/// Nesting mode: list
/// </summary>
public class AzurermConfidentialLedgerAzureadBasedServicePrincipalBlock : TerraformBlock
{
    /// <summary>
    /// The ledger_role_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LedgerRoleName is required")]
    public required TerraformProperty<string> LedgerRoleName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("ledger_role_name");
        set => WithProperty("ledger_role_name", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    public required TerraformProperty<string> PrincipalId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    public required TerraformProperty<string> TenantId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

}

/// <summary>
/// Block type for certificate_based_security_principal in .
/// Nesting mode: list
/// </summary>
public class AzurermConfidentialLedgerCertificateBasedSecurityPrincipalBlock : TerraformBlock
{
    /// <summary>
    /// The ledger_role_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LedgerRoleName is required")]
    public required TerraformProperty<string> LedgerRoleName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("ledger_role_name");
        set => WithProperty("ledger_role_name", value);
    }

    /// <summary>
    /// The pem_public_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PemPublicKey is required")]
    public required TerraformProperty<string> PemPublicKey
    {
        get => GetRequiredProperty<TerraformProperty<string>>("pem_public_key");
        set => WithProperty("pem_public_key", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermConfidentialLedgerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_confidential_ledger resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermConfidentialLedger : TerraformResource
{
    public AzurermConfidentialLedger(string name) : base("azurerm_confidential_ledger", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("identity_service_endpoint");
        this.WithOutput("ledger_endpoint");
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
    /// The ledger_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LedgerType is required")]
    public required TerraformProperty<string> LedgerType
    {
        get => GetRequiredProperty<TerraformProperty<string>>("ledger_type");
        set => this.WithProperty("ledger_type", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for azuread_based_service_principal.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AzureadBasedServicePrincipal block(s) required")]
    public List<AzurermConfidentialLedgerAzureadBasedServicePrincipalBlock>? AzureadBasedServicePrincipal
    {
        get => GetProperty<List<AzurermConfidentialLedgerAzureadBasedServicePrincipalBlock>>("azuread_based_service_principal");
        set => this.WithProperty("azuread_based_service_principal", value);
    }

    /// <summary>
    /// Block for certificate_based_security_principal.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermConfidentialLedgerCertificateBasedSecurityPrincipalBlock>? CertificateBasedSecurityPrincipal
    {
        get => GetProperty<List<AzurermConfidentialLedgerCertificateBasedSecurityPrincipalBlock>>("certificate_based_security_principal");
        set => this.WithProperty("certificate_based_security_principal", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermConfidentialLedgerTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermConfidentialLedgerTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The identity_service_endpoint attribute.
    /// </summary>
    public TerraformExpression IdentityServiceEndpoint => this["identity_service_endpoint"];

    /// <summary>
    /// The ledger_endpoint attribute.
    /// </summary>
    public TerraformExpression LedgerEndpoint => this["ledger_endpoint"];

}
