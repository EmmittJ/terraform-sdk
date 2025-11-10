using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for aws in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryConnectionAwsBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for azure in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryConnectionAzureBlock : ITerraformBlock
{
    /// <summary>
    /// The name of the Azure Active Directory Application.
    /// </summary>
    [TerraformPropertyName("application")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Application => new TerraformReferenceProperty<TerraformProperty<string>>("", "application");

    /// <summary>
    /// The client id of the Azure Active Directory Application.
    /// </summary>
    [TerraformPropertyName("client_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClientId => new TerraformReferenceProperty<TerraformProperty<string>>("", "client_id");

    /// <summary>
    /// The id of customer&#39;s directory that host the data.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomerTenantId is required")]
    [TerraformPropertyName("customer_tenant_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CustomerTenantId { get; set; }

    /// <summary>
    /// The Azure Application (client) ID where the federated credentials will be hosted.
    /// </summary>
    [TerraformPropertyName("federated_application_client_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FederatedApplicationClientId { get; set; }

    /// <summary>
    /// A unique Google-owned and Google-generated identity for the Connection. This identity will be used to access the user&#39;s Azure Active Directory Application.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Identity => new TerraformReferenceProperty<TerraformProperty<string>>("", "identity");

    /// <summary>
    /// The object id of the Azure Active Directory Application.
    /// </summary>
    [TerraformPropertyName("object_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ObjectId => new TerraformReferenceProperty<TerraformProperty<string>>("", "object_id");

    /// <summary>
    /// The URL user will be redirected to after granting consent during connection setup.
    /// </summary>
    [TerraformPropertyName("redirect_uri")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RedirectUri => new TerraformReferenceProperty<TerraformProperty<string>>("", "redirect_uri");

}

/// <summary>
/// Block type for cloud_resource in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryConnectionCloudResourceBlock : ITerraformBlock
{
    /// <summary>
    /// The account ID of the service created for the purpose of this connection.
    /// </summary>
    [TerraformPropertyName("service_account_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceAccountId => new TerraformReferenceProperty<TerraformProperty<string>>("", "service_account_id");

}

/// <summary>
/// Block type for cloud_spanner in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryConnectionCloudSpannerBlock : ITerraformBlock
{
    /// <summary>
    /// Cloud Spanner database in the form &#39;project/instance/database&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    [TerraformPropertyName("database")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Database { get; set; }

    /// <summary>
    /// Cloud Spanner database role for fine-grained access control. The Cloud Spanner admin should have provisioned the database role with appropriate permissions, such as &#39;SELECT&#39; and &#39;INSERT&#39;. Other users should only use roles provided by their Cloud Spanner admins. The database role name must start with a letter, and can only contain letters, numbers, and underscores. For more details, see https://cloud.google.com/spanner/docs/fgac-about.
    /// </summary>
    [TerraformPropertyName("database_role")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DatabaseRole { get; set; }

    /// <summary>
    /// Allows setting max parallelism per query when executing on Spanner independent compute resources. If unspecified, default values of parallelism are chosen that are dependent on the Cloud Spanner instance configuration. &#39;useParallelism&#39; and &#39;useDataBoost&#39; must be set when setting max parallelism.
    /// </summary>
    [TerraformPropertyName("max_parallelism")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxParallelism { get; set; }

    /// <summary>
    /// If set, the request will be executed via Spanner independent compute resources. &#39;use_parallelism&#39; must be set when using data boost.
    /// </summary>
    [TerraformPropertyName("use_data_boost")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseDataBoost { get; set; }

    /// <summary>
    /// If parallelism should be used when reading from Cloud Spanner.
    /// </summary>
    [TerraformPropertyName("use_parallelism")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseParallelism { get; set; }

    /// <summary>
    /// If the serverless analytics service should be used to read data from Cloud Spanner. &#39;useParallelism&#39; must be set when using serverless analytics.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformPropertyName("use_serverless_analytics")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UseServerlessAnalytics { get; set; }

}

/// <summary>
/// Block type for cloud_sql in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryConnectionCloudSqlBlock : ITerraformBlock
{
    /// <summary>
    /// Database name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    [TerraformPropertyName("database")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Database { get; set; }

    /// <summary>
    /// Cloud SQL instance ID in the form project:location:instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    [TerraformPropertyName("instance_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InstanceId { get; set; }

    /// <summary>
    /// When the connection is used in the context of an operation in BigQuery, this service account will serve as the identity being used for connecting to the CloudSQL instance specified in this connection.
    /// </summary>
    [TerraformPropertyName("service_account_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceAccountId => new TerraformReferenceProperty<TerraformProperty<string>>("", "service_account_id");

    /// <summary>
    /// Type of the Cloud SQL database. Possible values: [&amp;quot;DATABASE_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;POSTGRES&amp;quot;, &amp;quot;MYSQL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for spark in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryConnectionSparkBlock : ITerraformBlock
{
    /// <summary>
    /// The account ID of the service created for the purpose of this connection.
    /// </summary>
    [TerraformPropertyName("service_account_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceAccountId => new TerraformReferenceProperty<TerraformProperty<string>>("", "service_account_id");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryConnectionTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_bigquery_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBigqueryConnection : TerraformResource
{
    public GoogleBigqueryConnection(string name) : base("google_bigquery_connection", name)
    {
    }

    /// <summary>
    /// Optional connection id that should be assigned to the created connection.
    /// </summary>
    [TerraformPropertyName("connection_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ConnectionId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "connection_id");

    /// <summary>
    /// A descriptive description for the connection
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// A descriptive name for the connection
    /// </summary>
    [TerraformPropertyName("friendly_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? FriendlyName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Optional. The Cloud KMS key that is used for encryption.
    /// 
    /// Example: projects/[kms_project_id]/locations/[region]/keyRings/[key_region]/cryptoKeys/[key]
    /// </summary>
    [TerraformPropertyName("kms_key_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyName { get; set; }

    /// <summary>
    /// The geographic location where the connection should reside.
    /// Cloud SQL instance must be in the same location as the connection
    /// with following exceptions: Cloud SQL us-central1 maps to BigQuery US, Cloud SQL europe-west1 maps to BigQuery EU.
    /// Examples: US, EU, asia-northeast1, us-central1, europe-west1.
    /// Spanner Connections same as spanner region
    /// AWS allowed regions are aws-us-east-1
    /// Azure allowed regions are azure-eastus2
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for aws.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Aws block(s) allowed")]
    [TerraformPropertyName("aws")]
    public TerraformList<TerraformBlock<GoogleBigqueryConnectionAwsBlock>>? Aws { get; set; } = new();

    /// <summary>
    /// Block for azure.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Azure block(s) allowed")]
    [TerraformPropertyName("azure")]
    public TerraformList<TerraformBlock<GoogleBigqueryConnectionAzureBlock>>? Azure { get; set; } = new();

    /// <summary>
    /// Block for cloud_resource.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudResource block(s) allowed")]
    [TerraformPropertyName("cloud_resource")]
    public TerraformList<TerraformBlock<GoogleBigqueryConnectionCloudResourceBlock>>? CloudResource { get; set; } = new();

    /// <summary>
    /// Block for cloud_spanner.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudSpanner block(s) allowed")]
    [TerraformPropertyName("cloud_spanner")]
    public TerraformList<TerraformBlock<GoogleBigqueryConnectionCloudSpannerBlock>>? CloudSpanner { get; set; } = new();

    /// <summary>
    /// Block for cloud_sql.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudSql block(s) allowed")]
    [TerraformPropertyName("cloud_sql")]
    public TerraformList<TerraformBlock<GoogleBigqueryConnectionCloudSqlBlock>>? CloudSql { get; set; } = new();

    /// <summary>
    /// Block for spark.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spark block(s) allowed")]
    [TerraformPropertyName("spark")]
    public TerraformList<TerraformBlock<GoogleBigqueryConnectionSparkBlock>>? Spark { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleBigqueryConnectionTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// True if the connection has credential assigned.
    /// </summary>
    [TerraformPropertyName("has_credential")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> HasCredential => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "has_credential");

    /// <summary>
    /// The resource name of the connection in the form of:
    /// &amp;quot;projects/{project_id}/locations/{location_id}/connections/{connectionId}&amp;quot;
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
