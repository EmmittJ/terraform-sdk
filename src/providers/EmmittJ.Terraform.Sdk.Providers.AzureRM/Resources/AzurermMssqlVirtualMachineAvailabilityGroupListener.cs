using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for load_balancer_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMssqlVirtualMachineAvailabilityGroupListenerLoadBalancerConfigurationBlock() : TerraformBlock("load_balancer_configuration")
{
    /// <summary>
    /// The load_balancer_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoadBalancerId is required")]
    [TerraformProperty("load_balancer_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LoadBalancerId { get; set; }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateIpAddress is required")]
    [TerraformProperty("private_ip_address")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PrivateIpAddress { get; set; }

    /// <summary>
    /// The probe_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProbePort is required")]
    [TerraformProperty("probe_port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> ProbePort { get; set; }

    /// <summary>
    /// The sql_virtual_machine_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlVirtualMachineIds is required")]
    [TerraformProperty("sql_virtual_machine_ids")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> SqlVirtualMachineIds { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformProperty("subnet_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SubnetId { get; set; }

}

/// <summary>
/// Block type for multi_subnet_ip_configuration in .
/// Nesting mode: set
/// </summary>
public partial class AzurermMssqlVirtualMachineAvailabilityGroupListenerMultiSubnetIpConfigurationBlock() : TerraformBlock("multi_subnet_ip_configuration")
{
    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrivateIpAddress is required")]
    [TerraformProperty("private_ip_address")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PrivateIpAddress { get; set; }

    /// <summary>
    /// The sql_virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlVirtualMachineId is required")]
    [TerraformProperty("sql_virtual_machine_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SqlVirtualMachineId { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformProperty("subnet_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SubnetId { get; set; }

}

/// <summary>
/// Block type for replica in .
/// Nesting mode: set
/// </summary>
public partial class AzurermMssqlVirtualMachineAvailabilityGroupListenerReplicaBlock() : TerraformBlock("replica")
{
    /// <summary>
    /// The commit attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Commit is required")]
    [TerraformProperty("commit")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Commit { get; set; }

    /// <summary>
    /// The failover_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FailoverMode is required")]
    [TerraformProperty("failover_mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FailoverMode { get; set; }

    /// <summary>
    /// The readable_secondary attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReadableSecondary is required")]
    [TerraformProperty("readable_secondary")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ReadableSecondary { get; set; }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Role is required")]
    [TerraformProperty("role")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Role { get; set; }

    /// <summary>
    /// The sql_virtual_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlVirtualMachineId is required")]
    [TerraformProperty("sql_virtual_machine_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SqlVirtualMachineId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMssqlVirtualMachineAvailabilityGroupListenerTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a azurerm_mssql_virtual_machine_availability_group_listener resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermMssqlVirtualMachineAvailabilityGroupListener : TerraformResource
{
    public AzurermMssqlVirtualMachineAvailabilityGroupListener(string name) : base("azurerm_mssql_virtual_machine_availability_group_listener", name)
    {
    }

    /// <summary>
    /// The availability_group_name attribute.
    /// </summary>
    [TerraformProperty("availability_group_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AvailabilityGroupName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Port { get; set; }

    /// <summary>
    /// The sql_virtual_machine_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlVirtualMachineGroupId is required")]
    [TerraformProperty("sql_virtual_machine_group_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SqlVirtualMachineGroupId { get; set; }

    /// <summary>
    /// Block for load_balancer_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoadBalancerConfiguration block(s) allowed")]
    [TerraformProperty("load_balancer_configuration")]
    public TerraformList<AzurermMssqlVirtualMachineAvailabilityGroupListenerLoadBalancerConfigurationBlock> LoadBalancerConfiguration { get; set; } = new();

    /// <summary>
    /// Block for multi_subnet_ip_configuration.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("multi_subnet_ip_configuration")]
    public TerraformSet<AzurermMssqlVirtualMachineAvailabilityGroupListenerMultiSubnetIpConfigurationBlock> MultiSubnetIpConfiguration { get; set; } = new();

    /// <summary>
    /// Block for replica.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Replica is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Replica block(s) required")]
    [TerraformProperty("replica")]
    public required TerraformSet<AzurermMssqlVirtualMachineAvailabilityGroupListenerReplicaBlock> Replica { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermMssqlVirtualMachineAvailabilityGroupListenerTimeoutsBlock Timeouts { get; set; } = new();

}
