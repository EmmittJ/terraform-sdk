using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for group_key in GoogleCloudIdentityGroup.
/// Nesting mode: list
/// </summary>
public class GoogleCloudIdentityGroupGroupKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "group_key";

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
    public required TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    public TerraformValue<string>? NamespaceAttribute
    {
        get => new TerraformReference<string>(this, "namespace");
        set => SetArgument("namespace", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleCloudIdentityGroup.
/// Nesting mode: single
/// </summary>
public class GoogleCloudIdentityGroupTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_cloud_identity_group Terraform resource.
/// Manages a google_cloud_identity_group resource.
/// </summary>
public partial class GoogleCloudIdentityGroup(string name) : TerraformResource("google_cloud_identity_group", name)
{
    /// <summary>
    /// An extended description to help users determine the purpose of a Group.
    /// Must not be longer than 4,096 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display name of the Group.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The initial configuration options for creating a Group.
    /// 
    /// See the
    /// [API reference](https://cloud.google.com/identity/docs/reference/rest/v1beta1/groups/create#initialgroupconfig)
    /// for possible values. Default value: &amp;quot;EMPTY&amp;quot; Possible values: [&amp;quot;INITIAL_GROUP_CONFIG_UNSPECIFIED&amp;quot;, &amp;quot;WITH_INITIAL_OWNER&amp;quot;, &amp;quot;EMPTY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? InitialGroupConfig
    {
        get => new TerraformReference<string>(this, "initial_group_config");
        set => SetArgument("initial_group_config", value);
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
    public required TerraformMap<string> Labels
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "labels").ResolveNodes(ctx));
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The resource name of the entity under which this Group resides in the
    /// Cloud Identity resource hierarchy.
    /// 
    /// Must be of the form identitysources/{identity_source_id} for external-identity-mapped
    /// groups or customers/{customer_id} for Google Groups.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => new TerraformReference<string>(this, "parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// Additional group keys associated with the Group
    /// </summary>
    public TerraformList<TerraformMap<object>> AdditionalGroupKeys
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "additional_group_keys").ResolveNodes(ctx));
    }

    /// <summary>
    /// The time when the Group was created.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Resource name of the Group in the format: groups/{group_id}, where group_id
    /// is the unique ID assigned to the Group.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The time when the Group was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// GroupKey block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupKey is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GroupKey block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GroupKey block(s) allowed")]
    public required TerraformList<GoogleCloudIdentityGroupGroupKeyBlock> GroupKey
    {
        get => GetRequiredArgument<TerraformList<GoogleCloudIdentityGroupGroupKeyBlock>>("group_key");
        set => SetArgument("group_key", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleCloudIdentityGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleCloudIdentityGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
