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
/// Block type for timeouts in .
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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_confidential_ledger.
/// </summary>
public class AzurermConfidentialLedgerDataSource : TerraformDataSource
{
    public AzurermConfidentialLedgerDataSource(string name) : base("azurerm_confidential_ledger", name)
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermConfidentialLedgerDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The azuread_based_service_principal attribute.
    /// </summary>
    [TerraformArgument("azuread_based_service_principal")]
    public TerraformList<object> AzureadBasedServicePrincipal
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "azuread_based_service_principal").ResolveNodes(ctx));
    }

    /// <summary>
    /// The certificate_based_security_principal attribute.
    /// </summary>
    [TerraformArgument("certificate_based_security_principal")]
    public TerraformList<object> CertificateBasedSecurityPrincipal
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "certificate_based_security_principal").ResolveNodes(ctx));
    }

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

    /// <summary>
    /// The ledger_type attribute.
    /// </summary>
    [TerraformArgument("ledger_type")]
    public TerraformValue<string> LedgerType
    {
        get => new TerraformReference<string>(this, "ledger_type");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

}
