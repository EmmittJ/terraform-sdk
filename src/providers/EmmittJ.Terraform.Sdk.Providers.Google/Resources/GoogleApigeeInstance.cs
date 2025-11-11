using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for access_logging_config in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeInstanceAccessLoggingConfigBlock
{
    /// <summary>
    /// Boolean flag that specifies whether the customer access log feature is enabled.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// Ship the access log entries that match the statusCode defined in the filter.
    /// The statusCode is the only expected/supported filter field. (Ex: statusCode)
    /// The filter will parse it to the Common Expression Language semantics for expression
    /// evaluation to build the filter condition. (Ex: &amp;quot;filter&amp;quot;: statusCode &amp;gt;= 200 &amp;amp;&amp;amp; statusCode &amp;lt; 300 )
    /// </summary>
    [TerraformPropertyName("filter")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Filter { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeInstanceTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_apigee_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleApigeeInstance : TerraformResource
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
    [TerraformPropertyName("consumer_accept_list")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformList<string> ConsumerAcceptList { get; set; } = default!;

    /// <summary>
    /// Description of the instance.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// Customer Managed Encryption Key (CMEK) used for disk and volume encryption. Required for Apigee paid subscriptions only.
    /// Use the following format: &#39;projects/([^/]+)/locations/([^/]+)/keyRings/([^/]+)/cryptoKeys/([^/]+)&#39;
    /// </summary>
    [TerraformPropertyName("disk_encryption_key_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DiskEncryptionKeyName { get; set; }

    /// <summary>
    /// Display name of the instance.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// IP range represents the customer-provided CIDR block of length 22 that will be used for
    /// the Apigee instance creation. This optional range, if provided, should be freely
    /// available as part of larger named range the customer has allocated to the Service
    /// Networking peering. If this is not provided, Apigee will automatically request for any
    /// available /22 CIDR block from Service Networking. The customer should use this CIDR block
    /// for configuring their firewall needs to allow traffic from Apigee.
    /// Input format: &amp;quot;a.b.c.d/22&amp;quot;
    /// </summary>
    [TerraformPropertyName("ip_range")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? IpRange { get; set; }

    /// <summary>
    /// Required. Compute Engine location where the instance resides.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Resource ID of the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The Apigee Organization associated with the Apigee instance,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    [TerraformPropertyName("org_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> OrgId { get; set; }

    /// <summary>
    /// The size of the CIDR block range that will be reserved by the instance. For valid values,
    /// see [CidrRange](https://cloud.google.com/apigee/docs/reference/apis/apigee/rest/v1/organizations.instances#CidrRange) on the documentation.
    /// </summary>
    [TerraformPropertyName("peering_cidr_range")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PeeringCidrRange { get; set; } = default!;

    /// <summary>
    /// Block for access_logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLoggingConfig block(s) allowed")]
    [TerraformPropertyName("access_logging_config")]
    public TerraformList<TerraformBlock<GoogleApigeeInstanceAccessLoggingConfigBlock>>? AccessLoggingConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleApigeeInstanceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Output only. Hostname or IP address of the exposed Apigee endpoint used by clients to connect to the service.
    /// </summary>
    [TerraformPropertyName("host")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Host => new TerraformReference(this, "host");

    /// <summary>
    /// Output only. Port number of the exposed Apigee endpoint.
    /// </summary>
    [TerraformPropertyName("port")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Port => new TerraformReference(this, "port");

    /// <summary>
    /// Output only. Resource name of the service attachment created for the instance in
    /// the format: projects/*/regions/*/serviceAttachments/* Apigee customers can privately
    /// forward traffic to this service attachment using the PSC endpoints.
    /// </summary>
    [TerraformPropertyName("service_attachment")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceAttachment => new TerraformReference(this, "service_attachment");

}
