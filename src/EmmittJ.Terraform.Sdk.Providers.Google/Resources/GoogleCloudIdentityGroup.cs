using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_cloud_identity_group resource.
/// </summary>
public class GoogleCloudIdentityGroup : TerraformResource
{
    public GoogleCloudIdentityGroup(string name) : base("google_cloud_identity_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("additional_group_keys");
        this.DeclareOutput("create_time");
        this.DeclareOutput("name");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// An extended description to help users determine the purpose of a Group.
    /// Must not be longer than 4,096 characters.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display name of the Group.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The initial configuration options for creating a Group.
    /// 
    /// See the
    /// [API reference](https://cloud.google.com/identity/docs/reference/rest/v1beta1/groups/create#initialgroupconfig)
    /// for possible values. Default value: &amp;quot;EMPTY&amp;quot; Possible values: [&amp;quot;INITIAL_GROUP_CONFIG_UNSPECIFIED&amp;quot;, &amp;quot;WITH_INITIAL_OWNER&amp;quot;, &amp;quot;EMPTY&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? InitialGroupConfig
    {
        get => GetProperty<TerraformProperty<string>>("initial_group_config");
        set => this.WithProperty("initial_group_config", value);
    }

    /// <summary>
    /// One or more label entries that apply to the Group. Currently supported labels contain a key with an empty value.
    /// 
    /// Google Groups are the default type of group and have a label with a key of cloudidentity.googleapis.com/groups.discussion_forum and an empty value.
    /// 
    /// Existing Google Groups can have an additional label with a key of cloudidentity.googleapis.com/groups.security and an empty value added to them. This is an immutable change and the security label cannot be removed once added.
    /// 
    /// Dynamic groups have a label with a key of cloudidentity.googleapis.com/groups.dynamic.
    /// 
    /// Identity-mapped groups for Cloud Search have a label with a key of system/groups/external and an empty value.
    /// </summary>
    public TerraformMapProperty<string>? Labels
    {
        get => GetProperty<TerraformMapProperty<string>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The resource name of the entity under which this Group resides in the
    /// Cloud Identity resource hierarchy.
    /// 
    /// Must be of the form identitysources/{identity_source_id} for external-identity-mapped
    /// groups or customers/{customer_id} for Google Groups.
    /// </summary>
    public TerraformProperty<string>? Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// Additional group keys associated with the Group
    /// </summary>
    public TerraformExpression AdditionalGroupKeys => this["additional_group_keys"];

    /// <summary>
    /// The time when the Group was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Resource name of the Group in the format: groups/{group_id}, where group_id
    /// is the unique ID assigned to the Group.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The time when the Group was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
