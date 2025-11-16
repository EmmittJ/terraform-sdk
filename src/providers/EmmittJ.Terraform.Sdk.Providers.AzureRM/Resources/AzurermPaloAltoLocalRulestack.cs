using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_palo_alto_local_rulestack Terraform resource.
/// Manages a azurerm_palo_alto_local_rulestack resource.
/// </summary>
public partial class AzurermPaloAltoLocalRulestack(string name) : TerraformResource("azurerm_palo_alto_local_rulestack", name)
{
    /// <summary>
    /// The anti_spyware_profile attribute.
    /// </summary>
    public TerraformValue<string>? AntiSpywareProfile
    {
        get => new TerraformReference<string>(this, "anti_spyware_profile");
        set => SetArgument("anti_spyware_profile", value);
    }

    /// <summary>
    /// The anti_virus_profile attribute.
    /// </summary>
    public TerraformValue<string>? AntiVirusProfile
    {
        get => new TerraformReference<string>(this, "anti_virus_profile");
        set => SetArgument("anti_virus_profile", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The dns_subscription attribute.
    /// </summary>
    public TerraformValue<string>? DnsSubscription
    {
        get => new TerraformReference<string>(this, "dns_subscription");
        set => SetArgument("dns_subscription", value);
    }

    /// <summary>
    /// The file_blocking_profile attribute.
    /// </summary>
    public TerraformValue<string>? FileBlockingProfile
    {
        get => new TerraformReference<string>(this, "file_blocking_profile");
        set => SetArgument("file_blocking_profile", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The url_filtering_profile attribute.
    /// </summary>
    public TerraformValue<string>? UrlFilteringProfile
    {
        get => new TerraformReference<string>(this, "url_filtering_profile");
        set => SetArgument("url_filtering_profile", value);
    }

    /// <summary>
    /// The vulnerability_profile attribute.
    /// </summary>
    public TerraformValue<string>? VulnerabilityProfile
    {
        get => new TerraformReference<string>(this, "vulnerability_profile");
        set => SetArgument("vulnerability_profile", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPaloAltoLocalRulestackTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPaloAltoLocalRulestackTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
