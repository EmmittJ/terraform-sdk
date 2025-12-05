using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleDataCatalogEntryGroup.
/// Nesting mode: single
/// </summary>
public class GoogleDataCatalogEntryGroupTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_data_catalog_entry_group Terraform resource.
/// Manages a google_data_catalog_entry_group resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class GoogleDataCatalogEntryGroup(string name) : TerraformResource("google_data_catalog_entry_group", name)
{
    /// <summary>
    /// Entry group description, which can consist of several sentences or paragraphs that describe entry group contents.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// A short name to identify the entry group, for example, &amp;quot;analytics data - jan 2011&amp;quot;.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id of the entry group to create. The id must begin with a letter or underscore,
    /// contain only English letters, numbers and underscores, and be at most 64 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntryGroupId is required")]
    public required TerraformValue<string> EntryGroupId
    {
        get => GetRequiredArgument<TerraformValue<string>>("entry_group_id");
        set => SetArgument("entry_group_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// EntryGroup location region.
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resource name of the entry group in URL format. Example: projects/{project}/locations/{location}/entryGroups/{entryGroupId}
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDataCatalogEntryGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDataCatalogEntryGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
