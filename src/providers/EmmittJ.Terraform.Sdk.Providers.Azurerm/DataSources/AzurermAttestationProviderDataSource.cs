using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermAttestationProviderDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermAttestationProviderDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_attestation_provider Terraform data source.
/// Retrieves information about a azurerm_attestation_provider.
/// </summary>
public partial class AzurermAttestationProviderDataSource(string name) : TerraformDataSource("azurerm_attestation_provider", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
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
    /// The attestation_uri attribute.
    /// </summary>
    public TerraformValue<string> AttestationUri
        => CreateReference("attestation_uri");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The trust_model attribute.
    /// </summary>
    public TerraformValue<string> TrustModel
        => CreateReference("trust_model");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAttestationProviderDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAttestationProviderDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
