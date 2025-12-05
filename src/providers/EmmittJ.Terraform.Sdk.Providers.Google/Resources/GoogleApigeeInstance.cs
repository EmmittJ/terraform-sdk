using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for access_logging_config in GoogleApigeeInstance.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeInstanceAccessLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_logging_config";

    /// <summary>
    /// Boolean flag that specifies whether the customer access log feature is enabled.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// Ship the access log entries that match the statusCode defined in the filter.
    /// The statusCode is the only expected/supported filter field. (Ex: statusCode)
    /// The filter will parse it to the Common Expression Language semantics for expression
    /// evaluation to build the filter condition. (Ex: &amp;quot;filter&amp;quot;: statusCode &amp;gt;= 200 &amp;amp;&amp;amp; statusCode &amp;lt; 300 )
    /// </summary>
    public TerraformValue<string>? Filter
    {
        get => GetArgument<TerraformValue<string>>("filter");
        set => SetArgument("filter", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleApigeeInstance.
/// Nesting mode: single
/// </summary>
public class GoogleApigeeInstanceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_apigee_instance Terraform resource.
/// Manages a google_apigee_instance resource.
/// </summary>
public partial class GoogleApigeeInstance(string name) : TerraformResource("google_apigee_instance", name)
{
    /// <summary>
    /// Optional. Customer accept list represents the list of projects (id/number) on customer
    /// side that can privately connect to the service attachment. It is an optional field
    /// which the customers can provide during the instance creation. By default, the customer
    /// project associated with the Apigee organization will be included to the list.
    /// </summary>
    public TerraformList<string> ConsumerAcceptList
    {
        get => GetArgument<TerraformList<string>>("consumer_accept_list") ?? CreateReference("consumer_accept_list");
        set => SetArgument("consumer_accept_list", value);
    }

    /// <summary>
    /// Description of the instance.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Customer Managed Encryption Key (CMEK) used for disk and volume encryption. Required for Apigee paid subscriptions only.
    /// Use the following format: &#39;projects/([^/]+)/locations/([^/]+)/keyRings/([^/]+)/cryptoKeys/([^/]+)&#39;
    /// </summary>
    public TerraformValue<string>? DiskEncryptionKeyName
    {
        get => GetArgument<TerraformValue<string>>("disk_encryption_key_name");
        set => SetArgument("disk_encryption_key_name", value);
    }

    /// <summary>
    /// Display name of the instance.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// IP range represents the customer-provided CIDR block of length 22 that will be used for
    /// the Apigee instance creation. This optional range, if provided, should be freely
    /// available as part of larger named range the customer has allocated to the Service
    /// Networking peering. If this is not provided, Apigee will automatically request for any
    /// available /22 CIDR block from Service Networking. The customer should use this CIDR block
    /// for configuring their firewall needs to allow traffic from Apigee.
    /// Input format: &amp;quot;a.b.c.d/22&amp;quot;
    /// </summary>
    public TerraformValue<string>? IpRange
    {
        get => GetArgument<TerraformValue<string>>("ip_range");
        set => SetArgument("ip_range", value);
    }

    /// <summary>
    /// Required. Compute Engine location where the instance resides.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Resource ID of the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee instance,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformValue<string> OrgId
    {
        get => GetRequiredArgument<TerraformValue<string>>("org_id");
        set => SetArgument("org_id", value);
    }

    /// <summary>
    /// The size of the CIDR block range that will be reserved by the instance. For valid values,
    /// see [CidrRange](https://cloud.google.com/apigee/docs/reference/apis/apigee/rest/v1/organizations.instances#CidrRange) on the documentation.
    /// </summary>
    public TerraformValue<string> PeeringCidrRange
    {
        get => GetArgument<TerraformValue<string>>("peering_cidr_range") ?? CreateReference("peering_cidr_range");
        set => SetArgument("peering_cidr_range", value);
    }

    /// <summary>
    /// Output only. Hostname or IP address of the exposed Apigee endpoint used by clients to connect to the service.
    /// </summary>
    public TerraformValue<string> Host
        => CreateReference("host");

    /// <summary>
    /// Output only. Port number of the exposed Apigee endpoint.
    /// </summary>
    public TerraformValue<string> Port
        => CreateReference("port");

    /// <summary>
    /// Output only. Resource name of the service attachment created for the instance in
    /// the format: projects/*/regions/*/serviceAttachments/* Apigee customers can privately
    /// forward traffic to this service attachment using the PSC endpoints.
    /// </summary>
    public TerraformValue<string> ServiceAttachment
        => CreateReference("service_attachment");

    /// <summary>
    /// AccessLoggingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLoggingConfig block(s) allowed")]
    public TerraformList<GoogleApigeeInstanceAccessLoggingConfigBlock>? AccessLoggingConfig
    {
        get => GetArgument<TerraformList<GoogleApigeeInstanceAccessLoggingConfigBlock>>("access_logging_config");
        set => SetArgument("access_logging_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApigeeInstanceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApigeeInstanceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
