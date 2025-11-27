using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleNetworkSecurityUrlLists.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkSecurityUrlListsTimeoutsBlock : TerraformBlock
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
/// Represents a google_network_security_url_lists Terraform resource.
/// Manages a google_network_security_url_lists resource.
/// </summary>
public partial class GoogleNetworkSecurityUrlLists(string name) : TerraformResource("google_network_security_url_lists", name)
{
    /// <summary>
    /// Free-text description of the resource.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The location of the url lists.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Short name of the UrlList resource to be created.
    /// This value should be 1-63 characters long, containing only letters, numbers, hyphens, and underscores, and should not start with a number. E.g. &#39;urlList&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// FQDNs and URLs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public TerraformList<string>? ValuesAttribute
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "values").ResolveNodes(ctx));
        set => SetArgument("values", value);
    }

    /// <summary>
    /// Output only. Time when the security policy was created.
    /// A timestamp in RFC3339 UTC &#39;Zulu&#39; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &#39;2014-10-02T15:01:23Z&#39; and &#39;2014-10-02T15:01:23.045123456Z&#39;
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Output only. Time when the security policy was updated.
    /// A timestamp in RFC3339 UTC &#39;Zulu&#39; format, with nanosecond resolution and up to nine fractional digits.
    /// Examples: &#39;2014-10-02T15:01:23Z&#39; and &#39;2014-10-02T15:01:23.045123456Z&#39;.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetworkSecurityUrlListsTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkSecurityUrlListsTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
