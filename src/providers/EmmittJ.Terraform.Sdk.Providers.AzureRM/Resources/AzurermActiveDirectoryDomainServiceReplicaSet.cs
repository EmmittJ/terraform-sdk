using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermActiveDirectoryDomainServiceReplicaSetTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_active_directory_domain_service_replica_set resource.
/// </summary>
public partial class AzurermActiveDirectoryDomainServiceReplicaSet : TerraformResource
{
    public AzurermActiveDirectoryDomainServiceReplicaSet(string name) : base("azurerm_active_directory_domain_service_replica_set", name)
    {
    }

    /// <summary>
    /// The domain_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainServiceId is required")]
    [TerraformProperty("domain_service_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DomainServiceId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    [TerraformProperty("subnet_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SubnetId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermActiveDirectoryDomainServiceReplicaSetTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The domain_controller_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("domain_controller_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> DomainControllerIpAddresses { get; }

    /// <summary>
    /// The external_access_ip_address attribute.
    /// </summary>
    [TerraformProperty("external_access_ip_address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExternalAccessIpAddress { get; }

    /// <summary>
    /// The service_status attribute.
    /// </summary>
    [TerraformProperty("service_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServiceStatus { get; }

}
