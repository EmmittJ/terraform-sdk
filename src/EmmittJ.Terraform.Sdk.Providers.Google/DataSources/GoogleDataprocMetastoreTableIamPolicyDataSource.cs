using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_dataproc_metastore_table_iam_policy.
/// </summary>
public class GoogleDataprocMetastoreTableIamPolicyDataSource : TerraformDataSource
{
    public GoogleDataprocMetastoreTableIamPolicyDataSource(string name) : base("google_dataproc_metastore_table_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
        this.DeclareOutput("policy_data");
    }

    /// <summary>
    /// The database_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseId is required")]
    public required TerraformProperty<string> DatabaseId
    {
        get => GetProperty<TerraformProperty<string>>("database_id");
        set => this.WithProperty("database_id", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceId is required")]
    public required TerraformProperty<string> ServiceId
    {
        get => GetProperty<TerraformProperty<string>>("service_id");
        set => this.WithProperty("service_id", value);
    }

    /// <summary>
    /// The table attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    public required TerraformProperty<string> Table
    {
        get => GetProperty<TerraformProperty<string>>("table");
        set => this.WithProperty("table", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformExpression PolicyData => this["policy_data"];

}
