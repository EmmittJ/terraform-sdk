using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for access_logging_config in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeInstanceAccessLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Boolean flag that specifies whether the customer access log feature is enabled.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// Ship the access log entries that match the statusCode defined in the filter.
    /// The statusCode is the only expected/supported filter field. (Ex: statusCode)
    /// The filter will parse it to the Common Expression Language semantics for expression
    /// evaluation to build the filter condition. (Ex: &amp;quot;filter&amp;quot;: statusCode &amp;gt;= 200 &amp;amp;&amp;amp; statusCode &amp;lt; 300 )
    /// </summary>
    public TerraformProperty<string>? Filter
    {
        set => SetProperty("filter", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeInstanceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_apigee_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleApigeeInstance : TerraformResource
{
    public GoogleApigeeInstance(string name) : base("google_apigee_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("host");
        SetOutput("port");
        SetOutput("service_attachment");
        SetOutput("consumer_accept_list");
        SetOutput("description");
        SetOutput("disk_encryption_key_name");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("ip_range");
        SetOutput("location");
        SetOutput("name");
        SetOutput("org_id");
        SetOutput("peering_cidr_range");
    }

    /// <summary>
    /// Optional. Customer accept list represents the list of projects (id/number) on customer
    /// side that can privately connect to the service attachment. It is an optional field
    /// which the customers can provide during the instance creation. By default, the customer
    /// project associated with the Apigee organization will be included to the list.
    /// </summary>
    public List<TerraformProperty<string>> ConsumerAcceptList
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("consumer_accept_list");
        set => SetProperty("consumer_accept_list", value);
    }

    /// <summary>
    /// Description of the instance.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Customer Managed Encryption Key (CMEK) used for disk and volume encryption. Required for Apigee paid subscriptions only.
    /// Use the following format: &#39;projects/([^/]+)/locations/([^/]+)/keyRings/([^/]+)/cryptoKeys/([^/]+)&#39;
    /// </summary>
    public TerraformProperty<string> DiskEncryptionKeyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("disk_encryption_key_name");
        set => SetProperty("disk_encryption_key_name", value);
    }

    /// <summary>
    /// Display name of the instance.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
    public TerraformProperty<string> IpRange
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ip_range");
        set => SetProperty("ip_range", value);
    }

    /// <summary>
    /// Required. Compute Engine location where the instance resides.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// Resource ID of the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee instance,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformProperty<string> OrgId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("org_id");
        set => SetProperty("org_id", value);
    }

    /// <summary>
    /// The size of the CIDR block range that will be reserved by the instance. For valid values,
    /// see [CidrRange](https://cloud.google.com/apigee/docs/reference/apis/apigee/rest/v1/organizations.instances#CidrRange) on the documentation.
    /// </summary>
    public TerraformProperty<string> PeeringCidrRange
    {
        get => GetRequiredOutput<TerraformProperty<string>>("peering_cidr_range");
        set => SetProperty("peering_cidr_range", value);
    }

    /// <summary>
    /// Block for access_logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessLoggingConfig block(s) allowed")]
    public List<GoogleApigeeInstanceAccessLoggingConfigBlock>? AccessLoggingConfig
    {
        set => SetProperty("access_logging_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApigeeInstanceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Output only. Hostname or IP address of the exposed Apigee endpoint used by clients to connect to the service.
    /// </summary>
    public TerraformExpression Host => this["host"];

    /// <summary>
    /// Output only. Port number of the exposed Apigee endpoint.
    /// </summary>
    public TerraformExpression Port => this["port"];

    /// <summary>
    /// Output only. Resource name of the service attachment created for the instance in
    /// the format: projects/*/regions/*/serviceAttachments/* Apigee customers can privately
    /// forward traffic to this service attachment using the PSC endpoints.
    /// </summary>
    public TerraformExpression ServiceAttachment => this["service_attachment"];

}
