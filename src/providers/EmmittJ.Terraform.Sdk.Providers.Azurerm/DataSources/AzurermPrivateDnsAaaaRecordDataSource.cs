using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermPrivateDnsAaaaRecordDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermPrivateDnsAaaaRecordDataSourceTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_private_dns_aaaa_record Terraform data source.
/// Retrieves information about a azurerm_private_dns_aaaa_record.
/// </summary>
public partial class AzurermPrivateDnsAaaaRecordDataSource(string name) : TerraformDataSource("azurerm_private_dns_aaaa_record", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The zone_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneName is required")]
    public required TerraformValue<string> ZoneName
    {
        get => new TerraformReference<string>(this, "zone_name");
        set => SetArgument("zone_name", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string> Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
    }

    /// <summary>
    /// The records attribute.
    /// </summary>
    public TerraformSet<string> Records
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "records").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformValue<double> Ttl
    {
        get => new TerraformReference<double>(this, "ttl");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPrivateDnsAaaaRecordDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPrivateDnsAaaaRecordDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
