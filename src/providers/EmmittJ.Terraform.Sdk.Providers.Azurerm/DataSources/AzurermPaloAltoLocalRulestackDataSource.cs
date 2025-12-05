using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermPaloAltoLocalRulestackDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermPaloAltoLocalRulestackDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_palo_alto_local_rulestack Terraform data source.
/// Retrieves information about a azurerm_palo_alto_local_rulestack.
/// </summary>
public partial class AzurermPaloAltoLocalRulestackDataSource(string name) : TerraformDataSource("azurerm_palo_alto_local_rulestack", name)
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
    /// The anti_spyware_profile attribute.
    /// </summary>
    public TerraformValue<string> AntiSpywareProfile
        => CreateReference("anti_spyware_profile");

    /// <summary>
    /// The anti_virus_profile attribute.
    /// </summary>
    public TerraformValue<string> AntiVirusProfile
        => CreateReference("anti_virus_profile");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// The dns_subscription attribute.
    /// </summary>
    public TerraformValue<string> DnsSubscription
        => CreateReference("dns_subscription");

    /// <summary>
    /// The file_blocking_profile attribute.
    /// </summary>
    public TerraformValue<string> FileBlockingProfile
        => CreateReference("file_blocking_profile");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => CreateReference("location");

    /// <summary>
    /// The outbound_trust_certificate attribute.
    /// </summary>
    public TerraformValue<string> OutboundTrustCertificate
        => CreateReference("outbound_trust_certificate");

    /// <summary>
    /// The outbound_untrust_certificate attribute.
    /// </summary>
    public TerraformValue<string> OutboundUntrustCertificate
        => CreateReference("outbound_untrust_certificate");

    /// <summary>
    /// The url_filtering_profile attribute.
    /// </summary>
    public TerraformValue<string> UrlFilteringProfile
        => CreateReference("url_filtering_profile");

    /// <summary>
    /// The vulnerability_profile attribute.
    /// </summary>
    public TerraformValue<string> VulnerabilityProfile
        => CreateReference("vulnerability_profile");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPaloAltoLocalRulestackDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPaloAltoLocalRulestackDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
