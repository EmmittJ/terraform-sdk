using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for load_balancer_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineAvailabilityGroupListenerLoadBalancerConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The load_balancer_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancerId is required")]
    [TerraformPropertyName("load_balancer_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LoadBalancerId { get; set; }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateIpAddress is required")]
    [TerraformPropertyName("private_ip_address")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PrivateIpAddress { get; set; }

    /// <summary>
    /// The probe_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProbePort is required")]
    [TerraformPropertyName("probe_port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> ProbePort { get; set; }

    /// <summary>
    /// The sql_virtual_machine_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlVirtualMachineIds is required")]
    [TerraformPropertyName("sql_virtual_machine_ids")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? SqlVirtualMachineIds { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformPropertyName("subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SubnetId { get; set; }

}

/// <summary>
/// Block type for multi_subnet_ip_configuration in .
/// Nesting mode: set
/// </summary>
public class AzurermMssqlVirtualMachineAvailabilityGroupListenerMultiSubnetIpConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateIpAddress is required")]
    [TerraformPropertyName("private_ip_address")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PrivateIpAddress { get; set; }

    /// <summary>
    /// The sql_virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlVirtualMachineId is required")]
    [TerraformPropertyName("sql_virtual_machine_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SqlVirtualMachineId { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformPropertyName("subnet_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SubnetId { get; set; }

}

/// <summary>
/// Block type for replica in .
/// Nesting mode: set
/// </summary>
public class AzurermMssqlVirtualMachineAvailabilityGroupListenerReplicaBlock : ITerraformBlock
{
    /// <summary>
    /// The commit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Commit is required")]
    [TerraformPropertyName("commit")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Commit { get; set; }

    /// <summary>
    /// The failover_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailoverMode is required")]
    [TerraformPropertyName("failover_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FailoverMode { get; set; }

    /// <summary>
    /// The readable_secondary attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReadableSecondary is required")]
    [TerraformPropertyName("readable_secondary")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ReadableSecondary { get; set; }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    [TerraformPropertyName("role")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Role { get; set; }

    /// <summary>
    /// The sql_virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlVirtualMachineId is required")]
    [TerraformPropertyName("sql_virtual_machine_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SqlVirtualMachineId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlVirtualMachineAvailabilityGroupListenerTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    [TerraformPropertyName("availability_group_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AvailabilityGroupName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Port { get; set; }

    /// <summary>
    /// The sql_virtual_machine_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlVirtualMachineGroupId is required")]
    [TerraformPropertyName("sql_virtual_machine_group_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SqlVirtualMachineGroupId { get; set; }

    /// <summary>
    /// Block for load_balancer_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancerConfiguration block(s) allowed")]
    [TerraformPropertyName("load_balancer_configuration")]
    public TerraformList<TerraformBlock<AzurermMssqlVirtualMachineAvailabilityGroupListenerLoadBalancerConfigurationBlock>>? LoadBalancerConfiguration { get; set; } = new();

    /// <summary>
    /// Block for multi_subnet_ip_configuration.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("multi_subnet_ip_configuration")]
    public TerraformSet<TerraformBlock<AzurermMssqlVirtualMachineAvailabilityGroupListenerMultiSubnetIpConfigurationBlock>>? MultiSubnetIpConfiguration { get; set; } = new();

    /// <summary>
    /// Block for replica.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Replica is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Replica block(s) required")]
    [TerraformPropertyName("replica")]
    public TerraformSet<TerraformBlock<AzurermMssqlVirtualMachineAvailabilityGroupListenerReplicaBlock>>? Replica { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMssqlVirtualMachineAvailabilityGroupListenerTimeoutsBlock>? Timeouts { get; set; } = new();

}
