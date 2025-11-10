using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for proto_schema in .
/// Nesting mode: list
/// </summary>
public class GoogleBigtableSchemaBundleProtoSchemaBlock : TerraformBlock
{
    /// <summary>
    /// Base64 encoded content of the file.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtoDescriptors is required")]
    public required TerraformProperty<string> ProtoDescriptors
    {
        set => SetProperty("proto_descriptors", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigtableSchemaBundleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_bigtable_schema_bundle resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBigtableSchemaBundle : TerraformResource
{
    public GoogleBigtableSchemaBundle(string name) : base("google_bigtable_schema_bundle", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("name");
        SetOutput("id");
        SetOutput("ignore_warnings");
        SetOutput("instance");
        SetOutput("project");
        SetOutput("schema_bundle_id");
        SetOutput("table");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// If true, allow backwards incompatible changes.
    /// </summary>
    public TerraformProperty<bool> IgnoreWarnings
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ignore_warnings");
        set => SetProperty("ignore_warnings", value);
    }

    /// <summary>
    /// The name of the instance to create the schema bundle within.
    /// </summary>
    public TerraformProperty<string> Instance
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance");
        set => SetProperty("instance", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The unique name of the schema bundle in the form &#39;[_a-zA-Z0-9][-_.a-zA-Z0-9]*&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaBundleId is required")]
    public required TerraformProperty<string> SchemaBundleId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("schema_bundle_id");
        set => SetProperty("schema_bundle_id", value);
    }

    /// <summary>
    /// The name of the table to create the schema bundle within.
    /// </summary>
    public TerraformProperty<string> Table
    {
        get => GetRequiredOutput<TerraformProperty<string>>("table");
        set => SetProperty("table", value);
    }

    /// <summary>
    /// Block for proto_schema.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtoSchema is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ProtoSchema block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProtoSchema block(s) allowed")]
    public List<GoogleBigtableSchemaBundleProtoSchemaBlock>? ProtoSchema
    {
        set => SetProperty("proto_schema", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBigtableSchemaBundleTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The unique name of the requested schema bundle. Values are of the form &#39;projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;/schemaBundles/&amp;lt;schemaBundleId&amp;gt;&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
