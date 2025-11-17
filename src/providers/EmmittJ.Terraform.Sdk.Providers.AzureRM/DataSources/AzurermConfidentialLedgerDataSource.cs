using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermConfidentialLedgerDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermConfidentialLedgerDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_confidential_ledger Terraform data source.
/// Retrieves information about a azurerm_confidential_ledger.
/// </summary>
public partial class AzurermConfidentialLedgerDataSource(string name) : TerraformDataSource("azurerm_confidential_ledger", name)
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
    /// The azuread_based_service_principal attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AzureadBasedServicePrincipal
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "azuread_based_service_principal").ResolveNodes(ctx));
    }

    /// <summary>
    /// The certificate_based_security_principal attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CertificateBasedSecurityPrincipal
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "certificate_based_security_principal").ResolveNodes(ctx));
    }

    /// <summary>
    /// The identity_service_endpoint attribute.
    /// </summary>
    public TerraformValue<string> IdentityServiceEndpoint
    {
        get => new TerraformReference<string>(this, "identity_service_endpoint");
    }

    /// <summary>
    /// The ledger_endpoint attribute.
    /// </summary>
    public TerraformValue<string> LedgerEndpoint
    {
        get => new TerraformReference<string>(this, "ledger_endpoint");
    }

    /// <summary>
    /// The ledger_type attribute.
    /// </summary>
    public TerraformValue<string> LedgerType
    {
        get => new TerraformReference<string>(this, "ledger_type");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermConfidentialLedgerDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermConfidentialLedgerDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
