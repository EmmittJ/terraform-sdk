using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermPublicIpsDataSource.
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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("allocation_type");
        set => SetArgument("allocation_type", value);
    }

    /// <summary>
    /// The attachment_status attribute.
    /// </summary>
    public TerraformValue<string>? AttachmentStatus
    {
        get => GetArgument<TerraformValue<string>>("attachment_status");
        set => SetArgument("attachment_status", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name_prefix attribute.
    /// </summary>
    public TerraformValue<string>? NamePrefix
    {
        get => GetArgument<TerraformValue<string>>("name_prefix");
        set => SetArgument("name_prefix", value);
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
    /// The public_ips attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PublicIps
        => AsReference("public_ips");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPublicIpsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPublicIpsDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
