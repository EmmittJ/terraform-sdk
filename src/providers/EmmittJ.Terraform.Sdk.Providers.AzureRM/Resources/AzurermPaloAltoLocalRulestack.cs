using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPaloAltoLocalRulestackTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_palo_alto_local_rulestack resource.
/// </summary>
public class AzurermPaloAltoLocalRulestack : TerraformResource
{
    public AzurermPaloAltoLocalRulestack(string name) : base("azurerm_palo_alto_local_rulestack", name)
    {
    }

    /// <summary>
    /// The anti_spyware_profile attribute.
    /// </summary>
    [TerraformArgument("anti_spyware_profile")]
    public TerraformValue<string>? AntiSpywareProfile
    {
        get => new TerraformReference<string>(this, "anti_spyware_profile");
        set => SetArgument("anti_spyware_profile", value);
    }

    /// <summary>
    /// The anti_virus_profile attribute.
    /// </summary>
    [TerraformArgument("anti_virus_profile")]
    public TerraformValue<string>? AntiVirusProfile
    {
        get => new TerraformReference<string>(this, "anti_virus_profile");
        set => SetArgument("anti_virus_profile", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The dns_subscription attribute.
    /// </summary>
    [TerraformArgument("dns_subscription")]
    public TerraformValue<string>? DnsSubscription
    {
        get => new TerraformReference<string>(this, "dns_subscription");
        set => SetArgument("dns_subscription", value);
    }

    /// <summary>
    /// The file_blocking_profile attribute.
    /// </summary>
    [TerraformArgument("file_blocking_profile")]
    public TerraformValue<string>? FileBlockingProfile
    {
        get => new TerraformReference<string>(this, "file_blocking_profile");
        set => SetArgument("file_blocking_profile", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The url_filtering_profile attribute.
    /// </summary>
    [TerraformArgument("url_filtering_profile")]
    public TerraformValue<string>? UrlFilteringProfile
    {
        get => new TerraformReference<string>(this, "url_filtering_profile");
        set => SetArgument("url_filtering_profile", value);
    }

    /// <summary>
    /// The vulnerability_profile attribute.
    /// </summary>
    [TerraformArgument("vulnerability_profile")]
    public TerraformValue<string>? VulnerabilityProfile
    {
        get => new TerraformReference<string>(this, "vulnerability_profile");
        set => SetArgument("vulnerability_profile", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermPaloAltoLocalRulestackTimeoutsBlock Timeouts { get; set; } = new();

}
