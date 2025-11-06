using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_palo_alto_local_rulestack resource.
/// </summary>
public class AzurermPaloAltoLocalRulestack : TerraformResource
{
    public AzurermPaloAltoLocalRulestack(string name) : base("azurerm_palo_alto_local_rulestack", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The anti_spyware_profile attribute.
    /// </summary>
    public string? AntiSpywareProfile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("anti_spyware_profile")?.Value;
        set => this.WithProperty("anti_spyware_profile", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The anti_virus_profile attribute.
    /// </summary>
    public string? AntiVirusProfile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("anti_virus_profile")?.Value;
        set => this.WithProperty("anti_virus_profile", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The dns_subscription attribute.
    /// </summary>
    public string? DnsSubscription
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dns_subscription")?.Value;
        set => this.WithProperty("dns_subscription", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The file_blocking_profile attribute.
    /// </summary>
    public string? FileBlockingProfile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("file_blocking_profile")?.Value;
        set => this.WithProperty("file_blocking_profile", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The url_filtering_profile attribute.
    /// </summary>
    public string? UrlFilteringProfile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("url_filtering_profile")?.Value;
        set => this.WithProperty("url_filtering_profile", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vulnerability_profile attribute.
    /// </summary>
    public string? VulnerabilityProfile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vulnerability_profile")?.Value;
        set => this.WithProperty("vulnerability_profile", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
