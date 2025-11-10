using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for aws in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryConnectionAwsBlock : TerraformBlock
{
}

/// <summary>
/// Block type for azure in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryConnectionAzureBlock : TerraformBlock
{
    /// <summary>
    /// The name of the Azure Active Directory Application.
    /// </summary>
    public TerraformProperty<string>? Application
    {
        get => GetProperty<TerraformProperty<string>>("application");
        set => WithProperty("application", value);
    }

    /// <summary>
    /// The client id of the Azure Active Directory Application.
    /// </summary>
    public TerraformProperty<string>? ClientId
    {
        get => GetProperty<TerraformProperty<string>>("client_id");
        set => WithProperty("client_id", value);
    }

    /// <summary>
    /// The id of customer&#39;s directory that host the data.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomerTenantId is required")]
    public required TerraformProperty<string> CustomerTenantId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("customer_tenant_id");
        set => WithProperty("customer_tenant_id", value);
    }

    /// <summary>
    /// The Azure Application (client) ID where the federated credentials will be hosted.
    /// </summary>
    public TerraformProperty<string>? FederatedApplicationClientId
    {
        get => GetProperty<TerraformProperty<string>>("federated_application_client_id");
        set => WithProperty("federated_application_client_id", value);
    }

    /// <summary>
    /// A unique Google-owned and Google-generated identity for the Connection. This identity will be used to access the user&#39;s Azure Active Directory Application.
    /// </summary>
    public TerraformProperty<string>? Identity
    {
        get => GetProperty<TerraformProperty<string>>("identity");
        set => WithProperty("identity", value);
    }

    /// <summary>
    /// The object id of the Azure Active Directory Application.
    /// </summary>
    public TerraformProperty<string>? ObjectId
    {
        get => GetProperty<TerraformProperty<string>>("object_id");
        set => WithProperty("object_id", value);
    }

    /// <summary>
    /// The URL user will be redirected to after granting consent during connection setup.
    /// </summary>
    public TerraformProperty<string>? RedirectUri
    {
        get => GetProperty<TerraformProperty<string>>("redirect_uri");
        set => WithProperty("redirect_uri", value);
    }

}

/// <summary>
/// Block type for cloud_resource in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryConnectionCloudResourceBlock : TerraformBlock
{
    /// <summary>
    /// The account ID of the service created for the purpose of this connection.
    /// </summary>
    public TerraformProperty<string>? ServiceAccountId
    {
        get => GetProperty<TerraformProperty<string>>("service_account_id");
        set => WithProperty("service_account_id", value);
    }

}

/// <summary>
/// Block type for cloud_spanner in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryConnectionCloudSpannerBlock : TerraformBlock
{
    /// <summary>
    /// Cloud Spanner database in the form &#39;project/instance/database&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformProperty<string> Database
    {
        get => GetRequiredProperty<TerraformProperty<string>>("database");
        set => WithProperty("database", value);
    }

    /// <summary>
    /// Cloud Spanner database role for fine-grained access control. The Cloud Spanner admin should have provisioned the database role with appropriate permissions, such as &#39;SELECT&#39; and &#39;INSERT&#39;. Other users should only use roles provided by their Cloud Spanner admins. The database role name must start with a letter, and can only contain letters, numbers, and underscores. For more details, see https://cloud.google.com/spanner/docs/fgac-about.
    /// </summary>
    public TerraformProperty<string>? DatabaseRole
    {
        get => GetProperty<TerraformProperty<string>>("database_role");
        set => WithProperty("database_role", value);
    }

    /// <summary>
    /// Allows setting max parallelism per query when executing on Spanner independent compute resources. If unspecified, default values of parallelism are chosen that are dependent on the Cloud Spanner instance configuration. &#39;useParallelism&#39; and &#39;useDataBoost&#39; must be set when setting max parallelism.
    /// </summary>
    public TerraformProperty<double>? MaxParallelism
    {
        get => GetProperty<TerraformProperty<double>>("max_parallelism");
        set => WithProperty("max_parallelism", value);
    }

    /// <summary>
    /// If set, the request will be executed via Spanner independent compute resources. &#39;use_parallelism&#39; must be set when using data boost.
    /// </summary>
    public TerraformProperty<bool>? UseDataBoost
    {
        get => GetProperty<TerraformProperty<bool>>("use_data_boost");
        set => WithProperty("use_data_boost", value);
    }

    /// <summary>
    /// If parallelism should be used when reading from Cloud Spanner.
    /// </summary>
    public TerraformProperty<bool>? UseParallelism
    {
        get => GetProperty<TerraformProperty<bool>>("use_parallelism");
        set => WithProperty("use_parallelism", value);
    }

    /// <summary>
    /// If the serverless analytics service should be used to read data from Cloud Spanner. &#39;useParallelism&#39; must be set when using serverless analytics.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool>? UseServerlessAnalytics
    {
        get => GetProperty<TerraformProperty<bool>>("use_serverless_analytics");
        set => WithProperty("use_serverless_analytics", value);
    }

}

/// <summary>
/// Block type for cloud_sql in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryConnectionCloudSqlBlock : TerraformBlock
{
    /// <summary>
    /// Database name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformProperty<string> Database
    {
        get => GetRequiredProperty<TerraformProperty<string>>("database");
        set => WithProperty("database", value);
    }

    /// <summary>
    /// Cloud SQL instance ID in the form project:location:instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformProperty<string> InstanceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("instance_id");
        set => WithProperty("instance_id", value);
    }

    /// <summary>
    /// When the connection is used in the context of an operation in BigQuery, this service account will serve as the identity being used for connecting to the CloudSQL instance specified in this connection.
    /// </summary>
    public TerraformProperty<string>? ServiceAccountId
    {
        get => GetProperty<TerraformProperty<string>>("service_account_id");
        set => WithProperty("service_account_id", value);
    }

    /// <summary>
    /// Type of the Cloud SQL database. Possible values: [&amp;quot;DATABASE_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;POSTGRES&amp;quot;, &amp;quot;MYSQL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for spark in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryConnectionSparkBlock : TerraformBlock
{
    /// <summary>
    /// The account ID of the service created for the purpose of this connection.
    /// </summary>
    public TerraformProperty<string>? ServiceAccountId
    {
        get => GetProperty<TerraformProperty<string>>("service_account_id");
        set => WithProperty("service_account_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryConnectionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_bigquery_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    /// Block for aws.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Aws block(s) allowed")]
    public List<GoogleBigqueryConnectionAwsBlock>? Aws
    {
        get => GetProperty<List<GoogleBigqueryConnectionAwsBlock>>("aws");
        set => this.WithProperty("aws", value);
    }

    /// <summary>
    /// Block for azure.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Azure block(s) allowed")]
    public List<GoogleBigqueryConnectionAzureBlock>? Azure
    {
        get => GetProperty<List<GoogleBigqueryConnectionAzureBlock>>("azure");
        set => this.WithProperty("azure", value);
    }

    /// <summary>
    /// Block for cloud_resource.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudResource block(s) allowed")]
    public List<GoogleBigqueryConnectionCloudResourceBlock>? CloudResource
    {
        get => GetProperty<List<GoogleBigqueryConnectionCloudResourceBlock>>("cloud_resource");
        set => this.WithProperty("cloud_resource", value);
    }

    /// <summary>
    /// Block for cloud_spanner.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudSpanner block(s) allowed")]
    public List<GoogleBigqueryConnectionCloudSpannerBlock>? CloudSpanner
    {
        get => GetProperty<List<GoogleBigqueryConnectionCloudSpannerBlock>>("cloud_spanner");
        set => this.WithProperty("cloud_spanner", value);
    }

    /// <summary>
    /// Block for cloud_sql.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudSql block(s) allowed")]
    public List<GoogleBigqueryConnectionCloudSqlBlock>? CloudSql
    {
        get => GetProperty<List<GoogleBigqueryConnectionCloudSqlBlock>>("cloud_sql");
        set => this.WithProperty("cloud_sql", value);
    }

    /// <summary>
    /// Block for spark.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spark block(s) allowed")]
    public List<GoogleBigqueryConnectionSparkBlock>? Spark
    {
        get => GetProperty<List<GoogleBigqueryConnectionSparkBlock>>("spark");
        set => this.WithProperty("spark", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBigqueryConnectionTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleBigqueryConnectionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
