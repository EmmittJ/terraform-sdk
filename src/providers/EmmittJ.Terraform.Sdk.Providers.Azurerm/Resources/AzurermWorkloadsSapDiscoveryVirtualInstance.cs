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
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "central_server_virtual_machine_id");
        set => SetArgument("central_server_virtual_machine_id", value);
    }

    /// <summary>
    /// The environment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environment is required")]
    public required TerraformValue<string> Environment
    {
        get => new TerraformReference<string>(this, "environment");
        set => SetArgument("environment", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    public TerraformValue<string>? ManagedResourceGroupName
    {
        get => new TerraformReference<string>(this, "managed_resource_group_name");
        set => SetArgument("managed_resource_group_name", value);
    }

    /// <summary>
    /// The managed_resources_network_access_type attribute.
    /// </summary>
    public TerraformValue<string>? ManagedResourcesNetworkAccessType
    {
        get => new TerraformReference<string>(this, "managed_resources_network_access_type");
        set => SetArgument("managed_resources_network_access_type", value);
    }

    /// <summary>
    /// The managed_storage_account_name attribute.
    /// </summary>
    public TerraformValue<string>? ManagedStorageAccountName
    {
        get => new TerraformReference<string>(this, "managed_storage_account_name");
        set => SetArgument("managed_storage_account_name", value);
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
    /// The sap_product attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SapProduct is required")]
    public required TerraformValue<string> SapProduct
    {
        get => new TerraformReference<string>(this, "sap_product");
        set => SetArgument("sap_product", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
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
