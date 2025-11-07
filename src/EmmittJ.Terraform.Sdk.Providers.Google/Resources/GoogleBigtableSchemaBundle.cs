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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// If true, allow backwards incompatible changes.
    /// </summary>
    public TerraformProperty<bool>? IgnoreWarnings
    {
        get => GetProperty<TerraformProperty<bool>>("ignore_warnings");
        set => this.WithProperty("ignore_warnings", value);
    }

    /// <summary>
    /// The name of the instance to create the schema bundle within.
    /// </summary>
    public TerraformProperty<string>? Instance
    {
        get => GetProperty<TerraformProperty<string>>("instance");
        set => this.WithProperty("instance", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The unique name of the schema bundle in the form &#39;[_a-zA-Z0-9][-_.a-zA-Z0-9]*&#39;.
    /// </summary>
    public TerraformProperty<string>? SchemaBundleId
    {
        get => GetProperty<TerraformProperty<string>>("schema_bundle_id");
        set => this.WithProperty("schema_bundle_id", value);
    }

    /// <summary>
    /// The name of the table to create the schema bundle within.
    /// </summary>
    public TerraformProperty<string>? Table
    {
        get => GetProperty<TerraformProperty<string>>("table");
        set => this.WithProperty("table", value);
    }

    /// <summary>
    /// The unique name of the requested schema bundle. Values are of the form &#39;projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/tables/&amp;lt;table&amp;gt;/schemaBundles/&amp;lt;schemaBundleId&amp;gt;&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
