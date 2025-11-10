using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_project.
/// </summary>
public class GoogleProjectDataSource : TerraformDataSource
{
    public GoogleProjectDataSource(string name) : base("google_project", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The project ID. Changing this forces a new project to be created.
    /// </summary>
    [TerraformPropertyName("project_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProjectId { get; set; }

    /// <summary>
    /// Create the &#39;default&#39; network automatically.  Default true. If set to false, the default network will be deleted.  Note that, for quota purposes, you will still need to have 1 network slot available to create the project successfully, even if you set auto_create_network to false, since the network will exist momentarily.
    /// </summary>
    [TerraformPropertyName("auto_create_network")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AutoCreateNetwork => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "auto_create_network");

    /// <summary>
    /// The alphanumeric ID of the billing account this project belongs to. The user or service account performing this operation with Terraform must have Billing Account Administrator privileges (roles/billing.admin) in the organization. See Google Cloud Billing API Access Control for more details.
    /// </summary>
    [TerraformPropertyName("billing_account")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> BillingAccount => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "billing_account");

    /// <summary>
    /// The deletion policy for the Project. Setting PREVENT will protect the project against any destroy actions caused by a terraform apply or terraform destroy. Setting ABANDON allows the resource
    /// 				to be abandoned rather than deleted. Possible values are: &amp;quot;PREVENT&amp;quot;, &amp;quot;ABANDON&amp;quot;, &amp;quot;DELETE&amp;quot;
    /// </summary>
    [TerraformPropertyName("deletion_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeletionPolicy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "deletion_policy");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    [TerraformPropertyName("effective_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> EffectiveLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "effective_labels");

    /// <summary>
    /// The numeric ID of the folder this project should be created under. Only one of org_id or folder_id may be specified. If the folder_id is specified, then the project is created under the specified folder. Changing this forces the project to be migrated to the newly specified folder.
    /// </summary>
    [TerraformPropertyName("folder_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> FolderId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "folder_id");

    /// <summary>
    /// A set of key/value label pairs to assign to the project.
    /// 				
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    [TerraformPropertyName("labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Labels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "labels");

    /// <summary>
    /// The display name of the project.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The numeric identifier of the project.
    /// </summary>
    [TerraformPropertyName("number")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Number => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "number");

    /// <summary>
    /// The numeric ID of the organization this project belongs to. Changing this forces a new project to be created.  Only one of org_id or folder_id may be specified. If the org_id is specified then the project is created at the top level. Changing this forces the project to be migrated to the newly specified organization.
    /// </summary>
    [TerraformPropertyName("org_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OrgId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "org_id");

    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored when empty. This field is only set at create time and modifying this field after creation will trigger recreation. To apply tags to an existing resource, see the google_tags_tag_value resource.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// (ReadOnly) The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    [TerraformPropertyName("terraform_labels")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TerraformLabels => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "terraform_labels");

}
