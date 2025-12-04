using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for identity in AzurermWorkloadsSapDiscoveryVirtualInstance.
/// Nesting mode: list
/// </summary>
public class AzurermWorkloadsSapDiscoveryVirtualInstanceIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    public required TerraformSet<string> IdentityIds
    {
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermWorkloadsSapDiscoveryVirtualInstance.
/// Nesting mode: single
/// </summary>
public class AzurermWorkloadsSapDiscoveryVirtualInstanceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_workloads_sap_discovery_virtual_instance Terraform resource.
/// Manages a azurerm_workloads_sap_discovery_virtual_instance resource.
/// </summary>
public partial class AzurermWorkloadsSapDiscoveryVirtualInstance(string name) : TerraformResource("azurerm_workloads_sap_discovery_virtual_instance", name)
{
    /// <summary>
    /// The central_server_virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CentralServerVirtualMachineId is required")]
    public required TerraformValue<string> CentralServerVirtualMachineId
    {
        get => GetArgument<TerraformValue<string>>("central_server_virtual_machine_id");
        set => SetArgument("central_server_virtual_machine_id", value);
    }

    /// <summary>
    /// The environment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    public required TerraformValue<string> Environment
    {
        get => GetArgument<TerraformValue<string>>("environment");
        set => SetArgument("environment", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    public TerraformValue<string>? ManagedResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("managed_resource_group_name");
        set => SetArgument("managed_resource_group_name", value);
    }

    /// <summary>
    /// The managed_resources_network_access_type attribute.
    /// </summary>
    public TerraformValue<string>? ManagedResourcesNetworkAccessType
    {
        get => GetArgument<TerraformValue<string>>("managed_resources_network_access_type");
        set => SetArgument("managed_resources_network_access_type", value);
    }

    /// <summary>
    /// The managed_storage_account_name attribute.
    /// </summary>
    public TerraformValue<string>? ManagedStorageAccountName
    {
        get => GetArgument<TerraformValue<string>>("managed_storage_account_name");
        set => SetArgument("managed_storage_account_name", value);
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
    /// The sap_product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SapProduct is required")]
    public required TerraformValue<string> SapProduct
    {
        get => GetArgument<TerraformValue<string>>("sap_product");
        set => SetArgument("sap_product", value);
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
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermWorkloadsSapDiscoveryVirtualInstanceIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermWorkloadsSapDiscoveryVirtualInstanceIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermWorkloadsSapDiscoveryVirtualInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermWorkloadsSapDiscoveryVirtualInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
