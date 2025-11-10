using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for load_balancer_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineAvailabilityGroupListenerLoadBalancerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The load_balancer_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancerId is required")]
    public required TerraformProperty<string> LoadBalancerId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("load_balancer_id");
        set => WithProperty("load_balancer_id", value);
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateIpAddress is required")]
    public required TerraformProperty<string> PrivateIpAddress
    {
        get => GetRequiredProperty<TerraformProperty<string>>("private_ip_address");
        set => WithProperty("private_ip_address", value);
    }

    /// <summary>
    /// The probe_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProbePort is required")]
    public required TerraformProperty<double> ProbePort
    {
        get => GetRequiredProperty<TerraformProperty<double>>("probe_port");
        set => WithProperty("probe_port", value);
    }

    /// <summary>
    /// The sql_virtual_machine_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlVirtualMachineIds is required")]
    public HashSet<TerraformProperty<string>>? SqlVirtualMachineIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("sql_virtual_machine_ids");
        set => WithProperty("sql_virtual_machine_ids", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
    }

}

/// <summary>
/// Block type for multi_subnet_ip_configuration in .
/// Nesting mode: set
/// </summary>
public class AzurermMssqlVirtualMachineAvailabilityGroupListenerMultiSubnetIpConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateIpAddress is required")]
    public required TerraformProperty<string> PrivateIpAddress
    {
        get => GetRequiredProperty<TerraformProperty<string>>("private_ip_address");
        set => WithProperty("private_ip_address", value);
    }

    /// <summary>
    /// The sql_virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlVirtualMachineId is required")]
    public required TerraformProperty<string> SqlVirtualMachineId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("sql_virtual_machine_id");
        set => WithProperty("sql_virtual_machine_id", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("subnet_id");
        set => WithProperty("subnet_id", value);
    }

}

/// <summary>
/// Block type for replica in .
/// Nesting mode: set
/// </summary>
public class AzurermMssqlVirtualMachineAvailabilityGroupListenerReplicaBlock : TerraformBlock
{
    /// <summary>
    /// The commit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Commit is required")]
    public required TerraformProperty<string> Commit
    {
        get => GetRequiredProperty<TerraformProperty<string>>("commit");
        set => WithProperty("commit", value);
    }

    /// <summary>
    /// The failover_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailoverMode is required")]
    public required TerraformProperty<string> FailoverMode
    {
        get => GetRequiredProperty<TerraformProperty<string>>("failover_mode");
        set => WithProperty("failover_mode", value);
    }

    /// <summary>
    /// The readable_secondary attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReadableSecondary is required")]
    public required TerraformProperty<string> ReadableSecondary
    {
        get => GetRequiredProperty<TerraformProperty<string>>("readable_secondary");
        set => WithProperty("readable_secondary", value);
    }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    public required TerraformProperty<string> Role
    {
        get => GetRequiredProperty<TerraformProperty<string>>("role");
        set => WithProperty("role", value);
    }

    /// <summary>
    /// The sql_virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlVirtualMachineId is required")]
    public required TerraformProperty<string> SqlVirtualMachineId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("sql_virtual_machine_id");
        set => WithProperty("sql_virtual_machine_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlVirtualMachineAvailabilityGroupListenerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The availability_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? AvailabilityGroupName
    {
        get => GetProperty<TerraformProperty<string>>("availability_group_name");
        set => this.WithProperty("availability_group_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => this.WithProperty("port", value);
    }

    /// <summary>
    /// The sql_virtual_machine_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlVirtualMachineGroupId is required")]
    public required TerraformProperty<string> SqlVirtualMachineGroupId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("sql_virtual_machine_group_id");
        set => this.WithProperty("sql_virtual_machine_group_id", value);
    }

    /// <summary>
    /// Block for load_balancer_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancerConfiguration block(s) allowed")]
    public List<AzurermMssqlVirtualMachineAvailabilityGroupListenerLoadBalancerConfigurationBlock>? LoadBalancerConfiguration
    {
        get => GetProperty<List<AzurermMssqlVirtualMachineAvailabilityGroupListenerLoadBalancerConfigurationBlock>>("load_balancer_configuration");
        set => this.WithProperty("load_balancer_configuration", value);
    }

    /// <summary>
    /// Block for multi_subnet_ip_configuration.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermMssqlVirtualMachineAvailabilityGroupListenerMultiSubnetIpConfigurationBlock>? MultiSubnetIpConfiguration
    {
        get => GetProperty<HashSet<AzurermMssqlVirtualMachineAvailabilityGroupListenerMultiSubnetIpConfigurationBlock>>("multi_subnet_ip_configuration");
        set => this.WithProperty("multi_subnet_ip_configuration", value);
    }

    /// <summary>
    /// Block for replica.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Replica block(s) required")]
    public HashSet<AzurermMssqlVirtualMachineAvailabilityGroupListenerReplicaBlock>? Replica
    {
        get => GetProperty<HashSet<AzurermMssqlVirtualMachineAvailabilityGroupListenerReplicaBlock>>("replica");
        set => this.WithProperty("replica", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMssqlVirtualMachineAvailabilityGroupListenerTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMssqlVirtualMachineAvailabilityGroupListenerTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
