using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_bigtable_materialized_view resource.
/// </summary>
public class GoogleBigtableMaterializedView : TerraformResource
{
    public GoogleBigtableMaterializedView(string name) : base("google_bigtable_materialized_view", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// Set to true to make the MaterializedView protected against deletion.
    /// </summary>
    public bool? DeletionProtection
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("deletion_protection")?.Value;
        set => this.WithProperty("deletion_protection", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The name of the instance to create the materialized view within.
    /// </summary>
    public string? Instance
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance")?.Value;
        set => this.WithProperty("instance", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The unique name of the materialized view in the form &#39;[_a-zA-Z0-9][-_.a-zA-Z0-9]*&#39;.
    /// </summary>
    public string? MaterializedViewId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("materialized_view_id")?.Value;
        set => this.WithProperty("materialized_view_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The materialized view&#39;s select query.
    /// </summary>
    public string? Query
    {
        get => GetProperty<TerraformLiteralProperty<string>>("query")?.Value;
        set => this.WithProperty("query", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The unique name of the requested materialized view. Values are of the form &#39;projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/materializedViews/&amp;lt;materializedViewId&amp;gt;&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
