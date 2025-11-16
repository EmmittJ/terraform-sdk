using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for load_balancer_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineAvailabilityGroupListenerLoadBalancerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "load_balancer_configuration";

    /// <summary>
    /// The load_balancer_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancerId is required")]
    public required TerraformValue<string> LoadBalancerId
    {
        get => new TerraformReference<string>(this, "load_balancer_id");
        set => SetArgument("load_balancer_id", value);
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateIpAddress is required")]
    public required TerraformValue<string> PrivateIpAddress
    {
        get => new TerraformReference<string>(this, "private_ip_address");
        set => SetArgument("private_ip_address", value);
    }

    /// <summary>
    /// The probe_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProbePort is required")]
    public required TerraformValue<double> ProbePort
    {
        get => new TerraformReference<double>(this, "probe_port");
        set => SetArgument("probe_port", value);
    }

    /// <summary>
    /// The sql_virtual_machine_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlVirtualMachineIds is required")]
    public required TerraformSet<string> SqlVirtualMachineIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "sql_virtual_machine_ids").ResolveNodes(ctx));
        set => SetArgument("sql_virtual_machine_ids", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

}

/// <summary>
/// Block type for multi_subnet_ip_configuration in .
/// Nesting mode: set
/// </summary>
public class AzurermMssqlVirtualMachineAvailabilityGroupListenerMultiSubnetIpConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "multi_subnet_ip_configuration";

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateIpAddress is required")]
    public required TerraformValue<string> PrivateIpAddress
    {
        get => new TerraformReference<string>(this, "private_ip_address");
        set => SetArgument("private_ip_address", value);
    }

    /// <summary>
    /// The sql_virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlVirtualMachineId is required")]
    public required TerraformValue<string> SqlVirtualMachineId
    {
        get => new TerraformReference<string>(this, "sql_virtual_machine_id");
        set => SetArgument("sql_virtual_machine_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

}

/// <summary>
/// Block type for replica in .
/// Nesting mode: set
/// </summary>
public class AzurermMssqlVirtualMachineAvailabilityGroupListenerReplicaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replica";

    /// <summary>
    /// The commit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Commit is required")]
    public required TerraformValue<string> Commit
    {
        get => new TerraformReference<string>(this, "commit");
        set => SetArgument("commit", value);
    }

    /// <summary>
    /// The failover_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailoverMode is required")]
    public required TerraformValue<string> FailoverMode
    {
        get => new TerraformReference<string>(this, "failover_mode");
        set => SetArgument("failover_mode", value);
    }

    /// <summary>
    /// The readable_secondary attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReadableSecondary is required")]
    public required TerraformValue<string> ReadableSecondary
    {
        get => new TerraformReference<string>(this, "readable_secondary");
        set => SetArgument("readable_secondary", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformValue<string> Role
    {
        get => new TerraformReference<string>(this, "role");
        set => SetArgument("role", value);
    }

    /// <summary>
    /// The sql_virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlVirtualMachineId is required")]
    public required TerraformValue<string> SqlVirtualMachineId
    {
        get => new TerraformReference<string>(this, "sql_virtual_machine_id");
        set => SetArgument("sql_virtual_machine_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlVirtualMachineAvailabilityGroupListenerTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Represents a azurerm_mssql_virtual_machine_availability_group_listener Terraform resource.
/// Manages a azurerm_mssql_virtual_machine_availability_group_listener resource.
/// </summary>
public partial class AzurermMssqlVirtualMachineAvailabilityGroupListener(string name) : TerraformResource("azurerm_mssql_virtual_machine_availability_group_listener", name)
{
    /// <summary>
    /// The availability_group_name attribute.
    /// </summary>
    public TerraformValue<string>? AvailabilityGroupName
    {
        get => new TerraformReference<string>(this, "availability_group_name");
        set => SetArgument("availability_group_name", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The sql_virtual_machine_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlVirtualMachineGroupId is required")]
    public required TerraformValue<string> SqlVirtualMachineGroupId
    {
        get => new TerraformReference<string>(this, "sql_virtual_machine_group_id");
        set => SetArgument("sql_virtual_machine_group_id", value);
    }

    /// <summary>
    /// LoadBalancerConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancerConfiguration block(s) allowed")]
    public AzurermMssqlVirtualMachineAvailabilityGroupListenerLoadBalancerConfigurationBlock? LoadBalancerConfiguration
    {
        get => GetArgument<AzurermMssqlVirtualMachineAvailabilityGroupListenerLoadBalancerConfigurationBlock>("load_balancer_configuration");
        set => SetArgument("load_balancer_configuration", value);
    }

    /// <summary>
    /// MultiSubnetIpConfiguration block (nesting mode: set).
    /// </summary>
    public AzurermMssqlVirtualMachineAvailabilityGroupListenerMultiSubnetIpConfigurationBlock? MultiSubnetIpConfiguration
    {
        get => GetArgument<AzurermMssqlVirtualMachineAvailabilityGroupListenerMultiSubnetIpConfigurationBlock>("multi_subnet_ip_configuration");
        set => SetArgument("multi_subnet_ip_configuration", value);
    }

    /// <summary>
    /// Replica block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Replica is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Replica block(s) required")]
    public required AzurermMssqlVirtualMachineAvailabilityGroupListenerReplicaBlock Replica
    {
        get => GetRequiredArgument<AzurermMssqlVirtualMachineAvailabilityGroupListenerReplicaBlock>("replica");
        set => SetArgument("replica", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMssqlVirtualMachineAvailabilityGroupListenerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMssqlVirtualMachineAvailabilityGroupListenerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
