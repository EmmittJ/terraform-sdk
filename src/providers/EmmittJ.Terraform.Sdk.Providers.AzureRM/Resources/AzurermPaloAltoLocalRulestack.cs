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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("anti_spyware_profile");
        SetOutput("anti_virus_profile");
        SetOutput("description");
        SetOutput("dns_subscription");
        SetOutput("file_blocking_profile");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("url_filtering_profile");
        SetOutput("vulnerability_profile");
    }

    /// <summary>
    /// The anti_spyware_profile attribute.
    /// </summary>
    public TerraformProperty<string> AntiSpywareProfile
    {
        get => GetRequiredOutput<TerraformProperty<string>>("anti_spyware_profile");
        set => SetProperty("anti_spyware_profile", value);
    }

    /// <summary>
    /// The anti_virus_profile attribute.
    /// </summary>
    public TerraformProperty<string> AntiVirusProfile
    {
        get => GetRequiredOutput<TerraformProperty<string>>("anti_virus_profile");
        set => SetProperty("anti_virus_profile", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The dns_subscription attribute.
    /// </summary>
    public TerraformProperty<string> DnsSubscription
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dns_subscription");
        set => SetProperty("dns_subscription", value);
    }

    /// <summary>
    /// The file_blocking_profile attribute.
    /// </summary>
    public TerraformProperty<string> FileBlockingProfile
    {
        get => GetRequiredOutput<TerraformProperty<string>>("file_blocking_profile");
        set => SetProperty("file_blocking_profile", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// The url_filtering_profile attribute.
    /// </summary>
    public TerraformProperty<string> UrlFilteringProfile
    {
        get => GetRequiredOutput<TerraformProperty<string>>("url_filtering_profile");
        set => SetProperty("url_filtering_profile", value);
    }

    /// <summary>
    /// The vulnerability_profile attribute.
    /// </summary>
    public TerraformProperty<string> VulnerabilityProfile
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vulnerability_profile");
        set => SetProperty("vulnerability_profile", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermPaloAltoLocalRulestackTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
