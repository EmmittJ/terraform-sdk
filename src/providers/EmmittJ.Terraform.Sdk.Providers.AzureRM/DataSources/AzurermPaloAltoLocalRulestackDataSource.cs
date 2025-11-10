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
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
        this.WithOutput("anti_spyware_profile");
        this.WithOutput("anti_virus_profile");
        this.WithOutput("description");
        this.WithOutput("dns_subscription");
        this.WithOutput("file_blocking_profile");
        this.WithOutput("location");
        this.WithOutput("outbound_trust_certificate");
        this.WithOutput("outbound_untrust_certificate");
        this.WithOutput("url_filtering_profile");
        this.WithOutput("vulnerability_profile");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPaloAltoLocalRulestackDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermPaloAltoLocalRulestackDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
