using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermPublicIpDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermPublicIpDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_public_ip Terraform data source.
/// Retrieves information about a azurerm_public_ip.
/// </summary>
public partial class AzurermPublicIpDataSource(string name) : TerraformDataSource("azurerm_public_ip", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
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
    /// The allocation_method attribute.
    /// </summary>
    public TerraformValue<string> AllocationMethod
        => AsReference("allocation_method");

    /// <summary>
    /// The ddos_protection_mode attribute.
    /// </summary>
    public TerraformValue<string> DdosProtectionMode
        => AsReference("ddos_protection_mode");

    /// <summary>
    /// The ddos_protection_plan_id attribute.
    /// </summary>
    public TerraformValue<string> DdosProtectionPlanId
        => AsReference("ddos_protection_plan_id");

    /// <summary>
    /// The domain_name_label attribute.
    /// </summary>
    public TerraformValue<string> DomainNameLabel
        => AsReference("domain_name_label");

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string> Fqdn
        => AsReference("fqdn");

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double> IdleTimeoutInMinutes
        => AsReference("idle_timeout_in_minutes");

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformValue<string> IpAddress
        => AsReference("ip_address");

    /// <summary>
    /// The ip_tags attribute.
    /// </summary>
    public TerraformMap<string> IpTags
        => AsReference("ip_tags");

    /// <summary>
    /// The ip_version attribute.
    /// </summary>
    public TerraformValue<string> IpVersion
        => AsReference("ip_version");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The reverse_fqdn attribute.
    /// </summary>
    public TerraformValue<string> ReverseFqdn
        => AsReference("reverse_fqdn");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string> Sku
        => AsReference("sku");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformList<string> Zones
        => AsReference("zones");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPublicIpDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPublicIpDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
