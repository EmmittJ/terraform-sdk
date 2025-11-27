using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for proto_schema in GoogleBigtableSchemaBundle.
/// Nesting mode: list
/// </summary>
public class GoogleBigtableSchemaBundleProtoSchemaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "proto_schema";

    /// <summary>
    /// Base64 encoded content of the file.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtoDescriptors is required")]
    public required TerraformValue<string> ProtoDescriptors
    {
        get => new TerraformReference<string>(this, "proto_descriptors");
        set => SetArgument("proto_descriptors", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleBigtableSchemaBundle.
/// Nesting mode: single
/// </summary>
public class GoogleBigtableSchemaBundleTimeoutsBlock : TerraformBlock
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
/// Represents a google_bigtable_schema_bundle Terraform resource.
/// Manages a google_bigtable_schema_bundle resource.
/// </summary>
public partial class GoogleBigtableSchemaBundle(string name) : TerraformResource("google_bigtable_schema_bundle", name)
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
    /// If true, allow backwards incompatible changes.
    /// </summary>
    public TerraformValue<bool>? IgnoreWarnings
    {
        get => new TerraformReference<bool>(this, "ignore_warnings");
        set => SetArgument("ignore_warnings", value);
    }

    /// <summary>
    /// The name of the instance to create the schema bundle within.
    /// </summary>
    public TerraformValue<string>? Instance
    {
        get => new TerraformReference<string>(this, "instance");
        set => SetArgument("instance", value);
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
    /// The unique name of the schema bundle in the form &#39;[_a-zA-Z0-9][-_.a-zA-Z0-9]*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaBundleId is required")]
    public required TerraformValue<string> SchemaBundleId
    {
        get => new TerraformReference<string>(this, "schema_bundle_id");
        set => SetArgument("schema_bundle_id", value);
    }

    /// <summary>
    /// The name of the table to create the schema bundle within.
    /// </summary>
    public TerraformValue<string>? Table
    {
        get => new TerraformReference<string>(this, "table");
        set => SetArgument("table", value);
    }

    /// <summary>
    /// The unique name of the requested schema bundle. Values are of the form &#39;projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;/schemaBundles/&amp;lt;schemaBundleId&amp;gt;&#39;.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// ProtoSchema block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtoSchema is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ProtoSchema block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProtoSchema block(s) allowed")]
    public required TerraformList<GoogleBigtableSchemaBundleProtoSchemaBlock> ProtoSchema
    {
        get => GetRequiredArgument<TerraformList<GoogleBigtableSchemaBundleProtoSchemaBlock>>("proto_schema");
        set => SetArgument("proto_schema", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBigtableSchemaBundleTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBigtableSchemaBundleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
