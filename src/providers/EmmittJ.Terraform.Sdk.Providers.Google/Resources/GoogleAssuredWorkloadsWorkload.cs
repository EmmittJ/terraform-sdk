using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for kms_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleAssuredWorkloadsWorkloadKmsSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// Required. Input only. Immutable. The time at which the Key Management Service will automatically create a new version of the crypto key and mark it as the primary.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NextRotationTime is required")]
    [TerraformPropertyName("next_rotation_time")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NextRotationTime { get; set; }

    /// <summary>
    /// Required. Input only. Immutable. will be advanced by this period when the Key Management Service automatically rotates a key. Must be at least 24 hours and at most 876,000 hours.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RotationPeriod is required")]
    [TerraformPropertyName("rotation_period")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RotationPeriod { get; set; }

}

/// <summary>
/// Block type for partner_permissions in .
/// Nesting mode: list
/// </summary>
public class GoogleAssuredWorkloadsWorkloadPartnerPermissionsBlock : ITerraformBlock
{
    /// <summary>
    /// Optional. Allow partner to view violation alerts.
    /// </summary>
    [TerraformPropertyName("assured_workloads_monitoring")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? AssuredWorkloadsMonitoring { get; set; }

    /// <summary>
    /// Allow the partner to view inspectability logs and monitoring violations.
    /// </summary>
    [TerraformPropertyName("data_logs_viewer")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DataLogsViewer { get; set; }

    /// <summary>
    /// Optional. Allow partner to view access approval logs.
    /// </summary>
    [TerraformPropertyName("service_access_approver")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ServiceAccessApprover { get; set; }

}

/// <summary>
/// Block type for resource_settings in .
/// Nesting mode: list
/// </summary>
public class GoogleAssuredWorkloadsWorkloadResourceSettingsBlock : ITerraformBlock
{
    /// <summary>
    /// User-assigned resource display name. If not empty it will be used to create a resource with the specified name.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// Resource identifier. For a project this represents projectId. If the project is already taken, the workload creation will fail. For KeyRing, this represents the keyring_id. For a folder, don&#39;t set this value as folder_id is assigned by Google.
    /// </summary>
    [TerraformPropertyName("resource_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ResourceId { get; set; }

    /// <summary>
    /// Indicates the type of resource. This field should be specified to correspond the id to the right project type (CONSUMER_PROJECT or ENCRYPTION_KEYS_PROJECT) Possible values: RESOURCE_TYPE_UNSPECIFIED, CONSUMER_PROJECT, ENCRYPTION_KEYS_PROJECT, KEYRING, CONSUMER_FOLDER
    /// </summary>
    [TerraformPropertyName("resource_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ResourceType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleAssuredWorkloadsWorkloadTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for workload_options in .
/// Nesting mode: list
/// </summary>
public class GoogleAssuredWorkloadsWorkloadWorkloadOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// Indicates type of KAJ enrollment for the workload. Currently, only specifiying KEY_ACCESS_TRANSPARENCY_OFF is implemented to not enroll in KAT-level KAJ enrollment for Regional Controls workloads. Possible values: KAJ_ENROLLMENT_TYPE_UNSPECIFIED, FULL_KAJ, EKM_ONLY, KEY_ACCESS_TRANSPARENCY_OFF
    /// </summary>
    [TerraformPropertyName("kaj_enrollment_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KajEnrollmentType { get; set; }

}

/// <summary>
/// Manages a google_assured_workloads_workload resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleAssuredWorkloadsWorkload : TerraformResource
{
    public GoogleAssuredWorkloadsWorkload(string name) : base("google_assured_workloads_workload", name)
    {
    }

    /// <summary>
    /// Optional. Input only. The billing account used for the resources which are direct children of workload. This billing account is initially associated with the resources created as part of Workload creation. After the initial creation of these resources, the customer can change the assigned billing account. The resource name has the form `billingAccounts/{billing_account_id}`. For example, `billingAccounts/012345-567890-ABCDEF`.
    /// </summary>
    [TerraformPropertyName("billing_account")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? BillingAccount { get; set; }

    /// <summary>
    /// Required. Immutable. Compliance Regime associated with this workload. Possible values: COMPLIANCE_REGIME_UNSPECIFIED, IL4, CJIS, FEDRAMP_HIGH, FEDRAMP_MODERATE, US_REGIONAL_ACCESS, HIPAA, HITRUST, EU_REGIONS_AND_SUPPORT, CA_REGIONS_AND_SUPPORT, ITAR, AU_REGIONS_AND_US_SUPPORT, ASSURED_WORKLOADS_FOR_PARTNERS, ISR_REGIONS, ISR_REGIONS_AND_SUPPORT, CA_PROTECTED_B, IL5, IL2, JP_REGIONS_AND_SUPPORT, KSA_REGIONS_AND_SUPPORT_WITH_SOVEREIGNTY_CONTROLS, REGIONAL_CONTROLS, HEALTHCARE_AND_LIFE_SCIENCES_CONTROLS, HEALTHCARE_AND_LIFE_SCIENCES_CONTROLS_US_SUPPORT, IRS_1075
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComplianceRegime is required")]
    [TerraformPropertyName("compliance_regime")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ComplianceRegime { get; set; }

    /// <summary>
    /// Required. The user-assigned display name of the Workload. When present it must be between 4 to 30 characters. Allowed characters are: lowercase and uppercase letters, numbers, hyphen, and spaces. Example: My Workload
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// Optional. Indicates the sovereignty status of the given workload. Currently meant to be used by Europe/Canada customers.
    /// </summary>
    [TerraformPropertyName("enable_sovereign_controls")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnableSovereignControls { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Optional. Labels applied to the workload.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field `effective_labels` for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The location for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The organization for the resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Organization is required")]
    [TerraformPropertyName("organization")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Organization { get; set; }

    /// <summary>
    /// Optional. Partner regime associated with this workload. Possible values: PARTNER_UNSPECIFIED, LOCAL_CONTROLS_BY_S3NS, SOVEREIGN_CONTROLS_BY_T_SYSTEMS, SOVEREIGN_CONTROLS_BY_SIA_MINSAIT, SOVEREIGN_CONTROLS_BY_PSN, SOVEREIGN_CONTROLS_BY_CNTXT, SOVEREIGN_CONTROLS_BY_CNTXT_NO_EKM
    /// </summary>
    [TerraformPropertyName("partner")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Partner { get; set; }

    /// <summary>
    /// Optional. Input only. Billing account necessary for purchasing services from Sovereign Partners. This field is required for creating SIA/PSN/CNTXT partner workloads. The caller should have &#39;billing.resourceAssociations.create&#39; IAM permission on this billing-account. The format of this string is billingAccounts/AAAAAA-BBBBBB-CCCCCC.
    /// </summary>
    [TerraformPropertyName("partner_services_billing_account")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PartnerServicesBillingAccount { get; set; }

    /// <summary>
    /// Input only. The parent resource for the resources managed by this Assured Workload. May be either empty or a folder resource which is a child of the Workload parent. If not specified all resources are created under the parent organization. Format: folders/{folder_id}
    /// </summary>
    [TerraformPropertyName("provisioned_resources_parent")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProvisionedResourcesParent { get; set; }

    /// <summary>
    /// Optional. Indicates whether the e-mail notification for a violation is enabled for a workload. This value will be by default True, and if not present will be considered as true. This should only be updated via updateWorkload call. Any Changes to this field during the createWorkload call will not be honored. This will always be true while creating the workload.
    /// </summary>
    [TerraformPropertyName("violation_notifications_enabled")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<bool>> ViolationNotificationsEnabled { get; set; } = new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "violation_notifications_enabled");

    /// <summary>
    /// Block for kms_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 KmsSettings block(s) allowed")]
    [TerraformPropertyName("kms_settings")]
    public TerraformList<TerraformBlock<GoogleAssuredWorkloadsWorkloadKmsSettingsBlock>>? KmsSettings { get; set; } = new();

    /// <summary>
    /// Block for partner_permissions.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PartnerPermissions block(s) allowed")]
    [TerraformPropertyName("partner_permissions")]
    public TerraformList<TerraformBlock<GoogleAssuredWorkloadsWorkloadPartnerPermissionsBlock>>? PartnerPermissions { get; set; } = new();

    /// <summary>
    /// Block for resource_settings.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("resource_settings")]
    public TerraformList<TerraformBlock<GoogleAssuredWorkloadsWorkloadResourceSettingsBlock>>? ResourceSettings { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleAssuredWorkloadsWorkloadTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for workload_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WorkloadOptions block(s) allowed")]
    [TerraformPropertyName("workload_options")]
    public TerraformList<TerraformBlock<GoogleAssuredWorkloadsWorkloadWorkloadOptionsBlock>>? WorkloadOptions { get; set; } = new();

    /// <summary>
    /// Output only. Count of active Violations in the Workload.
    /// </summary>
    [TerraformPropertyName("compliance_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ComplianceStatus => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "compliance_status");

    /// <summary>
    /// Output only. Urls for services which are compliant for this Assured Workload, but which are currently disallowed by the ResourceUsageRestriction org policy. Invoke workloads.restrictAllowedResources endpoint to allow your project developers to use these services in their environment.
    /// </summary>
    [TerraformPropertyName("compliant_but_disallowed_services")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> CompliantButDisallowedServices => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "compliant_but_disallowed_services");

    /// <summary>
    /// Output only. Immutable. The Workload creation timestamp.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// Optional. Represents the Ekm Provisioning State of the given workload.
    /// </summary>
    [TerraformPropertyName("ekm_provisioning_response")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EkmProvisioningResponse => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "ekm_provisioning_response");

    /// <summary>
    /// Output only. Represents the KAJ enrollment state of the given workload. Possible values: KAJ_ENROLLMENT_STATE_UNSPECIFIED, KAJ_ENROLLMENT_STATE_PENDING, KAJ_ENROLLMENT_STATE_COMPLETE
    /// </summary>
    [TerraformPropertyName("kaj_enrollment_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> KajEnrollmentState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "kaj_enrollment_state");

    /// <summary>
    /// Output only. The resource name of the workload.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// Output only. The resources associated with this workload. These resources will be created when creating the workload. If any of the projects already exist, the workload creation will fail. Always read only.
    /// </summary>
    [TerraformPropertyName("resources")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Resources => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "resources");

    /// <summary>
    /// Output only. Represents the SAA enrollment response of the given workload. SAA enrollment response is queried during workloads.get call. In failure cases, user friendly error message is shown in SAA details page.
    /// </summary>
    [TerraformPropertyName("saa_enrollment_response")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SaaEnrollmentResponse => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "saa_enrollment_response");

    /// <summary>
    /// The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

}
