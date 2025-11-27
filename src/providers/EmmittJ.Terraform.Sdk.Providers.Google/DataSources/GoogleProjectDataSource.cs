using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_project Terraform data source.
/// Retrieves information about a google_project.
/// </summary>
public partial class GoogleProjectDataSource(string name) : TerraformDataSource("google_project", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project ID. Changing this forces a new project to be created.
    /// </summary>
    public TerraformValue<string>? ProjectId
    {
        get => new TerraformReference<string>(this, "project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// Create the &#39;default&#39; network automatically.  Default true. If set to false, the default network will be deleted.  Note that, for quota purposes, you will still need to have 1 network slot available to create the project successfully, even if you set auto_create_network to false, since the network will exist momentarily.
    /// </summary>
    public TerraformValue<bool> AutoCreateNetwork
    {
        get => new TerraformReference<bool>(this, "auto_create_network");
    }

    /// <summary>
    /// The alphanumeric ID of the billing account this project belongs to. The user or service account performing this operation with Terraform must have Billing Account Administrator privileges (roles/billing.admin) in the organization. See Google Cloud Billing API Access Control for more details.
    /// </summary>
    public TerraformValue<string> BillingAccount
    {
        get => new TerraformReference<string>(this, "billing_account");
    }

    /// <summary>
    /// The deletion policy for the Project. Setting PREVENT will protect the project against any destroy actions caused by a terraform apply or terraform destroy. Setting ABANDON allows the resource
    /// 				to be abandoned rather than deleted. Possible values are: &amp;quot;PREVENT&amp;quot;, &amp;quot;ABANDON&amp;quot;, &amp;quot;DELETE&amp;quot;
    /// </summary>
    public TerraformValue<string> DeletionPolicy
    {
        get => new TerraformReference<string>(this, "deletion_policy");
    }

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "effective_labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The numeric ID of the folder this project should be created under. Only one of org_id or folder_id may be specified. If the folder_id is specified, then the project is created under the specified folder. Changing this forces the project to be migrated to the newly specified folder.
    /// </summary>
    public TerraformValue<string> FolderId
    {
        get => new TerraformReference<string>(this, "folder_id");
    }

    /// <summary>
    /// A set of key/value label pairs to assign to the project.
    /// 				
    /// 				**Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// 				Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string> Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
    }

    /// <summary>
    /// The display name of the project.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The numeric identifier of the project.
    /// </summary>
    public TerraformValue<string> Number
    {
        get => new TerraformReference<string>(this, "number");
    }

    /// <summary>
    /// The numeric ID of the organization this project belongs to. Changing this forces a new project to be created.  Only one of org_id or folder_id may be specified. If the org_id is specified then the project is created at the top level. Changing this forces the project to be migrated to the newly specified organization.
    /// </summary>
    public TerraformValue<string> OrgId
    {
        get => new TerraformReference<string>(this, "org_id");
    }

    /// <summary>
    /// A map of resource manager tags. Resource manager tag keys and values have the same definition as resource manager tags. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456. The field is ignored when empty. This field is only set at create time and modifying this field after creation will trigger recreation. To apply tags to an existing resource, see the google_tags_tag_value resource.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// (ReadOnly) The combination of labels configured directly on the resource and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "terraform_labels").ResolveNodes(ctx));
    }

}
