using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for attributes in GoogleApigeeAppGroup.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeAppGroupAttributesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "attributes";

    /// <summary>
    /// Key of the attribute
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Value of the attribute
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleApigeeAppGroup.
/// Nesting mode: single
/// </summary>
public class GoogleApigeeAppGroupTimeoutsBlock : TerraformBlock
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
/// Represents a google_apigee_app_group Terraform resource.
/// Manages a google_apigee_app_group resource.
/// </summary>
public partial class GoogleApigeeAppGroup(string name) : TerraformResource("google_apigee_app_group", name)
{
    /// <summary>
    /// Channel identifier identifies the owner maintaining this grouping.
    /// </summary>
    public TerraformValue<string>? ChannelId
    {
        get => new TerraformReference<string>(this, "channel_id");
        set => SetArgument("channel_id", value);
    }

    /// <summary>
    /// A reference to the associated storefront/marketplace.
    /// </summary>
    public TerraformValue<string>? ChannelUri
    {
        get => new TerraformReference<string>(this, "channel_uri");
        set => SetArgument("channel_uri", value);
    }

    /// <summary>
    /// App group name displayed in the UI
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
    /// Name of the AppGroup. Characters you can use in the name are restricted to: A-Z0-9._-$ %.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The Apigee Organization associated with the Apigee app group,
    /// in the format &#39;organizations/{{org_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformValue<string> OrgId
    {
        get => new TerraformReference<string>(this, "org_id");
        set => SetArgument("org_id", value);
    }

    /// <summary>
    /// Valid values are active or inactive. Note that the status of the AppGroup should be updated via UpdateAppGroupRequest by setting the action as active or inactive. Possible values: [&amp;quot;active&amp;quot;, &amp;quot;inactive&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// Internal identifier that cannot be edited
    /// </summary>
    public TerraformValue<string> AppGroupId
    {
        get => new TerraformReference<string>(this, "app_group_id");
    }

    /// <summary>
    /// Created time as milliseconds since epoch.
    /// </summary>
    public TerraformValue<string> CreatedAt
    {
        get => new TerraformReference<string>(this, "created_at");
    }

    /// <summary>
    /// Modified time as milliseconds since epoch.
    /// </summary>
    public TerraformValue<string> LastModifiedAt
    {
        get => new TerraformReference<string>(this, "last_modified_at");
    }

    /// <summary>
    /// App group name displayed in the UI
    /// </summary>
    public TerraformValue<string> Organization
    {
        get => new TerraformReference<string>(this, "organization");
    }

    /// <summary>
    /// Attributes block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleApigeeAppGroupAttributesBlock>? Attributes
    {
        get => GetArgument<TerraformList<GoogleApigeeAppGroupAttributesBlock>>("attributes");
        set => SetArgument("attributes", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApigeeAppGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApigeeAppGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
