using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermStackHciClusterDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermStackHciClusterDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_stack_hci_cluster Terraform data source.
/// Retrieves information about a azurerm_stack_hci_cluster.
/// </summary>
public partial class AzurermStackHciClusterDataSource(string name) : TerraformDataSource("azurerm_stack_hci_cluster", name)
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
    /// The automanage_configuration_id attribute.
    /// </summary>
    public TerraformValue<string> AutomanageConfigurationId
        => AsReference("automanage_configuration_id");

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    public TerraformValue<string> ClientId
        => AsReference("client_id");

    /// <summary>
    /// The cloud_id attribute.
    /// </summary>
    public TerraformValue<string> CloudId
        => AsReference("cloud_id");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => AsReference("identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The resource_provider_object_id attribute.
    /// </summary>
    public TerraformValue<string> ResourceProviderObjectId
        => AsReference("resource_provider_object_id");

    /// <summary>
    /// The service_endpoint attribute.
    /// </summary>
    public TerraformValue<string> ServiceEndpoint
        => AsReference("service_endpoint");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStackHciClusterDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStackHciClusterDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
