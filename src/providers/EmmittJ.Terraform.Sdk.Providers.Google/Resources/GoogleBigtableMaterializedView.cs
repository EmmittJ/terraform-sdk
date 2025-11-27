using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleBigtableMaterializedView.
/// Nesting mode: single
/// </summary>
public class GoogleBigtableMaterializedViewTimeoutsBlock : TerraformBlock
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
/// Represents a google_bigtable_materialized_view Terraform resource.
/// Manages a google_bigtable_materialized_view resource.
/// </summary>
public partial class GoogleBigtableMaterializedView(string name) : TerraformResource("google_bigtable_materialized_view", name)
{
    /// <summary>
    /// Set to true to make the MaterializedView protected against deletion.
    /// </summary>
    public TerraformValue<bool>? DeletionProtection
    {
        get => new TerraformReference<bool>(this, "deletion_protection");
        set => SetArgument("deletion_protection", value);
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
    /// The name of the instance to create the materialized view within.
    /// </summary>
    public TerraformValue<string>? Instance
    {
        get => new TerraformReference<string>(this, "instance");
        set => SetArgument("instance", value);
    }

    /// <summary>
    /// The unique name of the materialized view in the form &#39;[_a-zA-Z0-9][-_.a-zA-Z0-9]*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaterializedViewId is required")]
    public required TerraformValue<string> MaterializedViewId
    {
        get => new TerraformReference<string>(this, "materialized_view_id");
        set => SetArgument("materialized_view_id", value);
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
    /// The materialized view&#39;s select query.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Query is required")]
    public required TerraformValue<string> Query
    {
        get => new TerraformReference<string>(this, "query");
        set => SetArgument("query", value);
    }

    /// <summary>
    /// The unique name of the requested materialized view. Values are of the form &#39;projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/materializedViews/&amp;lt;materializedViewId&amp;gt;&#39;.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBigtableMaterializedViewTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBigtableMaterializedViewTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
