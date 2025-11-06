using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

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
    public string? BillingAccount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("billing_account")?.Value;
        set => this.WithProperty("billing_account", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Required. Immutable. Compliance Regime associated with this workload. Possible values: COMPLIANCE_REGIME_UNSPECIFIED, IL4, CJIS, FEDRAMP_HIGH, FEDRAMP_MODERATE, US_REGIONAL_ACCESS, HIPAA, HITRUST, EU_REGIONS_AND_SUPPORT, CA_REGIONS_AND_SUPPORT, ITAR, AU_REGIONS_AND_US_SUPPORT, ASSURED_WORKLOADS_FOR_PARTNERS, ISR_REGIONS, ISR_REGIONS_AND_SUPPORT, CA_PROTECTED_B, IL5, IL2, JP_REGIONS_AND_SUPPORT, KSA_REGIONS_AND_SUPPORT_WITH_SOVEREIGNTY_CONTROLS, REGIONAL_CONTROLS, HEALTHCARE_AND_LIFE_SCIENCES_CONTROLS, HEALTHCARE_AND_LIFE_SCIENCES_CONTROLS_US_SUPPORT, IRS_1075
    /// </summary>
    public string? ComplianceRegime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compliance_regime")?.Value;
        set => this.WithProperty("compliance_regime", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Required. The user-assigned display name of the Workload. When present it must be between 4 to 30 characters. Allowed characters are: lowercase and uppercase letters, numbers, hyphen, and spaces. Example: My Workload
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Optional. Indicates the sovereignty status of the given workload. Currently meant to be used by Europe/Canada customers.
    /// </summary>
    public bool? EnableSovereignControls
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_sovereign_controls")?.Value;
        set => this.WithProperty("enable_sovereign_controls", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// Optional. Labels applied to the workload.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field `effective_labels` for all of the labels present on the resource.
    /// </summary>
    public Dictionary<string, string>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("labels")?.Value;
        set => this.WithProperty("labels", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The location for the resource
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The organization for the resource
    /// </summary>
    public string? Organization
    {
        get => GetProperty<TerraformLiteralProperty<string>>("organization")?.Value;
        set => this.WithProperty("organization", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Optional. Partner regime associated with this workload. Possible values: PARTNER_UNSPECIFIED, LOCAL_CONTROLS_BY_S3NS, SOVEREIGN_CONTROLS_BY_T_SYSTEMS, SOVEREIGN_CONTROLS_BY_SIA_MINSAIT, SOVEREIGN_CONTROLS_BY_PSN, SOVEREIGN_CONTROLS_BY_CNTXT, SOVEREIGN_CONTROLS_BY_CNTXT_NO_EKM
    /// </summary>
    public string? Partner
    {
        get => GetProperty<TerraformLiteralProperty<string>>("partner")?.Value;
        set => this.WithProperty("partner", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Optional. Input only. Billing account necessary for purchasing services from Sovereign Partners. This field is required for creating SIA/PSN/CNTXT partner workloads. The caller should have &#39;billing.resourceAssociations.create&#39; IAM permission on this billing-account. The format of this string is billingAccounts/AAAAAA-BBBBBB-CCCCCC.
    /// </summary>
    public string? PartnerServicesBillingAccount
    {
        get => GetProperty<TerraformLiteralProperty<string>>("partner_services_billing_account")?.Value;
        set => this.WithProperty("partner_services_billing_account", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Input only. The parent resource for the resources managed by this Assured Workload. May be either empty or a folder resource which is a child of the Workload parent. If not specified all resources are created under the parent organization. Format: folders/{folder_id}
    /// </summary>
    public string? ProvisionedResourcesParent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("provisioned_resources_parent")?.Value;
        set => this.WithProperty("provisioned_resources_parent", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Optional. Indicates whether the e-mail notification for a violation is enabled for a workload. This value will be by default True, and if not present will be considered as true. This should only be updated via updateWorkload call. Any Changes to this field during the createWorkload call will not be honored. This will always be true while creating the workload.
    /// </summary>
    public bool? ViolationNotificationsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("violation_notifications_enabled")?.Value;
        set => this.WithProperty("violation_notifications_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
