using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for properties in GoogleApigeeOrganization.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeOrganizationPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "properties";

    /// <summary>
    /// Property block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleApigeeOrganizationPropertiesBlockPropertyBlock>? Property
    {
        get => GetArgument<TerraformList<GoogleApigeeOrganizationPropertiesBlockPropertyBlock>>("property");
        set => SetArgument("property", value);
    }

}

/// <summary>
/// Block type for property in GoogleApigeeOrganizationPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeOrganizationPropertiesBlockPropertyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "property";

    /// <summary>
    /// Name of the property.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Value of the property.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleApigeeOrganization.
/// Nesting mode: single
/// </summary>
public class GoogleApigeeOrganizationTimeoutsBlock : TerraformBlock
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
/// Represents a google_apigee_organization Terraform resource.
/// Manages a google_apigee_organization resource.
/// </summary>
public partial class GoogleApigeeOrganization(string name) : TerraformResource("google_apigee_organization", name)
{
    /// <summary>
    /// Primary GCP region for analytics data storage. For valid values, see [Create an Apigee organization](https://cloud.google.com/apigee/docs/api-platform/get-started/create-org).
    /// </summary>
    public TerraformValue<string>? AnalyticsRegion
    {
        get => GetArgument<TerraformValue<string>>("analytics_region");
        set => SetArgument("analytics_region", value);
    }

    /// <summary>
    /// Cloud KMS key name used for encrypting API consumer data.
    /// </summary>
    public TerraformValue<string>? ApiConsumerDataEncryptionKeyName
    {
        get => GetArgument<TerraformValue<string>>("api_consumer_data_encryption_key_name");
        set => SetArgument("api_consumer_data_encryption_key_name", value);
    }

    /// <summary>
    /// This field is needed only for customers using non-default data residency regions.
    /// Apigee stores some control plane data only in single region.
    /// This field determines which single region Apigee should use.
    /// </summary>
    public TerraformValue<string>? ApiConsumerDataLocation
    {
        get => GetArgument<TerraformValue<string>>("api_consumer_data_location");
        set => SetArgument("api_consumer_data_location", value);
    }

    /// <summary>
    /// Compute Engine network used for Service Networking to be peered with Apigee runtime instances.
    /// See [Getting started with the Service Networking API](https://cloud.google.com/service-infrastructure/docs/service-networking/getting-started).
    /// Valid only when &#39;RuntimeType&#39; is set to CLOUD. The value can be updated only when there are no runtime instances. For example: &amp;quot;default&amp;quot;.
    /// </summary>
    public TerraformValue<string>? AuthorizedNetwork
    {
        get => GetArgument<TerraformValue<string>>("authorized_network");
        set => SetArgument("authorized_network", value);
    }

    /// <summary>
    /// Billing type of the Apigee organization. See [Apigee pricing](https://cloud.google.com/apigee/pricing).
    /// </summary>
    public TerraformValue<string>? BillingType
    {
        get => GetArgument<TerraformValue<string>>("billing_type");
        set => SetArgument("billing_type", value);
    }

    /// <summary>
    /// Cloud KMS key name used for encrypting control plane data that is stored in a multi region.
    /// Only used for the data residency region &amp;quot;US&amp;quot; or &amp;quot;EU&amp;quot;.
    /// </summary>
    public TerraformValue<string>? ControlPlaneEncryptionKeyName
    {
        get => GetArgument<TerraformValue<string>>("control_plane_encryption_key_name");
        set => SetArgument("control_plane_encryption_key_name", value);
    }

    /// <summary>
    /// Description of the Apigee organization.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Flag that specifies whether the VPC Peering through Private Google Access should be
    /// disabled between the consumer network and Apigee. Required if an &#39;authorizedNetwork&#39;
    /// on the consumer project is not provided, in which case the flag should be set to &#39;true&#39;.
    /// Valid only when &#39;RuntimeType&#39; is set to CLOUD. The value must be set before the creation
    /// of any Apigee runtime instance and can be updated only when there are no runtime instances.
    /// </summary>
    public TerraformValue<bool>? DisableVpcPeering
    {
        get => GetArgument<TerraformValue<bool>>("disable_vpc_peering");
        set => SetArgument("disable_vpc_peering", value);
    }

    /// <summary>
    /// The display name of the Apigee organization.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project ID associated with the Apigee organization.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformValue<string> ProjectId
    {
        get => GetArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// Optional. This setting is applicable only for organizations that are soft-deleted (i.e., BillingType
    /// is not EVALUATION). It controls how long Organization data will be retained after the initial delete
    /// operation completes. During this period, the Organization may be restored to its last known state.
    /// After this period, the Organization will no longer be able to be restored. Default value: &amp;quot;DELETION_RETENTION_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;DELETION_RETENTION_UNSPECIFIED&amp;quot;, &amp;quot;MINIMUM&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Retention
    {
        get => GetArgument<TerraformValue<string>>("retention");
        set => SetArgument("retention", value);
    }

    /// <summary>
    /// Cloud KMS key name used for encrypting the data that is stored and replicated across runtime instances.
    /// Update is not allowed after the organization is created.
    /// If not specified, a Google-Managed encryption key will be used.
    /// Valid only when &#39;RuntimeType&#39; is CLOUD. For example: &#39;projects/foo/locations/us/keyRings/bar/cryptoKeys/baz&#39;.
    /// </summary>
    public TerraformValue<string>? RuntimeDatabaseEncryptionKeyName
    {
        get => GetArgument<TerraformValue<string>>("runtime_database_encryption_key_name");
        set => SetArgument("runtime_database_encryption_key_name", value);
    }

    /// <summary>
    /// Runtime type of the Apigee organization based on the Apigee subscription purchased. Default value: &amp;quot;CLOUD&amp;quot; Possible values: [&amp;quot;CLOUD&amp;quot;, &amp;quot;HYBRID&amp;quot;]
    /// </summary>
    public TerraformValue<string>? RuntimeType
    {
        get => GetArgument<TerraformValue<string>>("runtime_type");
        set => SetArgument("runtime_type", value);
    }

    /// <summary>
    /// Output only. Project ID of the Apigee Tenant Project.
    /// </summary>
    public TerraformValue<string> ApigeeProjectId
        => AsReference("apigee_project_id");

    /// <summary>
    /// Output only. Base64-encoded public certificate for the root CA of the Apigee organization.
    /// Valid only when &#39;RuntimeType&#39; is CLOUD. A base64-encoded string.
    /// </summary>
    public TerraformValue<string> CaCertificate
        => AsReference("ca_certificate");

    /// <summary>
    /// Output only. Name of the Apigee organization.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Output only. Subscription type of the Apigee organization.
    /// Valid values include trial (free, limited, and for evaluation purposes only) or paid (full subscription has been purchased).
    /// </summary>
    public TerraformValue<string> SubscriptionType
        => AsReference("subscription_type");

    /// <summary>
    /// Properties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Properties block(s) allowed")]
    public TerraformList<GoogleApigeeOrganizationPropertiesBlock>? Properties
    {
        get => GetArgument<TerraformList<GoogleApigeeOrganizationPropertiesBlock>>("properties");
        set => SetArgument("properties", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApigeeOrganizationTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApigeeOrganizationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
