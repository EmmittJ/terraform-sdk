using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermPublicIpPrefixDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermPublicIpPrefixDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_public_ip_prefix Terraform data source.
/// Retrieves information about a azurerm_public_ip_prefix.
/// </summary>
public partial class AzurermPublicIpPrefixDataSource(string name) : TerraformDataSource("azurerm_public_ip_prefix", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The ip_prefix attribute.
    /// </summary>
    public TerraformValue<string> IpPrefix
        => AsReference("ip_prefix");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The prefix_length attribute.
    /// </summary>
    public TerraformValue<double> PrefixLength
        => AsReference("prefix_length");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string> Sku
        => AsReference("sku");

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    public TerraformValue<string> SkuTier
        => AsReference("sku_tier");

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
    public AzurermPublicIpPrefixDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPublicIpPrefixDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
