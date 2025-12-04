using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermActiveDirectoryDomainServiceReplicaSet.
/// Nesting mode: single
/// </summary>
public class AzurermActiveDirectoryDomainServiceReplicaSetTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a azurerm_active_directory_domain_service_replica_set Terraform resource.
/// Manages a azurerm_active_directory_domain_service_replica_set resource.
/// </summary>
public partial class AzurermActiveDirectoryDomainServiceReplicaSet(string name) : TerraformResource("azurerm_active_directory_domain_service_replica_set", name)
{
    /// <summary>
    /// The domain_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainServiceId is required")]
    public required TerraformValue<string> DomainServiceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("domain_service_id");
        set => SetArgument("domain_service_id", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The domain_controller_ip_addresses attribute.
    /// </summary>
    public TerraformList<string> DomainControllerIpAddresses
        => AsReference("domain_controller_ip_addresses");

    /// <summary>
    /// The external_access_ip_address attribute.
    /// </summary>
    public TerraformValue<string> ExternalAccessIpAddress
        => AsReference("external_access_ip_address");

    /// <summary>
    /// The service_status attribute.
    /// </summary>
    public TerraformValue<string> ServiceStatus
        => AsReference("service_status");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermActiveDirectoryDomainServiceReplicaSetTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermActiveDirectoryDomainServiceReplicaSetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
