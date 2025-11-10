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
        set => SetProperty("application", value);
    }

    /// <summary>
    /// The client id of the Azure Active Directory Application.
    /// </summary>
    public TerraformProperty<string>? ClientId
    {
        set => SetProperty("client_id", value);
    }

    /// <summary>
    /// The id of customer&#39;s directory that host the data.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomerTenantId is required")]
    public required TerraformProperty<string> CustomerTenantId
    {
        set => SetProperty("customer_tenant_id", value);
    }

    /// <summary>
    /// The Azure Application (client) ID where the federated credentials will be hosted.
    /// </summary>
    public TerraformProperty<string>? FederatedApplicationClientId
    {
        set => SetProperty("federated_application_client_id", value);
    }

    /// <summary>
    /// A unique Google-owned and Google-generated identity for the Connection. This identity will be used to access the user&#39;s Azure Active Directory Application.
    /// </summary>
    public TerraformProperty<string>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// The object id of the Azure Active Directory Application.
    /// </summary>
    public TerraformProperty<string>? ObjectId
    {
        set => SetProperty("object_id", value);
    }

    /// <summary>
    /// The URL user will be redirected to after granting consent during connection setup.
    /// </summary>
    public TerraformProperty<string>? RedirectUri
    {
        set => SetProperty("redirect_uri", value);
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
        set => SetProperty("service_account_id", value);
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
        set => SetProperty("database", value);
    }

    /// <summary>
    /// Cloud Spanner database role for fine-grained access control. The Cloud Spanner admin should have provisioned the database role with appropriate permissions, such as &#39;SELECT&#39; and &#39;INSERT&#39;. Other users should only use roles provided by their Cloud Spanner admins. The database role name must start with a letter, and can only contain letters, numbers, and underscores. For more details, see https://cloud.google.com/spanner/docs/fgac-about.
    /// </summary>
    public TerraformProperty<string>? DatabaseRole
    {
        set => SetProperty("database_role", value);
    }

    /// <summary>
    /// Allows setting max parallelism per query when executing on Spanner independent compute resources. If unspecified, default values of parallelism are chosen that are dependent on the Cloud Spanner instance configuration. &#39;useParallelism&#39; and &#39;useDataBoost&#39; must be set when setting max parallelism.
    /// </summary>
    public TerraformProperty<double>? MaxParallelism
    {
        set => SetProperty("max_parallelism", value);
    }

    /// <summary>
    /// If set, the request will be executed via Spanner independent compute resources. &#39;use_parallelism&#39; must be set when using data boost.
    /// </summary>
    public TerraformProperty<bool>? UseDataBoost
    {
        set => SetProperty("use_data_boost", value);
    }

    /// <summary>
    /// If parallelism should be used when reading from Cloud Spanner.
    /// </summary>
    public TerraformProperty<bool>? UseParallelism
    {
        set => SetProperty("use_parallelism", value);
    }

    /// <summary>
    /// If the serverless analytics service should be used to read data from Cloud Spanner. &#39;useParallelism&#39; must be set when using serverless analytics.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool>? UseServerlessAnalytics
    {
        set => SetProperty("use_serverless_analytics", value);
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
        set => SetProperty("database", value);
    }

    /// <summary>
    /// Cloud SQL instance ID in the form project:location:instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformProperty<string> InstanceId
    {
        set => SetProperty("instance_id", value);
    }

    /// <summary>
    /// When the connection is used in the context of an operation in BigQuery, this service account will serve as the identity being used for connecting to the CloudSQL instance specified in this connection.
    /// </summary>
    public TerraformProperty<string>? ServiceAccountId
    {
        set => SetProperty("service_account_id", value);
    }

    /// <summary>
    /// Type of the Cloud SQL database. Possible values: [&amp;quot;DATABASE_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;POSTGRES&amp;quot;, &amp;quot;MYSQL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("service_account_id", value);
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
        SetOutput("has_credential");
        SetOutput("name");
        SetOutput("connection_id");
        SetOutput("description");
        SetOutput("friendly_name");
        SetOutput("id");
        SetOutput("kms_key_name");
        SetOutput("location");
        SetOutput("project");
    }

    /// <summary>
    /// Optional connection id that should be assigned to the created connection.
    /// </summary>
    public TerraformProperty<string> ConnectionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connection_id");
        set => SetProperty("connection_id", value);
    }

    /// <summary>
    /// A descriptive description for the connection
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// A descriptive name for the connection
    /// </summary>
    public TerraformProperty<string> FriendlyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("friendly_name");
        set => SetProperty("friendly_name", value);
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
    /// Optional. The Cloud KMS key that is used for encryption.
    /// 
    /// Example: projects/[kms_project_id]/locations/[region]/keyRings/[key_region]/cryptoKeys/[key]
    /// </summary>
    public TerraformProperty<string> KmsKeyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("kms_key_name");
        set => SetProperty("kms_key_name", value);
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
    public TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// Block for aws.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Aws block(s) allowed")]
    public List<GoogleBigqueryConnectionAwsBlock>? Aws
    {
        set => SetProperty("aws", value);
    }

    /// <summary>
    /// Block for azure.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Azure block(s) allowed")]
    public List<GoogleBigqueryConnectionAzureBlock>? Azure
    {
        set => SetProperty("azure", value);
    }

    /// <summary>
    /// Block for cloud_resource.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudResource block(s) allowed")]
    public List<GoogleBigqueryConnectionCloudResourceBlock>? CloudResource
    {
        set => SetProperty("cloud_resource", value);
    }

    /// <summary>
    /// Block for cloud_spanner.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudSpanner block(s) allowed")]
    public List<GoogleBigqueryConnectionCloudSpannerBlock>? CloudSpanner
    {
        set => SetProperty("cloud_spanner", value);
    }

    /// <summary>
    /// Block for cloud_sql.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudSql block(s) allowed")]
    public List<GoogleBigqueryConnectionCloudSqlBlock>? CloudSql
    {
        set => SetProperty("cloud_sql", value);
    }

    /// <summary>
    /// Block for spark.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spark block(s) allowed")]
    public List<GoogleBigqueryConnectionSparkBlock>? Spark
    {
        set => SetProperty("spark", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBigqueryConnectionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
