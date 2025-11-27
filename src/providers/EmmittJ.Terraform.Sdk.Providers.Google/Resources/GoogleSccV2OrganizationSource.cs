using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleSccV2OrganizationSource.
/// Nesting mode: single
/// </summary>
public class GoogleSccV2OrganizationSourceTimeoutsBlock : TerraformBlock
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
/// Represents a google_scc_v2_organization_source Terraform resource.
/// Manages a google_scc_v2_organization_source resource.
/// </summary>
public partial class GoogleSccV2OrganizationSource(string name) : TerraformResource("google_scc_v2_organization_source", name)
{
    /// <summary>
    /// The description of the source (max of 1024 characters).
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The source’s display name. A source’s display name must be unique
    /// amongst its siblings, for example, two sources with the same parent
    /// can&#39;t share the same display name. The display name must start and end
    /// with a letter or digit, may contain letters, digits, spaces, hyphens,
    /// and underscores, and can be no longer than 32 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
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
    /// The organization whose Cloud Security Command Center the Source
    /// lives in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Organization is required")]
    public required TerraformValue<string> Organization
    {
        get => new TerraformReference<string>(this, "organization");
        set => SetArgument("organization", value);
    }

    /// <summary>
    /// The resource name of this source, in the format
    /// &#39;organizations/{{organization}}/sources/{{source}}&#39;.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleSccV2OrganizationSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleSccV2OrganizationSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
