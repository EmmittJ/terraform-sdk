using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_dataproc_metastore_table_iam_binding resource.
/// </summary>
public class GoogleDataprocMetastoreTableIamBinding : TerraformResource
{
    public GoogleDataprocMetastoreTableIamBinding(string name) : base("google_dataproc_metastore_table_iam_binding", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
    }

    /// <summary>
    /// The database_id attribute.
    /// </summary>
    public string? DatabaseId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_id")?.Value;
        set => this.WithProperty("database_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The members attribute.
    /// </summary>
    public HashSet<string>? Members
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("members")?.Value;
        set => this.WithProperty("members", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The role attribute.
    /// </summary>
    public string? Role
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role")?.Value;
        set => this.WithProperty("role", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_id attribute.
    /// </summary>
    public string? ServiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_id")?.Value;
        set => this.WithProperty("service_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The table attribute.
    /// </summary>
    public string? Table
    {
        get => GetProperty<TerraformLiteralProperty<string>>("table")?.Value;
        set => this.WithProperty("table", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

}
