using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleBiglakeCatalog.
/// Nesting mode: single
/// </summary>
public class GoogleBiglakeCatalogTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a google_biglake_catalog Terraform resource.
/// Manages a google_biglake_catalog resource.
/// </summary>
public partial class GoogleBiglakeCatalog(string name) : TerraformResource("google_biglake_catalog", name)
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
    /// The geographic location where the Catalog should reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name of the Catalog. Format:
    /// projects/{project_id_or_number}/locations/{locationId}/catalogs/{catalogId}
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
    /// Output only. The creation time of the catalog. A timestamp in RFC3339 UTC
    /// &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional
    /// digits.
    /// </summary>
    public TerraformValue<string> CreateTime
    {
        get => new TerraformReference<string>(this, "create_time");
    }

    /// <summary>
    /// Output only. The deletion time of the catalog. Only set after the catalog
    /// is deleted. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond
    /// resolution and up to nine fractional digits.
    /// </summary>
    public TerraformValue<string> DeleteTime
    {
        get => new TerraformReference<string>(this, "delete_time");
    }

    /// <summary>
    /// Output only. The time when this catalog is considered expired. Only set
    /// after the catalog is deleted. Only set after the catalog is deleted.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and
    /// up to nine fractional digits.
    /// </summary>
    public TerraformValue<string> ExpireTime
    {
        get => new TerraformReference<string>(this, "expire_time");
    }

    /// <summary>
    /// Output only. The last modification time of the catalog. A timestamp in
    /// RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine
    /// fractional digits.
    /// </summary>
    public TerraformValue<string> UpdateTime
    {
        get => new TerraformReference<string>(this, "update_time");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBiglakeCatalogTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBiglakeCatalogTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
