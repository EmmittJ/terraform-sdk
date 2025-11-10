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
        set => SetProperty("ledger_role_name", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    public required TerraformProperty<string> PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    public required TerraformProperty<string> TenantId
    {
        set => SetProperty("tenant_id", value);
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
        set => SetProperty("ledger_role_name", value);
    }

    /// <summary>
    /// The pem_public_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PemPublicKey is required")]
    public required TerraformProperty<string> PemPublicKey
    {
        set => SetProperty("pem_public_key", value);
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
        SetOutput("identity_service_endpoint");
        SetOutput("ledger_endpoint");
        SetOutput("id");
        SetOutput("ledger_type");
        SetOutput("location");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("tags");
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
    /// The ledger_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LedgerType is required")]
    public required TerraformProperty<string> LedgerType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ledger_type");
        set => SetProperty("ledger_type", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// Block for azuread_based_service_principal.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AzureadBasedServicePrincipal is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AzureadBasedServicePrincipal block(s) required")]
    public List<AzurermConfidentialLedgerAzureadBasedServicePrincipalBlock>? AzureadBasedServicePrincipal
    {
        set => SetProperty("azuread_based_service_principal", value);
    }

    /// <summary>
    /// Block for certificate_based_security_principal.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermConfidentialLedgerCertificateBasedSecurityPrincipalBlock>? CertificateBasedSecurityPrincipal
    {
        set => SetProperty("certificate_based_security_principal", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermConfidentialLedgerTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
