using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermContainerAppDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermContainerAppDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The container_app_environment_id attribute.
    /// </summary>
    [TerraformPropertyName("container_app_environment_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ContainerAppEnvironmentId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "container_app_environment_id");

    /// <summary>
    /// The ID of the Custom Domain Verification for this Container App.
    /// </summary>
    [TerraformPropertyName("custom_domain_verification_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomDomainVerificationId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "custom_domain_verification_id");

    /// <summary>
    /// The dapr attribute.
    /// </summary>
    [TerraformPropertyName("dapr")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Dapr => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "dapr");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Identity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "identity");

    /// <summary>
    /// The ingress attribute.
    /// </summary>
    [TerraformPropertyName("ingress")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Ingress => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "ingress");

    /// <summary>
    /// The fully qualified domain name of the latest Container App.
    /// </summary>
    [TerraformPropertyName("latest_revision_fqdn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LatestRevisionFqdn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "latest_revision_fqdn");

    /// <summary>
    /// The name of the latest Container Revision.
    /// </summary>
    [TerraformPropertyName("latest_revision_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LatestRevisionName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "latest_revision_name");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The max_inactive_revisions attribute.
    /// </summary>
    [TerraformPropertyName("max_inactive_revisions")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> MaxInactiveRevisions => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "max_inactive_revisions");

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    [TerraformPropertyName("outbound_ip_addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> OutboundIpAddresses => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "outbound_ip_addresses");

    /// <summary>
    /// The registry attribute.
    /// </summary>
    [TerraformPropertyName("registry")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Registry => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "registry");

    /// <summary>
    /// The revision_mode attribute.
    /// </summary>
    [TerraformPropertyName("revision_mode")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RevisionMode => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "revision_mode");

    /// <summary>
    /// The secret attribute.
    /// </summary>
    [TerraformPropertyName("secret")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> Secret => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "secret");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The template attribute.
    /// </summary>
    [TerraformPropertyName("template")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Template => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "template");

    /// <summary>
    /// The workload_profile_name attribute.
    /// </summary>
    [TerraformPropertyName("workload_profile_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WorkloadProfileName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "workload_profile_name");

}
