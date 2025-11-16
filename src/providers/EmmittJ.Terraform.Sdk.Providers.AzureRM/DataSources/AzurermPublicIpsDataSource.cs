using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPublicIpsDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_public_ips Terraform data source.
/// Retrieves information about a azurerm_public_ips.
/// </summary>
public partial class AzurermPublicIpsDataSource(string name) : TerraformDataSource("azurerm_public_ips", name)
{
    /// <summary>
    /// The allocation_type attribute.
    /// </summary>
    public TerraformValue<string>? AllocationType
    {
        get => new TerraformReference<string>(this, "allocation_type");
        set => SetArgument("allocation_type", value);
    }

    /// <summary>
    /// The attachment_status attribute.
    /// </summary>
    public TerraformValue<string>? AttachmentStatus
    {
        get => new TerraformReference<string>(this, "attachment_status");
        set => SetArgument("attachment_status", value);
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
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string>? NamePrefix
    {
        get => new TerraformReference<string>(this, "name_prefix");
        set => SetArgument("name_prefix", value);
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
    /// The public_ips attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PublicIps
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "public_ips").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPublicIpsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPublicIpsDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
