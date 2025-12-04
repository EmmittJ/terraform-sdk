using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermEventgridDomainDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermEventgridDomainDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_eventgrid_domain Terraform data source.
/// Retrieves information about a azurerm_eventgrid_domain.
/// </summary>
public partial class AzurermEventgridDomainDataSource(string name) : TerraformDataSource("azurerm_eventgrid_domain", name)
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
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
        => AsReference("endpoint");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => AsReference("identity");

    /// <summary>
    /// The inbound_ip_rule attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> InboundIpRule
        => AsReference("inbound_ip_rule");

    /// <summary>
    /// The input_mapping_default_values attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> InputMappingDefaultValues
        => AsReference("input_mapping_default_values");

    /// <summary>
    /// The input_mapping_fields attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> InputMappingFields
        => AsReference("input_mapping_fields");

    /// <summary>
    /// The input_schema attribute.
    /// </summary>
    public TerraformValue<string> InputSchema
        => AsReference("input_schema");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryAccessKey
        => AsReference("primary_access_key");

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool> PublicNetworkAccessEnabled
        => AsReference("public_network_access_enabled");

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformValue<string> SecondaryAccessKey
        => AsReference("secondary_access_key");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermEventgridDomainDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermEventgridDomainDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
