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
public class AzurermPublicIpsDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_public_ips.
/// </summary>
public class AzurermPublicIpsDataSource : TerraformDataSource
{
    public AzurermPublicIpsDataSource(string name) : base("azurerm_public_ips", name)
    {
    }

    /// <summary>
    /// The allocation_type attribute.
    /// </summary>
    [TerraformArgument("allocation_type")]
    public TerraformValue<string>? AllocationType
    {
        get => new TerraformReference<string>(this, "allocation_type");
        set => SetArgument("allocation_type", value);
    }

    /// <summary>
    /// The attachment_status attribute.
    /// </summary>
    [TerraformArgument("attachment_status")]
    public TerraformValue<string>? AttachmentStatus
    {
        get => new TerraformReference<string>(this, "attachment_status");
        set => SetArgument("attachment_status", value);
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
    /// The name_prefix attribute.
    /// </summary>
    [TerraformArgument("name_prefix")]
    public TerraformValue<string>? NamePrefix
    {
        get => new TerraformReference<string>(this, "name_prefix");
        set => SetArgument("name_prefix", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermPublicIpsDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The public_ips attribute.
    /// </summary>
    [TerraformArgument("public_ips")]
    public TerraformList<object> PublicIps
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "public_ips").ResolveNodes(ctx));
    }

}
