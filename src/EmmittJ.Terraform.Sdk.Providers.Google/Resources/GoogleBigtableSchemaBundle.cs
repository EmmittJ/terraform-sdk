using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_bigtable_schema_bundle resource.
/// </summary>
public class GoogleBigtableSchemaBundle : TerraformResource
{
    public GoogleBigtableSchemaBundle(string name) : base("google_bigtable_schema_bundle", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// If true, allow backwards incompatible changes.
    /// </summary>
    public bool? IgnoreWarnings
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ignore_warnings")?.Value;
        set => this.WithProperty("ignore_warnings", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The name of the instance to create the schema bundle within.
    /// </summary>
    public string? Instance
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance")?.Value;
        set => this.WithProperty("instance", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The unique name of the schema bundle in the form &#39;[_a-zA-Z0-9][-_.a-zA-Z0-9]*&#39;.
    /// </summary>
    public string? SchemaBundleId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("schema_bundle_id")?.Value;
        set => this.WithProperty("schema_bundle_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the table to create the schema bundle within.
    /// </summary>
    public string? Table
    {
        get => GetProperty<TerraformLiteralProperty<string>>("table")?.Value;
        set => this.WithProperty("table", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The unique name of the requested schema bundle. Values are of the form &#39;projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;/schemaBundles/&amp;lt;schemaBundleId&amp;gt;&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
