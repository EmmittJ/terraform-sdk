using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for properties in .
/// Nesting mode: list
/// </summary>
public partial class GoogleApigeeOrganizationPropertiesBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleApigeeOrganizationTimeoutsBlock : TerraformBlockBase
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
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_apigee_organization resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleApigeeOrganization : TerraformResource
{
    public GoogleApigeeOrganization(string name) : base("google_apigee_organization", name)
    {
    }

    /// <summary>
    /// Primary GCP region for analytics data storage. For valid values, see [Create an Apigee organization](https://cloud.google.com/apigee/docs/api-platform/get-started/create-org).
    /// </summary>
    [TerraformProperty("analytics_region")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AnalyticsRegion { get; set; }

    /// <summary>
    /// Cloud KMS key name used for encrypting API consumer data.
    /// </summary>
    [TerraformProperty("api_consumer_data_encryption_key_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ApiConsumerDataEncryptionKeyName { get; set; }

    /// <summary>
    /// This field is needed only for customers using non-default data residency regions.
    /// Apigee stores some control plane data only in single region.
    /// This field determines which single region Apigee should use.
    /// </summary>
    [TerraformProperty("api_consumer_data_location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ApiConsumerDataLocation { get; set; }

    /// <summary>
    /// Compute Engine network used for Service Networking to be peered with Apigee runtime instances.
    /// See [Getting started with the Service Networking API](https://cloud.google.com/service-infrastructure/docs/service-networking/getting-started).
    /// Valid only when &#39;RuntimeType&#39; is set to CLOUD. The value can be updated only when there are no runtime instances. For example: &amp;quot;default&amp;quot;.
    /// </summary>
    [TerraformProperty("authorized_network")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AuthorizedNetwork { get; set; }

    /// <summary>
    /// Billing type of the Apigee organization. See [Apigee pricing](https://cloud.google.com/apigee/pricing).
    /// </summary>
    [TerraformProperty("billing_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> BillingType { get; set; }

    /// <summary>
    /// Cloud KMS key name used for encrypting control plane data that is stored in a multi region.
    /// Only used for the data residency region &amp;quot;US&amp;quot; or &amp;quot;EU&amp;quot;.
    /// </summary>
    [TerraformProperty("control_plane_encryption_key_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ControlPlaneEncryptionKeyName { get; set; }

    /// <summary>
    /// Description of the Apigee organization.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Flag that specifies whether the VPC Peering through Private Google Access should be
    /// disabled between the consumer network and Apigee. Required if an &#39;authorizedNetwork&#39;
    /// on the consumer project is not provided, in which case the flag should be set to &#39;true&#39;.
    /// Valid only when &#39;RuntimeType&#39; is set to CLOUD. The value must be set before the creation
    /// of any Apigee runtime instance and can be updated only when there are no runtime instances.
    /// </summary>
    [TerraformProperty("disable_vpc_peering")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DisableVpcPeering { get; set; }

    /// <summary>
    /// The display name of the Apigee organization.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project ID associated with the Apigee organization.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    [TerraformProperty("project_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProjectId { get; set; }

    /// <summary>
    /// Optional. This setting is applicable only for organizations that are soft-deleted (i.e., BillingType
    /// is not EVALUATION). It controls how long Organization data will be retained after the initial delete
    /// operation completes. During this period, the Organization may be restored to its last known state.
    /// After this period, the Organization will no longer be able to be restored. Default value: &amp;quot;DELETION_RETENTION_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;DELETION_RETENTION_UNSPECIFIED&amp;quot;, &amp;quot;MINIMUM&amp;quot;]
    /// </summary>
    [TerraformProperty("retention")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Retention { get; set; }

    /// <summary>
    /// Cloud KMS key name used for encrypting the data that is stored and replicated across runtime instances.
    /// Update is not allowed after the organization is created.
    /// If not specified, a Google-Managed encryption key will be used.
    /// Valid only when &#39;RuntimeType&#39; is CLOUD. For example: &#39;projects/foo/locations/us/keyRings/bar/cryptoKeys/baz&#39;.
    /// </summary>
    [TerraformProperty("runtime_database_encryption_key_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RuntimeDatabaseEncryptionKeyName { get; set; }

    /// <summary>
    /// Runtime type of the Apigee organization based on the Apigee subscription purchased. Default value: &amp;quot;CLOUD&amp;quot; Possible values: [&amp;quot;CLOUD&amp;quot;, &amp;quot;HYBRID&amp;quot;]
    /// </summary>
    [TerraformProperty("runtime_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RuntimeType { get; set; }

    /// <summary>
    /// Block for properties.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Properties block(s) allowed")]
    [TerraformProperty("properties")]
    public partial TerraformList<TerraformBlock<GoogleApigeeOrganizationPropertiesBlock>>? Properties { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleApigeeOrganizationTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. Project ID of the Apigee Tenant Project.
    /// </summary>
    [TerraformProperty("apigee_project_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ApigeeProjectId { get; }

    /// <summary>
    /// Output only. Base64-encoded public certificate for the root CA of the Apigee organization.
    /// Valid only when &#39;RuntimeType&#39; is CLOUD. A base64-encoded string.
    /// </summary>
    [TerraformProperty("ca_certificate")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CaCertificate { get; }

    /// <summary>
    /// Output only. Name of the Apigee organization.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// Output only. Subscription type of the Apigee organization.
    /// Valid values include trial (free, limited, and for evaluation purposes only) or paid (full subscription has been purchased).
    /// </summary>
    [TerraformProperty("subscription_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SubscriptionType { get; }

}
