using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermKubernetesFleetMemberTimeoutsBlock() : TerraformBlock("timeouts")
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_kubernetes_fleet_member resource.
/// </summary>
public partial class AzurermKubernetesFleetMember : TerraformResource
{
    public AzurermKubernetesFleetMember(string name) : base("azurerm_kubernetes_fleet_member", name)
    {
    }

    /// <summary>
    /// The group attribute.
    /// </summary>
    [TerraformProperty("group")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Group { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kubernetes_cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesClusterId is required")]
    [TerraformProperty("kubernetes_cluster_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KubernetesClusterId { get; set; }

    /// <summary>
    /// The kubernetes_fleet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KubernetesFleetId is required")]
    [TerraformProperty("kubernetes_fleet_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KubernetesFleetId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermKubernetesFleetMemberTimeoutsBlock Timeouts { get; set; } = new();

}
