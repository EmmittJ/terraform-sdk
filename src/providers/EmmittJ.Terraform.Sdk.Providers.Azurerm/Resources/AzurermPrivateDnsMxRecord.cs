using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for record in AzurermPrivateDnsMxRecord.
/// Nesting mode: set
/// </summary>
public class AzurermPrivateDnsMxRecordRecordBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "record";

    /// <summary>
    /// The exchange attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Exchange is required")]
    public required TerraformValue<string> Exchange
    {
        get => GetArgument<TerraformValue<string>>("exchange");
        set => SetArgument("exchange", value);
    }

    /// <summary>
    /// The preference attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Preference is required")]
    public required TerraformValue<double> Preference
    {
        get => GetArgument<TerraformValue<double>>("preference");
        set => SetArgument("preference", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermPrivateDnsMxRecord.
/// Nesting mode: single
/// </summary>
public class AzurermPrivateDnsMxRecordTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_private_dns_mx_record Terraform resource.
/// Manages a azurerm_private_dns_mx_record resource.
/// </summary>
public partial class AzurermPrivateDnsMxRecord(string name) : TerraformResource("azurerm_private_dns_mx_record", name)
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
    public TerraformValue<string>? Name
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ttl is required")]
    public required TerraformValue<double> Ttl
    {
        get => GetArgument<TerraformValue<double>>("ttl");
        set => SetArgument("ttl", value);
    }

    /// <summary>
    /// The zone_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneName is required")]
    public required TerraformValue<string> ZoneName
    {
        get => GetArgument<TerraformValue<string>>("zone_name");
        set => SetArgument("zone_name", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string> Fqdn
        => AsReference("fqdn");

    /// <summary>
    /// Record block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Record is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Record block(s) required")]
    public required TerraformSet<AzurermPrivateDnsMxRecordRecordBlock> Record
    {
        get => GetRequiredArgument<TerraformSet<AzurermPrivateDnsMxRecordRecordBlock>>("record");
        set => SetArgument("record", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPrivateDnsMxRecordTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPrivateDnsMxRecordTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
