using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermNetappVolumeGroupSapHanaDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermNetappVolumeGroupSapHanaDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_netapp_volume_group_sap_hana Terraform data source.
/// Retrieves information about a azurerm_netapp_volume_group_sap_hana.
/// </summary>
public partial class AzurermNetappVolumeGroupSapHanaDataSource(string name) : TerraformDataSource("azurerm_netapp_volume_group_sap_hana", name)
{
    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformValue<string> AccountName
    {
        get => GetRequiredArgument<TerraformValue<string>>("account_name");
        set => SetArgument("account_name", value);
    }

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
    /// The application_identifier attribute.
    /// </summary>
    public TerraformValue<string> ApplicationIdentifier
        => AsReference("application_identifier");

    /// <summary>
    /// The group_description attribute.
    /// </summary>
    public TerraformValue<string> GroupDescription
        => AsReference("group_description");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The volume attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Volume
        => AsReference("volume");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetappVolumeGroupSapHanaDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetappVolumeGroupSapHanaDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
