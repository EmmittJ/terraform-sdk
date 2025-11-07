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
    public TerraformLiteralProperty<bool>? DeletionProtection
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("deletion_protection");
        set => this.WithProperty("deletion_protection", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name of the instance to create the materialized view within.
    /// </summary>
    public TerraformLiteralProperty<string>? Instance
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance");
        set => this.WithProperty("instance", value);
    }

    /// <summary>
    /// The unique name of the materialized view in the form &#39;[_a-zA-Z0-9][-_.a-zA-Z0-9]*&#39;.
    /// </summary>
    public TerraformLiteralProperty<string>? MaterializedViewId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("materialized_view_id");
        set => this.WithProperty("materialized_view_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The materialized view&#39;s select query.
    /// </summary>
    public TerraformLiteralProperty<string>? Query
    {
        get => GetProperty<TerraformLiteralProperty<string>>("query");
        set => this.WithProperty("query", value);
    }

    /// <summary>
    /// The unique name of the requested materialized view. Values are of the form &#39;projects/&amp;lt;project&amp;gt;/instances/&amp;lt;instance&amp;gt;/materializedViews/&amp;lt;materializedViewId&amp;gt;&#39;.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
