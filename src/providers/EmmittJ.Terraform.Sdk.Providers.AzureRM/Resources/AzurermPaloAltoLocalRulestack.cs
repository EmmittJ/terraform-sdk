using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPaloAltoLocalRulestackTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    public TerraformProperty<string>? AntiSpywareProfile
    {
        get => GetProperty<TerraformProperty<string>>("anti_spyware_profile");
        set => this.WithProperty("anti_spyware_profile", value);
    }

    /// <summary>
    /// The anti_virus_profile attribute.
    /// </summary>
    public TerraformProperty<string>? AntiVirusProfile
    {
        get => GetProperty<TerraformProperty<string>>("anti_virus_profile");
        set => this.WithProperty("anti_virus_profile", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The dns_subscription attribute.
    /// </summary>
    public TerraformProperty<string>? DnsSubscription
    {
        get => GetProperty<TerraformProperty<string>>("dns_subscription");
        set => this.WithProperty("dns_subscription", value);
    }

    /// <summary>
    /// The file_blocking_profile attribute.
    /// </summary>
    public TerraformProperty<string>? FileBlockingProfile
    {
        get => GetProperty<TerraformProperty<string>>("file_blocking_profile");
        set => this.WithProperty("file_blocking_profile", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The url_filtering_profile attribute.
    /// </summary>
    public TerraformProperty<string>? UrlFilteringProfile
    {
        get => GetProperty<TerraformProperty<string>>("url_filtering_profile");
        set => this.WithProperty("url_filtering_profile", value);
    }

    /// <summary>
    /// The vulnerability_profile attribute.
    /// </summary>
    public TerraformProperty<string>? VulnerabilityProfile
    {
        get => GetProperty<TerraformProperty<string>>("vulnerability_profile");
        set => this.WithProperty("vulnerability_profile", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPaloAltoLocalRulestackTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermPaloAltoLocalRulestackTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
