using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_apigee_instance resource.
/// </summary>
public class GoogleApigeeInstance : TerraformResource
{
    public GoogleApigeeInstance(string name) : base("google_apigee_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("host");
        this.DeclareOutput("port");
        this.DeclareOutput("service_attachment");
    }

    /// <summary>
    /// Optional. Customer accept list represents the list of projects (id/number) on customer
    /// side that can privately connect to the service attachment. It is an optional field
    /// which the customers can provide during the instance creation. By default, the customer
    /// project associated with the Apigee organization will be included to the list.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? ConsumerAcceptList
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("consumer_accept_list");
        set => this.WithProperty("consumer_accept_list", value);
    }

    /// <summary>
    /// Description of the instance.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// Customer Managed Encryption Key (CMEK) used for disk and volume encryption. Required for Apigee paid subscriptions only.
    /// Use the following format: &#39;projects/([^/]+)/locations/([^/]+)/keyRings/([^/]+)/cryptoKeys/([^/]+)&#39;
    /// </summary>
    public TerraformLiteralProperty<string>? DiskEncryptionKeyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("disk_encryption_key_name");
        set => this.WithProperty("disk_encryption_key_name", value);
    }

    /// <summary>
    /// Display name of the instance.
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    public TerraformLiteralProperty<string>? IpRange
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_range");
        set => this.WithProperty("ip_range", value);
    }

    /// <summary>
    /// Required. Compute Engine location where the instance resides.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Resource ID of the instance.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee instance,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    public TerraformLiteralProperty<string>? OrgId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("org_id");
        set => this.WithProperty("org_id", value);
    }

    /// <summary>
    /// The size of the CIDR block range that will be reserved by the instance. For valid values,
    /// see [CidrRange](https://cloud.google.com/apigee/docs/reference/apis/apigee/rest/v1/organizations.instances#CidrRange) on the documentation.
    /// </summary>
    public TerraformLiteralProperty<string>? PeeringCidrRange
    {
        get => GetProperty<TerraformLiteralProperty<string>>("peering_cidr_range");
        set => this.WithProperty("peering_cidr_range", value);
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
