using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public required TerraformValue<string> LedgerRoleName
    {
        get => new TerraformReference<string>(this, "ledger_role_name");
        set => SetArgument("ledger_role_name", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalId is required")]
    public required TerraformValue<string> PrincipalId
    {
        get => new TerraformReference<string>(this, "principal_id");
        set => SetArgument("principal_id", value);
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
    public required TerraformValue<string> LedgerRoleName
    {
        get => new TerraformReference<string>(this, "ledger_role_name");
        set => SetArgument("ledger_role_name", value);
    }

    /// <summary>
    /// The pem_public_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PemPublicKey is required")]
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
/// Represents a azurerm_confidential_ledger Terraform resource.
/// Manages a azurerm_confidential_ledger resource.
/// </summary>
public partial class AzurermConfidentialLedger(string name) : TerraformResource("azurerm_confidential_ledger", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ledger_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LedgerType is required")]
    public required TerraformValue<string> LedgerType
    {
        get => new TerraformReference<string>(this, "ledger_type");
        set => SetArgument("ledger_type", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// AzureadBasedServicePrincipal block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AzureadBasedServicePrincipal is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AzureadBasedServicePrincipal block(s) required")]
    public required TerraformList<AzurermConfidentialLedgerAzureadBasedServicePrincipalBlock> AzureadBasedServicePrincipal
    {
        get => GetRequiredArgument<TerraformList<AzurermConfidentialLedgerAzureadBasedServicePrincipalBlock>>("azuread_based_service_principal");
        set => SetArgument("azuread_based_service_principal", value);
    }

    /// <summary>
    /// CertificateBasedSecurityPrincipal block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermConfidentialLedgerCertificateBasedSecurityPrincipalBlock>? CertificateBasedSecurityPrincipal
    {
        get => GetArgument<TerraformList<AzurermConfidentialLedgerCertificateBasedSecurityPrincipalBlock>>("certificate_based_security_principal");
        set => SetArgument("certificate_based_security_principal", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermConfidentialLedgerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermConfidentialLedgerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
