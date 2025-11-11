using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_container_app.
/// </summary>
public class AzurermContainerAppDataSource : TerraformDataSource
{
    public AzurermContainerAppDataSource(string name) : base("azurerm_container_app", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermContainerAppDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The container_app_environment_id attribute.
    /// </summary>
    [TerraformPropertyName("container_app_environment_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ContainerAppEnvironmentId => new TerraformReference(this, "container_app_environment_id");

    /// <summary>
    /// The ID of the Custom Domain Verification for this Container App.
    /// </summary>
    [TerraformPropertyName("custom_domain_verification_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CustomDomainVerificationId => new TerraformReference(this, "custom_domain_verification_id");

    /// <summary>
    /// The dapr attribute.
    /// </summary>
    [TerraformPropertyName("dapr")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Dapr => new TerraformReference(this, "dapr");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Identity => new TerraformReference(this, "identity");

    /// <summary>
    /// The ingress attribute.
    /// </summary>
    [TerraformPropertyName("ingress")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Ingress => new TerraformReference(this, "ingress");

    /// <summary>
    /// The fully qualified domain name of the latest Container App.
    /// </summary>
    [TerraformPropertyName("latest_revision_fqdn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LatestRevisionFqdn => new TerraformReference(this, "latest_revision_fqdn");

    /// <summary>
    /// The name of the latest Container Revision.
    /// </summary>
    [TerraformPropertyName("latest_revision_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LatestRevisionName => new TerraformReference(this, "latest_revision_name");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The max_inactive_revisions attribute.
    /// </summary>
    [TerraformPropertyName("max_inactive_revisions")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> MaxInactiveRevisions => new TerraformReference(this, "max_inactive_revisions");

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("outbound_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<string> OutboundIpAddresses => new TerraformReference(this, "outbound_ip_addresses");

    /// <summary>
    /// The registry attribute.
    /// </summary>
    [TerraformPropertyName("registry")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Registry => new TerraformReference(this, "registry");

    /// <summary>
    /// The revision_mode attribute.
    /// </summary>
    [TerraformPropertyName("revision_mode")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RevisionMode => new TerraformReference(this, "revision_mode");

    /// <summary>
    /// The secret attribute.
    /// </summary>
    [TerraformPropertyName("secret")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> Secret => new TerraformReference(this, "secret");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The template attribute.
    /// </summary>
    [TerraformPropertyName("template")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Template => new TerraformReference(this, "template");

    /// <summary>
    /// The workload_profile_name attribute.
    /// </summary>
    [TerraformPropertyName("workload_profile_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WorkloadProfileName => new TerraformReference(this, "workload_profile_name");

}
