using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for access_logging_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleApigeeInstanceAccessLoggingConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// Boolean flag that specifies whether the customer access log feature is enabled.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// Ship the access log entries that match the statusCode defined in the filter.
    /// The statusCode is the only expected/supported filter field. (Ex: statusCode)
    /// The filter will parse it to the Common Expression Language semantics for expression
    /// evaluation to build the filter condition. (Ex: &amp;quot;filter&amp;quot;: statusCode &amp;gt;= 200 &amp;amp;&amp;amp; statusCode &amp;lt; 300 )
    /// </summary>
    [TerraformProperty("filter")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Filter { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleApigeeInstanceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_apigee_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleApigeeInstance : TerraformResource
{
    public GoogleApigeeInstance(string name) : base("google_apigee_instance", name)
    {
    }

    /// <summary>
    /// Optional. Customer accept list represents the list of projects (id/number) on customer
    /// side that can privately connect to the service attachment. It is an optional field
    /// which the customers can provide during the instance creation. By default, the customer
    /// project associated with the Apigee organization will be included to the list.
    /// </summary>
    [TerraformProperty("consumer_accept_list")]
    // Optional+Computed - source generator will implement get/set
    public TerraformList<string> ConsumerAcceptList { get; set; }

    /// <summary>
    /// Description of the instance.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Customer Managed Encryption Key (CMEK) used for disk and volume encryption. Required for Apigee paid subscriptions only.
    /// Use the following format: &#39;projects/([^/]+)/locations/([^/]+)/keyRings/([^/]+)/cryptoKeys/([^/]+)&#39;
    /// </summary>
    [TerraformProperty("disk_encryption_key_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DiskEncryptionKeyName { get; set; }

    /// <summary>
    /// Display name of the instance.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// IP range represents the customer-provided CIDR block of length 22 that will be used for
    /// the Apigee instance creation. This optional range, if provided, should be freely
    /// available as part of larger named range the customer has allocated to the Service
    /// Networking peering. If this is not provided, Apigee will automatically request for any
    /// available /22 CIDR block from Service Networking. The customer should use this CIDR block
    /// for configuring their firewall needs to allow traffic from Apigee.
    /// Input format: &amp;quot;a.b.c.d/22&amp;quot;
    /// </summary>
    [TerraformProperty("ip_range")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IpRange { get; set; }

    /// <summary>
    /// Required. Compute Engine location where the instance resides.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Resource ID of the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The Apigee Organization associated with the Apigee instance,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformProperty("org_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> OrgId { get; set; }

    /// <summary>
    /// The size of the CIDR block range that will be reserved by the instance. For valid values,
    /// see [CidrRange](https://cloud.google.com/apigee/docs/reference/apis/apigee/rest/v1/organizations.instances#CidrRange) on the documentation.
    /// </summary>
    [TerraformProperty("peering_cidr_range")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PeeringCidrRange { get; set; }

    /// <summary>
    /// Block for access_logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLoggingConfig block(s) allowed")]
    [TerraformProperty("access_logging_config")]
    public TerraformList<TerraformBlock<GoogleApigeeInstanceAccessLoggingConfigBlock>>? AccessLoggingConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleApigeeInstanceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. Hostname or IP address of the exposed Apigee endpoint used by clients to connect to the service.
    /// </summary>
    [TerraformProperty("host")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Host { get; }

    /// <summary>
    /// Output only. Port number of the exposed Apigee endpoint.
    /// </summary>
    [TerraformProperty("port")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Port { get; }

    /// <summary>
    /// Output only. Resource name of the service attachment created for the instance in
    /// the format: projects/*/regions/*/serviceAttachments/* Apigee customers can privately
    /// forward traffic to this service attachment using the PSC endpoints.
    /// </summary>
    [TerraformProperty("service_attachment")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServiceAttachment { get; }

}
