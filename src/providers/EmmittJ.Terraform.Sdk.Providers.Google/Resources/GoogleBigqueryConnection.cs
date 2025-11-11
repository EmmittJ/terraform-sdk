using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for aws in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryConnectionAwsBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for azure in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryConnectionAzureBlock : TerraformBlockBase
{


    /// <summary>
    /// The id of customer&#39;s directory that host the data.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomerTenantId is required")]
    [TerraformProperty("customer_tenant_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CustomerTenantId { get; set; }

    /// <summary>
    /// The Azure Application (client) ID where the federated credentials will be hosted.
    /// </summary>
    [TerraformProperty("federated_application_client_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? FederatedApplicationClientId { get; set; }




}

/// <summary>
/// Block type for cloud_resource in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryConnectionCloudResourceBlock : TerraformBlockBase
{

}

/// <summary>
/// Block type for cloud_spanner in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryConnectionCloudSpannerBlock : TerraformBlockBase
{
    /// <summary>
    /// Cloud Spanner database in the form &#39;project/instance/database&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    [TerraformProperty("database")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Database { get; set; }

    /// <summary>
    /// Cloud Spanner database role for fine-grained access control. The Cloud Spanner admin should have provisioned the database role with appropriate permissions, such as &#39;SELECT&#39; and &#39;INSERT&#39;. Other users should only use roles provided by their Cloud Spanner admins. The database role name must start with a letter, and can only contain letters, numbers, and underscores. For more details, see https://cloud.google.com/spanner/docs/fgac-about.
    /// </summary>
    [TerraformProperty("database_role")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DatabaseRole { get; set; }

    /// <summary>
    /// Allows setting max parallelism per query when executing on Spanner independent compute resources. If unspecified, default values of parallelism are chosen that are dependent on the Cloud Spanner instance configuration. &#39;useParallelism&#39; and &#39;useDataBoost&#39; must be set when setting max parallelism.
    /// </summary>
    [TerraformProperty("max_parallelism")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MaxParallelism { get; set; }

    /// <summary>
    /// If set, the request will be executed via Spanner independent compute resources. &#39;use_parallelism&#39; must be set when using data boost.
    /// </summary>
    [TerraformProperty("use_data_boost")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? UseDataBoost { get; set; }

    /// <summary>
    /// If parallelism should be used when reading from Cloud Spanner.
    /// </summary>
    [TerraformProperty("use_parallelism")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? UseParallelism { get; set; }

    /// <summary>
    /// If the serverless analytics service should be used to read data from Cloud Spanner. &#39;useParallelism&#39; must be set when using serverless analytics.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("use_serverless_analytics")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? UseServerlessAnalytics { get; set; }

}

/// <summary>
/// Block type for cloud_sql in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryConnectionCloudSqlBlock : TerraformBlockBase
{
    /// <summary>
    /// Database name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    [TerraformProperty("database")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Database { get; set; }

    /// <summary>
    /// Cloud SQL instance ID in the form project:location:instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    [TerraformProperty("instance_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> InstanceId { get; set; }


    /// <summary>
    /// Type of the Cloud SQL database. Possible values: [&amp;quot;DATABASE_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;POSTGRES&amp;quot;, &amp;quot;MYSQL&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for spark in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryConnectionSparkBlock : TerraformBlockBase
{

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBigqueryConnectionTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_bigquery_connection resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleBigqueryConnection : TerraformResource
{
    public GoogleBigqueryConnection(string name) : base("google_bigquery_connection", name)
    {
    }

    /// <summary>
    /// Optional connection id that should be assigned to the created connection.
    /// </summary>
    [TerraformProperty("connection_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ConnectionId { get; set; }

    /// <summary>
    /// A descriptive description for the connection
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// A descriptive name for the connection
    /// </summary>
    [TerraformProperty("friendly_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? FriendlyName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Optional. The Cloud KMS key that is used for encryption.
    /// 
    /// Example: projects/[kms_project_id]/locations/[region]/keyRings/[key_region]/cryptoKeys/[key]
    /// </summary>
    [TerraformProperty("kms_key_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKeyName { get; set; }

    /// <summary>
    /// The geographic location where the connection should reside.
    /// Cloud SQL instance must be in the same location as the connection
    /// with following exceptions: Cloud SQL us-central1 maps to BigQuery US, Cloud SQL europe-west1 maps to BigQuery EU.
    /// Examples: US, EU, asia-northeast1, us-central1, europe-west1.
    /// Spanner Connections same as spanner region
    /// AWS allowed regions are aws-us-east-1
    /// Azure allowed regions are azure-eastus2
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for aws.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Aws block(s) allowed")]
    [TerraformProperty("aws")]
    public TerraformList<TerraformBlock<GoogleBigqueryConnectionAwsBlock>>? Aws { get; set; }

    /// <summary>
    /// Block for azure.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Azure block(s) allowed")]
    [TerraformProperty("azure")]
    public TerraformList<TerraformBlock<GoogleBigqueryConnectionAzureBlock>>? Azure { get; set; }

    /// <summary>
    /// Block for cloud_resource.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudResource block(s) allowed")]
    [TerraformProperty("cloud_resource")]
    public TerraformList<TerraformBlock<GoogleBigqueryConnectionCloudResourceBlock>>? CloudResource { get; set; }

    /// <summary>
    /// Block for cloud_spanner.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudSpanner block(s) allowed")]
    [TerraformProperty("cloud_spanner")]
    public TerraformList<TerraformBlock<GoogleBigqueryConnectionCloudSpannerBlock>>? CloudSpanner { get; set; }

    /// <summary>
    /// Block for cloud_sql.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudSql block(s) allowed")]
    [TerraformProperty("cloud_sql")]
    public TerraformList<TerraformBlock<GoogleBigqueryConnectionCloudSqlBlock>>? CloudSql { get; set; }

    /// <summary>
    /// Block for spark.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Spark block(s) allowed")]
    [TerraformProperty("spark")]
    public TerraformList<TerraformBlock<GoogleBigqueryConnectionSparkBlock>>? Spark { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleBigqueryConnectionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// True if the connection has credential assigned.
    /// </summary>
    [TerraformProperty("has_credential")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> HasCredential { get; }

    /// <summary>
    /// The resource name of the connection in the form of:
    /// &amp;quot;projects/{project_id}/locations/{location_id}/connections/{connectionId}&amp;quot;
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

}
