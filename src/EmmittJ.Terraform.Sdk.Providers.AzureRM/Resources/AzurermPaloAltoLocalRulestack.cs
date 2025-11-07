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
    public TerraformLiteralProperty<string>? AntiSpywareProfile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("anti_spyware_profile");
        set => this.WithProperty("anti_spyware_profile", value);
    }

    /// <summary>
    /// The anti_virus_profile attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AntiVirusProfile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("anti_virus_profile");
        set => this.WithProperty("anti_virus_profile", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The dns_subscription attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DnsSubscription
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dns_subscription");
        set => this.WithProperty("dns_subscription", value);
    }

    /// <summary>
    /// The file_blocking_profile attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FileBlockingProfile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("file_blocking_profile");
        set => this.WithProperty("file_blocking_profile", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The url_filtering_profile attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? UrlFilteringProfile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("url_filtering_profile");
        set => this.WithProperty("url_filtering_profile", value);
    }

    /// <summary>
    /// The vulnerability_profile attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VulnerabilityProfile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vulnerability_profile");
        set => this.WithProperty("vulnerability_profile", value);
    }

}
