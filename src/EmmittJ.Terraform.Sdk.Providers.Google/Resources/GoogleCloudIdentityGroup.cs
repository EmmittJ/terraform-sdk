using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for group_key in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudIdentityGroupGroupKeyBlock : TerraformBlock
{
    /// <summary>
    /// The ID of the entity.
    /// 
    /// For Google-managed entities, the id must be the email address of an existing
    /// group or user.
    /// 
    /// For external-identity-mapped entities, the id must be a string conforming
    /// to the Identity Source&#39;s requirements.
    /// 
    /// Must be unique within a namespace.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The namespace in which the entity exists.
    /// 
    /// If not specified, the EntityKey represents a Google-managed entity
    /// such as a Google user or a Google Group.
    /// 
    /// If specified, the EntityKey represents an external-identity-mapped group.
    /// The namespace must correspond to an identity source created in Admin Console
    /// and must be in the form of &#39;identitysources/{identity_source_id}&#39;.
    /// </summary>
    public TerraformProperty<string>? Namespace
    {
        get => GetProperty<TerraformProperty<string>>("namespace");
        set => WithProperty("namespace", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCloudIdentityGroupTimeoutsBlock : TerraformBlock
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
/// Manages a google_cloud_identity_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Labels is required")]
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => this.WithProperty("labels", value);
    }

    /// <summary>
    /// The resource name of the entity under which this Group resides in the
    /// Cloud Identity resource hierarchy.
    /// 
    /// Must be of the form identitysources/{identity_source_id} for external-identity-mapped
    /// groups or customers/{customer_id} for Google Groups.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// Block for group_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GroupKey block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GroupKey block(s) allowed")]
    public List<GoogleCloudIdentityGroupGroupKeyBlock>? GroupKey
    {
        get => GetProperty<List<GoogleCloudIdentityGroupGroupKeyBlock>>("group_key");
        set => this.WithProperty("group_key", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleCloudIdentityGroupTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleCloudIdentityGroupTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
