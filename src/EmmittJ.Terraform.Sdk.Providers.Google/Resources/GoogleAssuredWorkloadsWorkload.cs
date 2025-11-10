using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for kms_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleAssuredWorkloadsWorkloadKmsSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Required. Input only. Immutable. The time at which the Key Management Service will automatically create a new version of the crypto key and mark it as the primary.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NextRotationTime is required")]
    public required TerraformProperty<string> NextRotationTime
    {
        get => GetProperty<TerraformProperty<string>>("next_rotation_time");
        set => WithProperty("next_rotation_time", value);
    }

    /// <summary>
    /// Required. Input only. Immutable. will be advanced by this period when the Key Management Service automatically rotates a key. Must be at least 24 hours and at most 876,000 hours.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RotationPeriod is required")]
    public required TerraformProperty<string> RotationPeriod
    {
        get => GetProperty<TerraformProperty<string>>("rotation_period");
        set => WithProperty("rotation_period", value);
    }

}

/// <summary>
/// Block type for partner_permissions in .
/// Nesting mode: list
/// </summary>
public class GoogleAssuredWorkloadsWorkloadPartnerPermissionsBlock : TerraformBlock
{
    /// <summary>
    /// Optional. Allow partner to view violation alerts.
    /// </summary>
    public TerraformProperty<bool>? AssuredWorkloadsMonitoring
    {
        get => GetProperty<TerraformProperty<bool>>("assured_workloads_monitoring");
        set => WithProperty("assured_workloads_monitoring", value);
    }

    /// <summary>
    /// Allow the partner to view inspectability logs and monitoring violations.
    /// </summary>
    public TerraformProperty<bool>? DataLogsViewer
    {
        get => GetProperty<TerraformProperty<bool>>("data_logs_viewer");
        set => WithProperty("data_logs_viewer", value);
    }

    /// <summary>
    /// Optional. Allow partner to view access approval logs.
    /// </summary>
    public TerraformProperty<bool>? ServiceAccessApprover
    {
        get => GetProperty<TerraformProperty<bool>>("service_access_approver");
        set => WithProperty("service_access_approver", value);
    }

}

/// <summary>
/// Block type for resource_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleAssuredWorkloadsWorkloadResourceSettingsBlock : TerraformBlock
{
    /// <summary>
    /// User-assigned resource display name. If not empty it will be used to create a resource with the specified name.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => WithProperty("display_name", value);
    }

    /// <summary>
    /// Resource identifier. For a project this represents projectId. If the project is already taken, the workload creation will fail. For KeyRing, this represents the keyring_id. For a folder, don&#39;t set this value as folder_id is assigned by Google.
    /// </summary>
    public TerraformProperty<string>? ResourceId
    {
        get => GetProperty<TerraformProperty<string>>("resource_id");
        set => WithProperty("resource_id", value);
    }

    /// <summary>
    /// Indicates the type of resource. This field should be specified to correspond the id to the right project type (CONSUMER_PROJECT or ENCRYPTION_KEYS_PROJECT) Possible values: RESOURCE_TYPE_UNSPECIFIED, CONSUMER_PROJECT, ENCRYPTION_KEYS_PROJECT, KEYRING, CONSUMER_FOLDER
    /// </summary>
    public TerraformProperty<string>? ResourceType
    {
        get => GetProperty<TerraformProperty<string>>("resource_type");
        set => WithProperty("resource_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAssuredWorkloadsWorkloadTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for workload_options in .
/// Nesting mode: list
/// </summary>
public class GoogleAssuredWorkloadsWorkloadWorkloadOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Indicates type of KAJ enrollment for the workload. Currently, only specifiying KEY_ACCESS_TRANSPARENCY_OFF is implemented to not enroll in KAT-level KAJ enrollment for Regional Controls workloads. Possible values: KAJ_ENROLLMENT_TYPE_UNSPECIFIED, FULL_KAJ, EKM_ONLY, KEY_ACCESS_TRANSPARENCY_OFF
    /// </summary>
    public TerraformProperty<string>? KajEnrollmentType
    {
        get => GetProperty<TerraformProperty<string>>("kaj_enrollment_type");
        set => WithProperty("kaj_enrollment_type", value);
    }

}

/// <summary>
/// Manages a google_assured_workloads_workload resource.
/// </summary>
public class GoogleAssuredWorkloadsWorkload : TerraformResource
{
    public GoogleAssuredWorkloadsWorkload(string name) : base("google_assured_workloads_workload", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("compliance_status");
        this.DeclareOutput("compliant_but_disallowed_services");
        this.DeclareOutput("create_time");
        this.DeclareOutput("effective_labels");
        this.DeclareOutput("ekm_provisioning_response");
        this.DeclareOutput("kaj_enrollment_state");
        this.DeclareOutput("name");
        this.DeclareOutput("resources");
        this.DeclareOutput("saa_enrollment_response");
        this.DeclareOutput("terraform_labels");
    }

    /// <summary>
    /// Optional. Input only. The billing account used for the resources which are direct children of workload. This billing account is initially associated with the resources created as part of Workload creation. After the initial creation of these resources, the customer can change the assigned billing account. The resource name has the form `billingAccounts/{billing_account_id}`. For example, `billingAccounts/012345-567890-ABCDEF`.
    /// </summary>
    public TerraformProperty<string>? BillingAccount
    {
        get => GetProperty<TerraformProperty<string>>("billing_account");
        set => this.WithProperty("billing_account", value);
    }

    /// <summary>
    /// Required. Immutable. Compliance Regime associated with this workload. Possible values: COMPLIANCE_REGIME_UNSPECIFIED, IL4, CJIS, FEDRAMP_HIGH, FEDRAMP_MODERATE, US_REGIONAL_ACCESS, HIPAA, HITRUST, EU_REGIONS_AND_SUPPORT, CA_REGIONS_AND_SUPPORT, ITAR, AU_REGIONS_AND_US_SUPPORT, ASSURED_WORKLOADS_FOR_PARTNERS, ISR_REGIONS, ISR_REGIONS_AND_SUPPORT, CA_PROTECTED_B, IL5, IL2, JP_REGIONS_AND_SUPPORT, KSA_REGIONS_AND_SUPPORT_WITH_SOVEREIGNTY_CONTROLS, REGIONAL_CONTROLS, HEALTHCARE_AND_LIFE_SCIENCES_CONTROLS, HEALTHCARE_AND_LIFE_SCIENCES_CONTROLS_US_SUPPORT, IRS_1075
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComplianceRegime is required")]
    public required TerraformProperty<string> ComplianceRegime
    {
        get => GetProperty<TerraformProperty<string>>("compliance_regime");
        set => this.WithProperty("compliance_regime", value);
    }

    /// <summary>
    /// Required. The user-assigned display name of the Workload. When present it must be between 4 to 30 characters. Allowed characters are: lowercase and uppercase letters, numbers, hyphen, and spaces. Example: My Workload
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Optional. Indicates the sovereignty status of the given workload. Currently meant to be used by Europe/Canada customers.
    /// </summary>
    public TerraformProperty<bool>? EnableSovereignControls
    {
        get => GetProperty<TerraformProperty<bool>>("enable_sovereign_controls");
        set => this.WithProperty("enable_sovereign_controls", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Optional. Labels applied to the workload.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field `effective_labels` for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The organization for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Organization is required")]
    public required TerraformProperty<string> Organization
    {
        get => GetProperty<TerraformProperty<string>>("organization");
        set => this.WithProperty("organization", value);
    }

    /// <summary>
    /// Optional. Partner regime associated with this workload. Possible values: PARTNER_UNSPECIFIED, LOCAL_CONTROLS_BY_S3NS, SOVEREIGN_CONTROLS_BY_T_SYSTEMS, SOVEREIGN_CONTROLS_BY_SIA_MINSAIT, SOVEREIGN_CONTROLS_BY_PSN, SOVEREIGN_CONTROLS_BY_CNTXT, SOVEREIGN_CONTROLS_BY_CNTXT_NO_EKM
    /// </summary>
    public TerraformProperty<string>? Partner
    {
        get => GetProperty<TerraformProperty<string>>("partner");
        set => this.WithProperty("partner", value);
    }

    /// <summary>
    /// Optional. Input only. Billing account necessary for purchasing services from Sovereign Partners. This field is required for creating SIA/PSN/CNTXT partner workloads. The caller should have &#39;billing.resourceAssociations.create&#39; IAM permission on this billing-account. The format of this string is billingAccounts/AAAAAA-BBBBBB-CCCCCC.
    /// </summary>
    public TerraformProperty<string>? PartnerServicesBillingAccount
    {
        get => GetProperty<TerraformProperty<string>>("partner_services_billing_account");
        set => this.WithProperty("partner_services_billing_account", value);
    }

    /// <summary>
    /// Input only. The parent resource for the resources managed by this Assured Workload. May be either empty or a folder resource which is a child of the Workload parent. If not specified all resources are created under the parent organization. Format: folders/{folder_id}
    /// </summary>
    public TerraformProperty<string>? ProvisionedResourcesParent
    {
        get => GetProperty<TerraformProperty<string>>("provisioned_resources_parent");
        set => this.WithProperty("provisioned_resources_parent", value);
    }

    /// <summary>
    /// Optional. Indicates whether the e-mail notification for a violation is enabled for a workload. This value will be by default True, and if not present will be considered as true. This should only be updated via updateWorkload call. Any Changes to this field during the createWorkload call will not be honored. This will always be true while creating the workload.
    /// </summary>
    public TerraformProperty<bool>? ViolationNotificationsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("violation_notifications_enabled");
        set => this.WithProperty("violation_notifications_enabled", value);
    }

    /// <summary>
    /// Block for kms_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KmsSettings block(s) allowed")]
    public List<GoogleAssuredWorkloadsWorkloadKmsSettingsBlock>? KmsSettings
    {
        get => GetProperty<List<GoogleAssuredWorkloadsWorkloadKmsSettingsBlock>>("kms_settings");
        set => this.WithProperty("kms_settings", value);
    }

    /// <summary>
    /// Block for partner_permissions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PartnerPermissions block(s) allowed")]
    public List<GoogleAssuredWorkloadsWorkloadPartnerPermissionsBlock>? PartnerPermissions
    {
        get => GetProperty<List<GoogleAssuredWorkloadsWorkloadPartnerPermissionsBlock>>("partner_permissions");
        set => this.WithProperty("partner_permissions", value);
    }

    /// <summary>
    /// Block for resource_settings.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleAssuredWorkloadsWorkloadResourceSettingsBlock>? ResourceSettings
    {
        get => GetProperty<List<GoogleAssuredWorkloadsWorkloadResourceSettingsBlock>>("resource_settings");
        set => this.WithProperty("resource_settings", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleAssuredWorkloadsWorkloadTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleAssuredWorkloadsWorkloadTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for workload_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkloadOptions block(s) allowed")]
    public List<GoogleAssuredWorkloadsWorkloadWorkloadOptionsBlock>? WorkloadOptions
    {
        get => GetProperty<List<GoogleAssuredWorkloadsWorkloadWorkloadOptionsBlock>>("workload_options");
        set => this.WithProperty("workload_options", value);
    }

    /// <summary>
    /// Output only. Count of active Violations in the Workload.
    /// </summary>
    public TerraformExpression ComplianceStatus => this["compliance_status"];

    /// <summary>
    /// Output only. Urls for services which are compliant for this Assured Workload, but which are currently disallowed by the ResourceUsageRestriction org policy. Invoke workloads.restrictAllowedResources endpoint to allow your project developers to use these services in their environment.
    /// </summary>
    public TerraformExpression CompliantButDisallowedServices => this["compliant_but_disallowed_services"];

    /// <summary>
    /// Output only. Immutable. The Workload creation timestamp.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformExpression EffectiveLabels => this["effective_labels"];

    /// <summary>
    /// Optional. Represents the Ekm Provisioning State of the given workload.
    /// </summary>
    public TerraformExpression EkmProvisioningResponse => this["ekm_provisioning_response"];

    /// <summary>
    /// Output only. Represents the KAJ enrollment state of the given workload. Possible values: KAJ_ENROLLMENT_STATE_UNSPECIFIED, KAJ_ENROLLMENT_STATE_PENDING, KAJ_ENROLLMENT_STATE_COMPLETE
    /// </summary>
    public TerraformExpression KajEnrollmentState => this["kaj_enrollment_state"];

    /// <summary>
    /// Output only. The resource name of the workload.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. The resources associated with this workload. These resources will be created when creating the workload. If any of the projects already exist, the workload creation will fail. Always read only.
    /// </summary>
    public TerraformExpression Resources => this["resources"];

    /// <summary>
    /// Output only. Represents the SAA enrollment response of the given workload. SAA enrollment response is queried during workloads.get call. In failure cases, user friendly error message is shown in SAA details page.
    /// </summary>
    public TerraformExpression SaaEnrollmentResponse => this["saa_enrollment_response"];

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformExpression TerraformLabels => this["terraform_labels"];

}
