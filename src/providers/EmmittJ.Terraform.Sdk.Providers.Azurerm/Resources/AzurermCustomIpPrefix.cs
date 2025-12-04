using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermCustomIpPrefix.
/// Nesting mode: single
/// </summary>
public class AzurermCustomIpPrefixTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_custom_ip_prefix Terraform resource.
/// Manages a azurerm_custom_ip_prefix resource.
/// </summary>
public partial class AzurermCustomIpPrefix(string name) : TerraformResource("azurerm_custom_ip_prefix", name)
{
    /// <summary>
    /// The cidr attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Cidr is required")]
    public required TerraformValue<string> Cidr
    {
        get => GetArgument<TerraformValue<string>>("cidr");
        set => SetArgument("cidr", value);
    }

    /// <summary>
    /// The commissioning_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? CommissioningEnabled
    {
        get => GetArgument<TerraformValue<bool>>("commissioning_enabled");
        set => SetArgument("commissioning_enabled", value);
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
    /// The internet_advertising_disabled attribute.
    /// </summary>
    public TerraformValue<bool>? InternetAdvertisingDisabled
    {
        get => GetArgument<TerraformValue<bool>>("internet_advertising_disabled");
        set => SetArgument("internet_advertising_disabled", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
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
    /// The parent_custom_ip_prefix_id attribute.
    /// </summary>
    public TerraformValue<string>? ParentCustomIpPrefixId
    {
        get => GetArgument<TerraformValue<string>>("parent_custom_ip_prefix_id");
        set => SetArgument("parent_custom_ip_prefix_id", value);
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
    /// The roa_validity_end_date attribute.
    /// </summary>
    public TerraformValue<string>? RoaValidityEndDate
    {
        get => GetArgument<TerraformValue<string>>("roa_validity_end_date");
        set => SetArgument("roa_validity_end_date", value);
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
    /// The wan_validation_signed_message attribute.
    /// </summary>
    public TerraformValue<string>? WanValidationSignedMessage
    {
        get => GetArgument<TerraformValue<string>>("wan_validation_signed_message");
        set => SetArgument("wan_validation_signed_message", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformSet<string>? Zones
    {
        get => GetArgument<TerraformSet<string>>("zones");
        set => SetArgument("zones", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCustomIpPrefixTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCustomIpPrefixTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
