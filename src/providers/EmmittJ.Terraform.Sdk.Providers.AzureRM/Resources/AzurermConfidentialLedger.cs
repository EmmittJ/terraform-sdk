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
/// Block type for azuread_based_service_principal in .
/// Nesting mode: list
/// </summary>
public class AzurermConfidentialLedgerAzureadBasedServicePrincipalBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azuread_based_service_principal";

    /// <summary>
    /// The ledger_role_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LedgerRoleName is required")]
    [TerraformArgument("ledger_role_name")]
    public required TerraformValue<string> LedgerRoleName
    {
        get => new TerraformReference<string>(this, "ledger_role_name");
        set => SetArgument("ledger_role_name", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    [TerraformArgument("principal_id")]
    public required TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
        set => SetArgument("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    [TerraformArgument("tenant_id")]
    public required TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
        set => SetArgument("tenant_id", value);
    }

}

/// <summary>
/// Block type for certificate_based_security_principal in .
/// Nesting mode: list
/// </summary>
public class AzurermConfidentialLedgerCertificateBasedSecurityPrincipalBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate_based_security_principal";

    /// <summary>
    /// The ledger_role_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LedgerRoleName is required")]
    [TerraformArgument("ledger_role_name")]
    public required TerraformValue<string> LedgerRoleName
    {
        get => new TerraformReference<string>(this, "ledger_role_name");
        set => SetArgument("ledger_role_name", value);
    }

    /// <summary>
    /// The pem_public_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PemPublicKey is required")]
    [TerraformArgument("pem_public_key")]
    public required TerraformValue<string> PemPublicKey
    {
        get => new TerraformReference<string>(this, "pem_public_key");
        set => SetArgument("pem_public_key", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermConfidentialLedgerTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_confidential_ledger resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermConfidentialLedger : TerraformResource
{
    public AzurermConfidentialLedger(string name) : base("azurerm_confidential_ledger", name)
    {
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
    /// The ledger_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LedgerType is required")]
    [TerraformArgument("ledger_type")]
    public required TerraformValue<string> LedgerType
    {
        get => new TerraformReference<string>(this, "ledger_type");
        set => SetArgument("ledger_type", value);
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
    /// Block for azuread_based_service_principal.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AzureadBasedServicePrincipal is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AzureadBasedServicePrincipal block(s) required")]
    [TerraformArgument("azuread_based_service_principal")]
    public required TerraformList<AzurermConfidentialLedgerAzureadBasedServicePrincipalBlock> AzureadBasedServicePrincipal { get; set; } = new();

    /// <summary>
    /// Block for certificate_based_security_principal.
    /// Nesting mode: list
    /// </summary>
    [TerraformArgument("certificate_based_security_principal")]
    public TerraformList<AzurermConfidentialLedgerCertificateBasedSecurityPrincipalBlock> CertificateBasedSecurityPrincipal { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermConfidentialLedgerTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The identity_service_endpoint attribute.
    /// </summary>
    [TerraformArgument("identity_service_endpoint")]
    public TerraformValue<string> IdentityServiceEndpoint
    {
        get => new TerraformReference<string>(this, "identity_service_endpoint");
    }

    /// <summary>
    /// The ledger_endpoint attribute.
    /// </summary>
    [TerraformArgument("ledger_endpoint")]
    public TerraformValue<string> LedgerEndpoint
    {
        get => new TerraformReference<string>(this, "ledger_endpoint");
    }

}
