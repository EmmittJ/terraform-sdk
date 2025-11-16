using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "read");
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
    /// The anti_spyware_profile attribute.
    /// </summary>
    public TerraformValue<string> AntiSpywareProfile
    {
        get => new TerraformReference<string>(this, "anti_spyware_profile");
    }

    /// <summary>
    /// The anti_virus_profile attribute.
    /// </summary>
    public TerraformValue<string> AntiVirusProfile
    {
        get => new TerraformReference<string>(this, "anti_virus_profile");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The dns_subscription attribute.
    /// </summary>
    public TerraformValue<string> DnsSubscription
    {
        get => new TerraformReference<string>(this, "dns_subscription");
    }

    /// <summary>
    /// The file_blocking_profile attribute.
    /// </summary>
    public TerraformValue<string> FileBlockingProfile
    {
        get => new TerraformReference<string>(this, "file_blocking_profile");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The outbound_trust_certificate attribute.
    /// </summary>
    public TerraformValue<string> OutboundTrustCertificate
    {
        get => new TerraformReference<string>(this, "outbound_trust_certificate");
    }

    /// <summary>
    /// The outbound_untrust_certificate attribute.
    /// </summary>
    public TerraformValue<string> OutboundUntrustCertificate
    {
        get => new TerraformReference<string>(this, "outbound_untrust_certificate");
    }

    /// <summary>
    /// The url_filtering_profile attribute.
    /// </summary>
    public TerraformValue<string> UrlFilteringProfile
    {
        get => new TerraformReference<string>(this, "url_filtering_profile");
    }

    /// <summary>
    /// The vulnerability_profile attribute.
    /// </summary>
    public TerraformValue<string> VulnerabilityProfile
    {
        get => new TerraformReference<string>(this, "vulnerability_profile");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPaloAltoLocalRulestackDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPaloAltoLocalRulestackDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
