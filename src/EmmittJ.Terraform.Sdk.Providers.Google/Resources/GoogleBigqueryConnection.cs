using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_bigquery_connection resource.
/// </summary>
public class GoogleBigqueryConnection : TerraformResource
{
    public GoogleBigqueryConnection(string name) : base("google_bigquery_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("has_credential");
        this.DeclareOutput("name");
    }

    /// <summary>
    /// Optional connection id that should be assigned to the created connection.
    /// </summary>
    public TerraformProperty<string>? ConnectionId
    {
        get => GetProperty<TerraformProperty<string>>("connection_id");
        set => this.WithProperty("connection_id", value);
    }

    /// <summary>
    /// A descriptive description for the connection
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// A descriptive name for the connection
    /// </summary>
    public TerraformProperty<string>? FriendlyName
    {
        get => GetProperty<TerraformProperty<string>>("friendly_name");
        set => this.WithProperty("friendly_name", value);
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
    /// Optional. The Cloud KMS key that is used for encryption.
    /// 
    /// Example: projects/[kms_project_id]/locations/[region]/keyRings/[key_region]/cryptoKeys/[key]
    /// </summary>
    public TerraformProperty<string>? KmsKeyName
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_name");
        set => this.WithProperty("kms_key_name", value);
    }

    /// <summary>
    /// The geographic location where the connection should reside.
    /// Cloud SQL instance must be in the same location as the connection
    /// with following exceptions: Cloud SQL us-central1 maps to BigQuery US, Cloud SQL europe-west1 maps to BigQuery EU.
    /// Examples: US, EU, asia-northeast1, us-central1, europe-west1.
    /// Spanner Connections same as spanner region
    /// AWS allowed regions are aws-us-east-1
    /// Azure allowed regions are azure-eastus2
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
    /// True if the connection has credential assigned.
    /// </summary>
    public TerraformExpression HasCredential => this["has_credential"];

    /// <summary>
    /// The resource name of the connection in the form of:
    /// &amp;quot;projects/{project_id}/locations/{location_id}/connections/{connectionId}&amp;quot;
    /// </summary>
    public TerraformExpression Name => this["name"];

}
