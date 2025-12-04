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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The azuread_based_service_principal attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AzureadBasedServicePrincipal
        => AsReference("azuread_based_service_principal");

    /// <summary>
    /// The certificate_based_security_principal attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CertificateBasedSecurityPrincipal
        => AsReference("certificate_based_security_principal");

    /// <summary>
    /// The identity_service_endpoint attribute.
    /// </summary>
    public TerraformValue<string> IdentityServiceEndpoint
        => AsReference("identity_service_endpoint");

    /// <summary>
    /// The ledger_endpoint attribute.
    /// </summary>
    public TerraformValue<string> LedgerEndpoint
        => AsReference("ledger_endpoint");

    /// <summary>
    /// The ledger_type attribute.
    /// </summary>
    public TerraformValue<string> LedgerType
        => AsReference("ledger_type");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermConfidentialLedgerDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermConfidentialLedgerDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
