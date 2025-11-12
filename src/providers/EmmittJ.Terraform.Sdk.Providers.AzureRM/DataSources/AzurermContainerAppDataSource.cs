using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermContainerAppDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_container_app.
/// </summary>
public partial class AzurermContainerAppDataSource : TerraformDataSource
{
    public AzurermContainerAppDataSource(string name) : base("azurerm_container_app", name)
    {
    }

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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermContainerAppDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The container_app_environment_id attribute.
    /// </summary>
    [TerraformProperty("container_app_environment_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ContainerAppEnvironmentId { get; }

    /// <summary>
    /// The ID of the Custom Domain Verification for this Container App.
    /// </summary>
    [TerraformProperty("custom_domain_verification_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CustomDomainVerificationId { get; }

    /// <summary>
    /// The dapr attribute.
    /// </summary>
    [TerraformProperty("dapr")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Dapr { get; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Identity { get; }

    /// <summary>
    /// The ingress attribute.
    /// </summary>
    [TerraformProperty("ingress")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Ingress { get; }

    /// <summary>
    /// The fully qualified domain name of the latest Container App.
    /// </summary>
    [TerraformProperty("latest_revision_fqdn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LatestRevisionFqdn { get; }

    /// <summary>
    /// The name of the latest Container Revision.
    /// </summary>
    [TerraformProperty("latest_revision_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LatestRevisionName { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The max_inactive_revisions attribute.
    /// </summary>
    [TerraformProperty("max_inactive_revisions")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> MaxInactiveRevisions { get; }

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    [TerraformProperty("outbound_ip_addresses")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> OutboundIpAddresses { get; }

    /// <summary>
    /// The registry attribute.
    /// </summary>
    [TerraformProperty("registry")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Registry { get; }

    /// <summary>
    /// The revision_mode attribute.
    /// </summary>
    [TerraformProperty("revision_mode")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RevisionMode { get; }

    /// <summary>
    /// The secret attribute.
    /// </summary>
    [TerraformProperty("secret")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> Secret { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The template attribute.
    /// </summary>
    [TerraformProperty("template")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Template { get; }

    /// <summary>
    /// The workload_profile_name attribute.
    /// </summary>
    [TerraformProperty("workload_profile_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> WorkloadProfileName { get; }

}
