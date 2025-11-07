using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_logging_log_scope resource.
/// </summary>
public class GoogleLoggingLogScope : TerraformResource
{
    public GoogleLoggingLogScope(string name) : base("google_logging_log_scope", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// Describes this log scopes.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The location of the resource. The only supported location is global so far.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The resource name of the log scope. For example: \&#39;projects/my-project/locations/global/logScopes/my-log-scope\&#39;
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parent of the resource.
    /// </summary>
    public TerraformProperty<string>? Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// Names of one or more parent resources : *  \&#39;projects/[PROJECT_ID]\&#39; May alternatively be one or more views : * \&#39;projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]\&#39; A log scope can include a maximum of 50 projects and a maximum of 100 resources in total.
    /// </summary>
    public TerraformProperty<List<string>>? ResourceNames
    {
        get => GetProperty<TerraformProperty<List<string>>>("resource_names");
        set => this.WithProperty("resource_names", value);
    }

    /// <summary>
    /// Output only. The creation timestamp of the log scopes.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Output only. The last update timestamp of the log scopes.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
