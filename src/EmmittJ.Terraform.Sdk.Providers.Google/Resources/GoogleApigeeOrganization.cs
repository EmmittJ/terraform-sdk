using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_apigee_organization resource.
/// </summary>
public class GoogleApigeeOrganization : TerraformResource
{
    public GoogleApigeeOrganization(string name) : base("google_apigee_organization", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("apigee_project_id");
        this.DeclareOutput("ca_certificate");
        this.DeclareOutput("name");
        this.DeclareOutput("subscription_type");
    }

    /// <summary>
    /// Primary GCP region for analytics data storage. For valid values, see [Create an Apigee organization](https://cloud.google.com/apigee/docs/api-platform/get-started/create-org).
    /// </summary>
    public string? AnalyticsRegion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("analytics_region")?.Value;
        set => this.WithProperty("analytics_region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Cloud KMS key name used for encrypting API consumer data.
    /// </summary>
    public string? ApiConsumerDataEncryptionKeyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_consumer_data_encryption_key_name")?.Value;
        set => this.WithProperty("api_consumer_data_encryption_key_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// This field is needed only for customers using non-default data residency regions.
    /// Apigee stores some control plane data only in single region.
    /// This field determines which single region Apigee should use.
    /// </summary>
    public string? ApiConsumerDataLocation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_consumer_data_location")?.Value;
        set => this.WithProperty("api_consumer_data_location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Compute Engine network used for Service Networking to be peered with Apigee runtime instances.
    /// See [Getting started with the Service Networking API](https://cloud.google.com/service-infrastructure/docs/service-networking/getting-started).
    /// Valid only when &#39;RuntimeType&#39; is set to CLOUD. The value can be updated only when there are no runtime instances. For example: &amp;quot;default&amp;quot;.
    /// </summary>
    public string? AuthorizedNetwork
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authorized_network")?.Value;
        set => this.WithProperty("authorized_network", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Billing type of the Apigee organization. See [Apigee pricing](https://cloud.google.com/apigee/pricing).
    /// </summary>
    public string? BillingType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("billing_type")?.Value;
        set => this.WithProperty("billing_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Cloud KMS key name used for encrypting control plane data that is stored in a multi region.
    /// Only used for the data residency region &amp;quot;US&amp;quot; or &amp;quot;EU&amp;quot;.
    /// </summary>
    public string? ControlPlaneEncryptionKeyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("control_plane_encryption_key_name")?.Value;
        set => this.WithProperty("control_plane_encryption_key_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Description of the Apigee organization.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Flag that specifies whether the VPC Peering through Private Google Access should be
    /// disabled between the consumer network and Apigee. Required if an &#39;authorizedNetwork&#39;
    /// on the consumer project is not provided, in which case the flag should be set to &#39;true&#39;.
    /// Valid only when &#39;RuntimeType&#39; is set to CLOUD. The value must be set before the creation
    /// of any Apigee runtime instance and can be updated only when there are no runtime instances.
    /// </summary>
    public bool? DisableVpcPeering
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disable_vpc_peering")?.Value;
        set => this.WithProperty("disable_vpc_peering", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The display name of the Apigee organization.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project ID associated with the Apigee organization.
    /// </summary>
    public string? ProjectId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project_id")?.Value;
        set => this.WithProperty("project_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Optional. This setting is applicable only for organizations that are soft-deleted (i.e., BillingType
    /// is not EVALUATION). It controls how long Organization data will be retained after the initial delete
    /// operation completes. During this period, the Organization may be restored to its last known state.
    /// After this period, the Organization will no longer be able to be restored. Default value: &amp;quot;DELETION_RETENTION_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;DELETION_RETENTION_UNSPECIFIED&amp;quot;, &amp;quot;MINIMUM&amp;quot;]
    /// </summary>
    public string? Retention
    {
        get => GetProperty<TerraformLiteralProperty<string>>("retention")?.Value;
        set => this.WithProperty("retention", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Cloud KMS key name used for encrypting the data that is stored and replicated across runtime instances.
    /// Update is not allowed after the organization is created.
    /// If not specified, a Google-Managed encryption key will be used.
    /// Valid only when &#39;RuntimeType&#39; is CLOUD. For example: &#39;projects/foo/locations/us/keyRings/bar/cryptoKeys/baz&#39;.
    /// </summary>
    public string? RuntimeDatabaseEncryptionKeyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("runtime_database_encryption_key_name")?.Value;
        set => this.WithProperty("runtime_database_encryption_key_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Runtime type of the Apigee organization based on the Apigee subscription purchased. Default value: &amp;quot;CLOUD&amp;quot; Possible values: [&amp;quot;CLOUD&amp;quot;, &amp;quot;HYBRID&amp;quot;]
    /// </summary>
    public string? RuntimeType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("runtime_type")?.Value;
        set => this.WithProperty("runtime_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Output only. Project ID of the Apigee Tenant Project.
    /// </summary>
    public TerraformExpression ApigeeProjectId => this["apigee_project_id"];

    /// <summary>
    /// Output only. Base64-encoded public certificate for the root CA of the Apigee organization.
    /// Valid only when &#39;RuntimeType&#39; is CLOUD. A base64-encoded string.
    /// </summary>
    public TerraformExpression CaCertificate => this["ca_certificate"];

    /// <summary>
    /// Output only. Name of the Apigee organization.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. Subscription type of the Apigee organization.
    /// Valid values include trial (free, limited, and for evaluation purposes only) or paid (full subscription has been purchased).
    /// </summary>
    public TerraformExpression SubscriptionType => this["subscription_type"];

}
