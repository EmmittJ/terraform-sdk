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
    [TerraformArgument("load_balancer_id")]
    public required TerraformValue<string> LoadBalancerId
    {
        get => new TerraformReference<string>(this, "load_balancer_id");
        set => SetArgument("load_balancer_id", value);
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateIpAddress is required")]
    [TerraformArgument("private_ip_address")]
    public required TerraformValue<string> PrivateIpAddress
    {
        get => new TerraformReference<string>(this, "private_ip_address");
        set => SetArgument("private_ip_address", value);
    }

    /// <summary>
    /// The probe_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProbePort is required")]
    [TerraformArgument("probe_port")]
    public required TerraformValue<double> ProbePort
    {
        get => new TerraformReference<double>(this, "probe_port");
        set => SetArgument("probe_port", value);
    }

    /// <summary>
    /// The sql_virtual_machine_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlVirtualMachineIds is required")]
    [TerraformArgument("sql_virtual_machine_ids")]
    public required TerraformSet<string> SqlVirtualMachineIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "sql_virtual_machine_ids").ResolveNodes(ctx));
        set => SetArgument("sql_virtual_machine_ids", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformArgument("subnet_id")]
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
    [TerraformArgument("private_ip_address")]
    public required TerraformValue<string> PrivateIpAddress
    {
        get => new TerraformReference<string>(this, "private_ip_address");
        set => SetArgument("private_ip_address", value);
    }

    /// <summary>
    /// The sql_virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlVirtualMachineId is required")]
    [TerraformArgument("sql_virtual_machine_id")]
    public required TerraformValue<string> SqlVirtualMachineId
    {
        get => new TerraformReference<string>(this, "sql_virtual_machine_id");
        set => SetArgument("sql_virtual_machine_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformArgument("subnet_id")]
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
    [TerraformArgument("commit")]
    public required TerraformValue<string> Commit
    {
        get => new TerraformReference<string>(this, "commit");
        set => SetArgument("commit", value);
    }

    /// <summary>
    /// The failover_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailoverMode is required")]
    [TerraformArgument("failover_mode")]
    public required TerraformValue<string> FailoverMode
    {
        get => new TerraformReference<string>(this, "failover_mode");
        set => SetArgument("failover_mode", value);
    }

    /// <summary>
    /// The readable_secondary attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReadableSecondary is required")]
    [TerraformArgument("readable_secondary")]
    public required TerraformValue<string> ReadableSecondary
    {
        get => new TerraformReference<string>(this, "readable_secondary");
        set => SetArgument("readable_secondary", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    [TerraformArgument("role")]
    public required TerraformValue<string> Role
    {
        get => new TerraformReference<string>(this, "role");
        set => SetArgument("role", value);
    }

    /// <summary>
    /// The sql_virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlVirtualMachineId is required")]
    [TerraformArgument("sql_virtual_machine_id")]
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

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
/// Manages a azurerm_mssql_virtual_machine_availability_group_listener resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMssqlVirtualMachineAvailabilityGroupListener : TerraformResource
{
    public AzurermMssqlVirtualMachineAvailabilityGroupListener(string name) : base("azurerm_mssql_virtual_machine_availability_group_listener", name)
    {
    }

    /// <summary>
    /// The availability_group_name attribute.
    /// </summary>
    [TerraformArgument("availability_group_name")]
    public TerraformValue<string>? AvailabilityGroupName
    {
        get => new TerraformReference<string>(this, "availability_group_name");
        set => SetArgument("availability_group_name", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformArgument("port")]
    public TerraformValue<double>? Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The sql_virtual_machine_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlVirtualMachineGroupId is required")]
    [TerraformArgument("sql_virtual_machine_group_id")]
    public required TerraformValue<string> SqlVirtualMachineGroupId
    {
        get => new TerraformReference<string>(this, "sql_virtual_machine_group_id");
        set => SetArgument("sql_virtual_machine_group_id", value);
    }

    /// <summary>
    /// Block for load_balancer_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancerConfiguration block(s) allowed")]
    [TerraformArgument("load_balancer_configuration")]
    public TerraformList<AzurermMssqlVirtualMachineAvailabilityGroupListenerLoadBalancerConfigurationBlock> LoadBalancerConfiguration { get; set; } = new();

    /// <summary>
    /// Block for multi_subnet_ip_configuration.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("multi_subnet_ip_configuration")]
    public TerraformSet<AzurermMssqlVirtualMachineAvailabilityGroupListenerMultiSubnetIpConfigurationBlock> MultiSubnetIpConfiguration { get; set; } = new();

    /// <summary>
    /// Block for replica.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Replica is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Replica block(s) required")]
    [TerraformArgument("replica")]
    public required TerraformSet<AzurermMssqlVirtualMachineAvailabilityGroupListenerReplicaBlock> Replica { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMssqlVirtualMachineAvailabilityGroupListenerTimeoutsBlock Timeouts { get; set; } = new();

}
