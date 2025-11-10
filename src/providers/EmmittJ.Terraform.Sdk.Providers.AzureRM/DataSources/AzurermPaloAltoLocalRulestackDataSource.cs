using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPaloAltoLocalRulestackDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_palo_alto_local_rulestack.
/// </summary>
public class AzurermPaloAltoLocalRulestackDataSource : TerraformDataSource
{
    public AzurermPaloAltoLocalRulestackDataSource(string name) : base("azurerm_palo_alto_local_rulestack", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("anti_spyware_profile");
        SetOutput("anti_virus_profile");
        SetOutput("description");
        SetOutput("dns_subscription");
        SetOutput("file_blocking_profile");
        SetOutput("location");
        SetOutput("outbound_trust_certificate");
        SetOutput("outbound_untrust_certificate");
        SetOutput("url_filtering_profile");
        SetOutput("vulnerability_profile");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPaloAltoLocalRulestackDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The anti_spyware_profile attribute.
    /// </summary>
    public TerraformExpression AntiSpywareProfile => this["anti_spyware_profile"];

    /// <summary>
    /// The anti_virus_profile attribute.
    /// </summary>
    public TerraformExpression AntiVirusProfile => this["anti_virus_profile"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The dns_subscription attribute.
    /// </summary>
    public TerraformExpression DnsSubscription => this["dns_subscription"];

    /// <summary>
    /// The file_blocking_profile attribute.
    /// </summary>
    public TerraformExpression FileBlockingProfile => this["file_blocking_profile"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The outbound_trust_certificate attribute.
    /// </summary>
    public TerraformExpression OutboundTrustCertificate => this["outbound_trust_certificate"];

    /// <summary>
    /// The outbound_untrust_certificate attribute.
    /// </summary>
    public TerraformExpression OutboundUntrustCertificate => this["outbound_untrust_certificate"];

    /// <summary>
    /// The url_filtering_profile attribute.
    /// </summary>
    public TerraformExpression UrlFilteringProfile => this["url_filtering_profile"];

    /// <summary>
    /// The vulnerability_profile attribute.
    /// </summary>
    public TerraformExpression VulnerabilityProfile => this["vulnerability_profile"];

}
