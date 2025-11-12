using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for assign_to_user in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMachineLearningComputeInstanceAssignToUserBlock() : TerraformBlock("assign_to_user")
{
    /// <summary>
    /// The object_id attribute.
    /// </summary>
    [TerraformProperty("object_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ObjectId { get; set; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformProperty("tenant_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TenantId { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMachineLearningComputeInstanceIdentityBlock() : TerraformBlock("identity")
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for ssh in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMachineLearningComputeInstanceSshBlock() : TerraformBlock("ssh")
{

    /// <summary>
    /// The public_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicKey is required")]
    [TerraformProperty("public_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PublicKey { get; set; }


}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMachineLearningComputeInstanceTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_machine_learning_compute_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermMachineLearningComputeInstance : TerraformResource
{
    public AzurermMachineLearningComputeInstance(string name) : base("azurerm_machine_learning_compute_instance", name)
    {
    }

    /// <summary>
    /// The authorization_type attribute.
    /// </summary>
    [TerraformProperty("authorization_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthorizationType { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    [TerraformProperty("local_auth_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? LocalAuthEnabled { get; set; }

    /// <summary>
    /// The machine_learning_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MachineLearningWorkspaceId is required")]
    [TerraformProperty("machine_learning_workspace_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MachineLearningWorkspaceId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The node_public_ip_enabled attribute.
    /// </summary>
    [TerraformProperty("node_public_ip_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? NodePublicIpEnabled { get; set; }

    /// <summary>
    /// The subnet_resource_id attribute.
    /// </summary>
    [TerraformProperty("subnet_resource_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SubnetResourceId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The virtual_machine_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VirtualMachineSize is required")]
    [TerraformProperty("virtual_machine_size")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VirtualMachineSize { get; set; }

    /// <summary>
    /// Block for assign_to_user.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AssignToUser block(s) allowed")]
    [TerraformProperty("assign_to_user")]
    public TerraformList<AzurermMachineLearningComputeInstanceAssignToUserBlock> AssignToUser { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<AzurermMachineLearningComputeInstanceIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for ssh.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ssh block(s) allowed")]
    [TerraformProperty("ssh")]
    public TerraformList<AzurermMachineLearningComputeInstanceSshBlock> Ssh { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermMachineLearningComputeInstanceTimeoutsBlock Timeouts { get; set; } = new();

}
